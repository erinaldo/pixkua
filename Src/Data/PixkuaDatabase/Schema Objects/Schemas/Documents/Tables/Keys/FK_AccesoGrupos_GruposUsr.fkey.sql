/****** Object:  ForeignKey [FK_AccesoGrupos_GruposUsr]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Documents].[AccesoGrupos]  WITH CHECK ADD  CONSTRAINT [FK_AccesoGrupos_GruposUsr] FOREIGN KEY([IdGrupo])
REFERENCES [dbo].[GruposUsr] ([IdGrupo])
ON DELETE CASCADE


GO
ALTER TABLE [Documents].[AccesoGrupos] CHECK CONSTRAINT [FK_AccesoGrupos_GruposUsr]

