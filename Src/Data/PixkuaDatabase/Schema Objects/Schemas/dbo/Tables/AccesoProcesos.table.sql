CREATE TABLE [dbo].[AccesoProcesos](
	[IdAccesoProceso] [int] IDENTITY(1,1) NOT NULL,
	[IdProceso] [int] NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[Acceso] [bit] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
	[UserUpdate] [int] NOT NULL,
	[UserCreate] [int] NOT NULL,
 CONSTRAINT [PK_AccesoProcesos] PRIMARY KEY CLUSTERED 
(
	[IdAccesoProceso] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


