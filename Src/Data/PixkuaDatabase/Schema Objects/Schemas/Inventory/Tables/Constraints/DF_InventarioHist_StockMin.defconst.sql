/****** Object:  Default [DF_InventarioHist_StockMin]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Inventory].[InventarioHist] ADD  CONSTRAINT [DF_InventarioHist_StockMin]  DEFAULT ((0)) FOR [StockMin]


