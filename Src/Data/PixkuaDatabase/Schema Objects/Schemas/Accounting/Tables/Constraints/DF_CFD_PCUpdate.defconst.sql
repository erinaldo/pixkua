/****** Object:  Default [DF_CFD_PCUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[CFD] ADD  CONSTRAINT [DF_CFD_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


