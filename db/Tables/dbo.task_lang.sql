CREATE TABLE [dbo].[task_lang]
(
[id] [int] NOT NULL IDENTITY(1, 1),
[task_lang] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[task_lang] ADD CONSTRAINT [PK_task_lang_1] PRIMARY KEY CLUSTERED ([id]) ON [PRIMARY]
GO
