/****** Object:  ForeignKey [FK_AccesoUsuarios_Tipos]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Documents].[AccesoUsuarios]  WITH CHECK ADD  CONSTRAINT [FK_AccesoUsuarios_Tipos] FOREIGN KEY([IdTipo])
REFERENCES [Documents].[Tipos] ([IdDocumentoTipo])
ON DELETE CASCADE


GO
ALTER TABLE [Documents].[AccesoUsuarios] CHECK CONSTRAINT [FK_AccesoUsuarios_Tipos]

