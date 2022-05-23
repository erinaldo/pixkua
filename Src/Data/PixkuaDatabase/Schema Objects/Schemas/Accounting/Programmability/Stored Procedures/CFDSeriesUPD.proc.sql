-- =============================================
-- Author: RCO
-- Create date: 04-sep-2010
-- Description:	Agrega o modifica la información de CFDSeries
-- =============================================
CREATE PROCEDURE [Accounting].[CFDSeriesUPD]
	@Id AS int out,
	@Codigo AS varchar(32),
	@Serie AS char(10),
	@IdCFDCertificado AS int,
	@IdEmpresa as int,
	@IdSucursal AS int,
	@IdStatus AS int,
	@LastUpdate AS datetime,
	@PCUpdate AS varchar(32),
	@UserUpdate AS int
AS
	SET NOCOUNT ON
	
	IF @ID=0
	BEGIN
		EXEC dbo.NewKey 'Accounting.CFDSeries', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Accounting.CFDSeries(IdCFDSerie, Codigo, Serie, IdCFDCertificado, IdEmpresa, 
			IdSucursal, IdStatus, LastUpdate, PCUpdate, UserUpdate, CreateDate, UserCreate)
		VALUES (@Id, @Codigo, @Serie, @IdCFDCertificado, @IdEmpresa,
			@IdSucursal, @IdStatus, @LastUpdate, @PCUpdate, @UserUpdate, @LastUpdate, @UserUpdate)
	END
	ELSE
		UPDATE Accounting.CFDSeries SET Codigo=@Codigo, Serie=@Serie, IdCFDCertificado=@IdCFDCertificado, 
			IdEmpresa=@IdEmpresa, IdSucursal=@IdSucursal, 
			IdStatus=@IdStatus, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdCFDSerie=@ID


