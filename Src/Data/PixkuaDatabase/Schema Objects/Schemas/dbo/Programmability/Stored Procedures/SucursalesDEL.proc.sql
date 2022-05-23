-- =============================================
-- Author: Ricardo Cortés Ornelas
-- Create date: 30-DIC-2005
-- Description:	Elimina la sucursal especificada.
-- =============================================

CREATE  PROCEDURE [dbo].[SucursalesDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE dbo.Sucursales WHERE IdSucursal=@ID


