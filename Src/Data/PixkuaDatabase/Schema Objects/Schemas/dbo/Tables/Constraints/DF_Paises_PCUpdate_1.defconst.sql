/****** Object:  Default [DF_Paises_PCUpdate_1]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[Paises] ADD  CONSTRAINT [DF_Paises_PCUpdate_1]  DEFAULT (host_name()) FOR [PCUpdate]


