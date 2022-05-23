/****** Object:  ForeignKey [FK_Workflow_Tipos]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Documents].[Workflow]  WITH CHECK ADD  CONSTRAINT [FK_Workflow_Tipos] FOREIGN KEY([IdDocumentoTipo])
REFERENCES [Documents].[Tipos] ([IdDocumentoTipo])
ON DELETE CASCADE


GO
ALTER TABLE [Documents].[Workflow] CHECK CONSTRAINT [FK_Workflow_Tipos]

