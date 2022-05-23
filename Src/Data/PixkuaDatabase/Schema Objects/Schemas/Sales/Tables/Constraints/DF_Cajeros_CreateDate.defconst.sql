/****** Object:  Default [DF_Cajeros_CreateDate]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[Cajeros] ADD  CONSTRAINT [DF_Cajeros_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


