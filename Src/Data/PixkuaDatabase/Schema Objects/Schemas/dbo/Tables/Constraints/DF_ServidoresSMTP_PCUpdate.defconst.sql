/****** Object:  Default [DF_ServidoresSMTP_PCUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[ServidoresSMTP] ADD  CONSTRAINT [DF_ServidoresSMTP_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


