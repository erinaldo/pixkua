-- =============================================
-- Author: alex Lopez
-- Create date: 08-nov-2010
-- Description:	Obtiene la información del PolizasTit especificado.
-- =============================================
CREATE FUNCTION [Accounting].[fxPolizasTitSEL](@ID AS char(18), @IdUsuario AS int)
RETURNS TABLE
AS
RETURN	(
	SELECT T.*, S.[Status] as [Status],PP.IdPolizaTipo,PP.AfectarSistemaExterno
	FROM Accounting.PolizasTit  AS T INNER JOIN Documents.[Status] AS S 
		ON S.IdStatus=T.IdStatus
		INNER JOIN Accounting.PolizasPerfiles PP ON PP.IdPolizaPerfil=T.IdPolizaPerfil
	WHERE IdPolizaTit=@ID and Fecha = Documents.fxDocumentDate(@Id)
		)


