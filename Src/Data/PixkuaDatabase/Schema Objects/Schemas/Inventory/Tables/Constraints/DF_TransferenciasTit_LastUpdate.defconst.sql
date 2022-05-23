/****** Object:  Default [DF_TransferenciasTit_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Inventory].[TransferenciasTit] ADD  CONSTRAINT [DF_TransferenciasTit_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


