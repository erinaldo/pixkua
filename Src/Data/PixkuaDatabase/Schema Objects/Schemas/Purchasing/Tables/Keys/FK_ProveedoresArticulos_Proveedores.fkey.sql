﻿/****** Object:  ForeignKey [FK_ProveedoresArticulos_Proveedores]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[ProveedoresArticulos]  WITH CHECK ADD  CONSTRAINT [FK_ProveedoresArticulos_Proveedores] FOREIGN KEY([IdProveedor])
REFERENCES [Purchasing].[Proveedores] ([IdProveedor])


GO
ALTER TABLE [Purchasing].[ProveedoresArticulos] CHECK CONSTRAINT [FK_ProveedoresArticulos_Proveedores]

