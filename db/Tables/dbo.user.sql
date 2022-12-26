CREATE TABLE [dbo].[user]
(
[id] [int] NOT NULL IDENTITY(1, 1),
[first_name] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[last_name] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[email] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[password] [nvarchar] (250) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[role_id] [int] NOT NULL,
[team_id] [int] NOT NULL,
[points_summary] [int] NOT NULL,
[date_create] [datetime] NOT NULL,
[date_modify] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[user_create_id] [int] NOT NULL,
[user_update_id] [int] NOT NULL,
[status_id] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[user] ADD CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED ([id]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[user] ADD CONSTRAINT [FK_user_team] FOREIGN KEY ([team_id]) REFERENCES [dbo].[team] ([id])
GO
ALTER TABLE [dbo].[user] ADD CONSTRAINT [FK_user_user_create] FOREIGN KEY ([user_create_id]) REFERENCES [dbo].[user] ([id])
GO
ALTER TABLE [dbo].[user] ADD CONSTRAINT [FK_user_user_role] FOREIGN KEY ([role_id]) REFERENCES [dbo].[user_role] ([id])
GO
ALTER TABLE [dbo].[user] ADD CONSTRAINT [FK_user_user_status] FOREIGN KEY ([status_id]) REFERENCES [dbo].[user_status] ([id])
GO
ALTER TABLE [dbo].[user] ADD CONSTRAINT [FK_user_user_update] FOREIGN KEY ([user_update_id]) REFERENCES [dbo].[user] ([id])
GO
