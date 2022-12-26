CREATE TABLE [dbo].[users_to_teams]
(
[user_id] [int] NOT NULL,
[team_id] [int] NOT NULL,
[is_captain] [bit] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[users_to_teams] ADD CONSTRAINT [FK_users_to_teams_team] FOREIGN KEY ([team_id]) REFERENCES [dbo].[team] ([id])
GO
ALTER TABLE [dbo].[users_to_teams] ADD CONSTRAINT [FK_users_to_teams_user] FOREIGN KEY ([user_id]) REFERENCES [dbo].[user] ([id])
GO
