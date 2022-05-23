/****** Object:  Default [DF_TraspasosTit_PCUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Inventory].[TraspasosTit] ADD  CONSTRAINT [DF_TraspasosTit_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


