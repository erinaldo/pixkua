CREATE PROCEDURE [Accounting].[ContabilizacionDocumentosDetPivote]
@IdContabilizacionDocumentoDet as int
AS
	DECLARE @Pivote varchar(4000)
	SELECT @Pivote =''
	
	SELECT @Pivote=@Pivote+ ''' AND V.' + VE.Columna + '=''+str(V.' + VE.Columna + ') +'
	FROM Accounting.ContabilizacionDocumentosTit DT
	INNER JOIN Accounting.ContabilizacionDocumentosDet DD ON DD.IdContabilizacionDocumentoTit=DT.IdContabilizacionDocumentoTit
	 LEFT JOIN Accounting.ContabilizacionCombinaciones CC ON CC.IdContabilizacionDocumentoDet=DD.IdContabilizacionDocumentoDet --AND DD.IdRacTit=0
	 LEFT JOIN Accounting.VistasContablesEntidad VE ON VE.IdVistaContableTit=DT.IdVistaContableTit AND VE.IdEntidad=CC.IdEntidad
	 LEFT JOIN Accounting.Entidades E ON E.IdEntidad=CC.IdEntidad
	WHERE DD.IdContabilizacionDocumentoDet=@IdContabilizacionDocumentoDet 
	
	SET @Pivote=Substring(@Pivote,1,len(@Pivote)-1) 

	UPDATE Accounting.ContabilizacionDocumentosDet SET Pivote=@Pivote WHERE IdContabilizacionDocumentoDet=@IdContabilizacionDocumentoDet


