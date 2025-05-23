
ALTER DATABASE [VitaFarm] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VitaFarm].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VitaFarm] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VitaFarm] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VitaFarm] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VitaFarm] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VitaFarm] SET ARITHABORT OFF 
GO
ALTER DATABASE [VitaFarm] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [VitaFarm] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VitaFarm] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VitaFarm] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VitaFarm] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VitaFarm] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VitaFarm] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VitaFarm] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VitaFarm] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VitaFarm] SET  DISABLE_BROKER 
GO
ALTER DATABASE [VitaFarm] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VitaFarm] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VitaFarm] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VitaFarm] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VitaFarm] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VitaFarm] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [VitaFarm] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VitaFarm] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [VitaFarm] SET  MULTI_USER 
GO
ALTER DATABASE [VitaFarm] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VitaFarm] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VitaFarm] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VitaFarm] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [VitaFarm] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [VitaFarm] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [VitaFarm] SET QUERY_STORE = OFF
GO
USE [VitaFarm]
GO
/****** Object:  Table [dbo].[MedicalList]    Script Date: 19.04.2025 10:42:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MedicalList](
	[UID] [int] NOT NULL,
	[Photo] [image] NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Desc] [nvarchar](max) NULL,
	[Source] [nvarchar](max) NOT NULL,
	[Price] [money] NOT NULL,
	[Value] [nvarchar](max) NOT NULL,
	[Count_] [nvarchar](max) NOT NULL,
	[Perc] [real] NOT NULL,
 CONSTRAINT [PK_Ассортимент] PRIMARY KEY CLUSTERED 
(
	[UID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MedicalOrder]    Script Date: 19.04.2025 10:42:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MedicalOrder](
	[UID] [int] NOT NULL,
	[Medical] [int] NOT NULL,
	[Count] [nvarchar](max) NULL,
 CONSTRAINT [PK_Состав] PRIMARY KEY CLUSTERED 
(
	[UID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 19.04.2025 10:42:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[UID] [int] NOT NULL,
	[DateOrder] [date] NOT NULL,
	[User] [int] NOT NULL,
	[ListMed] [int] NOT NULL,
	[PRICE] [money] NOT NULL,
	[Perc] [real] NULL,
	[OutPlace] [int] NOT NULL,
 CONSTRAINT [PK_Талоны] PRIMARY KEY CLUSTERED 
(
	[UID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OutPlaces]    Script Date: 19.04.2025 10:42:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OutPlaces](
	[UID] [int] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[City] [nvarchar](max) NOT NULL,
	[Street] [nvarchar](max) NOT NULL,
	[Structure] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_ПунктыВыдачи] PRIMARY KEY CLUSTERED 
(
	[UID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 19.04.2025 10:42:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[UID] [int] NOT NULL,
	[Role] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Роли] PRIMARY KEY CLUSTERED 
(
	[UID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 19.04.2025 10:42:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UID] [int] NOT NULL,
	[Family] [nvarchar](max) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[SecondName] [nvarchar](max) NULL,
	[Phone] [nvarchar](50) NOT NULL,
	[Role] [int] NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Покупатели] PRIMARY KEY CLUSTERED 
(
	[UID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[MedicalList] ([UID], [Photo], [Name], [Desc], [Source], [Price], [Value], [Count_], [Perc]) VALUES (1, NULL, N'Экстракт Пустырника', NULL, N'Велфарм', 150.0000, N'Упаковки 400гр', N'100', 2)
GO
INSERT [dbo].[OutPlaces] ([UID], [Name], [City], [Street], [Structure]) VALUES (1, NULL, N'Хабаровск', N'Ленина', N'5')
GO
INSERT [dbo].[Roles] ([UID], [Role]) VALUES (1, N'Администратор')
INSERT [dbo].[Roles] ([UID], [Role]) VALUES (2, N'Покупатель')
INSERT [dbo].[Roles] ([UID], [Role]) VALUES (3, N'Сотрудник')
GO
INSERT [dbo].[Users] ([UID], [Family], [Name], [SecondName], [Phone], [Role], [Login], [Password]) VALUES (1, N'Домодедов', N'Иван', N'Иванович', N'+7 (945) 912 56-65', 1, N'945', N'945')
INSERT [dbo].[Users] ([UID], [Family], [Name], [SecondName], [Phone], [Role], [Login], [Password]) VALUES (2, N'Пивоваров', N'Иван', N'Таранов', N'+7 (314) 945 45-54', 2, N'314', N'314')
INSERT [dbo].[Users] ([UID], [Family], [Name], [SecondName], [Phone], [Role], [Login], [Password]) VALUES (3, N'Шандралла', N'Магдалина', N'Николаевна', N'+7 (954) 956 56-73', 3, N'954', N'954')
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Пользователи_Логин]  DEFAULT ((0)) FOR [Login]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Пользователи_Пароль]  DEFAULT ((0)) FOR [Password]
GO
ALTER TABLE [dbo].[MedicalOrder]  WITH CHECK ADD  CONSTRAINT [FK_MedicalOrder_MedicalList] FOREIGN KEY([Medical])
REFERENCES [dbo].[MedicalList] ([UID])
GO
ALTER TABLE [dbo].[MedicalOrder] CHECK CONSTRAINT [FK_MedicalOrder_MedicalList]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_MedicalOrder] FOREIGN KEY([ListMed])
REFERENCES [dbo].[MedicalOrder] ([UID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_MedicalOrder]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_OutPlaces] FOREIGN KEY([OutPlace])
REFERENCES [dbo].[OutPlaces] ([UID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_OutPlaces]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Users] FOREIGN KEY([User])
REFERENCES [dbo].[Users] ([UID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Users]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Roles] FOREIGN KEY([Role])
REFERENCES [dbo].[Roles] ([UID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Roles]
GO
USE [master]
GO
ALTER DATABASE [VitaFarm] SET  READ_WRITE 
GO
