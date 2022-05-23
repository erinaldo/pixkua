-- =============================================
-- Author: Ricardo Cortés Ornelas
-- Create date: 30-DIC-2005
-- Description:	Elimina la empresa especificada.
-- =============================================
CREATE  PROCEDURE [dbo].[EmpresasDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE dbo.Empresas WHERE IdEmpresa=@ID


