/****** Object:  ForeignKey [FK_Articulos_EstCom]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[Articulos]  WITH CHECK ADD  CONSTRAINT [FK_Articulos_EstCom] FOREIGN KEY([IdEstCom])
REFERENCES [Sales].[EstCom] ([IdEstCom])


GO
ALTER TABLE [Sales].[Articulos] CHECK CONSTRAINT [FK_Articulos_EstCom]

