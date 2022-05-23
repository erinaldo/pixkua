/****** Object:  Default [DF_Servicios_CreateDate]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[Servicios] ADD  CONSTRAINT [DF_Servicios_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


