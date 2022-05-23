-- =============================================
-- Author: RCO
-- Create date: 08-sep-2010
-- Description:	Elimina el Servicios especificado.
-- =============================================
CREATE PROCEDURE [Sales].[ServiciosDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE Sales.Servicios WHERE IdServicio=@ID


