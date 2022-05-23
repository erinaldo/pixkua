﻿CREATE TABLE [Purchasing].[Proveedores](
	[IdProveedor] [int] NOT NULL,
	[Codigo] [varchar](16) NOT NULL,
	[Nombre] [varchar](128) NOT NULL,
	[Calle] [varchar](64) NOT NULL,
	[NumExt] [varchar](16) NOT NULL,
	[NumInt] [varchar](16) NOT NULL,
	[Colonia] [varchar](64) NOT NULL,
	[CP] [char](5) NOT NULL,
	[IdPoblacion] [int] NOT NULL,
	[FacturaElectronica] [bit] NOT NULL,
	[RFC] [varchar](16) NOT NULL,
	[RazonSocial] [varchar](128) NOT NULL,
	[CalleFIS] [varchar](128) NOT NULL,
	[NumExtFIS] [varchar](16) NOT NULL,
	[NumIntFIS] [varchar](16) NOT NULL,
	[ColoniaFIS] [varchar](128) NOT NULL,
	[CPFis] [char](5) NOT NULL,
	[IdPoblacionFIS] [int] NOT NULL,
	[Telefono] [varchar](16) NOT NULL,
	[Fax] [varchar](16) NOT NULL,
	[Correo] [varchar](128) NOT NULL,
	[PagWeb] [varchar](256) NOT NULL,
	[Saldo] [decimal](19, 4) NOT NULL,
	[LimiteCredito] [decimal](19, 4) NOT NULL,
	[DiasCredito] [int] NOT NULL,
	[DiasEntrega] [int] NOT NULL,
	[PagoAnticipado] [bit] NOT NULL,
	[PorcAnticipo] [decimal](7, 6) NOT NULL,
	[IdCuenta] [int] NOT NULL,
	[WebPassword] [varchar](16) NOT NULL,
	[IdStatus] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[IdEmpresa] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
	[UserCreate] [int] NOT NULL,
	[UserUpdate] [int] NOT NULL,
 CONSTRAINT [PK_Proveedores] PRIMARY KEY CLUSTERED 
(
	[IdProveedor] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

