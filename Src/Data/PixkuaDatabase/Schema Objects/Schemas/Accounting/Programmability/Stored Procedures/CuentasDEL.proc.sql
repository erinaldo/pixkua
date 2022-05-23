-- =============================================
-- Author: Alejandro Lopez Cadena
-- Create date: 20-sep-2007
-- Description:	Elimina el nodo especificado junto con todos sus nodos secundarios.
-- =============================================
CREATE PROCEDURE [Accounting].[CuentasDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	-- Obtener la ruta del nodo para poder eliminar la rama completa
	DECLARE @Path AS varchar(64)

	SELECT @Path=[Path] + '%' FROM Accounting.Cuentas
	WHERE IdCuenta=@ID

	DELETE Accounting.Cuentas WHERE [Path] LIKE @Path


