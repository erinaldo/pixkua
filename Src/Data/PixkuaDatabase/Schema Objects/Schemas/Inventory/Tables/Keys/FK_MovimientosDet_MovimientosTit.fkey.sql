/****** Object:  ForeignKey [FK_MovimientosDet_MovimientosTit]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Inventory].[MovimientosDet]  WITH CHECK ADD  CONSTRAINT [FK_MovimientosDet_MovimientosTit] FOREIGN KEY([Fecha], [IdMovimientoTit])
REFERENCES [Inventory].[MovimientosTit] ([Fecha], [IdMovimientoTit])
ON DELETE CASCADE


GO
ALTER TABLE [Inventory].[MovimientosDet] CHECK CONSTRAINT [FK_MovimientosDet_MovimientosTit]

