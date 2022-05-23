/****** Object:  Default [DF_VistasContablesTit_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[VistasContablesTit] ADD  CONSTRAINT [DF_VistasContablesTit_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


