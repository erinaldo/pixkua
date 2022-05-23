/****** Object:  Default [DF_VistasContablesTit_CreateDate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[VistasContablesTit] ADD  CONSTRAINT [DF_VistasContablesTit_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


