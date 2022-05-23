/****** Object:  Default [DF_CFDAddendas_PCUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[CFDAddendas] ADD  CONSTRAINT [DF_CFDAddendas_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


