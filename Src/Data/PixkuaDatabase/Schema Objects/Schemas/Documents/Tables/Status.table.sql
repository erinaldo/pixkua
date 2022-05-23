CREATE TABLE [Documents].[Status](
	[IdStatus_Homologar] [int] NOT NULL,
	[IdStatus] [int] NOT NULL,
	[Codigo] [varchar](16) NOT NULL,
	[Status] [varchar](64) NOT NULL,
	[StatusApplied] [varchar](64) NOT NULL,
	[Activo] [bit] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[IdEmpresa] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
	[UserCreate] [int] NOT NULL,
	[UserUpdate] [int] NOT NULL,
 CONSTRAINT [PK_Status_1] PRIMARY KEY CLUSTERED 
(
	[IdStatus_Homologar] ASC,
	[IdStatus] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


