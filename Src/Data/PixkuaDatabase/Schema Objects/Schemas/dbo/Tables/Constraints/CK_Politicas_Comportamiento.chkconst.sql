/****** Object:  Check [CK_Politicas_Comportamiento]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[Politicas]  WITH CHECK ADD  CONSTRAINT [CK_Politicas_Comportamiento] CHECK  (([Comportamiento]='E' OR [Comportamiento]='T'))


GO
ALTER TABLE [dbo].[Politicas] CHECK CONSTRAINT [CK_Politicas_Comportamiento]

