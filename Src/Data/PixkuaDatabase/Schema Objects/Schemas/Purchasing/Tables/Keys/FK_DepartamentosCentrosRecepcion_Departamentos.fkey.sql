/****** Object:  ForeignKey [FK_DepartamentosCentrosRecepcion_Departamentos]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[DepartamentosCentrosRecepcion]  WITH CHECK ADD  CONSTRAINT [FK_DepartamentosCentrosRecepcion_Departamentos] FOREIGN KEY([IdDepartamento])
REFERENCES [RH].[Departamentos] ([IdDepartamento])


GO
ALTER TABLE [Purchasing].[DepartamentosCentrosRecepcion] CHECK CONSTRAINT [FK_DepartamentosCentrosRecepcion_Departamentos]

