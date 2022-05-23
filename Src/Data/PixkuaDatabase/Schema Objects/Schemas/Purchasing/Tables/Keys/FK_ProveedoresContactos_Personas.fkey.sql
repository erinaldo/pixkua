/****** Object:  ForeignKey [FK_ProveedoresContactos_Personas]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[ProveedoresContactos]  WITH CHECK ADD  CONSTRAINT [FK_ProveedoresContactos_Personas] FOREIGN KEY([IdPersona])
REFERENCES [dbo].[Personas] ([IdPersona])


GO
ALTER TABLE [Purchasing].[ProveedoresContactos] CHECK CONSTRAINT [FK_ProveedoresContactos_Personas]

