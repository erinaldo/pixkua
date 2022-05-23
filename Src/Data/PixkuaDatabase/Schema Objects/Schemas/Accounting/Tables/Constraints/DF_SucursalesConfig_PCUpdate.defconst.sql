/****** Object:  Default [DF_SucursalesConfig_PCUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[SucursalesConfig] ADD  CONSTRAINT [DF_SucursalesConfig_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


