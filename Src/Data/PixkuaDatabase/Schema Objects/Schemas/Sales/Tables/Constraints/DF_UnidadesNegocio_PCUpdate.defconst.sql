/****** Object:  Default [DF_UnidadesNegocio_PCUpdate]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[UnidadesNegocio] ADD  CONSTRAINT [DF_UnidadesNegocio_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


