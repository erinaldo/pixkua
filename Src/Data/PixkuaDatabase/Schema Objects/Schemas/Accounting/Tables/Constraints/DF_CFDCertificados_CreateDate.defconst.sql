/****** Object:  Default [DF_CFDCertificados_CreateDate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[CFDCertificados] ADD  CONSTRAINT [DF_CFDCertificados_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


