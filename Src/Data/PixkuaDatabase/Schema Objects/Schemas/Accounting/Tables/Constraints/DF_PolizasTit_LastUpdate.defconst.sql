/****** Object:  Default [DF_PolizasTit_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[PolizasTit] ADD  CONSTRAINT [DF_PolizasTit_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


