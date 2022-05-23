/****** Object:  ForeignKey [FK_GruposPoliticas_GruposUsr]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[GruposPoliticas]  WITH NOCHECK ADD  CONSTRAINT [FK_GruposPoliticas_GruposUsr] FOREIGN KEY([IdGrupo])
REFERENCES [dbo].[GruposUsr] ([IdGrupo])
ON DELETE CASCADE


GO
ALTER TABLE [dbo].[GruposPoliticas] CHECK CONSTRAINT [FK_GruposPoliticas_GruposUsr]

