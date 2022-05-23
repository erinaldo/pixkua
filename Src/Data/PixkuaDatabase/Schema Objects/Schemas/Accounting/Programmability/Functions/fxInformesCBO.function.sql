CREATE FUNCTION [Accounting].[fxInformesCBO](@IdUsuario AS	INT)
RETURNS TABLE
AS
	RETURN(	SELECT IdInforme,Nombre,SeleccionarCuenta
			FROM Accounting.Informes 
			WHERE	IdStatus=1
)


