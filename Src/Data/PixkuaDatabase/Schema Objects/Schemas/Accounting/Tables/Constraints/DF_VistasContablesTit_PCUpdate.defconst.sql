/****** Object:  Default [DF_VistasContablesTit_PCUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[VistasContablesTit] ADD  CONSTRAINT [DF_VistasContablesTit_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


