CREATE TABLE [dbo].[task_status]
(
[id] [int] NOT NULL IDENTITY(1, 1),
[task_status_name] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[task_status] ADD CONSTRAINT [PK_task_status] PRIMARY KEY CLUSTERED ([id]) ON [PRIMARY]
GO
