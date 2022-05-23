/****** Object:  ForeignKey [FK_ClientesContactos_Personas]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[ClientesContactos]  WITH CHECK ADD  CONSTRAINT [FK_ClientesContactos_Personas] FOREIGN KEY([IdPersona])
REFERENCES [dbo].[Personas] ([IdPersona])


GO
ALTER TABLE [Sales].[ClientesContactos] CHECK CONSTRAINT [FK_ClientesContactos_Personas]

