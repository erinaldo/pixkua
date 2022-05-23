/****** Object:  ForeignKey [FK_Vendedores_Empleados]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[Vendedores]  WITH CHECK ADD  CONSTRAINT [FK_Vendedores_Empleados] FOREIGN KEY([IdEmpleado])
REFERENCES [RH].[Empleados] ([IdEmpleado])


GO
ALTER TABLE [Sales].[Vendedores] CHECK CONSTRAINT [FK_Vendedores_Empleados]

