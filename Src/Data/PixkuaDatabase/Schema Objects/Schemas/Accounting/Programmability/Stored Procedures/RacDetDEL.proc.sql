-- =============================================
-- Author: alexLopez
-- Create date: 08-oct-2010
-- Description:	Elimina el RacDet especificado.
-- =============================================
CREATE PROCEDURE [Accounting].[RacDetDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE Accounting.RacDet WHERE IdRacDet=@ID


