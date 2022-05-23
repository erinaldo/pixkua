/****** Object:  Default [DF_Productos_Cantidad]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Production].[Productos] ADD  CONSTRAINT [DF_Productos_Cantidad]  DEFAULT ((1)) FOR [Cantidad]


