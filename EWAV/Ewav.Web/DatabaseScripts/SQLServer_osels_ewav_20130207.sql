USE [OSELS_EWAV]
GO
/****** Object:  Table [dbo].[SecurityLevel]    Script Date: 02/07/2013 15:17:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SecurityLevel](
	[SecurityLevelID] [int] IDENTITY(1,1) NOT NULL,
	[SecurityLevelValue] [int] NOT NULL,
	[SecurityLevelDescription] [varchar](50) NOT NULL,
 CONSTRAINT [PK_SecurityLevel] PRIMARY KEY CLUSTERED 
(
	[SecurityLevelID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Organization]    Script Date: 02/07/2013 15:17:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Organization](
	[OrganizationID] [int] IDENTITY(1,1) NOT NULL,
	[OrganizationName] [varchar](50) NOT NULL,
	[Description] [varchar](50) NULL,
 CONSTRAINT [PK_Organization] PRIMARY KEY CLUSTERED 
(
	[OrganizationID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[User]    Script Date: 02/07/2013 15:17:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[OrganizationID] [int] NULL,
	[SecurityLevelID] [int] NULL,
	[PasswordHash] [varchar](max) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Datasource]    Script Date: 02/07/2013 15:17:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Datasource](
	[DatasourceID] [int] IDENTITY(1,1) NOT NULL,
	[DatasourceName] [nvarchar](50) NOT NULL,
	[OrganizationID] [int] NOT NULL,
	[DatasourceServerName] [nvarchar](100) NOT NULL,
	[DatabaseType] [varchar](50) NOT NULL,
	[InitialCatalog] [varchar](50) NULL,
	[PersistSecurityInfo] [varchar](50) NULL,
	[DatabaseUserID] [varchar](50) NULL,
	[Password] [varchar](50) NOT NULL,
	[TableName] [varchar](max) NOT NULL,
	[SQLQuery] [bit] NULL,
	[SQLText] [varchar](max) NULL,
	[active] [bit] NOT NULL,
 CONSTRAINT [PK_Datasource] PRIMARY KEY CLUSTERED 
(
	[DatasourceID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DatasourceUser]    Script Date: 02/07/2013 15:17:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatasourceUser](
	[DatasourceID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
 CONSTRAINT [PK_DatasourceUser] PRIMARY KEY CLUSTERED 
(
	[DatasourceID] ASC,
	[UserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Canvas]    Script Date: 02/07/2013 15:17:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Canvas](
	[CanvasID] [int] IDENTITY(1,1) NOT NULL,
	[CanvasName] [varchar](50) NOT NULL,
	[UserID] [int] NOT NULL,
	[CanvasDescription] [varchar](max) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
	[DatasourceID] [int] NOT NULL,
	[CanvasContent] [varchar](max) NOT NULL,
 CONSTRAINT [PK_CanvasNew1 ] PRIMARY KEY CLUSTERED 
(
	[CanvasID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[up_read_allUsers]    Script Date: 02/07/2013 15:17:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[up_read_allUsers] 
@orgid int = -1
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	--SELECT <@Param1, sysname, @p1>, <@Param2, sysname, @p2>
	Select UserId, FirstName, LastName From [User] Where OrganizationId = @orgid;
END
GO
/****** Object:  Table [dbo].[SharedCanvases]    Script Date: 02/07/2013 15:17:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SharedCanvases](
	[CanvasID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
 CONSTRAINT [PK_CanvasUser] PRIMARY KEY CLUSTERED 
(
	[CanvasID] ASC,
	[UserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vwUserDatasource]    Script Date: 02/07/2013 15:17:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vwUserDatasource]
AS
SELECT     dbo.[User].UserID, dbo.[User].UserName, dbo.[User].OrganizationID, dbo.[User].PasswordHash, dbo.SecurityLevel.SecurityLevelValue, 
                      dbo.SecurityLevel.SecurityLevelID, dbo.SecurityLevel.SecurityLevelDescription, dbo.Datasource.DatasourceID, dbo.Datasource.DatasourceName, 
                      dbo.Datasource.DatasourceServerName, dbo.Datasource.DatabaseType, dbo.Datasource.InitialCatalog, dbo.Datasource.PersistSecurityInfo, 
                      dbo.Datasource.Password, dbo.Datasource.TableName, dbo.Datasource.SQLQuery, dbo.Datasource.SQLText, dbo.Datasource.active, 
                      dbo.Datasource.DatabaseUserID
FROM         dbo.DatasourceUser INNER JOIN
                      dbo.Datasource ON dbo.DatasourceUser.DatasourceID = dbo.Datasource.DatasourceID INNER JOIN
                      dbo.[User] ON dbo.DatasourceUser.UserID = dbo.[User].UserID INNER JOIN
                      dbo.SecurityLevel ON dbo.[User].SecurityLevelID = dbo.SecurityLevel.SecurityLevelID
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[28] 4[27] 2[25] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1[50] 4[25] 3) )"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[45] 2[31] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1[56] 3) )"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "DatasourceUser"
            Begin Extent = 
               Top = 18
               Left = 49
               Bottom = 107
               Right = 209
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "User"
            Begin Extent = 
               Top = 6
               Left = 247
               Bottom = 159
               Right = 411
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "SecurityLevel"
            Begin Extent = 
               Top = 181
               Left = 380
               Bottom = 297
               Right = 586
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Datasource"
            Begin Extent = 
               Top = 32
               Left = 613
               Bottom = 290
               Right = 816
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 24
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 2130
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin Criteri' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwUserDatasource'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'aPane = 
      Begin ColumnWidths = 11
         Column = 2400
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwUserDatasource'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwUserDatasource'
GO
/****** Object:  View [dbo].[vwCanvasUser]    Script Date: 02/07/2013 15:17:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vwCanvasUser]
AS
SELECT     dbo.[User].UserName, dbo.Datasource.DatasourceName, dbo.Canvas.CanvasID, dbo.Canvas.CanvasName, dbo.Canvas.CanvasDescription, dbo.Canvas.CreatedDate, 
                      dbo.Canvas.ModifiedDate, dbo.Canvas.CanvasContent, dbo.[User].UserID, dbo.[User].OrganizationID, dbo.[User].FirstName, dbo.[User].LastName, 
                      dbo.Datasource.DatasourceID
FROM         dbo.Canvas INNER JOIN
                      dbo.[User] ON dbo.Canvas.UserID = dbo.[User].UserID INNER JOIN
                      dbo.DatasourceUser ON dbo.[User].UserID = dbo.DatasourceUser.UserID INNER JOIN
                      dbo.Datasource ON dbo.Canvas.DatasourceID = dbo.Datasource.DatasourceID AND dbo.DatasourceUser.DatasourceID = dbo.Datasource.DatasourceID
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[10] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1[50] 4[25] 3) )"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[50] 2[11] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Canvas"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 221
               Right = 216
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "User"
            Begin Extent = 
               Top = 6
               Left = 254
               Bottom = 186
               Right = 418
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "DatasourceUser"
            Begin Extent = 
               Top = 28
               Left = 512
               Bottom = 147
               Right = 672
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Datasource"
            Begin Extent = 
               Top = 43
               Left = 711
               Bottom = 248
               Right = 914
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 13
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 2070
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
 ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwCanvasUser'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'        Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwCanvasUser'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwCanvasUser'
GO
/****** Object:  View [dbo].[vwCanvasShare]    Script Date: 02/07/2013 15:17:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vwCanvasShare]
AS
SELECT     dbo.[User].UserName, dbo.Datasource.DatasourceName, dbo.Canvas.CanvasID, dbo.Canvas.CanvasName, dbo.Canvas.CanvasDescription, dbo.Canvas.CreatedDate, 
                      dbo.Canvas.ModifiedDate, dbo.Canvas.CanvasContent, dbo.[User].UserID, dbo.Datasource.OrganizationID, dbo.[User].FirstName, dbo.[User].LastName, 
                      dbo.Datasource.DatasourceID
FROM         dbo.Canvas INNER JOIN
                      dbo.SharedCanvases ON dbo.Canvas.CanvasID = dbo.SharedCanvases.CanvasID INNER JOIN
                      dbo.[User] ON dbo.SharedCanvases.UserID = dbo.[User].UserID INNER JOIN
                      dbo.Datasource ON dbo.Canvas.DatasourceID = dbo.Datasource.DatasourceID
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[20] 2[8] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1[50] 4[38] 3) )"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1[67] 3) )"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 4
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Canvas"
            Begin Extent = 
               Top = 35
               Left = 0
               Bottom = 227
               Right = 178
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "SharedCanvases"
            Begin Extent = 
               Top = 72
               Left = 241
               Bottom = 179
               Right = 401
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "User"
            Begin Extent = 
               Top = 108
               Left = 521
               Bottom = 227
               Right = 685
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Datasource"
            Begin Extent = 
               Top = 231
               Left = 273
               Bottom = 350
               Right = 476
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
      PaneHidden = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1875
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
     ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwCanvasShare'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'    Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwCanvasShare'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwCanvasShare'
GO
/****** Object:  StoredProcedure [dbo].[up_read_canvasInfo]    Script Date: 02/07/2013 15:17:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[up_read_canvasInfo]
@canvasId int = -1
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	--SELECT <@Param1, sysname, @p1>, <@Param2, sysname, @p2>
	--if(@canvasId = -1)
	--	begin
	--	--raiserror('',1,1);
	--	end
	--else
		begin
		SELECT UserId, CanvasID, CanvasContent, (select count(*) from SharedCanvases where CanvasId = @canvasId) as IsShared From vwCanvasUser where CanvasId = @canvasId;
		end
END
GO
/****** Object:  StoredProcedure [dbo].[up_delete_canvas]    Script Date: 02/07/2013 15:17:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[up_delete_canvas]
	-- Add the parameters for the stored procedure here
	@canvasId int = -1
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   if(@canvasId <> -1)
   begin
   Delete From SharedCanvases where CanvasId = @canvasId;
   
   Delete from Canvas where CanvasId = @canvasId;
   end
END
GO
/****** Object:  StoredProcedure [dbo].[up_sharecanvas]    Script Date: 02/07/2013 15:17:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[up_sharecanvas] 
@canvasId int = -1,
@userId int = -1
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	--SELECT <@Param1, sysname, @p1>, <@Param2, sysname, @p2>
	 INSERT INTO SharedCanvases    ([CanvasID] ,[UserID]) VALUES (@canvasId,@userId) ;
END
GO
/****** Object:  StoredProcedure [dbo].[up_save_canvas]    Script Date: 02/07/2013 15:17:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[up_save_canvas] 
	@CANVASNAME VARCHAR(50) = '',
	@USERID INT = -1,
	@CANVASDESC VARCHAR(MAX) = '',
	@CREATEDDATE DATETIME = '1/1/1900',
	@MODIFIEDDATE DATETIME= '1/1/1900',
	@DATASOURCEID INT = '-1',
	@ISNEWCANVAS BIT = 0,
	@CANVASID INT = -1,
	@XMLCONTENT VARCHAR(MAX) = ''
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
IF(@ISNEWCANVAS = 1)
	BEGIN
	Create Table #CountTable(count int);
		
	Insert into #CountTable
   		SELECT   count(*)  FROM VWCANVASUSER WHERE CANVASNAME = @CANVASNAME UNION 
		SELECT   count(*) FROM VWCANVASSHARE  WHERE CANVASNAME = @CANVASNAME  --ORDER BY CREATEDDATE DESC
		
		-- If true there is an existing canvas  
		IF((Select max(count) from #CountTable) > 0)
			BEGIN
			--raiserror ('Canvas Name already exists. Select another name.',11,1);
			select -1;
			END
		-- If not insert new record and return canvasID	
		Else
			Begin
			INSERT INTO CANVAS ([CANVASNAME] ,[USERID],[CANVASDESCRIPTION],[CREATEDDATE],[MODIFIEDDATE],
			[DATASOURCEID],[CANVASCONTENT])
			VALUES (''+ @CANVASNAME +'','' + @USERID + '', '' + @CANVASDESC + '', '' + @CREATEDDATE + '', '' + @MODIFIEDDATE + '',
			'' + @DATASOURCEID + '', '' + @XMLCONTENT + '');
		    
			Select (SELECT CANVASID FROM CANVAS WHERE CANVASNAME = '' + @CANVASNAME + '')
			End
		Drop Table #CountTable;
	END
-- If not then update canvas  	
ELSE
	BEGIN
	UPDATE CANVAS SET MODIFIEDDATE = '' + @MODIFIEDDATE + '', CANVASCONTENT = '' + @XMLCONTENT + '' WHERE CANVASID=@CANVASID;
	Select @CANVASID;
	return;
	END	
	
END
GO
/****** Object:  StoredProcedure [dbo].[up_read_all_canvases]    Script Date: 02/07/2013 15:17:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[up_read_all_canvases]
	 ( @userID int )
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here 
	select   'Owned' As IsShared,   *  from vwCanvasUser where UserID =   @userID  UNION 
	select   'Shared' As IsShared,   * from vwCanvasShare  where UserID = @userID  Order By CreatedDate DESC
	 
END
GO
/****** Object:  ForeignKey [FK_Canvas _Datasource]    Script Date: 02/07/2013 15:17:45 ******/
ALTER TABLE [dbo].[Canvas]  WITH CHECK ADD  CONSTRAINT [FK_Canvas _Datasource] FOREIGN KEY([DatasourceID])
REFERENCES [dbo].[Datasource] ([DatasourceID])
GO
ALTER TABLE [dbo].[Canvas] CHECK CONSTRAINT [FK_Canvas _Datasource]
GO
/****** Object:  ForeignKey [FK_Canvas_CreatorUser]    Script Date: 02/07/2013 15:17:45 ******/
ALTER TABLE [dbo].[Canvas]  WITH CHECK ADD  CONSTRAINT [FK_Canvas_CreatorUser] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[Canvas] CHECK CONSTRAINT [FK_Canvas_CreatorUser]
GO
/****** Object:  ForeignKey [FK_Datasource_Organization]    Script Date: 02/07/2013 15:17:45 ******/
ALTER TABLE [dbo].[Datasource]  WITH CHECK ADD  CONSTRAINT [FK_Datasource_Organization] FOREIGN KEY([OrganizationID])
REFERENCES [dbo].[Organization] ([OrganizationID])
GO
ALTER TABLE [dbo].[Datasource] CHECK CONSTRAINT [FK_Datasource_Organization]
GO
/****** Object:  ForeignKey [FK_DatasourceUser_Datasource]    Script Date: 02/07/2013 15:17:45 ******/
ALTER TABLE [dbo].[DatasourceUser]  WITH CHECK ADD  CONSTRAINT [FK_DatasourceUser_Datasource] FOREIGN KEY([DatasourceID])
REFERENCES [dbo].[Datasource] ([DatasourceID])
GO
ALTER TABLE [dbo].[DatasourceUser] CHECK CONSTRAINT [FK_DatasourceUser_Datasource]
GO
/****** Object:  ForeignKey [FK_DatasourceUser_User]    Script Date: 02/07/2013 15:17:45 ******/
ALTER TABLE [dbo].[DatasourceUser]  WITH CHECK ADD  CONSTRAINT [FK_DatasourceUser_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[DatasourceUser] CHECK CONSTRAINT [FK_DatasourceUser_User]
GO
/****** Object:  ForeignKey [FK_CanvasUser_Canvas]    Script Date: 02/07/2013 15:17:45 ******/
ALTER TABLE [dbo].[SharedCanvases]  WITH CHECK ADD  CONSTRAINT [FK_CanvasUser_Canvas] FOREIGN KEY([CanvasID])
REFERENCES [dbo].[Canvas] ([CanvasID])
GO
ALTER TABLE [dbo].[SharedCanvases] CHECK CONSTRAINT [FK_CanvasUser_Canvas]
GO
/****** Object:  ForeignKey [FK_CanvasUser_User]    Script Date: 02/07/2013 15:17:45 ******/
ALTER TABLE [dbo].[SharedCanvases]  WITH CHECK ADD  CONSTRAINT [FK_CanvasUser_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[SharedCanvases] CHECK CONSTRAINT [FK_CanvasUser_User]
GO
/****** Object:  ForeignKey [FK_User_Organization]    Script Date: 02/07/2013 15:17:45 ******/
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Organization] FOREIGN KEY([OrganizationID])
REFERENCES [dbo].[Organization] ([OrganizationID])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Organization]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'A user belongs to one Organization ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User', @level2type=N'CONSTRAINT',@level2name=N'FK_User_Organization'
GO
/****** Object:  ForeignKey [FK_User_SecurityLevel]    Script Date: 02/07/2013 15:17:45 ******/
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_SecurityLevel] FOREIGN KEY([SecurityLevelID])
REFERENCES [dbo].[SecurityLevel] ([SecurityLevelID])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_SecurityLevel]
GO
