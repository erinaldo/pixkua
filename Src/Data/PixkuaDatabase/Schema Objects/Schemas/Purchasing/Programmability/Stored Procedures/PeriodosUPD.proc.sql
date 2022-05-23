-- =============================================
-- Author: alez Lopez
-- Create date: 01-nov-2011
-- Description:	Agrega o modifica la información de Periodos
-- =============================================
CREATE PROCEDURE [Purchasing].[PeriodosUPD]
	@Id AS int out,
	@Codigo AS varchar(16),
	@Nombre AS varchar(128),
	@IdEjercicioFiscalTit AS char(18),
	@Mes AS int,
	@Estatus as char(1),
	@IdStatus AS int,
	@IdSucursal AS int,
	@IdEmpresa AS int,
	@LastUpdate AS datetime,
	@PCUpdate AS varchar(32),
	@UserUpdate AS int
AS
	SET NOCOUNT ON
	
	IF @ID=0
	BEGIN
		EXEC dbo.NewKey 'Purchasing.Periodos', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		DECLARE @FechaApertura as datetime
		SET @FechaApertura=CONVERT(varchar(8),getdate(),112 )
		INSERT INTO Purchasing.Periodos(IdPeriodo, Codigo, Nombre, IdEjercicioFiscalTit, Mes,FechaApertura, Estatus,  IdStatus, IdSucursal, IdEmpresa, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @Nombre, @IdEjercicioFiscalTit, @Mes,@FechaApertura, @Estatus, @IdStatus, @IdSucursal, @IdEmpresa, @LastUpdate, @PCUpdate, @UserUpdate)
		--TODO: Falta implementar la actualización de las columnas UserCreate y CreateDate
	END
	ELSE
		UPDATE Purchasing.Periodos SET Codigo=@Codigo, Nombre=@Nombre, IdEjercicioFiscalTit=@IdEjercicioFiscalTit, Mes=@Mes, Estatus=@Estatus, IdStatus=@IdStatus, IdSucursal=@IdSucursal, IdEmpresa=@IdEmpresa, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdPeriodo=@ID


