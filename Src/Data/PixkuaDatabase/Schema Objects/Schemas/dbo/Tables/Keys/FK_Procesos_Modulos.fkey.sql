/****** Object:  ForeignKey [FK_Procesos_Modulos]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[Procesos]  WITH NOCHECK ADD  CONSTRAINT [FK_Procesos_Modulos] FOREIGN KEY([IdModulo])
REFERENCES [dbo].[Modulos] ([IdModulo])


GO
ALTER TABLE [dbo].[Procesos] CHECK CONSTRAINT [FK_Procesos_Modulos]

