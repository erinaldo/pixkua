﻿/****** Object:  Default [DF_RacTit_Pixkua_CreateDate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[RacTit] ADD  CONSTRAINT [DF_RacTit_Pixkua_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


