/****** Object:  Default [DF_Categorias_PCUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Restaurant].[Categorias] ADD  CONSTRAINT [DF_Categorias_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


