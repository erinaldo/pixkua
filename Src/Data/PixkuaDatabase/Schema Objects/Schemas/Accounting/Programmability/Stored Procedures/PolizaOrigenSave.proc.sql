CREATE PROCEDURE [Accounting].[PolizaOrigenSave] 
@Id as int OUT,
@Descripcion as varchar(64)
AS
	INSERT INTO accounting.PolizasOrigen(Origen)VALUES(@Descripcion)
	SET @Id =@@ROWCOUNT


