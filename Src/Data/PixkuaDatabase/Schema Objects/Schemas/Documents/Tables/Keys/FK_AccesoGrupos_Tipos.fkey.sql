/****** Object:  ForeignKey [FK_AccesoGrupos_Tipos]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Documents].[AccesoGrupos]  WITH CHECK ADD  CONSTRAINT [FK_AccesoGrupos_Tipos] FOREIGN KEY([IdTipo])
REFERENCES [Documents].[Tipos] ([IdDocumentoTipo])
ON DELETE CASCADE


GO
ALTER TABLE [Documents].[AccesoGrupos] CHECK CONSTRAINT [FK_AccesoGrupos_Tipos]

