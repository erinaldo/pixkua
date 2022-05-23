/****** Object:  ForeignKey [FK_Requisiciones_RequisicionesTipos]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[Requisiciones]  WITH CHECK ADD  CONSTRAINT [FK_Requisiciones_RequisicionesTipos] FOREIGN KEY([IdRequisicionTipo])
REFERENCES [Purchasing].[RequisicionesTipos] ([IdRequisicionTipo])


GO
ALTER TABLE [Purchasing].[Requisiciones] CHECK CONSTRAINT [FK_Requisiciones_RequisicionesTipos]

