-- =============================================
-- Author: alexLopez
-- Create date: 08-oct-2010
-- Description:	Agrega o modifica la información de RacDet
-- =============================================
CREATE PROCEDURE [Accounting].[RacDetUPD]
	@Id AS int out,
	@IdRacTit AS int,
	@IdCuenta AS int,
	@IdEntidad AS int,
	@CampoFK AS varchar(32),
	@isEntidadConcepto AS bit,
	@Afectador AS char(1),
	@Rojo AS bit,
	@IdImporte AS int,
	@Orden AS int
AS
	SET NOCOUNT ON
	
	IF @ID=0
	BEGIN		
		INSERT INTO Accounting.RacDet(IdRacTit, IdCuenta, IdEntidad, CampoFK, isEntidadConcepto, Afectador, Rojo, IdImporte, Orden)
		VALUES ( @IdRacTit, @IdCuenta, @IdEntidad, @CampoFK, @isEntidadConcepto, @Afectador, @Rojo, @IdImporte, @Orden)
		SET @Id=@@IDENTITY
		
	END
	ELSE
		UPDATE Accounting.RacDet SET IdRacTit=@IdRacTit, IdCuenta=@IdCuenta, IdEntidad=@IdEntidad, CampoFK=@CampoFK, isEntidadConcepto=@isEntidadConcepto, Afectador=@Afectador, Rojo=@Rojo, IdImporte=@IdImporte, Orden=@Orden
		WHERE IdRacDet=@ID


