CREATE PROCEDURE [Purchasing].[DepartamentosCentrosRecepcionDEL]
@IdDepartamento as int,
@IdCentroRecepcion as int
AS
	DELETE Purchasing.DepartamentosCentrosRecepcion WHERe IdDepartamento=@IdDepartamento AND IdCentroRecepcion=@IdCentroRecepcion
	
	
	
	
	
	SELECT * from Purchasing.DepartamentosCentrosRecepcion


