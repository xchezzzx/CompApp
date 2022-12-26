CREATE TABLE [dbo].[task]
(
[id] [int] NOT NULL IDENTITY(1, 1),
[task_name] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[task_content] [varchar] (2000) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[task_category_id] [int] NOT NULL,
[task_lang_id] [int] NOT NULL,
[task_platform_id] [int] NOT NULL,
[timeframe] [int] NOT NULL,
[points] [int] NOT NULL,
[if_has_bonus] [bit] NULL,
[bonus_content] [varchar] (1000) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[bonus_timeframe] [int] NULL,
[bonus_points] [int] NULL,
[date_create] [datetime] NOT NULL CONSTRAINT [DF_task_date_create] DEFAULT (getdate()),
[date_update] [datetime] NOT NULL CONSTRAINT [DF_task_date_update] DEFAULT (getdate()),
[user_create_id] [int] NOT NULL,
[user_update_id] [int] NOT NULL,
[status_id] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[task] ADD CONSTRAINT [PK_task] PRIMARY KEY CLUSTERED ([id]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[task] ADD CONSTRAINT [FK_task_task_category] FOREIGN KEY ([task_category_id]) REFERENCES [dbo].[task_category] ([id])
GO
ALTER TABLE [dbo].[task] ADD CONSTRAINT [FK_task_task_lang] FOREIGN KEY ([task_lang_id]) REFERENCES [dbo].[task_lang] ([id])
GO
ALTER TABLE [dbo].[task] ADD CONSTRAINT [FK_task_task_platform] FOREIGN KEY ([task_platform_id]) REFERENCES [dbo].[task_platform] ([id])
GO
ALTER TABLE [dbo].[task] ADD CONSTRAINT [FK_task_task_status] FOREIGN KEY ([status_id]) REFERENCES [dbo].[task_status] ([id])
GO
ALTER TABLE [dbo].[task] ADD CONSTRAINT [FK_task_user_create] FOREIGN KEY ([user_create_id]) REFERENCES [dbo].[user] ([id])
GO
ALTER TABLE [dbo].[task] ADD CONSTRAINT [FK_task_user_update] FOREIGN KEY ([user_update_id]) REFERENCES [dbo].[user] ([id])
GO
