CREATE PROCEDURE [dbo].[FormatosUPD]
	@IdFormato as int out,
	@Nombre as varchar(64), 
	@Formato as xml,
	@DataSourceXSD as xml,
	@IdSucursal as int,
	@IdEmpresa as int
AS
	IF @IdFormato > 0
		UPDATE Formatos SET Nombre=@Nombre, Formato=@Formato, DataSourceXSD=@DataSourceXSD 
		WHERE IdFormato=@IdFormato
	ELSE
	BEGIN
		INSERT INTO Formatos(Nombre, Formato, DataSourceXSD, IdSucursal, IdEmpresa)
		VALUES (@Nombre, @Formato, @DataSourceXSD, @IdSucursal, @IdEmpresa)
		
		SET @IdFormato=@@IDENTITY
	END


