USE [trialdb]
GO
/****** Object:  Table [dbo].[Accounts]    Script Date: 10/12/2023 6:54:16 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounts](
	[AccountID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Username] [nvarchar](20) NULL,
	[Password] [nvarchar](20) NULL,
	[AccountType] [nvarchar](20) NULL,
	[Status] [nvarchar](20) NULL,
	[LastLoginDateTime] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[AccountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Accounts_Archive]    Script Date: 10/12/2023 6:54:17 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounts_Archive](
	[AccountID] [int] NULL,
	[Name] [nvarchar](50) NULL,
	[Username] [nvarchar](20) NULL,
	[Password] [nvarchar](20) NULL,
	[AccountType] [nvarchar](20) NULL,
	[Status] [nvarchar](20) NULL,
	[LastLoginDateTime] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pending_Approval]    Script Date: 10/12/2023 6:54:17 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pending_Approval](
	[Request] [nvarchar](50) NULL,
	[Category] [nvarchar](50) NULL,
	[ProductID] [nvarchar](50) NULL,
	[ProductCode] [nvarchar](50) NULL,
	[ProductName] [nvarchar](50) NULL,
	[Price] [decimal](10, 2) NULL,
	[RequestedBy] [nvarchar](50) NULL,
	[Date] [datetime] NULL,
 CONSTRAINT [UQ_ProductName] UNIQUE NONCLUSTERED 
(
	[ProductName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 10/12/2023 6:54:17 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[Category] [nvarchar](50) NULL,
	[ProductCode] [nvarchar](50) NULL,
	[ProductName] [nvarchar](50) NULL,
	[Price] [decimal](10, 2) NULL,
	[Stocks] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products_Archive]    Script Date: 10/12/2023 6:54:17 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products_Archive](
	[ProductID] [int] NULL,
	[Category] [nvarchar](50) NULL,
	[ProductCode] [nvarchar](50) NULL,
	[ProductName] [nvarchar](50) NULL,
	[Price] [decimal](10, 2) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StockIn_Transactions]    Script Date: 10/12/2023 6:54:17 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockIn_Transactions](
	[TransactionID] [int] IDENTITY(1,1) NOT NULL,
	[TransactionNum] [nvarchar](50) NULL,
	[Category] [nvarchar](50) NULL,
	[ProductCode] [nvarchar](50) NULL,
	[ProductName] [nvarchar](50) NULL,
	[Quantity] [int] NULL,
	[Price] [decimal](10, 2) NULL,
	[Date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[TransactionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StockOut_Transactions]    Script Date: 10/12/2023 6:54:17 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockOut_Transactions](
	[TransactionID] [int] IDENTITY(1,1) NOT NULL,
	[TransactionNum] [nvarchar](50) NULL,
	[Category] [nvarchar](50) NULL,
	[ProductCode] [nvarchar](50) NULL,
	[ProductName] [nvarchar](50) NULL,
	[Quantity] [int] NULL,
	[Price] [decimal](10, 2) NULL,
	[Date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[TransactionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT INTO [dbo].[Accounts] ([Name], [Username], [Password], [AccountType], [Status], [LastLoginDateTime])
VALUES ('Joralyn Tiburania', 'admin', 'admin123', 'Admin', 'Active', NULL);