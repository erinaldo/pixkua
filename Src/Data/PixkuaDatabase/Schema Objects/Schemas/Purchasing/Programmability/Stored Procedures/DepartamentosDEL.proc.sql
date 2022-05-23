-- =============================================
-- Author: alez Lopez
-- Create date: 28-oct-2011
-- Description:	Elimina el Departamentos especificado.
-- =============================================
CREATE PROCEDURE [Purchasing].[DepartamentosDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	UPDATE Purchasing.Departamentos SET IdStatus=0 WHERE IdDepartamento=@ID


