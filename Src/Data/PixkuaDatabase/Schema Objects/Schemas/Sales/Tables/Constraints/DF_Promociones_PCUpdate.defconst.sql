/****** Object:  Default [DF_Promociones_PCUpdate]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[Promociones] ADD  CONSTRAINT [DF_Promociones_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


