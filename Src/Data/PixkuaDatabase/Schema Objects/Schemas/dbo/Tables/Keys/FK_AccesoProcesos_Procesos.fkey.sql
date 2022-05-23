/****** Object:  ForeignKey [FK_AccesoProcesos_Procesos]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[AccesoProcesos]  WITH NOCHECK ADD  CONSTRAINT [FK_AccesoProcesos_Procesos] FOREIGN KEY([IdProceso])
REFERENCES [dbo].[Procesos] ([IdProceso])
ON DELETE CASCADE


GO
ALTER TABLE [dbo].[AccesoProcesos] CHECK CONSTRAINT [FK_AccesoProcesos_Procesos]

