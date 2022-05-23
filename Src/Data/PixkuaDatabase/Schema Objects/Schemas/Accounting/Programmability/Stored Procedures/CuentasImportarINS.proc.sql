CREATE PROCEDURE [Accounting].[CuentasImportarINS]
@Codigo as varchar(64),
@Nombre as varchar(128),
@Padre as varchar(64),
@Tipo as varchar(3),
@SegNeg as bit
AS
	INSERT INTO Accounting.CuentasImportacion(Codigo,Nombre,Tipo,Padre,SegNeg)
	VALUES (@Codigo,@Nombre,@Tipo,@Padre,@SegNeg)


