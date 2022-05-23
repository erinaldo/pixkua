CREATE TABLE [dbo].[EventLog](
	[IdEventLog] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime] NOT NULL,
	[Time] [datetime] NOT NULL,
	[Message] [text] NOT NULL,
	[Type] [int] NOT NULL,
	[Source] [varchar](64) NOT NULL,
	[WorkStation] [varchar](32) NOT NULL,
 CONSTRAINT [PK_EventLog_1] PRIMARY KEY CLUSTERED 
(
	[Time] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Indica el tipo de mensaje: 1=Información, 2=Warning, 3=Error' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EventLog', @level2type=N'COLUMN',@level2name=N'Type'

