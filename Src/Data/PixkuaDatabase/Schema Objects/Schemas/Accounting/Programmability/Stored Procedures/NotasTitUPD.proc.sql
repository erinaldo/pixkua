-- =============================================
-- Author: RCO
-- Create date: 04-abr-2011
-- Description:	Agrega o modifica la información de NotasTit
-- =============================================
CREATE PROCEDURE [Accounting].[NotasTitUPD]
	@Id AS char(18) out,
	@Fecha AS datetime,
	@Tipo AS char(1),
	@IdSerieRef AS char(10),
	@FolioRef AS int,
	@IdCliente AS int,
	@RFC AS varchar(16),
	@RazonSocial AS varchar(256),
	@Calle AS varchar(128),
	@NumExt AS varchar(16),
	@NumInt AS varchar(16),
	@Colonia AS varchar(128),
	@CP AS char(5),
	@IdPoblacion AS int,
	@IdDivisa as int,
	@SubTotal AS decimal(19,4),
	@TotalImpuestosTras AS decimal(19,4),
	@TotalImpuestosRet AS decimal(19,4),
	@Total AS decimal(19,4),
	@Observaciones AS varchar(256),
	@IdStatus AS int,
	@IdSucursal AS int,
	@UserUpdate AS int,
	@LastUpdate AS datetime,
	@PCUpdate AS varchar(32)
AS
	SET NOCOUNT ON
	
	IF @Id=''
	BEGIN
		DECLARE @IdTipoDocumento AS Int
		SET @IdTipoDocumento = Cast(dbo.fxParamGetValue('Configuracion/Documentos/Tipos','Notas') as int)

		--Obtenemos el Folio consecutivo del documento
		EXEC Documents.NewDocumentFolio @IdTipoDocumento, @IdSucursal, @Fecha, @Id Out
		
		INSERT INTO Accounting.NotasTit(IdNotaTit, Fecha, Tipo, 
			IdSerieRef, FolioRef, IdCliente, RFC, RazonSocial, Calle, NumExt, NumInt, Colonia, CP, 
			IdPoblacion, IdDivisa, SubTotal, TotalImpuestosTras, TotalImpuestosRet, Total, Observaciones, 
			IdStatus, IdSucursal, UserUpdate, LastUpdate, PCUpdate)
		VALUES (@Id, @Fecha, @Tipo,  
			@IdSerieRef, @FolioRef, @IdCliente, @RFC, @RazonSocial, @Calle, @NumExt, @NumInt, @Colonia, @CP, 
			@IdPoblacion, @IdDivisa, @SubTotal, @TotalImpuestosTras, @TotalImpuestosRet, @Total, @Observaciones, 
			@IdStatus, @IdSucursal, @UserUpdate, @LastUpdate, @PCUpdate)
	END
	ELSE
		UPDATE Accounting.NotasTit SET Fecha=@Fecha, Tipo=@Tipo, IdSerieRef=@IdSerieRef, FolioRef=@FolioRef, 
			IdCliente=@IdCliente, RFC=@RFC, RazonSocial=@RazonSocial, Calle=@Calle, NumExt=@NumExt, 
			NumInt=@NumInt, Colonia=@Colonia, CP=@CP, IdPoblacion=@IdPoblacion, SubTotal=@SubTotal, 
			TotalImpuestosTras=@TotalImpuestosTras, TotalImpuestosRet=@TotalImpuestosRet, Total=@Total, 
			IdDivisa=@IdDivisa, Observaciones=@Observaciones, 
			IdStatus=@IdStatus, IdSucursal=@IdSucursal, UserUpdate=@UserUpdate, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate
		WHERE IdNotaTit=@ID and Fecha = Documents.fxDocumentDate(@id)


