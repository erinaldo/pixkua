/****** Object:  Default [DF_Turnos_IdStatus]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Inventory].[Turnos] ADD  CONSTRAINT [DF_Turnos_IdStatus]  DEFAULT ((1)) FOR [IdStatus]


