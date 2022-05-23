/****** Object:  Default [DF_Chequeras_LastUpdate]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Treasury].[Chequeras] ADD  CONSTRAINT [DF_Chequeras_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


