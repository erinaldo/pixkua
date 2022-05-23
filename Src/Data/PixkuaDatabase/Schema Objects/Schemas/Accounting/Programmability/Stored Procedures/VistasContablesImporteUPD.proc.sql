-- =============================================
-- Author: alezLopez
-- Create date: 21-oct-2010
-- Description:	Agrega o modifica la información de VistasContablesImporte
-- =============================================
CREATE PROCEDURE [Accounting].[VistasContablesImporteUPD]
	@Id AS int out,
	@IdVistaContableTit AS int,
	@Columna AS varchar(64),
	@IdImporte AS int
AS
	SET NOCOUNT ON
	
	
	IF @Id=0 AND @IdImporte>0
	BEGIN
		INSERT INTO Accounting.VistasContablesImporte(IdVistaContableTit, Columna, IdImporte)
		VALUES (@IdVistaContableTit, @Columna, @IdImporte)
		SET @Id=@@IDENTITY		
		--TODO: Falta implementar la actualización de las columnas UserCreate y CreateDate
	END
	ELSE
		UPDATE Accounting.VistasContablesImporte SET IdVistaContableTit=@IdVistaContableTit, Columna=@Columna, IdImporte=@IdImporte
		WHERE IdVistaContableImporte=@Id


