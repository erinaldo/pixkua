/****** Object:  Default [DF_CFDSeries_CreateDate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[CFDSeries] ADD  CONSTRAINT [DF_CFDSeries_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


