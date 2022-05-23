/****** Object:  Default [DF_UnidadesNegocio_CreateDate]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[UnidadesNegocio] ADD  CONSTRAINT [DF_UnidadesNegocio_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


