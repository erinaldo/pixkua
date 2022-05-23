/****** Object:  Default [DF_ZonasVenta_LastUpdate]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[ZonasVenta] ADD  CONSTRAINT [DF_ZonasVenta_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


