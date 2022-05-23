/****** Object:  Default [DF_EstCom_CreateDate]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[EstCom] ADD  CONSTRAINT [DF_EstCom_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


