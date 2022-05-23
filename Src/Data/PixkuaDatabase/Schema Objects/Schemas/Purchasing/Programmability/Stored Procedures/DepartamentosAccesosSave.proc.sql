CREATE PROCEDURE [Purchasing].[DepartamentosAccesosSave]
@IdDepartamento as int,
@IdUsuario as int,
@PCUpdate as varchar(64),
@UserUpdate as int
AS
	IF NOT exists(SELECT IdDepartamentoAcceso FROM Purchasing.DepartamentosAccesos WHERe IdDepartamento=@IdDepartamento AND IdUsuario=@IdUsuario)
	BEGIN
		INSERT INTO Purchasing.DepartamentosAccesos (IdDepartamento,IdUsuario,Acceso,LastUpdate,PCUpdate,UserUpdate)
		VALUES(@IdDepartamento,@IdUsuario,1,GETDATE(),@PCUpdate,@UserUpdate)
	END


