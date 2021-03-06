USE [ws14]
GO
/****** Object:  Table [dbo].[Sotrudnikis]    Script Date: 16.07.2022 22:15:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sotrudnikis](
	[IdSotrudnik] [int] IDENTITY(1,1) NOT NULL,
	[IdDolznost] [nvarchar](max) NULL,
	[Должность] [nvarchar](255) NULL,
	[Сотрудник] [nvarchar](255) NULL,
	[Дата_рождения] [date] NULL,
	[Телефон] [nvarchar](255) NULL,
 CONSTRAINT [PK_Sotrudnikis] PRIMARY KEY CLUSTERED 
(
	[IdSotrudnik] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
