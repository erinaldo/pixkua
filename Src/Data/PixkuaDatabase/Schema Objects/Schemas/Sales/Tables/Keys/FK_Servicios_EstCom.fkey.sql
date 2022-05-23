/****** Object:  ForeignKey [FK_Servicios_EstCom]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[Servicios]  WITH CHECK ADD  CONSTRAINT [FK_Servicios_EstCom] FOREIGN KEY([IdEstCom])
REFERENCES [Sales].[EstCom] ([IdEstCom])


GO
ALTER TABLE [Sales].[Servicios] CHECK CONSTRAINT [FK_Servicios_EstCom]

