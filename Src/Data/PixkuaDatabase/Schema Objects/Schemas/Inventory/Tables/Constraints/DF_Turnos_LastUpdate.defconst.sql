/****** Object:  Default [DF_Turnos_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Inventory].[Turnos] ADD  CONSTRAINT [DF_Turnos_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


