/****** Object:  Default [DF_Areas_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Inventory].[Areas] ADD  CONSTRAINT [DF_Areas_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


