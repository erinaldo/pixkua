/****** Object:  Default [DF_CFDCertificados_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[CFDCertificados] ADD  CONSTRAINT [DF_CFDCertificados_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


