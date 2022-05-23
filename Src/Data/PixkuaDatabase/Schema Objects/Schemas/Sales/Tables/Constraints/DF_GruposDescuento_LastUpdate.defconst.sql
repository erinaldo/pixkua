/****** Object:  Default [DF_GruposDescuento_LastUpdate]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[GruposDescuento] ADD  CONSTRAINT [DF_GruposDescuento_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


