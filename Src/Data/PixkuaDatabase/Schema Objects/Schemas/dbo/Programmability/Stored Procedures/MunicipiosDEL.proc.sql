-- =============================================
-- Author: RCO
-- Create date: 23-mar-2009
-- Description:	Elimina el Municipios especificado.
-- =============================================
CREATE PROCEDURE [dbo].[MunicipiosDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE dbo.Municipios WHERE IdMunicipio=@ID


