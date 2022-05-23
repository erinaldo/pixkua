/****** Object:  Default [DF_Meseros_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Restaurant].[Meseros] ADD  CONSTRAINT [DF_Meseros_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


