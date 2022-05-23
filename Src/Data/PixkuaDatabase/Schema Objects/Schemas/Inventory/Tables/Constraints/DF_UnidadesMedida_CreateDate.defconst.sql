/****** Object:  Default [DF_UnidadesMedida_CreateDate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Inventory].[UnidadesMedida] ADD  CONSTRAINT [DF_UnidadesMedida_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


