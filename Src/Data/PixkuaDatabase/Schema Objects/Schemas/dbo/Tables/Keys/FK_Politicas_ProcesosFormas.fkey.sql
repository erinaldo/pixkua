/****** Object:  ForeignKey [FK_Politicas_ProcesosFormas]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[Politicas]  WITH NOCHECK ADD  CONSTRAINT [FK_Politicas_ProcesosFormas] FOREIGN KEY([IdProcesoForma])
REFERENCES [dbo].[ProcesosFormas] ([IdProcesoForma])
ON DELETE CASCADE


GO
ALTER TABLE [dbo].[Politicas] CHECK CONSTRAINT [FK_Politicas_ProcesosFormas]

