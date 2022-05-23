/****** Object:  ForeignKey [FK_DepartamentosCategorias_Departamentos]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[DepartamentosCategorias]  WITH CHECK ADD  CONSTRAINT [FK_DepartamentosCategorias_Departamentos] FOREIGN KEY([IdDepartamento])
REFERENCES [RH].[Departamentos] ([IdDepartamento])


GO
ALTER TABLE [Purchasing].[DepartamentosCategorias] CHECK CONSTRAINT [FK_DepartamentosCategorias_Departamentos]

