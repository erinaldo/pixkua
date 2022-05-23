/****** Object:  Default [DF_TiposPoliza_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[PolizasTipos] ADD  CONSTRAINT [DF_TiposPoliza_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


