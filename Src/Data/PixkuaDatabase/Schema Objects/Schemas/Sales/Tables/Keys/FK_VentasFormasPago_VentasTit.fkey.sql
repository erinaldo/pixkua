/****** Object:  ForeignKey [FK_VentasFormasPago_VentasTit]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[VentasFormasPago]  WITH CHECK ADD  CONSTRAINT [FK_VentasFormasPago_VentasTit] FOREIGN KEY([Fecha], [IdVentaTit])
REFERENCES [Sales].[VentasTit] ([Fecha], [IdVentaTit])


GO
ALTER TABLE [Sales].[VentasFormasPago] CHECK CONSTRAINT [FK_VentasFormasPago_VentasTit]

