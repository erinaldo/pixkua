CREATE FUNCTION [Accounting].[fxVistasContablesValidaRAC](@IdVistaContableTit AS INT,@IdRacTit as int)
RETURNS Varchar(256)
BEGIN
		DECLARE @Return as Varchar(256)
		SET @Return=''
		
		SELECT @Return=  @Return + '[' + E.Entidad + '],' 
		FROM Accounting.RacDet RD 
		INNER JOIN Accounting.Entidades E ON E.IdEntidad=RD.IdEntidad
		LEFT JOIN Accounting.VistasContablesEntidad AS VC ON VC.IdEntidad=RD.IdEntidad AND VC.IdVistaContableTit=@IdVistaContableTit
		WHERE IdRacTit=@IdRacTit AND VC.IdEntidad is null
		
		IF len(@Return)>0
			SET @Return= SUBSTRING(@Return,1,LEN(@Return)-1)
				
		RETURN @Return
END


