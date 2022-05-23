/****** Object:  Default [DF_FormasPago_PCUpdate]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[FormasPago] ADD  CONSTRAINT [DF_FormasPago_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


