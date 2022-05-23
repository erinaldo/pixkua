/****** Object:  Default [DF_ZonasVenta_PCUpdate]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[ZonasVenta] ADD  CONSTRAINT [DF_ZonasVenta_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


