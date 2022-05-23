/****** Object:  ForeignKey [FK_Procesos_ProcesosTipos]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[Procesos]  WITH NOCHECK ADD  CONSTRAINT [FK_Procesos_ProcesosTipos] FOREIGN KEY([IdProcesoTipo])
REFERENCES [dbo].[ProcesosTipos] ([IdProcesoTipo])


GO
ALTER TABLE [dbo].[Procesos] CHECK CONSTRAINT [FK_Procesos_ProcesosTipos]

