-- =============================================
-- Author: alex Lopez
-- Create date: 14-oct-2010
-- Description:	Obtiene la información del Status especificado.
-- =============================================
CREATE FUNCTION [Documents].[fxStatusSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT IdStatus_Homologar,Codigo,Status,StatusApplied,Activo AS IdStatus,IdEmpresa,IdSucursal,CreateDate,LastUpdate,PCUpdate,UserCreate,UserUpdate
	 FROM Documents.Status WHERE IdStatus=@ID)


