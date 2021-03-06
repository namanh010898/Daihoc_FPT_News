USE [master]
GO
/****** Object:  Database [SWP391_DB]    Script Date: 20/01/2022 11:30:44 CH ******/
CREATE DATABASE [SWP391_DB]
GO
ALTER DATABASE [SWP391_DB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SWP391_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SWP391_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SWP391_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SWP391_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SWP391_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SWP391_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [SWP391_DB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SWP391_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SWP391_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SWP391_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SWP391_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SWP391_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SWP391_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SWP391_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SWP391_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SWP391_DB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SWP391_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SWP391_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SWP391_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SWP391_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SWP391_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SWP391_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SWP391_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SWP391_DB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SWP391_DB] SET  MULTI_USER 
GO
ALTER DATABASE [SWP391_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SWP391_DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SWP391_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SWP391_DB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SWP391_DB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SWP391_DB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SWP391_DB] SET QUERY_STORE = OFF
GO
USE [SWP391_DB]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 20/01/2022 11:30:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AccountTypeID] [int] NOT NULL,
	[Active] [int] NOT NULL,
	[Name] [int] NOT NULL,
	[Email] [nvarchar](255) NOT NULL,
	[Username] [nvarchar](255) NOT NULL,
	[Password] [nvarchar](255) NOT NULL,
	[Phone] [nvarchar](255) NULL,
	[Address] [ntext] NOT NULL,
	[Photo] [ntext] NULL,
	[Description] [ntext] NULL,
	[Info] [nchar](10) NULL,
	[CreatedTime] [datetime] NOT NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AccountType]    Script Date: 20/01/2022 11:30:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccountType](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Active] [int] NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[Description] [ntext] NULL,
	[CreatedTime] [datetime] NOT NULL,
 CONSTRAINT [PK_AccountType] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Answer]    Script Date: 20/01/2022 11:30:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Answer](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[QuestionId] [int] NOT NULL,
	[Active] [int] NOT NULL,
	[Score] [float] NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[Description] [ntext] NULL,
	[CreatedTime] [datetime] NOT NULL,
 CONSTRAINT [PK_Answer] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comment]    Script Date: 20/01/2022 11:30:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comment](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PostID] [int] NOT NULL,
	[AccountID] [int] NOT NULL,
	[Active] [int] NOT NULL,
	[Approve] [int] NOT NULL,
	[Name] [ntext] NOT NULL,
	[Description] [ntext] NULL,
	[Email] [ntext] NULL,
	[Text] [ntext] NULL,
	[Website] [ntext] NULL,
	[IsChecked] [int] NOT NULL,
	[CreatedTime] [datetime] NOT NULL,
 CONSTRAINT [PK_Comment] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contact]    Script Date: 20/01/2022 11:30:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contact](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AccountID] [int] NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[Email] [nvarchar](255) NOT NULL,
	[Phone] [nvarchar](255) NOT NULL,
	[Description] [ntext] NULL,
	[CreatedTime] [datetime] NOT NULL,
	[Active] [int] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EventRequest]    Script Date: 20/01/2022 11:30:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EventRequest](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PostId] [int] NOT NULL,
	[AccountId] [int] NOT NULL,
	[Active] [int] NOT NULL,
	[EventRequestStatusId] [int] NOT NULL,
	[Name] [ntext] NOT NULL,
	[Email] [nvarchar](255) NULL,
	[Phone] [nvarchar](255) NULL,
	[Description] [ntext] NULL,
	[CreatedTime] [datetime] NOT NULL,
 CONSTRAINT [PK_EventRequest] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EventRequestStatus]    Script Date: 20/01/2022 11:30:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EventRequestStatus](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Active] [int] NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[Description] [ntext] NULL,
	[CreatedTime] [datetime] NOT NULL,
 CONSTRAINT [PK_EventRequestStatus] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Menu]    Script Date: 20/01/2022 11:30:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menu](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ParentID] [int] NULL,
	[Active] [int] NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[Url] [nvarchar](255) NOT NULL,
	[Priority] [int] NOT NULL,
	[GroupID] [int] NOT NULL,
	[Description] [ntext] NULL,
	[CreatedTime] [datetime] NOT NULL,
 CONSTRAINT [PK_Menu] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Notification]    Script Date: 20/01/2022 11:30:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Notification](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Active] [int] NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[Description] [ntext] NULL,
	[CreatedTime] [datetime] NOT NULL,
	[ViewStatus] [int] NOT NULL,
	[IsChecked] [int] NOT NULL,
 CONSTRAINT [PK_Notification] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Post]    Script Date: 20/01/2022 11:30:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Post](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PostTypeID] [int] NOT NULL,
	[PostAccountID] [int] NOT NULL,
	[PostCategoryID] [int] NOT NULL,
	[PostLayoutID] [int] NOT NULL,
	[PostPublishStatusID] [int] NOT NULL,
	[PostCommentStatusID] [int] NOT NULL,
	[Active] [int] NOT NULL,
	[Url] [nvarchar](255) NULL,
	[Photo] [nchar](10) NULL,
	[Video] [nvarchar](255) NULL,
	[ViewCount] [int] NULL,
	[CommentCount] [int] NULL,
	[LikeCount] [int] NULL,
	[Name] [nvarchar](255) NOT NULL,
	[Description] [ntext] NULL,
	[Text] [ntext] NULL,
	[PublishedTime] [datetime] NULL,
	[CreatedTime] [datetime] NOT NULL,
	[OpenTime] [datetime] NULL,
	[ClosedTime] [datetime] NULL,
	[EventAddress] [ntext] NULL,
	[FileURL] [ntext] NULL,
 CONSTRAINT [PK_Post] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PostCategory]    Script Date: 20/01/2022 11:30:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PostCategory](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Active] [int] NOT NULL,
	[ParentID] [int] NULL,
	[Name] [nvarchar](255) NOT NULL,
	[Slug] [nvarchar](255) NULL,
	[Photo] [nvarchar](255) NULL,
	[Description] [ntext] NULL,
	[CreatedTime] [datetime] NOT NULL,
	[PostCount] [int] NULL,
 CONSTRAINT [PK_PostCategory] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PostLayout]    Script Date: 20/01/2022 11:30:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PostLayout](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Active] [int] NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[Description] [ntext] NULL,
	[CreatedTime] [datetime] NOT NULL,
 CONSTRAINT [PK_PostLayout] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PostTag]    Script Date: 20/01/2022 11:30:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PostTag](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PostID] [int] NOT NULL,
	[TagID] [int] NOT NULL,
	[Active] [int] NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[Description] [ntext] NULL,
	[CreatedTime] [datetime] NOT NULL,
 CONSTRAINT [PK_PostTag] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PostTopic]    Script Date: 20/01/2022 11:30:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PostTopic](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PostID] [int] NOT NULL,
	[TopicID] [int] NOT NULL,
	[Active] [int] NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[Description] [ntext] NULL,
	[CreatedTime] [datetime] NOT NULL,
 CONSTRAINT [PK_PostTopic] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PostType]    Script Date: 20/01/2022 11:30:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PostType](
	[ID] [int] NOT NULL,
	[Active] [int] NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[Description] [ntext] NULL,
	[CreatedTime] [datetime] NOT NULL,
 CONSTRAINT [PK_PostType] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Question]    Script Date: 20/01/2022 11:30:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Question](
	[ID] [int] NOT NULL,
	[QuestionTypeID] [int] NULL,
	[Active] [int] NOT NULL,
	[Photo] [nvarchar](255) NULL,
	[Score] [float] NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[Description] [ntext] NULL,
	[Text] [ntext] NULL,
	[CreatedTime] [datetime] NOT NULL,
 CONSTRAINT [PK_Question] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuestionType]    Script Date: 20/01/2022 11:30:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuestionType](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Active] [int] NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[Description] [ntext] NULL,
	[CreatedTime] [datetime] NOT NULL,
 CONSTRAINT [PK_QuestionType] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Recomment]    Script Date: 20/01/2022 11:30:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Recomment](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SurveySectionID] [int] NOT NULL,
	[MinScore] [float] NULL,
	[MaxScore] [float] NULL,
	[Active] [int] NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Description] [ntext] NULL,
	[CreatedTime] [datetime] NOT NULL,
 CONSTRAINT [PK_Recomment] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subcribe]    Script Date: 20/01/2022 11:30:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subcribe](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Active] [int] NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[Description] [ntext] NULL,
	[CreatedTime] [datetime] NOT NULL,
 CONSTRAINT [PK_Subcribe] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Survey]    Script Date: 20/01/2022 11:30:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Survey](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Active] [int] NOT NULL,
	[Score] [float] NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[Description] [ntext] NULL,
	[Text] [ntext] NULL,
	[PublishedTime] [datetime] NULL,
	[CreatedTime] [datetime] NOT NULL,
	[SurveyTypeID] [int] NOT NULL,
 CONSTRAINT [PK_Survey] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SurveyAccount]    Script Date: 20/01/2022 11:30:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SurveyAccount](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AccountID] [int] NOT NULL,
	[SurveyID] [int] NOT NULL,
	[Active] [int] NOT NULL,
	[Score] [float] NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[Description] [ntext] NULL,
	[CreatedTime] [datetime] NOT NULL,
 CONSTRAINT [PK_SurveyAccount] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SurveySection]    Script Date: 20/01/2022 11:30:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SurveySection](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SurveyID] [int] NOT NULL,
	[SurveySectionID] [int] NULL,
	[Active] [int] NOT NULL,
	[ProportionScore] [int] NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[Description] [ntext] NULL,
	[Text] [ntext] NULL,
	[CreatedTime] [datetime] NOT NULL,
 CONSTRAINT [PK_SurveySection] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SurveySectionAccount]    Script Date: 20/01/2022 11:30:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SurveySectionAccount](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SurveyAccountID] [int] NOT NULL,
	[Active] [int] NOT NULL,
	[Score] [float] NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[CreatedTime] [datetime] NOT NULL,
 CONSTRAINT [PK_SurveySectionAccount] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SurveySectionAccountDetail]    Script Date: 20/01/2022 11:30:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SurveySectionAccountDetail](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Active] [int] NOT NULL,
	[SurveySectionAccount] [int] NOT NULL,
	[QuestionID] [int] NOT NULL,
	[AnswerID] [int] NOT NULL,
	[Score] [float] NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[Description] [ntext] NULL,
	[CreatedTime] [datetime] NOT NULL,
 CONSTRAINT [PK_SurveySectionAccountDetail] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SurveySectionQuestion]    Script Date: 20/01/2022 11:30:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SurveySectionQuestion](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[QuestionID] [int] NOT NULL,
	[SurveySectionID] [int] NOT NULL,
	[Active] [int] NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[Description] [ntext] NULL,
	[Text] [ntext] NULL,
	[CreatedTime] [datetime] NOT NULL,
 CONSTRAINT [PK_SurveySectionQuestion] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SurveyType]    Script Date: 20/01/2022 11:30:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SurveyType](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Active] [int] NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[Description] [ntext] NULL,
	[CreatedTime] [datetime] NOT NULL,
 CONSTRAINT [PK_SurveyType] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tag]    Script Date: 20/01/2022 11:30:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tag](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Active] [int] NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[Slug] [nvarchar](255) NOT NULL,
	[Description] [ntext] NULL,
	[CreatedTime] [datetime] NOT NULL,
	[PostCount] [int] NULL,
 CONSTRAINT [PK_Tag] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ViewStatus]    Script Date: 20/01/2022 11:30:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ViewStatus](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Active] [int] NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[Description] [ntext] NULL,
	[CreatedTime] [datetime] NOT NULL,
 CONSTRAINT [PK_ViewStatus] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Answer]  WITH CHECK ADD  CONSTRAINT [FK_Answer_Question] FOREIGN KEY([QuestionId])
REFERENCES [dbo].[Question] ([ID])
GO
ALTER TABLE [dbo].[Answer] CHECK CONSTRAINT [FK_Answer_Question]
GO
ALTER TABLE [dbo].[Contact]  WITH CHECK ADD  CONSTRAINT [FK_Contact_Account] FOREIGN KEY([AccountID])
REFERENCES [dbo].[Account] ([ID])
GO
ALTER TABLE [dbo].[Contact] CHECK CONSTRAINT [FK_Contact_Account]
GO
ALTER TABLE [dbo].[EventRequest]  WITH CHECK ADD  CONSTRAINT [FK_EventRequest_Account] FOREIGN KEY([AccountId])
REFERENCES [dbo].[Account] ([ID])
GO
ALTER TABLE [dbo].[EventRequest] CHECK CONSTRAINT [FK_EventRequest_Account]
GO
ALTER TABLE [dbo].[EventRequest]  WITH CHECK ADD  CONSTRAINT [FK_EventRequest_EventRequestStatus] FOREIGN KEY([EventRequestStatusId])
REFERENCES [dbo].[EventRequestStatus] ([ID])
GO
ALTER TABLE [dbo].[EventRequest] CHECK CONSTRAINT [FK_EventRequest_EventRequestStatus]
GO
ALTER TABLE [dbo].[EventRequest]  WITH CHECK ADD  CONSTRAINT [FK_EventRequest_Post] FOREIGN KEY([PostId])
REFERENCES [dbo].[Post] ([ID])
GO
ALTER TABLE [dbo].[EventRequest] CHECK CONSTRAINT [FK_EventRequest_Post]
GO
ALTER TABLE [dbo].[PostTag]  WITH CHECK ADD  CONSTRAINT [FK_PostTag_Tag] FOREIGN KEY([TagID])
REFERENCES [dbo].[Tag] ([ID])
GO
ALTER TABLE [dbo].[PostTag] CHECK CONSTRAINT [FK_PostTag_Tag]
GO
ALTER TABLE [dbo].[Question]  WITH CHECK ADD  CONSTRAINT [FK_Question_QuestionType] FOREIGN KEY([QuestionTypeID])
REFERENCES [dbo].[QuestionType] ([ID])
GO
ALTER TABLE [dbo].[Question] CHECK CONSTRAINT [FK_Question_QuestionType]
GO
ALTER TABLE [dbo].[Recomment]  WITH CHECK ADD  CONSTRAINT [FK_Recomment_SurveySection] FOREIGN KEY([SurveySectionID])
REFERENCES [dbo].[SurveySection] ([ID])
GO
ALTER TABLE [dbo].[Recomment] CHECK CONSTRAINT [FK_Recomment_SurveySection]
GO
ALTER TABLE [dbo].[Survey]  WITH CHECK ADD  CONSTRAINT [FK_Survey_SurveyType] FOREIGN KEY([SurveyTypeID])
REFERENCES [dbo].[SurveyType] ([ID])
GO
ALTER TABLE [dbo].[Survey] CHECK CONSTRAINT [FK_Survey_SurveyType]
GO
ALTER TABLE [dbo].[SurveyAccount]  WITH CHECK ADD  CONSTRAINT [FK_SurveyAccount_Survey] FOREIGN KEY([SurveyID])
REFERENCES [dbo].[Survey] ([ID])
GO
ALTER TABLE [dbo].[SurveyAccount] CHECK CONSTRAINT [FK_SurveyAccount_Survey]
GO
ALTER TABLE [dbo].[SurveySection]  WITH CHECK ADD  CONSTRAINT [FK_SurveySection_Survey] FOREIGN KEY([SurveyID])
REFERENCES [dbo].[Survey] ([ID])
GO
ALTER TABLE [dbo].[SurveySection] CHECK CONSTRAINT [FK_SurveySection_Survey]
GO
ALTER TABLE [dbo].[SurveySectionAccount]  WITH CHECK ADD  CONSTRAINT [FK_SurveySectionAccount_SurveyAccount] FOREIGN KEY([SurveyAccountID])
REFERENCES [dbo].[SurveyAccount] ([ID])
GO
ALTER TABLE [dbo].[SurveySectionAccount] CHECK CONSTRAINT [FK_SurveySectionAccount_SurveyAccount]
GO
ALTER TABLE [dbo].[SurveySectionAccountDetail]  WITH CHECK ADD  CONSTRAINT [FK_SurveySectionAccountDetail_Question] FOREIGN KEY([QuestionID])
REFERENCES [dbo].[Question] ([ID])
GO
ALTER TABLE [dbo].[SurveySectionAccountDetail] CHECK CONSTRAINT [FK_SurveySectionAccountDetail_Question]
GO
ALTER TABLE [dbo].[SurveySectionAccountDetail]  WITH NOCHECK ADD  CONSTRAINT [FK_SurveySectionAccountDetail_SurveyAccount] FOREIGN KEY([SurveySectionAccount])
REFERENCES [dbo].[SurveyAccount] ([ID])
GO
ALTER TABLE [dbo].[SurveySectionAccountDetail] NOCHECK CONSTRAINT [FK_SurveySectionAccountDetail_SurveyAccount]
GO
ALTER TABLE [dbo].[SurveySectionQuestion]  WITH CHECK ADD  CONSTRAINT [FK_SurveySectionQuestion_SurveySection] FOREIGN KEY([SurveySectionID])
REFERENCES [dbo].[SurveySection] ([ID])
GO
ALTER TABLE [dbo].[SurveySectionQuestion] CHECK CONSTRAINT [FK_SurveySectionQuestion_SurveySection]
GO
USE [master]
GO
ALTER DATABASE [SWP391_DB] SET  READ_WRITE 
GO
