-- =============================================
-- Author: alez lopez
-- Create date: 27-jun-2011
-- Description:	Elimina el Mesas especificado.
-- =============================================
CREATE PROCEDURE [Restaurant].[MesasDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE Restaurant.Mesas WHERE IdMesa=@ID


