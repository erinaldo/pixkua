-- =============================================
-- Author: RCO
-- Create date: 04-abr-2011
-- Description:	Aplica el proceso de flujo de trabajo del NotasTit especificado.
-- =============================================
CREATE PROCEDURE [Accounting].[NotasTitWorkflow]
	@ID AS Char(18),
	@IdStatus as int,
	@FechaTrabajo as datetime,
	@UserUpdate as int,
	@PCUpdate as varchar(32)
AS
	SET NOCOUNT ON
	
	DECLARE @Fecha as datetime, @IdDivisa as int, @TipoCambio as decimal(19,4)
	SET @TipoCambio=1
	SET @Fecha=Documents.fxDocumentDate(@ID)
	
	SELECT @IdDivisa=IdDivisa
	FROM Accounting.NotasTit
	WHERE IdNotaTit=@ID AND Fecha=@Fecha
		
	-->Si se está facturando
	IF @IdStatus=4
	BEGIN
		-->Actualizar el tipo de cambio
		SELECT @TipoCambio=PrecioVenta
		FROM Accounting.TiposCambio
		WHERE IdDivisaOrigen=@IdDivisa AND IdDivisaDestino=1
		
		-->Actualizar información del documento
		UPDATE Accounting.NotasTit SET TipoCambio=@TipoCambio
		WHERE IdNotaTit=@ID AND Fecha = @Fecha
	END
	
	UPDATE Accounting.NotasTit 
	SET IdStatus=@IdStatus, UserUpdate=@UserUpdate, PCUpdate=@PCUpdate, LastUpdate=getdate()
	WHERE IdNotaTit=@ID AND Fecha = @Fecha


