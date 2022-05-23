/****** Object:  Default [DF_CFDSeries_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[CFDSeries] ADD  CONSTRAINT [DF_CFDSeries_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


