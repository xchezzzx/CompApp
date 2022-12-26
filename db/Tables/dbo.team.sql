CREATE TABLE [dbo].[team]
(
[id] [int] NOT NULL IDENTITY(1, 1),
[name] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[icon] [image] NULL,
[email] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[sum_points] [int] NULL,
[date_create] [datetime] NOT NULL,
[date_update] [datetime] NOT NULL,
[user_create_id] [int] NOT NULL,
[user_update_id] [int] NOT NULL,
[status_id] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[team] ADD CONSTRAINT [PK_team] PRIMARY KEY CLUSTERED ([id]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[team] ADD CONSTRAINT [FK_team_team_status] FOREIGN KEY ([status_id]) REFERENCES [dbo].[team_status] ([id])
GO
ALTER TABLE [dbo].[team] ADD CONSTRAINT [FK_team_user_create] FOREIGN KEY ([user_create_id]) REFERENCES [dbo].[user] ([id])
GO
ALTER TABLE [dbo].[team] ADD CONSTRAINT [FK_team_user_update] FOREIGN KEY ([user_update_id]) REFERENCES [dbo].[user] ([id])
GO
