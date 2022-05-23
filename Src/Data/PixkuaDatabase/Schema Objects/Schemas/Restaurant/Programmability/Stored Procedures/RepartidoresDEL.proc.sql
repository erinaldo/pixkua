-- =============================================
-- Author: alez Lopez
-- Create date: 08-ago-2011
-- Description:	Elimina el Repartidores especificado.
-- =============================================
CREATE PROCEDURE [Restaurant].[RepartidoresDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	UPDATE Restaurant.Repartidores SET IdStatus=0 WHERE  IdRepartidor=@ID


