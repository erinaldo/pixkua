-- =============================================
-- Author: RCO
-- Create date: 05-oct-2010
-- Description:	Elimina el UnidadesMedidaTipos especificado.
-- =============================================
CREATE PROCEDURE [Inventory].[UnidadesMedidaTiposDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	--No se permite eliminar el tipo de unidad de piezas, ya que el sistema lo necesita para uso interno
	IF @ID > 1
		DELETE Inventory.UnidadesMedidaTipos WHERE IdUnidadMedidaTipo=@ID


