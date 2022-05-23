/****** Object:  Default [DF_Status_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Documents].[Status] ADD  CONSTRAINT [DF_Status_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


