/****** Object:  Default [DF_Conceptos_PCUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Inventory].[Conceptos] ADD  CONSTRAINT [DF_Conceptos_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


