CREATE PROCEDURE [Accounting].[PolizasLogINS]
@IdPolizaTit as varchar(18),
@IdStatus as int,
@Mensaje as varchar(512)
AS

	IF Len(@Mensaje)>0 
		IF EXISTS(SELECT IdPolizaTit FROM  Accounting.PolizasLog WHERE IdPolizaTit=@IdPolizaTit AND Fecha=Documents.fxDocumentDate(@IdPolizaTit))
			UPDATE Accounting.PolizasLog SET Fecha=GETDATE(), Mensaje=@Mensaje + CONVERT(Varchar(8),Fecha,112) + Mensaje 
			WHERE IdPolizaTit=@IdPolizaTit AND Fecha=Documents.fxDocumentDate(@IdPolizaTit)
		ELSE
			INSERT INTO Accounting.PolizasLog(IdPolizaTit,Fecha,FechaLog,IdStatus,Mensaje)
			VALUES (@IdPolizaTit,Documents.fxDocumentDate(@IdPolizaTit) ,GETDATE(),@IdStatus,@Mensaje)


