/****** Object:  ForeignKey [FK_Fechas_Calendario]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[Fechas]  WITH CHECK ADD  CONSTRAINT [FK_Fechas_Calendario] FOREIGN KEY([IdCalendario])
REFERENCES [dbo].[Calendarios] ([IdCalendario])


GO
ALTER TABLE [dbo].[Fechas] CHECK CONSTRAINT [FK_Fechas_Calendario]

