/****** Object:  ForeignKey [FK_GruposProcesos_GruposUsr]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[GruposProcesos]  WITH NOCHECK ADD  CONSTRAINT [FK_GruposProcesos_GruposUsr] FOREIGN KEY([IdGrupo])
REFERENCES [dbo].[GruposUsr] ([IdGrupo])
ON DELETE CASCADE


GO
ALTER TABLE [dbo].[GruposProcesos] CHECK CONSTRAINT [FK_GruposProcesos_GruposUsr]

