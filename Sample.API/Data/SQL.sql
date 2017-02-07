SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SumTest](
        [City] [nvarchar](50) NULL,
        [Population] [int] NULL
) ON [PRIMARY]

GO
INSERT [dbo].[SumTest] ([City], [Population]) VALUES (N'New York', 1000000)
GO
INSERT [dbo].[SumTest] ([City], [Population]) VALUES (N'New York', 3445623)
GO
INSERT [dbo].[SumTest] ([City], [Population]) VALUES (N'New York', 6666)
GO
INSERT [dbo].[SumTest] ([City], [Population]) VALUES (N'New York', 234334534)
GO
INSERT [dbo].[SumTest] ([City], [Population]) VALUES (N'Jersey City', 234334534)
GO
INSERT [dbo].[SumTest] ([City], [Population]) VALUES (N'San Diego', 234334534)
GO
INSERT [dbo].[SumTest] ([City], [Population]) VALUES (N'Los Angelos', 234334534)
GO
INSERT [dbo].[SumTest] ([City], [Population]) VALUES (N'Chicago', 23433453)
GO
INSERT [dbo].[SumTest] ([City], [Population]) VALUES (N'Stamford', 234334534)
GO
INSERT [dbo].[SumTest] ([City], [Population]) VALUES (N'Stamford', 342)
GO





SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employee](
        [Id] [int] IDENTITY(1,1) NOT NULL,
        [Name] [varchar](50) NOT NULL,
        [Salary] [decimal](18, 0) NOT NULL,
        [ManagerId] [int] NULL,
CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
        [Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

GO
INSERT [dbo].[Employee] ([Id], [Name], [Salary], [ManagerId]) VALUES (1, N'John', CAST(300 AS Decimal(18, 0)), 3)
GO
INSERT [dbo].[Employee] ([Id], [Name], [Salary], [ManagerId]) VALUES (2, N'Mike', CAST(200 AS Decimal(18, 0)), 3)
GO
INSERT [dbo].[Employee] ([Id], [Name], [Salary], [ManagerId]) VALUES (3, N'Sally', CAST(550 AS Decimal(18, 0)), 4)
GO
INSERT [dbo].[Employee] ([Id], [Name], [Salary], [ManagerId]) VALUES (4, N'Jane', CAST(500 AS Decimal(18, 0)), 7)
GO
INSERT [dbo].[Employee] ([Id], [Name], [Salary], [ManagerId]) VALUES (5, N'Joe', CAST(600 AS Decimal(18, 0)), 7)
GO
INSERT [dbo].[Employee] ([Id], [Name], [Salary], [ManagerId]) VALUES (6, N'Dan', CAST(600 AS Decimal(18, 0)), 3)
GO
INSERT [dbo].[Employee] ([Id], [Name], [Salary], [ManagerId]) VALUES (7, N'Phil', CAST(550 AS Decimal(18, 0)), NULL)
GO
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO

