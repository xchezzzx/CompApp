CREATE TABLE [dbo].[task_category]
(
[id] [int] NOT NULL IDENTITY(1, 1),
[category_name] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[task_category] ADD CONSTRAINT [PK_task_category] PRIMARY KEY CLUSTERED ([id]) ON [PRIMARY]
GO
