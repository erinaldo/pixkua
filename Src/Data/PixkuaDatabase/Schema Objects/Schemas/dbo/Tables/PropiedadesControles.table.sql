CREATE TABLE [dbo].[PropiedadesControles](
	[IdPropiedadControl] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[Propiedad] [varchar](64) NOT NULL,
	[UINombre] [varchar](64) NOT NULL,
	[DataType] [varchar](64) NOT NULL,
	[IdStatus] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
	[UserCreate] [int] NOT NULL,
	[UserUpdate] [int] NOT NULL,
 CONSTRAINT [PK_PropiedadesControles] PRIMARY KEY CLUSTERED 
(
	[IdPropiedadControl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


