/****** Object:  Default [DF_Terminales_CreateDate]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[Terminales] ADD  CONSTRAINT [DF_Terminales_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


