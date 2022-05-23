/****** Object:  Default [DF_PolizasTit_PCUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[PolizasTit] ADD  CONSTRAINT [DF_PolizasTit_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


