/****** Object:  ForeignKey [FK_VentasDet_VentasTit]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[VentasDet]  WITH CHECK ADD  CONSTRAINT [FK_VentasDet_VentasTit] FOREIGN KEY([Fecha], [IdVentaTit])
REFERENCES [Sales].[VentasTit] ([Fecha], [IdVentaTit])
ON DELETE CASCADE


GO
ALTER TABLE [Sales].[VentasDet] CHECK CONSTRAINT [FK_VentasDet_VentasTit]

