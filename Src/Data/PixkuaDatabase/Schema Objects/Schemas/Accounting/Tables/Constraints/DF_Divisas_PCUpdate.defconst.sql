﻿/****** Object:  Default [DF_Divisas_PCUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[Divisas] ADD  CONSTRAINT [DF_Divisas_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


