CREATE TABLE [dbo].[competition]
(
[id] [int] NOT NULL,
[competition_name] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[duration] [time] NOT NULL,
[start_time] [datetime] NOT NULL,
[end_time] [datetime] NOT NULL,
[number_conc_tasks] [int] NOT NULL,
[hashtag] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[date_create] [datetime] NOT NULL,
[date_update] [datetime] NOT NULL,
[user_create_id] [int] NOT NULL,
[user_update_id] [int] NOT NULL,
[status_id] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[competition] ADD CONSTRAINT [PK_competition] PRIMARY KEY CLUSTERED ([id]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[competition] ADD CONSTRAINT [FK_competition_competition_status] FOREIGN KEY ([status_id]) REFERENCES [dbo].[competition_status] ([id])
GO
ALTER TABLE [dbo].[competition] ADD CONSTRAINT [FK_competition_user_create] FOREIGN KEY ([user_create_id]) REFERENCES [dbo].[user] ([id])
GO
ALTER TABLE [dbo].[competition] ADD CONSTRAINT [FK_competition_user_modify] FOREIGN KEY ([user_update_id]) REFERENCES [dbo].[user] ([id])
GO
