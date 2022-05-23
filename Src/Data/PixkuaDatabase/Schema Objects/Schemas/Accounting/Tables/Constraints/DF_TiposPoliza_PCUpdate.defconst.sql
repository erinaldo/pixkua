/****** Object:  Default [DF_TiposPoliza_PCUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[PolizasTipos] ADD  CONSTRAINT [DF_TiposPoliza_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


