/****** Object:  ForeignKey [FK_CFD_CFDTipos]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[CFD]  WITH CHECK ADD  CONSTRAINT [FK_CFD_CFDTipos] FOREIGN KEY([IdCFDTipo])
REFERENCES [Accounting].[CFDTipos] ([IdCFDTipo])


GO
ALTER TABLE [Accounting].[CFD] CHECK CONSTRAINT [FK_CFD_CFDTipos]

