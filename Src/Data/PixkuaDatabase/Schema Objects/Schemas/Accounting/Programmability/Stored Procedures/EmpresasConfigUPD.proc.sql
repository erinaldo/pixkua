CREATE PROCEDURE [Accounting].[EmpresasConfigUPD]
@IdEmpresa as int,
@FormatoContable as varchar(64),
@BaseDatos as varchar(100),
@IdServicio as int,
@Niveles as int,
@LastUpdate AS datetime,
@PCUpdate AS varchar(32),
@UserUpdate AS int
AS

IF Exists(SELECT IdEmpresa FROM Accounting.EmpresasConfig WHERE IdEmpresa=@IdEmpresa)
	UPDATE Accounting.EmpresasConfig SET BaseDatos=@BaseDatos,IdServicio=@IdServicio,Niveles=@Niveles,LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
	WHERE IdEmpresa=@IdEmpresa
ELSE
	INSERT INTO Accounting.EmpresasConfig(IdEmpresa,BaseDatos,IdServicio,FormatoContable,Niveles,LastUpdate,PCUpdate,UserUpdate)
	VALUES(@IdEmpresa,@BaseDatos,@IdServicio,@FormatoContable,@Niveles,@LastUpdate,@PCUpdate,@UserUpdate)


