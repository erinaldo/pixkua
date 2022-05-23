/****** Object:  Default [DF_Turnos_IdEmpresa]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Inventory].[Turnos] ADD  CONSTRAINT [DF_Turnos_IdEmpresa]  DEFAULT ((1)) FOR [IdEmpresa]


