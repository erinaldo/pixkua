/****** Object:  Default [DF_Articulos_CreateDate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Restaurant].[Articulos] ADD  CONSTRAINT [DF_Articulos_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


