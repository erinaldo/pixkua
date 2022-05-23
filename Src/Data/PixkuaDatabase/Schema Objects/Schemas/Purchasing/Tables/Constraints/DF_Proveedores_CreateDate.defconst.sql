/****** Object:  Default [DF_Proveedores_CreateDate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[Proveedores] ADD  CONSTRAINT [DF_Proveedores_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


