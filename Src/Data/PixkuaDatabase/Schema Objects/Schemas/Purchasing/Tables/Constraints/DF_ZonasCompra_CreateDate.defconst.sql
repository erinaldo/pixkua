/****** Object:  Default [DF_ZonasCompra_CreateDate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[ZonasCompra] ADD  CONSTRAINT [DF_ZonasCompra_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


