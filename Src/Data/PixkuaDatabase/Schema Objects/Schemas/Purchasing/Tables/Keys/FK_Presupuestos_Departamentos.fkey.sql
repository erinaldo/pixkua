/****** Object:  ForeignKey [FK_Presupuestos_Departamentos]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[Presupuestos]  WITH CHECK ADD  CONSTRAINT [FK_Presupuestos_Departamentos] FOREIGN KEY([IdDepartamento])
REFERENCES [RH].[Departamentos] ([IdDepartamento])


GO
ALTER TABLE [Purchasing].[Presupuestos] CHECK CONSTRAINT [FK_Presupuestos_Departamentos]

