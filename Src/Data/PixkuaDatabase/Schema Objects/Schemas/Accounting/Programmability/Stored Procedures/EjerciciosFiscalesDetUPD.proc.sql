-- =============================================
-- Author: alez Lopez
-- Create date: 13-sep-2011
-- Description:	Agrega o modifica la información de EjerciciosFiscalesDet
-- =============================================
CREATE PROCEDURE [Accounting].[EjerciciosFiscalesDetUPD]
	@Id AS char(18),
	@Fecha AS datetime,
	@Mes AS int,
	@Activo AS bit,
	@Periodo as varchar(64)
AS
	SET NOCOUNT ON
	
	IF NOT EXISTS(SELECT IdEjercicioFiscalTit FROM Accounting.EjerciciosFiscalesDet WHERE IdEjercicioFiscalTit=@Id and Fecha=Documents.fxDocumentDate(@Id) AND Mes=@Mes)
	BEGIN		
		INSERT INTO Accounting.EjerciciosFiscalesDet( IdEjercicioFiscalTit, Fecha, Mes, Activo)
		VALUES (@Id, @Fecha, @Mes, @Activo)
	END
	ELSE
		UPDATE Accounting.EjerciciosFiscalesDet SET Fecha=@Fecha, Mes=@Mes, Activo=@Activo
		WHERE IdEjercicioFiscalTit= @Id and Fecha = Documents.fxDocumentDate(@Id)


