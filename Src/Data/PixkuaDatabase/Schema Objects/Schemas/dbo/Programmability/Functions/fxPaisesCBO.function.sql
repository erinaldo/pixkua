﻿CREATE FUNCTION [dbo].[fxPaisesCBO]()
RETURNS TABLE
AS
RETURN	(
	SELECT IdPais, Pais FROM Paises
		)


