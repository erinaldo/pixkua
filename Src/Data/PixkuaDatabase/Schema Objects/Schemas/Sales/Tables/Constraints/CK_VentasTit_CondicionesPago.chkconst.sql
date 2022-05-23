/****** Object:  Check [CK_VentasTit_CondicionesPago]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[VentasTit]  WITH CHECK ADD  CONSTRAINT [CK_VentasTit_CondicionesPago] CHECK  (([CondicionesPago]='E' OR [CondicionesPago]='C'))


GO
ALTER TABLE [Sales].[VentasTit] CHECK CONSTRAINT [CK_VentasTit_CondicionesPago]

