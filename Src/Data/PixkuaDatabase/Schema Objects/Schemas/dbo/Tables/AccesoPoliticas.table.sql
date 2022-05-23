CREATE TABLE [dbo].[AccesoPoliticas](
	[IdAccesoPolitica] [int] IDENTITY(1,1) NOT NULL,
	[IdPolitica] [int] NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[Aplica] [bit] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
	[UserUpdate] [int] NOT NULL,
	[UserCreate] [int] NOT NULL,
 CONSTRAINT [PK_AccesoPoliticas] PRIMARY KEY CLUSTERED 
(
	[IdAccesoPolitica] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


