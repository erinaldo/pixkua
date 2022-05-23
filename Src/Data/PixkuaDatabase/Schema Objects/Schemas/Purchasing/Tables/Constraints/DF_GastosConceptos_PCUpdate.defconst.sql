/****** Object:  Default [DF_GastosConceptos_PCUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[GastosConceptos] ADD  CONSTRAINT [DF_GastosConceptos_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


