-- =============================================
-- Author: alex Lopez
-- Create date: 09-oct-2010
-- Description:	Elimina el Polizas especificado.
-- =============================================
CREATE PROCEDURE [Accounting].[PolizasPerfilesDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE Accounting.PolizasPerfiles WHERE IdPolizaPerfil=@ID


