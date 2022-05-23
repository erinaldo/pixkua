/****** Object:  Default [DF_NotasConceptos_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[NotasConceptos] ADD  CONSTRAINT [DF_NotasConceptos_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


