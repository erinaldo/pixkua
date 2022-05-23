/****** Object:  Default [DF_Almacenes_CreateDate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Inventory].[Almacenes] ADD  CONSTRAINT [DF_Almacenes_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


