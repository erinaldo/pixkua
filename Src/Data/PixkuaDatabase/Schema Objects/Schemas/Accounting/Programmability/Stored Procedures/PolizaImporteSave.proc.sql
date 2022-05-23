CREATE PROCEDURE [Accounting].[PolizaImporteSave] 
@Id as int OUT,
@Descripcion as varchar(64)
AS
	INSERT INTO Accounting.Importes(Importe)VALUES(@Descripcion)
	SET @Id =@@ROWCOUNT


