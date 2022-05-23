-- =============================================
-- Author: alex Lopez
-- Create date: 09-nov-2010
-- Description:	Obtener un nuevo Folio para las diferentes tipos de polizas
-- =============================================

CREATE  PROCEDURE [Accounting].[PolizaFolioNew] 
	@IdPolizaPerfil as int, --Tipo de poliza
	@IdSucursal as int, -- Nombre de la tabla para la que se generará una nueva llave	
	@Key as int out -- Devuelve la nueva llave generada
AS
	SET NOCOUNT  ON
	DECLARE @IdPolizaTipo as int
	SELECT  @IdPolizaTipo=IdPolizaTipo FROM Accounting.PolizasPerfiles WHERE IdPolizaPerfil=@IdPolizaPerfil
	
	IF Exists(SELECT IdPolizaFolio FROM Accounting.PolizasFolios WHERE IdPolizaTipo=@IdPolizaTipo AND IdSucursal=@IdSucursal)
	BEGIN
		UPDATE Accounting.PolizasFolios SET UltimoFolio=UltimoFolio + 1
		WHERE IdPolizaTipo=@IdPolizaTipo AND IdSucursal=@IdSucursal
		
		SELECT @Key=UltimoFolio
		FROM Accounting.PolizasFolios
		WHERE IdPolizaTipo=@IdPolizaTipo AND IdSucursal=@IdSucursal
	END
	ELSE
	BEGIN
		SET @Key=1
		
		INSERT INTO Accounting.PolizasFolios(IdPolizaTipo,IdSucursal,UltimoFolio)
		VALUES (@IdPolizaTipo,@IdSucursal,@Key)
	END


