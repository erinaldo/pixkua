CREATE FUNCTION [Purchasing].[fxFacturaRPT](@IdProveedor as int, @Serie as char(10), @Folio as int)
RETURNS TABLE
AS
RETURN	(
	SELECT 
		F.Serie AS SerieFact, F.Folio, F.HoraComprobante AS FechaFactura,	
		F.SubTotal, F.Descuentos, F.ImpTrasladados, F.ImpRetenidos, F.Total, dbo.fxNumberToText(F.Total, 'Ma', 0) AS TotalLetra, 
		F.CadenaOriginal, F.SelloDigital, F.NumCertificado, F.NumAprobacion, F.AnioAprobacion,
		REPLACE(CAST(F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Receptor/@rfc)') AS varchar(32)), '&AMP;', '&') AS RFC, 
		REPLACE(CAST(F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Receptor/@nombre)') AS varchar(512)), '&AMP;', '&') AS RazonSocial, 
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Receptor/ns:Domicilio/@calle)') AS CalleFIS, 
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Receptor/ns:Domicilio/@noExterior)') AS NumExtFIS, 
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Receptor/ns:Domicilio/@noInterior)') AS NumIntFIS, 
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Receptor/ns:Domicilio/@colonia)') AS ColoniaFIS, 
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Receptor/ns:Domicilio/@codigoPostal)') CPCliente,
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Receptor/ns:Domicilio/@localidad)')AS PoblacionCliente, 
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Receptor/ns:Domicilio/@estado)') AS EstadoCliente,
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Emisor/ns:ExpedidoEn/@calle)') AS CalleSucursal, 
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Emisor/ns:ExpedidoEn/@noExterior)') AS NumExtSucursal, 
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Emisor/ns:ExpedidoEn/@noInterior)') AS NumIntSucursal,
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Emisor/ns:ExpedidoEn/@colonia)') AS ColoniaSucursal, 
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Emisor/ns:ExpedidoEn/@codigoPostal)') AS CPSucursal, 
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Emisor/ns:ExpedidoEn/@localidad)') AS PoblacionSucursal, 
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Emisor/ns:ExpedidoEn/@estado)') AS EstadoSucursal, 		
		REPLACE(CAST(F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Emisor/@rfc)') AS varchar(32)), '&AMP;', '&') AS RFCEmisor, 
		REPLACE(CAST(F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Emisor/@nombre)') AS varchar(512)), '&AMP;', '&') AS RazonSocialEmisor, 
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Emisor/ns:DomicilioFiscal/@calle)') AS CalleEmisor, 
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Emisor/ns:DomicilioFiscal/@noExterior)') AS NumExtEmisor,
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Emisor/ns:DomicilioFiscal/@noInterior)') AS NumIntEmisor, 
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Emisor/ns:DomicilioFiscal/@colonia)') AS ColoniaEmisor,
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Emisor/ns:DomicilioFiscal/@codigoPostal)') AS CPEmisor, 
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Emisor/ns:DomicilioFiscal/@localidad)') AS PoblacionEmisor,
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Emisor/ns:DomicilioFiscal/@estado)') AS EstadoEmisor, 
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Emisor/ns:DomicilioFiscal/@municipio)') AS MunicipioEmisor,
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Emisor/ns:ExpedidoEn/@calle)') AS CalleExp, 
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Emisor/ns:ExpedidoEn/@noExterior)') AS NumExtExp,
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Emisor/ns:ExpedidoEn/@noInterior)') AS NumIntExp, 
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Emisor/ns:ExpedidoEn/@colonia)') AS ColoniaExp,
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Emisor/ns:ExpedidoEn/@codigoPostal)') AS CPExp, 
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Emisor/ns:ExpedidoEn/@localidad)') AS PoblacionExp,
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Emisor/ns:ExpedidoEn/@estado)') AS EstadoExp, 
		F.Comprobante.query('declare namespace ns="http://www.sat.gob.mx/cfd/2";data(/ns:Comprobante/ns:Emisor/ns:ExpedidoEn/@municipio)') AS MunicipioExp,
		P.Codigo AS CodigoProveedor, P.Nombre AS NombreProveedor, D.Codigo, D.Descripcion, D.PrecioUnitario, D.Cantidad
	FROM Purchasing.CFD F WITH (READUNCOMMITTED) JOIN Purchasing.CFDConceptos D WITH (READUNCOMMITTED)
		ON F.Serie=D.Serie AND F.Folio=D.Folio AND F.IdProveedor=D.IdProveedor
	JOIN Purchasing.Proveedores P WITH (READUNCOMMITTED)
		ON F.IdProveedor=P.IdProveedor
	WHERE F.IdProveedor=@IdProveedor AND F.Serie=@Serie AND F.Folio=@Folio
	)


