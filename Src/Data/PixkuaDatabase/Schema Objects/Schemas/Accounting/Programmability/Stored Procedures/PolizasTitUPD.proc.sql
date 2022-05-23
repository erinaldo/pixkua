-- =============================================
-- Author: alex Lopez
-- Create date: 08-nov-2010
-- Description:	Agrega o modifica la información de PolizasTit
-- =============================================
CREATE PROCEDURE [Accounting].[PolizasTitUPD]
	@Id AS varchar(18)out,
	@Fecha AS datetime,
	@IdPolizaPerfil AS int,
	@Folio AS int,
	@IdStatus AS int,
	@IdSucursal AS int,
	@UserUpdate AS int,
	@LastUpdate AS datetime,
	@PCUpdate AS varchar(32)
AS
	SET NOCOUNT ON
	SET xact_abort ON

	IF @Id=''
	BEGIN
		--Armamos el Id del documento
		DECLARE @IdTipoDocumento AS Int,@ErrorMessage nvarchar(4000)
		SET @IdTipoDocumento = Cast(dbo.fxParamGetValue('Configuracion/Documentos/Tipos','Accounting.PolizasTit') as int)
		EXEC Documents.NewDocumentFolio @IdTipoDocumento,@IdSucursal,@Fecha,@Id Out
		
		EXEC [Accounting].[PolizaFolioNew] @IdPolizaPerfil,@IdSucursal,@Folio out
		
		--Nos traemos el Ejercicio Fiscal de la fecha de la poliza
		DECLARE @IdEjercicioFiscalTit as char(18),@Activo as BIT
		SELECT @IdEjercicioFiscalTit=T.IdEjercicioFiscalTit,@Activo=D.Activo 
		FROM Accounting.EjerciciosFiscalesTit T
		INNER JOIN Accounting.EjerciciosFiscalesDet D ON T.IdEjercicioFiscalTit=D.IdEjercicioFiscalTit AND D.Fecha=T.Fecha AND D.Mes=MONTH(@Fecha)
		WHERE @Fecha BETWEEN FechaIni AND FechaFin
		
		IF @Activo=0
		BEGIN
			SET @ErrorMessage = N'El periodo contable esta cerrado"'
			RAISERROR (@ErrorMessage,18,1)
			RETURN
		END
				
		INSERT INTO Accounting.PolizasTit(IdPolizaTit, Fecha,IdEjercicioFiscalTit, IdPolizaPerfil, Folio, IdStatus, IdSucursal, UserUpdate, LastUpdate, PCUpdate)
		VALUES (@Id, @Fecha,@IdEjercicioFiscalTit, @IdPolizaPerfil, @Folio, @IdStatus, @IdSucursal, @UserUpdate, @LastUpdate, @PCUpdate)
	END
	ELSE
		UPDATE Accounting.PolizasTit SET Fecha=@Fecha, IdPolizaPerfil=@IdPolizaPerfil, Folio=@Folio, IdStatus=@IdStatus, IdSucursal=@IdSucursal, UserUpdate=@UserUpdate, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate
		WHERE IdPolizaTit=@ID and Fecha = Documents.fxDocumentDate(@id)


