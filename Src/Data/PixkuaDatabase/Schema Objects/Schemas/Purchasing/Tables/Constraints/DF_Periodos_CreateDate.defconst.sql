﻿/****** Object:  Default [DF_Periodos_CreateDate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[Periodos] ADD  CONSTRAINT [DF_Periodos_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


