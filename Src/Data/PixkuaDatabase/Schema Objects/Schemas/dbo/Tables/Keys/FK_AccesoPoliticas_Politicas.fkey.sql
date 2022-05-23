/****** Object:  ForeignKey [FK_AccesoPoliticas_Politicas]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[AccesoPoliticas]  WITH CHECK ADD  CONSTRAINT [FK_AccesoPoliticas_Politicas] FOREIGN KEY([IdPolitica])
REFERENCES [dbo].[Politicas] ([IdPolitica])
ON DELETE CASCADE


GO
ALTER TABLE [dbo].[AccesoPoliticas] CHECK CONSTRAINT [FK_AccesoPoliticas_Politicas]

