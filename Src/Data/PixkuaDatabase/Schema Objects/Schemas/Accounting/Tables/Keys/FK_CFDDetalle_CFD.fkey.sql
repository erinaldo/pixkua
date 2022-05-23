/****** Object:  ForeignKey [FK_CFDDetalle_CFD]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[CFDConceptos]  WITH CHECK ADD  CONSTRAINT [FK_CFDDetalle_CFD] FOREIGN KEY([FechaComprobante], [IdCFDSerie], [Folio])
REFERENCES [Accounting].[CFD] ([FechaComprobante], [IdCFDSerie], [Folio])


GO
ALTER TABLE [Accounting].[CFDConceptos] CHECK CONSTRAINT [FK_CFDDetalle_CFD]

