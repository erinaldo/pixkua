/****** Object:  Default [DF_ComprobantesEnvios_CreateDate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[ComprobantesEnvios] ADD  CONSTRAINT [DF_ComprobantesEnvios_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


