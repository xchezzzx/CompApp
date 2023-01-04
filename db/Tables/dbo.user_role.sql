CREATE TABLE [dbo].[user_role]
(
[id] [int] NOT NULL IDENTITY(1, 1),
[role_name] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[user_role] ADD CONSTRAINT [PK_role] PRIMARY KEY CLUSTERED ([id]) ON [PRIMARY]
GO
