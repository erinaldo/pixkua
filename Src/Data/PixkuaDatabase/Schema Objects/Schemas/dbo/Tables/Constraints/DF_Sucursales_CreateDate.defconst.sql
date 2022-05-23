/****** Object:  Default [DF_Sucursales_CreateDate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[Sucursales] ADD  CONSTRAINT [DF_Sucursales_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


