﻿/****** Object:  Default [DF_CentrosCostos_CreateDate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[CategoriasPresupuestales] ADD  CONSTRAINT [DF_CentrosCostos_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


