/****** Object:  Default [DF_ContabilizacionDocumentosTit_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[ContabilizacionDocumentosTit] ADD  CONSTRAINT [DF_ContabilizacionDocumentosTit_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


