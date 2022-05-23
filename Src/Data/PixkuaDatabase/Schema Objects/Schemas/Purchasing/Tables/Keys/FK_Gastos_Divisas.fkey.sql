/****** Object:  ForeignKey [FK_Gastos_Divisas]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[Gastos]  WITH CHECK ADD  CONSTRAINT [FK_Gastos_Divisas] FOREIGN KEY([IdDivisa])
REFERENCES [Accounting].[Divisas] ([IdDivisa])


GO
ALTER TABLE [Purchasing].[Gastos] CHECK CONSTRAINT [FK_Gastos_Divisas]

