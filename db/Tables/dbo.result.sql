CREATE TABLE [dbo].[result]
(
[competition_id] [int] NOT NULL,
[team_id] [int] NOT NULL,
[user_id] [int] NOT NULL,
[points] [decimal] (6, 2) NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[result] ADD CONSTRAINT [FK_result_competition] FOREIGN KEY ([competition_id]) REFERENCES [dbo].[competition] ([id])
GO
ALTER TABLE [dbo].[result] ADD CONSTRAINT [FK_result_team] FOREIGN KEY ([team_id]) REFERENCES [dbo].[team] ([id])
GO
ALTER TABLE [dbo].[result] ADD CONSTRAINT [FK_result_user] FOREIGN KEY ([user_id]) REFERENCES [dbo].[user] ([id])
GO
