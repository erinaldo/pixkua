﻿/****** Object:  Default [DF_ServidoresSMTP_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[ServidoresSMTP] ADD  CONSTRAINT [DF_ServidoresSMTP_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


