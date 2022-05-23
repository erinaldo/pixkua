/****** Object:  Default [DF_Impresoras_CreateDate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[Impresoras] ADD  CONSTRAINT [DF_Impresoras_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


