/****** Object:  Default [DF_Estados_PCUpdate_1]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[Estados] ADD  CONSTRAINT [DF_Estados_PCUpdate_1]  DEFAULT (host_name()) FOR [PCUpdate]


