/****** Object:  Default [DF_Areas_PCUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Inventory].[Areas] ADD  CONSTRAINT [DF_Areas_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


