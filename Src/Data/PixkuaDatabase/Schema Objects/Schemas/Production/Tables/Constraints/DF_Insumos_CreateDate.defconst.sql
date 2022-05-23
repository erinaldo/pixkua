/****** Object:  Default [DF_Insumos_CreateDate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Production].[Insumos] ADD  CONSTRAINT [DF_Insumos_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


