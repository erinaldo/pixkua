CREATE PROCEDURE [Accounting].[ContabilizacionFiltrosSEL]
@IdContabilizacionDocumentoDet AS INT
AS 
	IF OBJECT_ID('tempdb..##Combinacion') IS NOT NULL
	BEGIN
		DROP TABLE ##Combinacion
	END

	DECLARE @Columnas as nVarchar(4000), @Tablas as nVarchar(4000),@Filtro as nVarchar(4000),@Sql as nvarchar(4000),@Pivote varchar(4000), @CatalogosLocales as nvarchar(4000)


	--Obtenemos el nombre de las columnas y tablas de las Entidades que participan y Generamos el Filtro en relacion a esta combinacion y la Columna de la vista
	SELECT @Columnas='', @Tablas='',@Filtro='',@Sql ='',@Pivote='',@CatalogosLocales=''
	SELECT @Columnas=@Columnas + E.Alias + '.' + E.CampoName  + ' AS[' + E.Entidad + '],' ,
		   @Tablas=@Tablas + E.[Schema] + '.' + E.Objeto + ' AS ' + E.Alias + ',' ,
		   @Filtro=@Filtro + ''' AND V.' + VE.Columna + '=''+str(' + E.Alias + '.' + E.CampoPK + ')+ ',
		   @Pivote=@Pivote+ ''' AND V.' + VE.Columna + '=''+str(V.' + VE.Columna + ') +',
		   @CatalogosLocales =@CatalogosLocales + E.Alias + '.IdEmpresa=' + Cast(DT.IdEmpresa as varchar(3)) + ' AND ' --END
	FROM Accounting.ContabilizacionDocumentosTit DT
	INNER JOIN Accounting.ContabilizacionDocumentosDet DD ON DD.IdContabilizacionDocumentoTit=DT.IdContabilizacionDocumentoTit
	 LEFT JOIN Accounting.ContabilizacionCombinaciones CC ON CC.IdContabilizacionDocumentoDet=DD.IdContabilizacionDocumentoDet --AND DD.IdRacTit=0
	 LEFT JOIN Accounting.VistasContablesEntidad VE ON VE.IdVistaContableTit=DT.IdVistaContableTit AND VE.IdEntidad=CC.IdEntidad
	 LEFT JOIN Accounting.Entidades E ON E.IdEntidad=CC.IdEntidad
	WHERE DD.IdContabilizacionDocumentoDet=@IdContabilizacionDocumentoDet 
	
	--Solo vamos a mostrar las entidades de la sucursal actual en caso q la DD.SoloCatalogoSucursal asi lo indique
	IF len(@CatalogosLocales)>0 
		SET @CatalogosLocales = ' WHERE ' + SUBSTRING(@CatalogosLocales,1,LEN(@CatalogosLocales)-4)
		
print 'Filtro:'+ @filtro
print 'Pivote:'+ @Pivote
print 'Locales'+ @CatalogosLocales 

	SELECT   @Tablas=Substring(@Tablas,1,len(@Tablas)-1),
  		     @Filtro=Substring(@Filtro,1,len(@Filtro)-1),
		     @Pivote=Substring(@Pivote,1,len(@Pivote)-1)    
	SET @Sql='SELECT ' + @Columnas + @Filtro + ' AS Filtro INTO ##Combinacion' + ' FROM ' + @Tablas + @CatalogosLocales
	PRINT (@SQL)
	EXEC sp_Executesql @SQL

	SELECT IsNULL(F.IdContabilizacionFiltro,0)AS IdContabilizacionFiltro,C.*,IsNULL(F.IdRacTit,0)as IdRacTit,RT.Nombre AS Rac,@Pivote AS Pivote
	FROM ##Combinacion C
	LEFT JOIN Accounting.ContabilizacionFiltros F ON F.Filtro =C.Filtro
	LEFT JOIN Accounting.RacTit RT ON RT.IdRacTit=F.IdRacTit


