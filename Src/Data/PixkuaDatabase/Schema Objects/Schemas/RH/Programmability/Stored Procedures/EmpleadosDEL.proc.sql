-- =============================================
-- Author: RCO
-- Create date: 11-ago-2011
-- Description:	Elimina el Empleados especificado.
-- =============================================
CREATE PROCEDURE [RH].[EmpleadosDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	UPDATE  RH.Empleados SET IdStatus=0,FechaBaja=GETDATE() WHERE IdEmpleado=@ID


