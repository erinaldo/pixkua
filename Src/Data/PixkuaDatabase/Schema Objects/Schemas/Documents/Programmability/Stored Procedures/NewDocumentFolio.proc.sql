---------------------------------------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE [Documents].[NewDocumentFolio] 
	@IdDocumentoTipo as Int,
	@IdSucursal as Int,
	@Fecha as dateTime,
	@Id as Char(18) OUT
AS
	DECLARE @Day as Int
	DECLARE @Consec as Int
	DECLARE @IdFolio as Int
    SET @Consec =0
 
 	--Verificamos si en esta fecha se ha guardado un registro consecutivo para esta Transaccion y tienda  
	SELECT @IdFolio= IdFolio, @Consec= IsNull(UltimoFolio,0) 
	FROM Documents.Folios (UPDLOCK)  
	WHERE IdDocumentoTipo = @IdDocumentoTipo AND IdSucursal =  @IdSucursal and Fecha = @Fecha  
     
	--Verificamos si encontro un registro consecutivo para este Tipo de Documento y Sucursal
	IF @Consec = 0     
		BEGIN
			--Sino encontro consecutivo, Inserta un registro con Consecutivo incremental siguiente   
			INSERT INTO Documents.Folios(IdDocumentoTipo, IdSucursal, Fecha, UltimoFolio) 
			values (@IdDocumentoTipo, @IdSucursal, @Fecha, 1) 

			SET @Consec=1
		END
    ELSE   
		BEGIN   
			--Actualiza el Siguiente Consecutivo que se regresa  
			UPDATE Documents.Folios SET UltimoFolio = UltimoFolio + 1 
			WHERE IdFolio=@IdFolio

			SELECT @Consec=UltimoFolio FROM Documents.Folios WHERE IdFolio=@IdFolio
		END  

  
	--Dia del año
	SET @Day = dbo.fxDateToNumberDay(@Fecha)

	---------------------Tipo de Documento----Tienda---Fecha---Consec
	--Obtenemos el Id.---------00---------------000---0000000--000000    	
    SET @Id = REPLICATE ('0', 3 - LEN(@IdDocumentoTipo))+ LTrim(RTrim(str(@IdDocumentoTipo))) +
	          REPLICATE ('0', 3 - LEN(@IdSucursal))	+ LTrim(RTrim(str(@IdSucursal))) + LTrim(RTrim(str(Year(@Fecha)))) +
              REPLICATE ('0', 3 - LEN(@Day))		+ LTrim(RTrim(str(@Day))) + 
              REPLICATE ('0', 5 - LEN(@Consec))		+ LTrim(RTrim(str(@Consec)))	




----------------------------------------------------------------------------------------------------------------------------------------------


set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON


