/****** Object:  Default [DF_ComandaTit_HoraInicio]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Restaurant].[ComandaTit] ADD  CONSTRAINT [DF_ComandaTit_HoraInicio]  DEFAULT (getdate()) FOR [HoraInicio]


