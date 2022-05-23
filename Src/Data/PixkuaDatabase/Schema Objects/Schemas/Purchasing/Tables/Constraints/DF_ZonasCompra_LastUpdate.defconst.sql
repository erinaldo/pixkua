/****** Object:  Default [DF_ZonasCompra_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[ZonasCompra] ADD  CONSTRAINT [DF_ZonasCompra_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


