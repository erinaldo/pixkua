/****** Object:  Default [DF_Marcas_CreateDate]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[Marcas] ADD  CONSTRAINT [DF_Marcas_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


