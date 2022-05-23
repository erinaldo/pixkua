-- =============================================
-- Author: RCO
-- Create date: 13-abr-2011
-- Description:	Agrega o modifica la información de SucursalesConfig
-- =============================================
CREATE PROCEDURE [Accounting].[SucursalesConfigUPD]
	@IdSucursal AS int out,
	@IdSerieNotasCargo AS int,
	@IdSerieNotasCredito AS int,
	@IdFormatoNotaCargo AS int,
	@IdFormatoNotaCredito AS int,
	@LastUpdate AS datetime,
	@PCUpdate AS varchar(32),
	@UserUpdate AS int
AS
	SET NOCOUNT ON
	
	IF EXISTS(SELECT IdSucursal FROM Accounting.SucursalesConfig WHERE IdSucursal=@IdSucursal)		
		UPDATE Accounting.SucursalesConfig SET IdSerieNotasCargo=@IdSerieNotasCargo, IdSerieNotasCredito=@IdSerieNotasCredito, IdFormatoNotaCargo=@IdFormatoNotaCargo, 
			IdFormatoNotaCredito=@IdFormatoNotaCredito, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdSucursal=@IdSucursal
	ELSE
		INSERT INTO Accounting.SucursalesConfig(IdSucursal,  IdSerieNotasCargo, IdSerieNotasCredito, IdFormatoNotaCargo, IdFormatoNotaCredito, 
			LastUpdate, PCUpdate, UserUpdate)
		VALUES (@IdSucursal, @IdSerieNotasCargo, @IdSerieNotasCredito, @IdFormatoNotaCargo, @IdFormatoNotaCredito, 
			@LastUpdate, @PCUpdate, @UserUpdate)


