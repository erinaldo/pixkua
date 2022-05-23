/****** Object:  Default [DF_RequisicionesTipos_PCUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[RequisicionesTipos] ADD  CONSTRAINT [DF_RequisicionesTipos_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


