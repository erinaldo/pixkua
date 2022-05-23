-- =============================================
-- Author: RCO
-- Create date: 02-nov-2011
-- Description:	Elimina el Servicios especificado.
-- =============================================
CREATE PROCEDURE [Purchasing].[ServiciosDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE Purchasing.Servicios WHERE IdServicio=@ID


