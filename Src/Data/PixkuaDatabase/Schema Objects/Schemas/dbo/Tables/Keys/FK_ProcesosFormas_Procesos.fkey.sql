/****** Object:  ForeignKey [FK_ProcesosFormas_Procesos]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[ProcesosFormas]  WITH NOCHECK ADD  CONSTRAINT [FK_ProcesosFormas_Procesos] FOREIGN KEY([IdProceso])
REFERENCES [dbo].[Procesos] ([IdProceso])
ON DELETE CASCADE


GO
ALTER TABLE [dbo].[ProcesosFormas] CHECK CONSTRAINT [FK_ProcesosFormas_Procesos]

