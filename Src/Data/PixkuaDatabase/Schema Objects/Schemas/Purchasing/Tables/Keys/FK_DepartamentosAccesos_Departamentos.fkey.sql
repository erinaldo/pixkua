/****** Object:  ForeignKey [FK_DepartamentosAccesos_Departamentos]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[DepartamentosAccesos]  WITH CHECK ADD  CONSTRAINT [FK_DepartamentosAccesos_Departamentos] FOREIGN KEY([IdDepartamento])
REFERENCES [RH].[Departamentos] ([IdDepartamento])


GO
ALTER TABLE [Purchasing].[DepartamentosAccesos] CHECK CONSTRAINT [FK_DepartamentosAccesos_Departamentos]

