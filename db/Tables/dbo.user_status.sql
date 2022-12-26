CREATE TABLE [dbo].[user_status]
(
[id] [int] NOT NULL IDENTITY(1, 1),
[user_status_name] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[user_status] ADD CONSTRAINT [PK_user_status] PRIMARY KEY CLUSTERED ([id]) ON [PRIMARY]
GO
