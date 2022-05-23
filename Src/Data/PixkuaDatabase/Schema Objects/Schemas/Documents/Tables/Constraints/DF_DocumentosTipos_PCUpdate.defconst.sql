/****** Object:  Default [DF_DocumentosTipos_PCUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Documents].[Tipos] ADD  CONSTRAINT [DF_DocumentosTipos_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


