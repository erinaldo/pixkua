/****** Object:  Default [DF_ContabilizacionDocumentosTit_CreateDate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[ContabilizacionDocumentosTit] ADD  CONSTRAINT [DF_ContabilizacionDocumentosTit_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


