﻿/****** Object:  Default [DF_Articulos_LastUpdate]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[Articulos] ADD  CONSTRAINT [DF_Articulos_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


