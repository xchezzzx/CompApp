CREATE TABLE [dbo].[competition_status]
(
[id] [int] NOT NULL IDENTITY(1, 1),
[competition_status_name] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[competition_status] ADD CONSTRAINT [PK_competition_status] PRIMARY KEY CLUSTERED ([id]) ON [PRIMARY]
GO
