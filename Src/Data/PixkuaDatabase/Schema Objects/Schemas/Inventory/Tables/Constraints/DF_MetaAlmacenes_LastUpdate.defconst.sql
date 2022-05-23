/****** Object:  Default [DF_MetaAlmacenes_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Inventory].[MetaAlmacenes] ADD  CONSTRAINT [DF_MetaAlmacenes_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


