﻿/****** Object:  Default [DF_UnidadesMedida_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Inventory].[UnidadesMedida] ADD  CONSTRAINT [DF_UnidadesMedida_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


