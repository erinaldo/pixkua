/****** Object:  Default [DF_Promociones_CreateDate]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[Promociones] ADD  CONSTRAINT [DF_Promociones_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


