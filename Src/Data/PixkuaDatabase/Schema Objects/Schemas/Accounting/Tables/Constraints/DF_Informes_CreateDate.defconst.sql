/****** Object:  Default [DF_Informes_CreateDate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[Informes] ADD  CONSTRAINT [DF_Informes_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


