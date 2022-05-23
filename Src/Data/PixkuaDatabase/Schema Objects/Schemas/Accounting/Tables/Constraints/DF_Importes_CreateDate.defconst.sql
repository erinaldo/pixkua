/****** Object:  Default [DF_Importes_CreateDate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[Importes] ADD  CONSTRAINT [DF_Importes_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


