-- =============================================
-- Author: Ricardo Cortés Ornelas
-- Create date: 30-DIC-2005
-- Description:	Crea una nueva llave para la tabla especificada
--	y la regresa a través del parametro de salida @Key.
-- =============================================

CREATE  PROCEDURE [dbo].[NewKey] 
	@Tabla as varchar(128), -- Nombre de la tabla para la que se generará una nueva llave
	@Key as int out -- Devuelve la nueva llave generada
AS
	SET NOCOUNT  ON
	IF Exists(SELECT Tabla FROM dbo.Llaves WHERE Tabla=@Tabla)
	BEGIN
		UPDATE dbo.Llaves SET Llave=Llave + 1
		WHERE Tabla=@Tabla
		
		SELECT @Key=Llave
		FROM dbo.Llaves
		WHERE Tabla=@Tabla
	END
	ELSE
	BEGIN
		SET @Key=1
		
		INSERT INTO dbo.Llaves(Tabla, Llave)
		VALUES (@Tabla, @Key)
	END


