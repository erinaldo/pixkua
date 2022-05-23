/****** Object:  Default [DF_Categorias_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Restaurant].[Categorias] ADD  CONSTRAINT [DF_Categorias_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


