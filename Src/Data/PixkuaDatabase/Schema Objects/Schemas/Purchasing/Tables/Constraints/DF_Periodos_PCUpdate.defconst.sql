/****** Object:  Default [DF_Periodos_PCUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[Periodos] ADD  CONSTRAINT [DF_Periodos_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


