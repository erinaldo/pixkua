-- =============================================
-- Author: alex Lopez
-- Create date: 08-nov-2010
-- Description:	Agrega o modifica la información de PolizasDet
-- =============================================
CREATE PROCEDURE [Accounting].[PolizasDetUPD]
	@IdPolizaDet AS int out,
	@Id AS char(18),
	@Fecha AS datetime,
	@IdReferencia AS char(18),
	@Referencia AS varchar(32),
	@IdVistaContableTit AS int,
	@IdCuenta AS int,
	@Observaciones AS varchar(100),
	@Cargo AS decimal(18,4),
	@Abono AS decimal(18,4),
	@Orden AS smallint,
	@IdSegmento AS int,
	@Cuenta as varchar(32),
	@CuentaName as varchar(32),
	@Segmento as varchar(64)
AS
	SET NOCOUNT ON
	
	IF NOT EXISTS(SELECT IdPolizaTit FROM Accounting.PolizasDet WHERE IdPolizaTit=@Id and Fecha=Documents.fxDocumentDate(@Id)AND IdPolizaDet=@IdPolizaDet)
	BEGIN		
		INSERT INTO Accounting.PolizasDet( IdPolizaTit, Fecha, IdReferencia, Referencia, IdVistaContableTit, IdCuenta, Observaciones, Cargo, Abono, Orden, IdSegmento)
		VALUES ( @Id, @Fecha, @IdReferencia, @Referencia, @IdVistaContableTit, @IdCuenta, @Observaciones, @Cargo, @Abono, @Orden, @IdSegmento)
		SET @IdPolizaDet=@@IDENTITY
	END
	ELSE
		UPDATE Accounting.PolizasDet SET IdPolizaTit=@Id, Fecha=@Fecha, IdReferencia=@IdReferencia, Referencia=@Referencia, IdVistaContableTit=@IdVistaContableTit, IdCuenta=@IdCuenta, Observaciones=@Observaciones, Cargo=@Cargo, Abono=@Abono, Orden=@Orden, IdSegmento=@IdSegmento
		WHERE IdPolizaTit= @Id and Fecha = Documents.fxDocumentDate(@Id) AND IdPolizaDet=@IdPolizaDet


