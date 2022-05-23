-- =============================================
-- Author: RCO
-- Create date: 05-oct-2010
-- Description:	Elimina el UnidadesMedida especificado.
-- =============================================
CREATE PROCEDURE [Inventory].[UnidadesMedidaDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	-- No se permite eliminar la unidad de medida de piezas ya que el sistema lo necesita para uso interno
	IF @ID > 1
		DELETE Inventory.UnidadesMedida WHERE IdUnidadMedida=@ID


