/****** Object:  ForeignKey [FK_Catalogos_Procesos]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[Catalogos]  WITH NOCHECK ADD  CONSTRAINT [FK_Catalogos_Procesos] FOREIGN KEY([IdProceso])
REFERENCES [dbo].[Procesos] ([IdProceso])
ON DELETE CASCADE


GO
ALTER TABLE [dbo].[Catalogos] CHECK CONSTRAINT [FK_Catalogos_Procesos]

