CREATE FUNCTION [Accounting].[fxComprobanteFiscalRPT](@IdCFDSerie as int, @Folio as int)
RETURNS TABLE
AS
RETURN	(
	SELECT 
		CT.Nombre AS TipoComprobante, SE.Serie AS Serie, F.Folio, F.HoraComprobante AS FechaComprobante,	
		RTrim(SE.Serie) + ' ' + dbo.fxNumberToText(F.Folio, 'Mi', 0) AS FolioLetra,
		F.SubTotal, F.Descuentos AS TotalDescuentos, F.ImpTrasladados, F.ImpRetenidos, F.Total,
		dbo.fxNumberToText(F.Total, 'Ma', 0) + ' ' + DV.Tipo  AS TotalLetra, 
		DV.Nombre Divisa, DV.Abrev AS AbrevDivisa, F.Activa,
		CASE F.Credito
			WHEN 0 THEN '*** CONTADO ***'
			WHEN 1 THEN '*** CREDITO ***'
		END AS TipoPago, IsNull(C.DiasCredito, 0) AS DiasCredito, IsNull(C.Codigo, '') AS CodigoCliente,
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Receptor/@rfc)') AS RFC, 
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Receptor/@nombre)') AS RazonSocial, 
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Receptor/ns:Domicilio/@calle)') AS CalleFIS, 
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Receptor/ns:Domicilio/@noExterior)') AS NumExtFIS, 
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Receptor/ns:Domicilio/@noInterior)') AS NumIntFIS, 
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Receptor/ns:Domicilio/@colonia)') AS ColoniaFIS, 
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Receptor/ns:Domicilio/@codigoPostal)') CPReceptor,
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Receptor/ns:Domicilio/@localidad)')AS PoblacionReceptor, 
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Receptor/ns:Domicilio/@estado)') AS EstadoReceptor,
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Emisor/ns:ExpedidoEn/@calle)') AS CalleSucursal, 
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Emisor/ns:ExpedidoEn/@noExterior)') AS NumExtSucursal, 
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Emisor/ns:ExpedidoEn/@noInterior)') AS NumIntSucursal,
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Emisor/ns:ExpedidoEn/@colonia)') AS ColoniaSucursal, 
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Emisor/ns:ExpedidoEn/@codigoPostal)') AS CPSucursal, 
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Emisor/ns:ExpedidoEn/@localidad)') AS PoblacionSucursal, 
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Emisor/ns:ExpedidoEn/@estado)') AS EstadoSucursal, 
		SUC.Tel1 AS TelefonoSucursal, SUC.Correo AS EmailSucursal,
		FD.Codigo AS CodigoConcepto, FD.Descripcion AS DescripcionConcepto, FD.FactorUnidad,
		FD.Unidad AS UnidadMedida, FD.Cantidad,	FD.PrecioUnitario,		
		FD.PorcImpTras1, FD.PorcImpTras2, FD.PorcImpRet1, FD.PorcImpRet2,
		F.CadenaOriginal, F.SelloDigital, RTrim(F.NumCertificado) AS NumCertificado, F.NumAprobacion, F.AnioAprobacion,
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Emisor/@rfc)') AS RFCEmisor, 
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Emisor/@nombre)') AS RazonSocialEmisor, 
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Emisor/ns:DomicilioFiscal/@calle)') AS CalleEmisor, 
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Emisor/ns:DomicilioFiscal/@noExterior)') AS NumExtEmisor,
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Emisor/ns:DomicilioFiscal/@noInterior)') AS NumIntEmisor, 
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Emisor/ns:DomicilioFiscal/@colonia)') AS ColoniaEmisor,
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Emisor/ns:DomicilioFiscal/@codigoPostal)') AS CPEmisor, 
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Emisor/ns:DomicilioFiscal/@localidad)') AS PoblacionEmisor,
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Emisor/ns:DomicilioFiscal/@estado)') AS EstadoEmisor, 
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Emisor/ns:DomicilioFiscal/@municipio)') AS MunicipioEmisor
	FROM Accounting.CFD F WITH (READUNCOMMITTED) 
	JOIN Accounting.CFDConceptos FD WITH (READUNCOMMITTED) 
		ON F.FechaComprobante=FD.FechaComprobante AND F.IdCFDSerie=FD.IdCFDSerie AND F.Folio=FD.Folio
	JOIN Accounting.CFDSeries SE
		ON SE.IdCFDSerie=F.IdCFDSerie
	JOIN Accounting.CFDTipos CT
		ON F.IdCFDTipo=CT.IdCFDTipo
	LEFT JOIN Sales.Clientes C WITH (READUNCOMMITTED)
		ON F.IdCliente=C.IdCliente
	JOIN dbo.Sucursales SUC
		ON F.IdSucursal=SUC.IdSucursal
	JOIN Accounting.Divisas DV
		ON F.IdDivisa=DV.IdDivisa
	WHERE F.IdCFDSerie=@IdCFDSerie AND F.Folio=@Folio AND FD.Cantidad > 0
		)


