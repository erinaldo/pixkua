-- =============================================
-- Author: alez Lopez
-- Create date: 13-sep-2011
-- Description:	Agrega o modifica la información de EjerciciosFiscalesTit
-- =============================================
CREATE PROCEDURE [Accounting].[EjerciciosFiscalesTitUPD]
	@Id AS char(18) out,
	@Fecha AS datetime out,
	@IdEmpresa AS int,
	@FechaIni AS datetime,
	@FechaFin AS datetime,
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
		SET @IdTipoDocumento = Cast(dbo.fxParamGetValue('Configuracion/Documentos/Tipos','EjercicioFiscal') as int)

		--Obtenemos el Folio consecutivo del documento
		EXEC Documents.NewDocumentFolio @IdTipoDocumento, @IdSucursal, @Fecha, @Id Out
		
		INSERT INTO Accounting.EjerciciosFiscalesTit(IdEjercicioFiscalTit, Fecha, IdEmpresa, FechaIni, FechaFin, IdStatus, IdSucursal, UserUpdate, LastUpdate, PCUpdate)
		VALUES (@Id, @Fecha,  @IdEmpresa, @FechaIni, @FechaFin, @IdStatus, @IdSucursal, @UserUpdate, @LastUpdate, @PCUpdate)
	END
	ELSE
		UPDATE Accounting.EjerciciosFiscalesTit SET Fecha=@Fecha, IdEmpresa=@IdEmpresa, FechaIni=@FechaIni, FechaFin=@FechaFin, IdStatus=@IdStatus, IdSucursal=@IdSucursal, UserUpdate=@UserUpdate, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate
		WHERE IdEjercicioFiscalTit=@ID and Fecha = Documents.fxDocumentDate(@id)


