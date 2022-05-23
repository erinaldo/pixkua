/****** Object:  Default [DF_Categorias_CreateDate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Restaurant].[Categorias] ADD  CONSTRAINT [DF_Categorias_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


