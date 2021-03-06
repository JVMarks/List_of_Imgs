USE [ImageDb]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 18/12/2020 13:59:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Images]    Script Date: 18/12/2020 13:59:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Images](
	[ImageId] [int] NOT NULL,
	[Title] [nvarchar](50) NULL,
	[ImageName] [nvarchar](100) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201215220703_InitialCreate', N'3.1.10')
GO
INSERT [dbo].[Images] ([ImageId], [Title], [ImageName]) VALUES (1, N'hello world', N'canada1201120987.jpg')
INSERT [dbo].[Images] ([ImageId], [Title], [ImageName]) VALUES (2, N'Avenges', N'DSC201128526.jpg')
INSERT [dbo].[Images] ([ImageId], [Title], [ImageName]) VALUES (3, N'jaison', N'jason201136969.jpg')
INSERT [dbo].[Images] ([ImageId], [Title], [ImageName]) VALUES (4, N'gran torino ', N'gran turino201145853.jpg')
INSERT [dbo].[Images] ([ImageId], [Title], [ImageName]) VALUES (5, N'Mandalorian', N'thumb201202654.jpg')
GO
