﻿/****** Object:  Default [DF_DepartamentosCategorias_PCUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[DepartamentosCategorias] ADD  CONSTRAINT [DF_DepartamentosCategorias_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]

