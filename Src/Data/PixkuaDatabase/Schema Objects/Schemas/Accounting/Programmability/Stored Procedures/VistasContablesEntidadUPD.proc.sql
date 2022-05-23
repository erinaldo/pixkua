-- =============================================
-- Author: alezLopez
-- Create date: 21-oct-2010
-- Description:	Agrega o modifica la información de VistasContablesEntidad
-- =============================================
CREATE PROCEDURE [Accounting].[VistasContablesEntidadUPD]
	@Id AS int out,
	@IdVistaContableTit AS int,
	@Columna AS varchar(64),
	@IdEntidad AS int
AS
	SET NOCOUNT ON
	
	IF @ID=0 AND @IdEntidad>0
	BEGIN		
			print 'Entr'
			INSERT INTO Accounting.VistasContablesEntidad(IdVistaContableTit, Columna, IdEntidad)
			VALUES (@IdVistaContableTit, @Columna, @IdEntidad)
			SELECT @Id =@@IDENTITY
		
		--TODO: Falta implementar la actualización de las columnas UserCreate y CreateDate
	END
	ELSE
		UPDATE Accounting.VistasContablesEntidad SET IdVistaContableTit=@IdVistaContableTit, Columna=@Columna, IdEntidad=@IdEntidad
		WHERE IdVistaContableEntidad=@Id


