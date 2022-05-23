/****** Object:  Default [DF_Articulos_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Restaurant].[Articulos] ADD  CONSTRAINT [DF_Articulos_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


