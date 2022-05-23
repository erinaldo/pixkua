CREATE TABLE [RH].[Empleados](
	[IdEmpleado] [int] NOT NULL,
	[Codigo] [varchar](32) NOT NULL,
	[IdPersona] [int] NOT NULL,
	[CodigoChecador] [int] NOT NULL,
	[NombreCorto] [varchar](32) NOT NULL,
	[IdTurno] [int] NOT NULL,
	[FechaInicio] [datetime] NOT NULL,
	[Genero] [char](1) NOT NULL,
	[Titulo] [varchar](64) NOT NULL,
	[FechaIngreso] [datetime] NOT NULL,
	[FechaBaja] [datetime] NULL,
	[Sueldo] [decimal](19, 4) NOT NULL,
	[IdDepartamento] [int] NOT NULL,
	[IdPuesto] [int] NOT NULL,
	[FechaNacimiento] [datetime] NOT NULL,
	[NSS] [varchar](32) NOT NULL,
	[RFC] [char](15) NOT NULL,
	[CURP] [char](32) NOT NULL,
	[Foto] [image] NULL,
	[IdCuenta] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[IdEmpresa] [int] NOT NULL,
	[IdStatus] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
	[UserCreate] [int] NOT NULL,
	[UserUpdate] [int] NOT NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[IdEmpleado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


