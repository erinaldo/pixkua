CREATE PROCEDURE [Purchasing].[DepartamentosCentrosRecepcionSave]
@IdDepartamento as int,
@IdCentroRecepcion as int,
@PCUpdate as varchar(64),
@UserUpdate as int
AS
	IF NOT exists(SELECT IdDepartamentoCentroRecepcion FROM Purchasing.DepartamentosCentrosRecepcion WHERe IdDepartamento=@IdDepartamento AND IdCentroRecepcion=@IdCentroRecepcion)
	BEGIN
		INSERT INTO Purchasing.DepartamentosCentrosRecepcion (IdDepartamento,IdCentroRecepcion,LastUpdate,PCUpdate,UserUpdate)
		VALUES(@IdDepartamento,@IdCentroRecepcion,GETDATE(),@PCUpdate,@UserUpdate)
	END


