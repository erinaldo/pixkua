﻿/****** Object:  Default [DF_EstCom_LastUpdate]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[EstCom] ADD  CONSTRAINT [DF_EstCom_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]

