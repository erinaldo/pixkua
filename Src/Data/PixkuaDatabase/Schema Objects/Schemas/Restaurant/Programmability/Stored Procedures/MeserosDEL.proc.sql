-- =============================================
-- Author: alez lopez
-- Create date: 27-jun-2011
-- Description:	Elimina el Meseros especificado.
-- =============================================
CREATE PROCEDURE [Restaurant].[MeserosDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE Restaurant.Meseros WHERE IdMesero=@ID


