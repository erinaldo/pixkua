/****** Object:  Default [DF_CFDCertificados_PCUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[CFDCertificados] ADD  CONSTRAINT [DF_CFDCertificados_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


