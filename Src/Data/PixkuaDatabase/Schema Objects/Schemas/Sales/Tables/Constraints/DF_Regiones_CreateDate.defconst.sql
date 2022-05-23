/****** Object:  Default [DF_Regiones_CreateDate]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[Regiones] ADD  CONSTRAINT [DF_Regiones_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


