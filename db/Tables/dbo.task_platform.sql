CREATE TABLE [dbo].[task_platform]
(
[id] [int] NOT NULL IDENTITY(1, 1),
[task_platform_name] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[task_platform] ADD CONSTRAINT [PK_task_platform_1] PRIMARY KEY CLUSTERED ([id]) ON [PRIMARY]
GO
