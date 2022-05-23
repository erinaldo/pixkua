/****** Object:  Default [DF_Status_PCUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Documents].[Status] ADD  CONSTRAINT [DF_Status_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


