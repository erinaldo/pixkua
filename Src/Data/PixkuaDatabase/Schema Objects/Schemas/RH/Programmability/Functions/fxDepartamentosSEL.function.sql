-- =============================================
-- Author: RCO
-- Create date: 11-ago-2011
-- Description:	Obtiene la información del Departamentos especificado.
-- =============================================
CREATE FUNCTION [RH].[fxDepartamentosSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM RH.Departamentos WHERE IdDepartamento=@ID)


