/****** Object:  Default [DF_Retenciones_PCUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[Retenciones] ADD  CONSTRAINT [DF_Retenciones_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


