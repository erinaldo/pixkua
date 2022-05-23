-- =============================================
-- Author: Ricardo Cortés Ornelas
-- Create date: <<FECHA>>
-- Description:	Elimina el <<>> especificado.
-- =============================================
CREATE PROCEDURE [dbo].[PoblacionesDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE dbo.Poblaciones WHERE IdPoblacion=@ID


