/****** Object:  Default [DF_ServidoresSMTP_CreateDate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[ServidoresSMTP] ADD  CONSTRAINT [DF_ServidoresSMTP_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


