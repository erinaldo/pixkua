/****** Object:  Default [DF_Departamentos_CreateDate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[Departamentos] ADD  CONSTRAINT [DF_Departamentos_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


