/****** Object:  Default [DF_Meseros_PCUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Restaurant].[Meseros] ADD  CONSTRAINT [DF_Meseros_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


