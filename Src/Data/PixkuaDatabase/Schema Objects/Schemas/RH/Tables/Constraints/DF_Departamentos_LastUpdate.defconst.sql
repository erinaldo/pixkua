/****** Object:  Default [DF_Departamentos_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [RH].[Departamentos] ADD  CONSTRAINT [DF_Departamentos_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


