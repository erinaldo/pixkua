/****** Object:  Default [DF_Centrales_PCUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[Centrales] ADD  CONSTRAINT [DF_Centrales_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


