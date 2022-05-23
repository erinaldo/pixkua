/****** Object:  Default [DF_NotasConceptos_PCUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[NotasConceptos] ADD  CONSTRAINT [DF_NotasConceptos_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


