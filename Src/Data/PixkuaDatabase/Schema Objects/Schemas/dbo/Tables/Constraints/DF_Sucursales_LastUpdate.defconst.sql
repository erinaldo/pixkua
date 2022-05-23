/****** Object:  Default [DF_Sucursales_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[Sucursales] ADD  CONSTRAINT [DF_Sucursales_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


