/*  EXEC Accounting.Contabilizar '001001201028800002','20101001',4,'del alex',1
    Recibe un Id de documento y verifica que el status en el que se encuentra generará una Póliza Contable
	Para Obtener los datos de la entidad. El Usuarios 2 debe tener permiso para todas las sucursales para el caso en que la funcion fxEntidadSEL filtre por permisos de usuario
*/
CREATE PROCEDURE [Accounting].[Contabilizar] 
@IdDocumento varchar(18),
@FechaTrabajo datetime,
@IdStatus int,
@PCUpdate varchar(16),
@UserUpdate int,
@Cancelacion as BIT =0
AS	
	DECLARE @RacTable TABLE (IdRac int Identity, IdDoc int,      Referencia varchar(32), ConReferencia bit, IdPolizaPerfil int, Acumulable BIT, IdRacDet int, IdCuenta INT, IdEntidad int, Afectador Char(1), Rojo BIT, IdImporte int, Importe varchar(32), Orden int, [Schema] varchar(64), Objeto varchar(64), CampoPK varchar(32), Cargo decimal(19,4), Abono decimal(19,4), CampoName varchar(32), Observaciones varchar(64),IdSegmento int )
	DECLARE					         @IdRac int,@IdDoc int,@ReferenciaDocto varchar(32),@ConReferencia bit,@IdPolizaPerfil int,@Acumulable BIT,@IdRacDet int,@IdCuenta INT,@IdEntidad int,@Afectador Char(1),@Rojo BIT,@IdImporte int,@Importe varchar(32),@Orden int, @Schema  varchar(64),@Objeto varchar(64),@CampoPK varchar(32),@Cargo decimal(19,4),@Abono decimal(19,4),@CampoName varchar(32),@Observaciones varchar(64)--,@IdSegmento int   
	DECLARE @SQLString nvarchar(4000), @SQLParams nvarchar(4000),@Pivote nvarchar(4000), @IdContabilizacionDocumentoDet int,@Variante BIT,@IdRacTit int, @IdObjeto varchar(64), @Referencia varchar(64), @IdCuentaContable int, @IdActor int,@Monto Decimal(19,4),@IdRacTitTMP int,@IdVistaContableTit int,@IdPolizaTit as char(18),@IdPolizaTit_TMP as char(18),@IdSucursal INT,@ErrorMessage nvarchar(4000)
	DECLARE @HayActor as bit
	
	--Verificamos si este documento genera poliza en el estatus actual.
	SELECT @IdContabilizacionDocumentoDet=CD.IdContabilizacionDocumentoDet,@IdVistaContableTit=CT.IdVistaContableTit, @Variante=CD.Variante, @IdRacTit=CD.IdRacTit,@Pivote=CD.Pivote, @Schema=[Schema], @Objeto=VT.Objeto, @IdObjeto=VT.IdObjeto,@Referencia=Referencia
	FROM Documents.Tipos AS D 
	INNER JOIN Accounting.ContabilizacionDocumentosTit CT ON CT.IdDocumentoTipo=D.IdDocumentoTipo
	INNER JOIN Accounting.ContabilizacionDocumentosDet AS CD ON CD.IdContabilizacionDocumentoTit=CT.IdContabilizacionDocumentoTit
	INNER JOIN Accounting.VistasContablesTit VT ON VT.IdVistaContableTit=CT.IdVistaContableTit
	WHERE D.IdDocumentoTipo = CAST(dbo.fxDocumentIdTipo(@IdDocumento)as int) AND CD.IdStatus=@IdStatus AND CT.IdEmpresa=Documents.fxDocumentCompany(@IdDocumento)

	IF @IdContabilizacionDocumentoDet>0 --Mayor a cero implica que tiene que generar poliza
	BEGIN --INICIO. Encontro Contabilizacion
		SELECT @IdPolizaTit ='',@IdPolizaTit_TMP='',@IdSucursal=Documents.fxDocumentSite(@IdDocumento)--,@IdSegmento=0		
		
		IF OBJECT_ID('tempdb..##Documento') IS NOT NULL
			DROP TABLE ##Documento

		SET @SQLString = N'SELECT IDENTITY(int,1,1)AS IdDoc, * INTO ##Documento FROM ' + @Schema + '.' + @Objeto + ' WHERE ' + @IdObjeto +'=''' +  @IdDocumento + ''' AND Fecha=Documents.fxDocumentDate(''' +  @IdDocumento + ''')'
		EXECUTE sp_Executesql @SQLString  --Obteniendo los datos del movimiento actual y lo metemos en una tabla temporal
					
		--Si el documento maneja Variables para redireccionar el RAC, revisamos cual es la que aplica en el movimiento actual
		IF @Variante=1
		BEGIN 
			--Sustituimos el Filtro Pivote con los datos del documento
			SET @SQLParams = N'@PivoteIN as varchar(8000) OUTPUT'
			SET @SQLString = N'	SELECT @PivoteIN= ' + @Pivote + ' FROM ##Documento V'
			EXECUTE sp_Executesql @SQLString,@SQLParams,@PivoteIN=@Pivote OUTPUT 

			--Buscamos el Pivote sustituido entre los filtros para saber que rac representa
			SELECT @IdRacTitTMP=IdRacTit 
			FROM Accounting.ContabilizacionFiltros 
			WHERE IdContabilizacionDocumentoDet=@IdContabilizacionDocumentoDet AND Filtro=@Pivote
			
			IF @IdRacTitTMP>0 
				SET @IdRacTit=@IdRacTitTMP --Se encontro un nuevo RAC y se va a generar la poliza en base a el				
			ELSE
				BEGIN 
					SET @ErrorMessage = N'No se encontro el Rac con la combinacion originada de este documento en este movimiento'
					RAISERROR (@ErrorMessage,18,1)
					Return					
				END	
		END						

		INSERT INTO @RacTable (IdDoc,IdPolizaPerfil,Acumulable,Referencia,ConReferencia,IdRacDet,IdCuenta, IdEntidad, Afectador, Rojo, IdImporte, Importe, Orden, E.[Schema],E.Objeto,CampoPK,CampoName,Observaciones,IdSegmento)
			SELECT RT.IdDoc,RT.IdPolizaPerfil,P.Acumulable,''AS Referencia,RD.TotalizarConReferencia,RD.IdRacDet,RD.IdCuenta,RD.IdEntidad,RD.Afectador,RD.Rojo,RD.IdImporte,I.Columna AS Importe,RD.Orden,E.[Schema],E.Objeto,E.CampoPK ,E.CampoName,C.Nombre,RT.IdSegmento
			FROM (  SELECT IdRacTit,IdPolizaPerfil,D.IdDoc,RT.IdSegmentoNegocio AS IdSegmento
					FROM Accounting.RacTit AS RT,##Documento AS D)AS RT
			INNER JOIN Accounting.RacDet AS RD ON RD.IdRacTit=RT.IdRacTit
			INNER JOIN Accounting.PolizasPerfiles AS P ON P.IdPolizaPerfil=RT.IdPolizaPerfil
			LEFT JOIN Accounting.Cuentas C ON C.IdCuenta=RD.IdCuenta
			LEFT JOIN Accounting.Entidades E ON E.IdEntidad = RD.IdEntidad
			INNER JOIN Accounting.VistasContablesImporte I ON I.IdImporte=RD.IdImporte AND I.IdVistaContableTit=P.IdVistaContableTit
			WHERE RT.IdRacTit = @IdRacTit


		DECLARE cMovto CURSOR FAST_FORWARD READ_ONLY FOR
		SELECT IdRac,IdDoc,IdPolizaPerfil, Acumulable, IdRacDet,IdCuenta, IdEntidad, Afectador, Rojo, IdImporte, Importe, Orden, [Schema],Objeto,CampoPK,CampoName
		FROM @RacTable R

		OPEN cMovto
			FETCH NEXT FROM cMovto INTO @IdRac,@IdDoc,@IdPolizaPerfil,@Acumulable,@IdRacDet,@IdCuenta, @IdEntidad, @Afectador, @Rojo, @IdImporte, @Importe, @Orden, @Schema ,@Objeto , @CampoPK, @CampoName
			WHILE @@FETCH_STATUS=0
			BEGIN
				SELECT @IdActor=0,@IdCuentaContable=0,@Observaciones='',@Monto=0,@HayActor=1
				--Si no trae cuenta, se trata de una Entidad y vamos a obtener su cuenta 
				IF @IdCuenta= 0 OR @IdCuenta Is Null
				BEGIN						
					--Obtenemos del documento el Id del Actor de la entidad 
					SET @SQLParams = N'@IdActorIN as int OUTPUT' 
					SET @SQLString = N'SELECT @IdActorIN=' + @CampoPK + ' FROM ##Documento WHERE IdDoc=' + str(@IdDoc) --<-----------En dado caso q el documento tenga varios registros, diseñar el link para relacionar cada 1
					EXECUTE sp_Executesql @SQLString,@SQLParams,@IdActorIN=@IdActor OUTPUT
					
					--Si encontro Actor									
					SET @HayActor=@IdActor									
					
					--Obtenemos la Cuenta del Actor de la entidad			
					SET @SQLParams = N'@IdCuentaCont int OUTPUT,@ObservIN Varchar(64)OUTPUT' 
					SET @SQLString = N'SELECT @IdCuentaCont=IdCuenta,@ObservIN=' + @CampoName +' FROM ' + @Schema +'.fx'+ @Objeto + 'SEL(' + CAST(@IdActor as varchar(10)) +',2)'
					print @SQLString
					EXECUTE sp_Executesql @SQLString,@SQLParams,@IdCuentaCont=@IdCuentaContable OUTPUT,@ObservIN=@Observaciones OUTPUT				
					UPDATE @RacTable SET IdCuenta=@IdCuentaContable,Observaciones=IsNull(@Observaciones,'') WHERE IdRac=@IdRac  --<--Asignamos la cuenta del actor de la entidad
				END
								
				-- Obtenemos el Importe
				SET @SQLParams = N'@ImporteIN as decimal(19,4) OUTPUT' 
				SET @SQLString = N'SELECT @ImporteIN=' + @Importe + ' FROM ##Documento WHERE IdDoc=' + str(@IdDoc) --<-----------En dado caso q el documento tenga varios registros, diseñar el link para relacionar cada 1
				EXECUTE sp_Executesql @SQLString,@SQLParams,@ImporteIN=@Monto OUTPUT				 
				UPDATE @RacTable SET Cargo=(CASE WHEN @Afectador='C' THEN @Monto ELSE 0 END), Abono=(CASE WHEN @Afectador='A' THEN @Monto ELSE 0 END)
				WHERE IdRac=@IdRac AND @HayActor=1

				--Obtenemos la referencia del documento				
				SET @SQLParams = N'@ReferenciaIN as varchar(64)OUTPUT'
				SET @SQLString = N'SELECT @ReferenciaIN=' + @Referencia + ' FROM ##Documento WHERE IdDoc=' + str( @IdDoc)
				EXECUTE sp_Executesql @SQLString,@SQLParams,@ReferenciaIN=@ReferenciaDocto OUTPUT		
				UPDATE @RacTable SET Referencia=@ReferenciaDocto WHERE IdRac=@IdRac  --<--Asignamos la cuenta del actor de la entidad
              								
				FETCH NEXT FROM cMovto INTO @IdRac,@IdDoc,@IdPolizaPerfil,@Acumulable,@IdRacDet,@IdCuenta, @IdEntidad, @Afectador, @Rojo, @IdImporte, @Importe, @Orden, @Schema ,@Objeto , @CampoPK, @CampoName
			END 

		CLOSE cMovto
		DEALLOCATE cMovto	
		
		--Eliminamos las Referencias de aquellos movimientos q no se acumulan por Referencia
		UPDATE @RacTable SET Referencia=''WHERE ConReferencia=0
		
		--Generamos el movimiento en negativo para cuando se este cancelando la poliza de este movimiento
		IF @Cancelacion=1
			UPDATE @RacTable SET Cargo=Cargo*-1, Abono=Abono*-1

		--Si los documentos se van acumulando en una poliza, verificamos que haya una poliza abierta
		IF @Acumulable = 1	
			SET @IdPolizaTit_TMP= Accounting.fxPolizaAcumuladaSEL(@IdPolizaPerfil, @FechaTrabajo, @IdSucursal)
					
		SET @IdPolizaTit=@IdPolizaTit_TMP
		
		--Se inserta el Titulo de la poliza siempre y cuando no sea Acumulable y ya tenga una poliza abierta
		IF len(rTrim(lTrim(@IdPolizaTit)))=0 
			--Guarda la poliza en PolizasTit
			EXEC Accounting.PolizasTitUPD @Id=@IdPolizaTit out ,@Fecha=@FechaTrabajo,@IdPolizaPerfil=@IdPolizaPerfil,@Folio=0,@IdSucursal=@IdSucursal,@UserUpdate=@UserUpdate,@LastUpdate=@FechaTrabajo, @IdStatus=1,@PCUpdate=@PCUpdate
				
		--Guardamos el detalle de la poliza		
		INSERT INTO Accounting.PolizasDet(IdPolizaTit,Fecha,IdReferencia,Referencia,IdVistaContableTit,IdCuenta,Observaciones,Cargo,Abono,Orden,IdSegmento)
			SELECT @IdPolizaTit,@FechaTrabajo,@IdDocumento,Referencia,@IdVistaContableTit,IdCuenta,Observaciones,SUM(Cargo),SUM(Abono),Orden,IdSegmento
			FROM @RacTable
			WHERE not Cargo is null and not Abono is null
			GROUP BY Referencia,IdCuenta,Observaciones,Orden,IdSegmento
		
		--Si es una Póliza acumulable y es la primera del dia, insertamos el registro para que posteriormente todas las otras polizas se acumulen en ella
		IF @Acumulable=1	AND len(rTrim(lTrim(@IdPolizaTit_TMP)))=0 
			INSERT INTO Accounting.PolizasAcumuladas(Fecha,IdSucursal,IdPolizaPerfil,IdPolizaTit)values(@FechaTrabajo,@IdSucursal,@IdPolizaPerfil,@IdPolizaTit)

		--aplicar en la contabilidad
		EXEC Accounting.PolizaAfectar  @IdPolizaTit
		
	END --FIN. Encontro Contabilizacion


