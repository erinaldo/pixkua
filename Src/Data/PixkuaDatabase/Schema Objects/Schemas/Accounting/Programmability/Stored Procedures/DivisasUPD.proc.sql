-- =============================================
-- Author: RCO
-- Create date: 10-sep-2010
-- Description:	Agrega o modifica la información de Divisas
-- =============================================
CREATE PROCEDURE [Accounting].[DivisasUPD]
	@Id AS int out,
	@Codigo AS varchar(32),
	@Nombre AS varchar(64),
	@Abrev AS varchar(16),
	@Tipo as varchar(32),
	@SerieBanxico as varchar(16),
	@IdStatus AS int,
	@IdSucursal AS int,
	@IdEmpresa as int,	
	@LastUpdate AS datetime,
	@PCUpdate AS varchar(32),
	@UserUpdate AS int
AS
	SET NOCOUNT ON
	
	IF @ID=0
	BEGIN
		EXEC dbo.NewKey 'Accounting.Divisas', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Accounting.Divisas(IdDivisa, Codigo, Nombre, Abrev, Tipo, SerieBanxico,
			IdStatus, IdSucursal, IdEmpresa, LastUpdate, PCUpdate, UserUpdate, CreateDate, UserCreate)
		VALUES (@Id, @Codigo, @Nombre, @Abrev, @Tipo, @SerieBanxico,
			@IdStatus, @IdSucursal, @IdEmpresa, @LastUpdate, @PCUpdate, @UserUpdate, @LastUpdate, @UserUpdate)
	END
	ELSE
		UPDATE Accounting.Divisas SET Codigo=@Codigo, Nombre=@Nombre, Abrev=@Abrev, Tipo=@Tipo, SerieBanxico=@SerieBanxico,
			IdStatus=@IdStatus, IdSucursal=@IdSucursal, IdEmpresa=@IdEmpresa, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdDivisa=@ID


