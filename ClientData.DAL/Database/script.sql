USE [ClientDataKS]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[ClientId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[ClientName] [varchar](255) NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[ClientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DocumentType]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocumentType](
	[DocumentTypeId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[CreatedBy] [nvarchar](450) NULL,
	[CreatedDateTime] [datetime] NULL,
	[IsDeleted] [bit] NULL,
	[DeletedDateTime] [datetime] NULL,
	[DeletedBy] [nvarchar](450) NULL,
	[LastUpdateDate] [datetime] NULL,
	[LastUpdatedBy] [varchar](50) NULL,
 CONSTRAINT [PK_DocumentType] PRIMARY KEY CLUSTERED 
(
	[DocumentTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DummyTest]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DummyTest](
	[ID] [int] IDENTITY(800001,1) NOT NULL,
	[DOE] [datetime] NULL,
	[Name] [varchar](50) NULL,
 CONSTRAINT [PK_DummyTest] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductId] [numeric](18, 0) NOT NULL,
	[Name] [varchar](50) NULL,
	[Price] [numeric](18, 0) NULL,
	[Category] [varchar](2) NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Project]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Project](
	[ProjectId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](255) NULL,
	[About] [varchar](2000) NOT NULL,
	[Notes] [varchar](2000) NULL,
	[SourceCodeLocation] [varchar](1000) NULL,
	[CreatedBy] [varchar](50) NULL,
	[CreatedDateTime] [datetime] NULL,
	[IsDeleted] [bit] NULL,
	[DeletedDateTime] [datetime] NULL,
	[DeletedBy] [varchar](50) NULL,
	[LastUpdateDate] [datetime] NULL,
	[LastUpdatedBy] [varchar](50) NULL,
 CONSTRAINT [PK_Project] PRIMARY KEY CLUSTERED 
(
	[ProjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjectDeployment]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectDeployment](
	[ProjectDeploymentId] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NOT NULL,
	[DeploymentDate] [date] NOT NULL,
	[ServerId] [int] NOT NULL,
	[Features] [varchar](max) NOT NULL,
	[Version] [varchar](10) NULL,
	[ActualFileName] [varchar](255) NULL,
	[StoreAsFileName] [varchar](255) NULL,
	[Notes] [varchar](2000) NULL,
	[CreatedBy] [varchar](50) NULL,
	[CreatedDateTime] [datetime] NULL,
	[IsDeleted] [bit] NULL,
	[DeletedDateTime] [datetime] NULL,
	[DeletedBy] [varchar](50) NULL,
	[LastUpdateDate] [datetime] NULL,
	[LastUpdatedBy] [varchar](50) NULL,
 CONSTRAINT [PK_ProjectDeployment] PRIMARY KEY CLUSTERED 
(
	[ProjectDeploymentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjectDocumentMapping]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectDocumentMapping](
	[ProjectDocumentMappingId] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NOT NULL,
	[DocumentTypeId] [int] NOT NULL,
	[ActualFileName] [varchar](255) NULL,
	[StoreAsFileName] [varchar](255) NULL,
	[Notes] [varchar](2000) NULL,
	[CreatedBy] [varchar](50) NULL,
	[CreatedDateTime] [datetime] NULL,
	[IsDeleted] [bit] NULL,
	[DeletedDateTime] [datetime] NULL,
	[DeletedBy] [varchar](50) NULL,
	[LastUpdateDate] [datetime] NULL,
	[LastUpdatedBy] [varchar](50) NULL,
 CONSTRAINT [PK_ProjectDocumentMappingI] PRIMARY KEY CLUSTERED 
(
	[ProjectDocumentMappingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjectServerMapping]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectServerMapping](
	[ProjectServerMappingId] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NOT NULL,
	[ServerId] [int] NOT NULL,
	[DeployedServerTypeId] [int] NOT NULL,
	[UrlToAccess] [varchar](500) NULL,
	[DeployedLocation] [varchar](500) NULL,
	[AppLogLocation] [varchar](500) NULL,
	[DbServerID] [int] NULL,
	[DbName] [varchar](255) NULL,
	[Notes] [varchar](2000) NULL,
	[CreatedBy] [varchar](50) NULL,
	[CreatedDateTime] [datetime] NULL,
	[IsDeleted] [bit] NULL,
	[DeletedDateTime] [datetime] NULL,
	[DeletedBy] [varchar](50) NULL,
	[LastUpdateDate] [datetime] NULL,
	[LastUpdatedBy] [varchar](50) NULL,
 CONSTRAINT [PK_ProjectServerMapping] PRIMARY KEY CLUSTERED 
(
	[ProjectServerMappingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Server]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Server](
	[ServerId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[ServerTypeId] [int] NOT NULL,
	[InternalIP] [varchar](50) NULL,
	[ExternalIP] [varchar](50) NULL,
	[URLToAccess] [varchar](255) NULL,
	[Notes] [varchar](1000) NULL,
	[CreatedBy] [varchar](50) NULL,
	[CreatedDateTime] [datetime] NULL,
	[IsDeleted] [bit] NULL,
	[DeletedDateTime] [datetime] NULL,
	[DeletedBy] [varchar](50) NULL,
	[LastUpdateDate] [datetime] NULL,
	[LastUpdatedBy] [varchar](50) NULL,
 CONSTRAINT [PK_Server] PRIMARY KEY CLUSTERED 
(
	[ServerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServerType]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServerType](
	[ServerTypeId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[CreatedBy] [nvarchar](450) NULL,
	[CreatedDateTime] [datetime] NULL,
	[IsDeleted] [bit] NULL,
	[DeletedDateTime] [datetime] NULL,
	[DeletedBy] [nvarchar](450) NULL,
	[LastUpdateDate] [datetime] NULL,
	[LastUpdatedBy] [varchar](50) NULL,
 CONSTRAINT [PK_ServerType] PRIMARY KEY CLUSTERED 
(
	[ServerTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
/****** Object:  StoredProcedure [dbo].[Addition]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Create procedure procedurename
CREATE Procedure [dbo].[Addition]
As
Begin -- Begining of Procedure -- Begin indicates begining of block

declare @ans int; -- declare to declare variable @ans is name of variable, int is datatype
--set used to assign value to the variable 
set @ans = 10+20
--print prints value on output window
--cast used to perform type casting (type conversion)
print 'Sum is ' + cast(@ans as varchar(10))

End -- End of block
GO
/****** Object:  StoredProcedure [dbo].[DocumentType_Delete]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Bhavin
-- Create date: 22-Jul-2020
-- Description:	To delete particular document type
-- Sample Call:	Exec DocumentType_Delete 1
-- =============================================
CREATE PROCEDURE [dbo].[DocumentType_Delete] 
@Id int
AS
BEGIN
	SET NOCOUNT ON;
	Update DocumentType set IsDeleted=1, DeletedBy='Admin', DeletedDateTime=GETDATE()
		where DocumentTypeId=@Id;
	Select @@ROWCOUNT as RowsAffected
END
GO
/****** Object:  StoredProcedure [dbo].[DocumentType_Edit]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Bhavin
-- Create date: 22-Jul-2020
-- Description:	To edit existing document type
-- Sample Call: DocumentType_Edit 5, 'OOPS'
-- =============================================
CREATE PROCEDURE [dbo].[DocumentType_Edit]  
@DocumentTypeId int,
@Name varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	Update DocumentType set Name=@Name , LastUpdatedBy='Admin', LastUpdateDate=GETDATE()
		Where DocumentTypeId=@DocumentTypeId
	Exec DocumentType_GetById @DocumentTypeId
END
GO
/****** Object:  StoredProcedure [dbo].[DocumentType_GetById]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Bhavin
-- Create date: 22-Jul-2020
-- Description:	To get details of particualr document type
-- Sample call: Exec DocumentType_GetById 4
-- =============================================
CREATE PROCEDURE [dbo].[DocumentType_GetById]
@Id numeric
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	Select D.DocumentTypeId, D.Name From DocumentType D 
		Where D.DocumentTypeId=@Id and D.IsDeleted=0
END
GO
/****** Object:  StoredProcedure [dbo].[DocumentType_Insert]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Bhavin
-- Create date: 22-Jul-2020
-- Description:	To add new document type
-- Sample call: Exec DocumentType_Insert 'Other'
-- =============================================
CREATE PROCEDURE [dbo].[DocumentType_Insert] 
@Name varchar(50)
AS
BEGIN
declare @InsertedDocumentTypeId numeric;
	SET NOCOUNT ON;
	Insert Into DocumentType (Name, CreatedBy, CreatedDateTime, IsDeleted) 
		values (@Name, 'Admin',GETDATE(), 0)
	
	set @InsertedDocumentTypeId = SCOPE_IDENTITY();

	Exec DocumentType_GetById @InsertedDocumentTypeId
END
GO
/****** Object:  StoredProcedure [dbo].[DocumentType_List]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Bhavin
-- Create date: 25-Jun-20
-- Description:	To get list of document type
-- Sample Call: DocumentType_List
-- =============================================
CREATE PROCEDURE [dbo].[DocumentType_List]
AS
BEGIN
	SET NOCOUNT ON;
	Select D.DocumentTypeId, D.Name From DocumentType D 
		Where D.IsDeleted=0 
		Order by D.Name
END
GO
/****** Object:  StoredProcedure [dbo].[Proc1]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Bhavin
-- Create date: 16-Jul-20
-- Description:	Sample procedure to retrieve data of ducument list
-- Sample Call: Exec Proc1
-- =============================================
CREATE PROCEDURE [dbo].[Proc1]
AS
BEGIN
	Select D.DocumentTypeId, D.Name  from DocumentType D
	Order by D.Name
END
GO
/****** Object:  StoredProcedure [dbo].[Project_Delete]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Bhavin
-- Create date: 19-May-2020
-- Description:	To delete particular project record
-- Sample Call: Exec Project_Delete 1
-- =============================================
CREATE PROCEDURE [dbo].[Project_Delete] 
@id int
AS
BEGIN
	SET NOCOUNT ON;

	Update Project Set IsDeleted=1, DeletedBy='Admin', DeletedDateTime=GETDATE()
		Where ProjectId=@id;
	Select @@ROWCOUNT As RowsAffected
END
GO
/****** Object:  StoredProcedure [dbo].[Project_Edit]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Bhavin
-- Create date: 19-May-2020
-- Description:	To edit particular project record
-- Sample Call: Exec Project_Edit 1,'Test Name,'Test About','Test Notes','Test Location'
-- =============================================
CREATE PROCEDURE [dbo].[Project_Edit] 
@ProjectId int,
@Name Varchar(255),
@About Varchar(2000),
@Notes Varchar(2000),
@SourceCodeLocation Varchar(1000)
AS
BEGIN
	
	SET NOCOUNT ON;
	Update Project Set Name=@Name, About=@About, Notes=@Notes,
		SourceCodeLocation=@SourceCodeLocation, LastUpdatedBy='Admin',
		LastUpdateDate=GETDATE() 
		Where ProjectId=@ProjectId and IsDeleted=0
		SELECT P.ProjectId, P.Name, P.About, P.Notes,P.SourceCodeLocation From Project P 
		Where P.ProjectId=@ProjectId
	
END
GO
/****** Object:  StoredProcedure [dbo].[Project_GetById]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Bhavin
-- Create date: 19-May-2020
-- Description:	To get details of particular project
-- Sample Call: Exec Project_GetById 1
-- =============================================
CREATE PROCEDURE [dbo].[Project_GetById]
@id int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT P.ProjectId, P.Name, P.About, P.Notes,P.SourceCodeLocation From Project P 
		Where P.ProjectId=@id and P.IsDeleted=0
	
END
GO
/****** Object:  StoredProcedure [dbo].[Project_Insert]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Bhavin
-- Create date: 19-May-2020
-- Description:	To add new project details (Insert)
-- Sample Call: Exec Project_Insert 'Test Add New','About','Notes','Code Location'
-- =============================================
CREATE PROCEDURE [dbo].[Project_Insert] 
@Name Varchar(255),
@About Varchar(2000),
@Notes Varchar(2000),
@SourceCodeLocation Varchar(1000)
AS
BEGIN
Declare
@InsertedProjectId int;
	SET NOCOUNT ON;
	Insert Into Project (Name, About, Notes,SourceCodeLocation,CreatedBy,CreatedDateTime,IsDeleted)
		Values (@Name,@About,@Notes,@SourceCodeLocation, 'Admin',GETDATE(), 0);
	Set @InsertedProjectId =SCOPE_IDENTITY();
	SELECT P.ProjectId, P.Name, P.About, P.Notes,P.SourceCodeLocation From Project P 
		Where P.ProjectId=@InsertedProjectId
END
GO
/****** Object:  StoredProcedure [dbo].[Project_List]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Bhavin
-- Create date: 19-May-2020
-- Description:	To get list of projects
-- Sample Call: Exec Project_List
-- =============================================
CREATE PROCEDURE [dbo].[Project_List] 
AS
BEGIN
	SET NOCOUNT ON;

	SELECT P.ProjectId, P.Name, P.About, P.Notes,P.SourceCodeLocation From Project P 
		Where P.IsDeleted=0
END
GO
/****** Object:  StoredProcedure [dbo].[ProjectDeployment_Delete]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Bhavin
-- Create date: 20-Aug-2020
-- Description:	To delete particular record of project migration (deployment)
-- Sample Call: Exec ProjectDeployment_Delete 1
-- =============================================
CREATE PROCEDURE [dbo].[ProjectDeployment_Delete] 
@ProjectDeploymentId int
AS
BEGIN
	SET NOCOUNT ON;
	Update ProjectDeployment set IsDeleted=1, DeletedBy='Admin', DeletedDateTime=GETDATE()
		Where ProjectDeploymentId= @ProjectDeploymentId
	Select @@ROWCOUNT as RowsAffected
END
GO
/****** Object:  StoredProcedure [dbo].[ProjectDeployment_Edit]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		 Bhavin
-- Create date: 20-Aug-20
-- Description:	To edit (update) details of particular migration (deployment) record
-- Sample Call: Exec ProjectDeployment_Edit 1, 1,'19-Aug-20',2,'Feat','1.0.2','AC File Name','Notes1'
-- =============================================
CREATE PROCEDURE [dbo].[ProjectDeployment_Edit] 
@ProjectDeploymentId int,
@ProjectId int,
@DeploymentDate date,
@ServerId int,
@Features varchar(max),
@Version varchar(10),
@ActualFileName varchar(255),
@Notes varchar(2000)
AS
BEGIN
Declare
@StoreAsFileName varchar(255)

	SET NOCOUNT ON;
	if(@ActualFileName!='')
			Begin
				Update ProjectDeployment set ProjectId=@ProjectId, DeploymentDate = @DeploymentDate, ServerId=@ServerId, 
					Features=@Features, [Version]=@Version, 
					ActualFileName=@ActualFileName, Notes=@Notes,
					LastUpdateDate=GETDATE(), LastUpdatedBy='Admin'
					Where ProjectDeploymentId=@ProjectDeploymentId

					set @StoreAsFileName = CONVERT(varchar(10), @ProjectDeploymentId) +'_' + @ActualFileName;
					Update ProjectDeployment  set StoreAsFileName=@StoreAsFileName
						Where ProjectDeploymentId=@ProjectDeploymentId;
			End
	else
			Begin
				Update ProjectDeployment set ProjectId=@ProjectId, DeploymentDate = @DeploymentDate, ServerId=@ServerId, 
					Features=@Features, [Version]=@Version, Notes=@Notes,
					LastUpdateDate=GETDATE(), LastUpdatedBy='Admin'
					Where ProjectDeploymentId=@ProjectDeploymentId
			End
	Exec ProjectDeployment_GetById @ProjectDeploymentId 
END
GO
/****** Object:  StoredProcedure [dbo].[ProjectDeployment_GetById]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Bhavin
-- Create date: 20-Aug-20
-- Description:	To get details of particular project deployment record.
-- Sample Call: Exec ProjectDeployment_GetById 1
-- =============================================
CREATE PROCEDURE [dbo].[ProjectDeployment_GetById] 
@ProjectDeploymentId int
AS
BEGIN
	SET NOCOUNT ON;

	Select PD.ProjectDeploymentId, PD.ProjectId, P.Name as ProjectName, PD.DeploymentDate, 
			PD.ServerId , S.Name as ServerName,  PD.Features,  PD.Version, PD.ActualFileName, PD.StoreAsFileName,
			PD.Notes
		From Project P inner join ProjectDeployment PD
		on P.ProjectId = PD.ProjectId inner join Server S 
		on PD.ServerId = S.ServerId
		Where PD.ProjectDeploymentId = @ProjectDeploymentId and PD.IsDeleted=0
END
GO
/****** Object:  StoredProcedure [dbo].[ProjectDeployment_Insert]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Bhavin
-- Create date: 20-Aug-2020
-- Description:	To insert deployment (migration) details for a particular project.
-- Sample Call: Exec ProjectDeployment_Insert 1, '20-Aug-20',1,'Features','1.0.0','Actual File','Notes'
-- =============================================
CREATE PROCEDURE [dbo].[ProjectDeployment_Insert] 
@ProjectId int,
@DeploymentDate date,
@ServerId int,
@Features varchar(max),
@Version varchar(10),
@ActualFileName varchar(255),
@Notes varchar(2000)
AS
BEGIN
declare
@InsertedId int,
@StoreAsFileName varchar(255);
	SET NOCOUNT ON;
	Insert Into ProjectDeployment (ProjectId, DeploymentDate, ServerId, Features, Version,
		ActualFileName, Notes, CreatedBy, CreatedDateTime, IsDeleted)
		values
		(@ProjectId,@DeploymentDate,@ServerId,@Features ,@Version,@ActualFileName,@Notes,
			'Admin',GETDATE(), 0)
		set @InsertedId= SCOPE_IDENTITY();
		
		set @StoreAsFileName = CONVERT(varchar(10), @InsertedId) +'_' + @ActualFileName;
		Update ProjectDeployment set StoreAsFileName = @StoreAsFileName
			Where ProjectDeploymentId = @InsertedId
		Exec ProjectDeployment_GetById @InsertedId

END
GO
/****** Object:  StoredProcedure [dbo].[ProjectDeployment_List]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Bhavin
-- Create date: 20-Aug-2020
-- Description:	To get list of deployment (migration) details for particuar project
-- Sample Call: Exec  ProjectDeployment_List 1
-- =============================================
CREATE PROCEDURE [dbo].[ProjectDeployment_List] 
@ProjectId int
AS
BEGIN
	SET NOCOUNT ON;
	Select PD.ProjectDeploymentId, PD.ProjectId, P.Name as ProjectName, PD.DeploymentDate, 
			PD.ServerId , S.Name as ServerName,  PD.Features,  PD.Version, PD.ActualFileName, PD.StoreAsFileName,
			PD.Notes
		From Project P inner join ProjectDeployment PD
		on P.ProjectId = PD.ProjectId inner join Server S 
		on PD.ServerId = S.ServerId
		Where PD.ProjectId = @ProjectId and PD.IsDeleted=0

   
END
GO
/****** Object:  StoredProcedure [dbo].[ProjectDocumentMapping_Delete]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Bhavin
-- Create date: 18-Jun-2020
-- Description:	To delete particular record of Project Document Mapping Details
-- Sample Call: Exec ProjectDocumentMapping_Delete 1
-- =============================================
CREATE PROCEDURE [dbo].[ProjectDocumentMapping_Delete] 
@ProjectDocumentMappingId int
AS
BEGIN
	SET NOCOUNT ON;
	Update ProjectDocumentMapping set IsDeleted=1, DeletedBy='Admin', DeletedDateTime= GETDATE()
		Where ProjectDocumentMappingId=@ProjectDocumentMappingId
	Select @@ROWCOUNT as RowsAffected
END
GO
/****** Object:  StoredProcedure [dbo].[ProjectDocumentMapping_Edit]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Bhavin
-- Create date: 18-Jun-2020
-- Description:	To edit details of particualar project document mapping record 
-- Sample Call: Exec ProjectDocumentMapping_Edit 1,1,1,'Modified File','Store','Notes on 1'
-- =============================================
CREATE PROCEDURE [dbo].[ProjectDocumentMapping_Edit]
@ProjectDocumentMappingId int,
@ProjectId int,
@DocumentTypeId int,
@ActualFileName varchar(255),
@StoreAsFileName varchar(255),
@Notes varchar(2000)
AS
BEGIN
	SET NOCOUNT ON;
	if(@ActualFileName!='')
		Begin
			Update ProjectDocumentMapping set ProjectId=@ProjectId,
				DocumentTypeId = @DocumentTypeId, ActualFileName=@ActualFileName,
				StoreAsFileName=@StoreAsFileName, Notes=@Notes,
				LastUpdateDate=GETDATE(), LastUpdatedBy='Admin'
				Where ProjectDocumentMappingId=@ProjectDocumentMappingId

				set @StoreAsFileName = CONVERT(varchar(10), @ProjectDocumentMappingId) +'_' + @ActualFileName;
				Update ProjectDocumentMapping  set StoreAsFileName=@StoreAsFileName
					Where ProjectDocumentMappingId=@ProjectDocumentMappingId;
		End
	else
		Begin
			Update ProjectDocumentMapping set ProjectId=@ProjectId,
				DocumentTypeId = @DocumentTypeId, Notes=@Notes,
				LastUpdateDate=GETDATE(), LastUpdatedBy='Admin'
				Where ProjectDocumentMappingId=@ProjectDocumentMappingId
		End
		Exec ProjectDocumentMapping_GetById @ProjectDocumentMappingId
END
GO
/****** Object:  StoredProcedure [dbo].[ProjectDocumentMapping_GetById]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Bhavin
-- Create date: 18-Jun-20
-- Description:	To get details of particular project documents (single record)
-- Sample Call: Exec ProjectDocumentMapping_GetById 1 
-- =============================================
CREATE PROCEDURE [dbo].[ProjectDocumentMapping_GetById] 
@ProjectDocumentMappingId int
AS
BEGIN
	SET NOCOUNT ON;
	Select PD.ProjectDocumentMappingId, PD.ProjectId, P.Name as ProjectName, 
			PD.DocumentTypeId, DT.Name as DocumentType,	PD.ActualFileName,
			PD.StoreAsFileName, PD.Notes
	From ProjectDocumentMapping PD inner join Project P
	on P.ProjectId= PD.ProjectId inner join DocumentType DT
	on PD.DocumentTypeId = DT.DocumentTypeId
	Where PD.ProjectDocumentMappingId=@ProjectDocumentMappingId and PD.IsDeleted=0
END
GO
/****** Object:  StoredProcedure [dbo].[ProjectDocumentMapping_Insert]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Bhavin
-- Create date: 18-Jun-2020
-- Description:	To add new project document. 
-- Sample Call: Exec ProjectDocumentMapping_Insert 2,1,'testfilename','notes'
-- =============================================
CREATE PROCEDURE [dbo].[ProjectDocumentMapping_Insert] 
@ProjectId int,
@DocumentTypeId int,
@ActualFileName varchar(255),
@Notes varchar(2000)
AS
BEGIN
declare
@InsertedId int,
@StoreAsFileName varchar(255);

	SET NOCOUNT ON;
	Insert Into ProjectDocumentMapping (ProjectId,DocumentTypeId,
		ActualFileName,Notes,CreatedBy,CreatedDateTime,
		IsDeleted)
		values
		(@ProjectId, @DocumentTypeId, @ActualFileName,
			@Notes, 'Admin',GETDATE(), 0)
		set @InsertedId= SCOPE_IDENTITY();
		
		set @StoreAsFileName = CONVERT(varchar(10), @InsertedId) +'_' + @ActualFileName;
		Update ProjectDocumentMapping  set StoreAsFileName=@StoreAsFileName
			Where ProjectDocumentMappingId=@InsertedId;
		Exec ProjectDocumentMapping_GetById @InsertedId
END
GO
/****** Object:  StoredProcedure [dbo].[ProjectDocumentMapping_List]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Bhavin
-- Create date: 18-Jun-20
-- Description:	To get list of project related documents. 
-- Sample Call: Exec ProjectDocumentMapping_List 1 
-- =============================================
CREATE PROCEDURE [dbo].[ProjectDocumentMapping_List]
@ProjectId int
AS
BEGIN
	SET NOCOUNT ON;
	Select PD.ProjectDocumentMappingId, PD.ProjectId, P.Name as ProjectName, 
		PD.DocumentTypeId, DT.Name as DocumentType,	PD.ActualFileName,
		PD.StoreAsFileName, PD.Notes
	From ProjectDocumentMapping PD inner join Project P
		on P.ProjectId= PD.ProjectId inner join DocumentType DT
		on PD.DocumentTypeId = DT.DocumentTypeId
	Where PD.ProjectId = @ProjectId and PD.IsDeleted=0
END
GO
/****** Object:  StoredProcedure [dbo].[ProjectServerMapping_Delete]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Bhavin
-- Create date: 19-May-2020
-- Description:	To delete particular record of Project Server Mapping Details
-- Sample Call: ProjectServerMapping_Delete 4
-- =============================================
CREATE PROCEDURE [dbo].[ProjectServerMapping_Delete] 
@ProjectServerMappingId int
AS
BEGIN

	SET NOCOUNT ON;
	Update ProjectServerMapping Set IsDeleted=1,DeletedBy='Admin',
		DeletedDateTime= GETDATE() 
		Where ProjectServerMappingId=@ProjectServerMappingId 
	Select @@ROWCOUNT as RowsAffected
   
END
GO
/****** Object:  StoredProcedure [dbo].[ProjectServerMapping_Edit]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Bhavin
-- Create date: 19-May-2020
-- Description:	To edit particular record of Project Server Mapping Details
-- Sample Call: Exec ProjectServerMapping_Edit 3,3, 1, 2, 'URL-t','location-t','log-t',2,'DBName-test','notes-test'
-- =============================================
CREATE PROCEDURE [dbo].[ProjectServerMapping_Edit]
@ProjectServerMappingId int,
@ProjectId int,
@ServerId int,
@DeployedServerTypeId int,
@UrlToAccess varchar(500),
@DeployedLocation varchar(500),
@AppLogLocation varchar(500),
@DbServerID int,
@DbName varchar(255),
@Notes varchar(2000)
AS
BEGIN
	SET NOCOUNT ON;
	Update ProjectServerMapping Set ProjectId=@ProjectId, ServerId=@ServerId,
		DeployedServerTypeId=@DeployedServerTypeId, UrlToAccess=@UrlToAccess,
		DeployedLocation=@DeployedLocation, AppLogLocation=@AppLogLocation,
		DbServerID=@DbServerID, DbName=@DbName, Notes=@Notes,
		LastUpdateDate=GETDATE(), LastUpdatedBy='Admin'
		Where ProjectServerMappingId=@ProjectServerMappingId

		Exec ProjectServerMapping_GetById @ProjectServerMappingId
END
GO
/****** Object:  StoredProcedure [dbo].[ProjectServerMapping_GetById]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Bhavin
-- Create date: 19-May-2020
-- Description:	To get detail of particular project server mapping details (single record)
-- Sample Call: Exec ProjectServerMapping_GetById 1
-- =============================================
CREATE PROCEDURE [dbo].[ProjectServerMapping_GetById]
@id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Select PSM.ProjectServerMappingId , PSM.ProjectId,  p.Name as ProjectName,
		PSM.ServerId,  S.Name as ServerName,  ST.Name as ActualServerType ,
		PSM.DeployedServerTypeId, STD.Name as DeployedAsServerType,
		PSM.UrlToAccess, PSM.DeployedLocation, PSM.AppLogLocation, 
		DBS.Name as DatabaseServerName, PSM.DbServerID, PSM.DbName, 
		PSM.Notes
	From ProjectServerMapping PSM inner join Server S 
		on PSM.ServerId = s.ServerId inner join Project P 
		on P.ProjectId= PSM.ProjectId inner join ServerType ST
		on S.ServerTypeId= ST.ServerTypeId inner join ServerType STD
		on PSM.DeployedServerTypeId = STD.ServerTypeId inner join Server DBS 
		on PSM.DbServerID= DBS.ServerId
	Where PSM.ProjectServerMappingId=@id and PSM.IsDeleted=0
END
GO
/****** Object:  StoredProcedure [dbo].[ProjectServerMapping_Insert]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Bhavin
-- Create date: 19-May-2020
-- Description:	To add new Project Server Mapping Detail
-- Sample Call: Exec ProjectServerMapping_Insert 3, 1, 2, 'URL','location','log',2,'DBName','notes'
-- =============================================
CREATE PROCEDURE [dbo].[ProjectServerMapping_Insert] 
@ProjectId int,
@ServerId int,
@DeployedServerTypeId int,
@UrlToAccess varchar(500),
@DeployedLocation varchar(500),
@AppLogLocation varchar(500),
@DbServerID int,
@DbName varchar(255),
@Notes varchar(2000)

AS
BEGIN
declare
@InsertedId int;
	SET NOCOUNT ON;
	Insert Into ProjectServerMapping (ProjectId, ServerId, DeployedServerTypeId, 
		UrlToAccess,DeployedLocation, AppLogLocation, DbServerID, DbName, Notes,
		CreatedBy, CreatedDateTime, IsDeleted)
		Values
		(@ProjectId, @ServerId, @DeployedServerTypeId, @UrlToAccess,
		@DeployedLocation, @AppLogLocation,@DbServerID, @DbName, @Notes,
		'Admin', GETDATE(), 0)
		set @InsertedId = SCOPE_IDENTITY();
		Exec ProjectServerMapping_GetById @InsertedId
END
GO
/****** Object:  StoredProcedure [dbo].[ProjectServerMapping_List]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Bhavin
-- Create date: 19-May-2020
-- Description:	To get list of Project relaetd server mapping. To determine project deployed on which servers
-- Sample Call: Exec ProjectServerMapping_List 2
-- =============================================
CREATE PROCEDURE [dbo].[ProjectServerMapping_List]
@ProjectId int
AS
BEGIN
	SET NOCOUNT ON;
	Select PSM.ProjectServerMappingId , PSM.ProjectId,  p.Name as ProjectName,
		PSM.ServerId,  S.Name as ServerName,  ST.Name as ActualServerType ,
		PSM.DeployedServerTypeId, STD.Name as DeployedAsServerType,
		PSM.UrlToAccess, PSM.DeployedLocation, PSM.AppLogLocation, 
		DBS.Name as DatabaseServerName, PSM.DbServerID, PSM.DbName, 
		PSM.Notes
	From ProjectServerMapping PSM inner join Server S 
		on PSM.ServerId = s.ServerId inner join Project P 
		on P.ProjectId= PSM.ProjectId inner join ServerType ST
		on S.ServerTypeId= ST.ServerTypeId inner join ServerType STD
		on PSM.DeployedServerTypeId = STD.ServerTypeId inner join Server DBS 
		on PSM.DbServerID= DBS.ServerId
	Where PSM.ProjectId=@ProjectId and PSM.IsDeleted=0
END
GO
/****** Object:  StoredProcedure [dbo].[ProjectServerMapping_ListForLOV]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Bhavin
-- Create date: 03-Sep-2020
-- Description:	To get list of server for each project. ProjectId is optional
-- Sample Call: Exec ProjectServerMapping_ListForLOV 1
-- =============================================
CREATE PROCEDURE [dbo].[ProjectServerMapping_ListForLOV] 
@ProjectId int = null
AS
BEGIN
	SET NOCOUNT ON;
		Select PSM.ProjectId,  PSM.ServerId,  S.Name as ServerName  
			From ProjectServerMapping PSM inner join Server S 
			on PSM.ServerId = s.ServerId 
			Where (PSM.ProjectId=@ProjectId OR  @ProjectId  is null) and PSM.IsDeleted=0
END
GO
/****** Object:  StoredProcedure [dbo].[Server_Delete]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Bhavin
-- Create date: 07-May-2020
-- Description:	To delete particular server record
-- Sample Call: Exec Server_Delete  1
-- =============================================
CREATE PROCEDURE [dbo].[Server_Delete] 
@id int
AS
BEGIN
	SET NOCOUNT ON;
	Update Server Set IsDeleted=1, DeletedBy='Admin', DeletedDateTime=GETDATE() Where ServerId=@id;
	Select @@ROWCOUNT as RowsAffected
END
GO
/****** Object:  StoredProcedure [dbo].[Server_Edit]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Bhavin
-- Create date: 07-May-2020
-- Description:	To edit particular server record
-- Sample Call: Exec Server_Edit 7,'A',1,'1010','2010','URL.com','Test notes'
-- =============================================
CREATE PROCEDURE [dbo].[Server_Edit] 
@ServerID int,
@Name varchar(50),
@ServerTypeId int,
@InternalIP varchar(50),
@ExternalIP varchar(50),
@URLToAccess varchar(255),
@Notes varchar(1000)
AS
BEGIN
	SET NOCOUNT ON;
	Update Server Set Name =@Name, ServerTypeId=@ServerTypeId, InternalIP=@InternalIP, ExternalIP=@ExternalIP,
		URLToAccess=@URLToAccess, Notes= @Notes, LastUpdateDate=GETDATE(), LastUpdatedBy='Admin'
		Where ServerId=@ServerID and IsDeleted=0
	Select S.ServerId, s.Name, S.ServerTypeId, ST.Name as ServerTypeName, S.InternalIP, S.ExternalIP,
		S.URLToAccess, S.Notes
		From Server S inner join ServerType ST on S.ServerTypeId=ST.ServerTypeId
		Where S.ServerId=@ServerID
END
GO
/****** Object:  StoredProcedure [dbo].[Server_GetById]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Bhavin
-- Create date: 07-May-2020
-- Description:	To get details of particular server
-- Sample Call: Exec Server_GetById 1
-- =============================================
CREATE PROCEDURE [dbo].[Server_GetById] 
@id int
AS
BEGIN
	SET NOCOUNT ON;
	Select S.ServerId, s.Name, S.ServerTypeId, ST.Name as ServerTypeName, S.InternalIP, S.ExternalIP,
		S.URLToAccess, S.Notes
		From Server S inner join ServerType ST on S.ServerTypeId=ST.ServerTypeId
		Where S.ServerId=@id and S.IsDeleted=0
END
GO
/****** Object:  StoredProcedure [dbo].[Server_Insert]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Bhavin
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- Sample Call: Exec Server_Insert 'New Record',1,'1010','2010','URL.com','Test notes'
-- =============================================
CREATE PROCEDURE [dbo].[Server_Insert] 
@Name varchar(50),
@ServerTypeId int,
@InternalIP varchar(50),
@ExternalIP varchar(50),
@URLToAccess varchar(255),
@Notes varchar(1000)
AS
BEGIN
Declare
@InserterServerId int;
	SET NOCOUNT ON;
	Insert into Server(Name, ServerTypeId, InternalIP, ExternalIP, URLToAccess, Notes, CreatedBy, CreatedDateTime,IsDeleted) 
		Values (@Name, @ServerTypeId, @InternalIP, @ExternalIP, @URLToAccess, @Notes, 'Admin',GETDATE(),0);
	set @InserterServerId = SCOPE_IDENTITY();
	Select S.ServerId, s.Name, S.ServerTypeId, ST.Name as ServerTypeName, S.InternalIP, S.ExternalIP,
		S.URLToAccess, S.Notes
		From Server S inner join ServerType ST on S.ServerTypeId=ST.ServerTypeId
		Where S.ServerId=@InserterServerId
    
END
GO
/****** Object:  StoredProcedure [dbo].[Server_List]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Bhavin
-- Create date: 07-May-2020
-- Description:	To get list of server
-- Sample Call: Server_List
-- =============================================
CREATE PROCEDURE [dbo].[Server_List]
AS
BEGIN
	SET NOCOUNT ON;
	Select S.ServerId, s.Name, S.ServerTypeId, ST.Name as ServerTypeName, S.InternalIP, S.ExternalIP,
		S.URLToAccess, S.Notes
		From Server S inner join ServerType ST on S.ServerTypeId=ST.ServerTypeId
		Where  S.IsDeleted=0
END
GO
/****** Object:  StoredProcedure [dbo].[Server_List_ForLOV]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Bhavin
-- Create date: 10-Jul-2020
-- Description:	To get list of server to fill dropdown for with ServerId and Server Name - optionally filter by server type id
-- Sample Call: Exec Server_List_ForLOV 2
-- =============================================
CREATE PROCEDURE [dbo].[Server_List_ForLOV]
@ServerTypeId int = null
AS
BEGIN
	SET NOCOUNT ON;
		Select S.ServerId, s.Name 
		From Server S 
		Where  S.IsDeleted=0 and (@ServerTypeId is null or ServerTypeId =@ServerTypeId)
		order by S.Name
END
GO
/****** Object:  StoredProcedure [dbo].[ServerType_Delete]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Bhavin
-- Create date: 07-May-20
-- Description:	To delete particular server type record
-- Sample Call: Exec ServerType_Delete, 1
-- =============================================
CREATE PROCEDURE [dbo].[ServerType_Delete] 
@Id int
AS
BEGIN
	SET NOCOUNT ON;

	Update ServerType Set IsDeleted=1 , DeletedBy='Admin', DeletedDateTime= GETDATE() Where ServerTypeId=@Id
	Select @@ROWCOUNT as RowsAffected
END
GO
/****** Object:  StoredProcedure [dbo].[ServerType_Edit]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Bhavin
-- Create date: 07-May-2020
-- Description:	To edit particular server type record
-- Sample Call: Exec ServerType_Edit 93,'Hello'
-- =============================================
CREATE PROCEDURE [dbo].[ServerType_Edit] 
@Id numeric,
@Name varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	Update ServerType Set Name=@Name, LastUpdatedBy='Admin', LastUpdateDate=GETDATE()  Where ServerTypeId=@Id and IsDeleted=0
	Select S.ServerTypeId, S.Name From ServerType S Where ServerTypeId=@Id and IsDeleted=0 
END
GO
/****** Object:  StoredProcedure [dbo].[ServerType_GetById]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Bhavin
-- Create date: 07-May-2020
-- Description:	To get details of particular server type
-- Sample Call: Exec ServerType_GetById 1
-- =============================================
CREATE PROCEDURE [dbo].[ServerType_GetById] 
@Id int
AS
BEGIN
	SET NOCOUNT ON;
	Select S.ServerTypeId, S.Name From ServerType S Where S.ServerTypeId = @Id and S.IsDeleted = 0
END
GO
/****** Object:  StoredProcedure [dbo].[ServerType_GetList]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Bhavin
-- Create date: 07-May-2020
-- Description:	To get list of server type
-- Sample Call: Exec ServerType_GetList
-- =============================================
CREATE PROCEDURE [dbo].[ServerType_GetList] 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	Select S.ServerTypeId, S.Name From ServerType S Where S.IsDeleted=0
END
GO
/****** Object:  StoredProcedure [dbo].[ServerType_Insert]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Bhavin
-- Create date: 07-May-2020
-- Description:	To insert new Server Type record
-- Sample Call: Exec ServerType_Insert 'Test Server Type'
-- =============================================
CREATE PROCEDURE  [dbo].[ServerType_Insert]
@Name varchar(50)
AS
BEGIN
declare
@InsertedServerTypeId numeric;

	SET NOCOUNT ON;
	Insert Into ServerType(Name, CreatedBy, CreatedDateTime, IsDeleted) 
	Values 	(@Name,'Admin',GETDATE(), 0);
	--Get Inserted Identity Value
	set @InsertedServerTypeId = SCOPE_IDENTITY();
	Select S.ServerTypeId, S.Name From ServerType S 
		Where S.ServerTypeId = @InsertedServerTypeId;
END
GO
/****** Object:  StoredProcedure [dbo].[ServerType_List]    Script Date: 04-09-2020 14:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Bhavin
-- Create date: 07-May-2020
-- Description:	To get list of server type
-- Sample Call: Exec ServerType_List
-- =============================================
CREATE PROCEDURE [dbo].[ServerType_List] 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	Select S.ServerTypeId, S.Name From ServerType S Where S.IsDeleted=0
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'To manage project deployment/migration summary.  As one project deploy multiple times on server' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ProjectDeployment'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Production server use as a testing server for same project with different url' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ProjectServerMapping', @level2type=N'COLUMN',@level2name=N'DeployedServerTypeId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Path where application project deployed' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ProjectServerMapping', @level2type=N'COLUMN',@level2name=N'DeployedLocation'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Location for application log' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ProjectServerMapping', @level2type=N'COLUMN',@level2name=N'AppLogLocation'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Server ID on which database installed' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ProjectServerMapping', @level2type=N'COLUMN',@level2name=N'DbServerID'
GO
