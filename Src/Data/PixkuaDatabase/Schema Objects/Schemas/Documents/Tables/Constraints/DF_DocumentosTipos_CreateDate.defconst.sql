/****** Object:  Default [DF_DocumentosTipos_CreateDate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Documents].[Tipos] ADD  CONSTRAINT [DF_DocumentosTipos_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


