CREATE FUNCTION [Accounting].[InformesCBO](@IdUsuario as int)
RETURNS TABLE
AS
	RETURN(	SELECT IdInforme,Nombre,SeleccionarCuenta
			FROM Accounting.Informes
)


