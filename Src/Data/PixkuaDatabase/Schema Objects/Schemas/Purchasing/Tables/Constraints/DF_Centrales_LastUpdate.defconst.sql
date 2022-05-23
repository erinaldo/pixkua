/****** Object:  Default [DF_Centrales_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[Centrales] ADD  CONSTRAINT [DF_Centrales_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


