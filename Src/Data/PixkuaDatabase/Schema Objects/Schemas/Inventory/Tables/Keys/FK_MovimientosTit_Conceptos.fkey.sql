/****** Object:  ForeignKey [FK_MovimientosTit_Conceptos]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Inventory].[MovimientosTit]  WITH CHECK ADD  CONSTRAINT [FK_MovimientosTit_Conceptos] FOREIGN KEY([IdConcepto])
REFERENCES [Inventory].[Conceptos] ([IdConcepto])


GO
ALTER TABLE [Inventory].[MovimientosTit] CHECK CONSTRAINT [FK_MovimientosTit_Conceptos]

