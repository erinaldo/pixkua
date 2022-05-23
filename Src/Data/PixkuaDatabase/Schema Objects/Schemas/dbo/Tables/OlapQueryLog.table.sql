CREATE TABLE [dbo].[OlapQueryLog](
	[MSOLAP_Database] [nvarchar](255) NULL,
	[MSOLAP_ObjectPath] [nvarchar](4000) NULL,
	[MSOLAP_User] [nvarchar](255) NULL,
	[Dataset] [nvarchar](4000) NULL,
	[StartTime] [datetime] NULL,
	[Duration] [bigint] NULL
) ON [PRIMARY]


