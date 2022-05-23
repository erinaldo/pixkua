/****** Object:  Default [DF_Almacenes_PCUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Inventory].[Almacenes] ADD  CONSTRAINT [DF_Almacenes_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


