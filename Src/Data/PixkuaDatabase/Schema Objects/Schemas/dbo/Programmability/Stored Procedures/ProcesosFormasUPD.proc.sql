-- =============================================
-- Author: Ricardo Cortés Ornelas
-- Create date: <<FECHA>>
-- Description:	Agrega o modifica la información de ProcesosFormas
-- =============================================
CREATE PROCEDURE [dbo].[ProcesosFormasUPD]
	@Id AS int out,
	@Codigo AS varchar(10),
	@IdProceso AS int,
	@Forma AS varchar(32),
	@Ensamblado AS varchar(32),
	@NameSpace AS varchar(128),
	@Clase AS varchar(32),
	@URL AS varchar(256),
	@Inicial AS bit,
	@IdSucursal AS int,
	@IdEmpresa as int,
	@IdStatus AS int,
	@LastUpdate AS datetime,
	@PCUpdate AS varchar(32),
	@UserUpdate AS int
AS
	SET NOCOUNT ON
	
	IF @ID=0
	BEGIN
		EXEC dbo.NewKey 'ProcesosFormas', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO dbo.ProcesosFormas(IdProcesoForma, IdProceso, Forma, Ensamblado, NameSpace, Clase, URL, Inicial, IdStatus, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @IdProceso, @Forma, @Ensamblado, @NameSpace, @Clase, @URL, @Inicial, @IdStatus, @LastUpdate, @PCUpdate, @UserUpdate)
		--TODO: Falta implementar la actualización de las columnas UserCreate y CreateDate
	END
	ELSE
		UPDATE dbo.ProcesosFormas SET IdProceso=@IdProceso, Forma=@Forma, Ensamblado=@Ensamblado, NameSpace=@NameSpace, Clase=@Clase, URL=@URL, Inicial=@Inicial, IdStatus=@IdStatus, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdProcesoForma=@ID


