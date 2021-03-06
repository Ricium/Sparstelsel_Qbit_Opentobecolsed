USE [master]
GO
/****** Object:  Database [Spar_Database]    Script Date: 27/11/2014 01:37:36 PM ******/
CREATE DATABASE [Spar_Database]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Spar_Database', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Spar_Database.mdf' , SIZE = 4160KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Spar_Database_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Spar_Database_log.ldf' , SIZE = 2624KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Spar_Database] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Spar_Database].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Spar_Database] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Spar_Database] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Spar_Database] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Spar_Database] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Spar_Database] SET ARITHABORT OFF 
GO
ALTER DATABASE [Spar_Database] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Spar_Database] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Spar_Database] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Spar_Database] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Spar_Database] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Spar_Database] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Spar_Database] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Spar_Database] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Spar_Database] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Spar_Database] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Spar_Database] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Spar_Database] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Spar_Database] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Spar_Database] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Spar_Database] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Spar_Database] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Spar_Database] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Spar_Database] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Spar_Database] SET RECOVERY FULL 
GO
ALTER DATABASE [Spar_Database] SET  MULTI_USER 
GO
ALTER DATABASE [Spar_Database] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Spar_Database] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Spar_Database] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Spar_Database] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Spar_Database]
GO
/****** Object:  DatabaseRole [aspnet_Roles_ReportingAccess]    Script Date: 27/11/2014 01:37:36 PM ******/
CREATE ROLE [aspnet_Roles_ReportingAccess]
GO
/****** Object:  DatabaseRole [aspnet_Roles_FullAccess]    Script Date: 27/11/2014 01:37:36 PM ******/
CREATE ROLE [aspnet_Roles_FullAccess]
GO
/****** Object:  DatabaseRole [aspnet_Roles_BasicAccess]    Script Date: 27/11/2014 01:37:36 PM ******/
CREATE ROLE [aspnet_Roles_BasicAccess]
GO
/****** Object:  DatabaseRole [aspnet_Profile_ReportingAccess]    Script Date: 27/11/2014 01:37:36 PM ******/
CREATE ROLE [aspnet_Profile_ReportingAccess]
GO
/****** Object:  DatabaseRole [aspnet_Profile_FullAccess]    Script Date: 27/11/2014 01:37:36 PM ******/
CREATE ROLE [aspnet_Profile_FullAccess]
GO
/****** Object:  DatabaseRole [aspnet_Profile_BasicAccess]    Script Date: 27/11/2014 01:37:36 PM ******/
CREATE ROLE [aspnet_Profile_BasicAccess]
GO
/****** Object:  DatabaseRole [aspnet_Personalization_ReportingAccess]    Script Date: 27/11/2014 01:37:36 PM ******/
CREATE ROLE [aspnet_Personalization_ReportingAccess]
GO
/****** Object:  DatabaseRole [aspnet_Personalization_FullAccess]    Script Date: 27/11/2014 01:37:36 PM ******/
CREATE ROLE [aspnet_Personalization_FullAccess]
GO
/****** Object:  DatabaseRole [aspnet_Personalization_BasicAccess]    Script Date: 27/11/2014 01:37:36 PM ******/
CREATE ROLE [aspnet_Personalization_BasicAccess]
GO
/****** Object:  DatabaseRole [aspnet_Membership_ReportingAccess]    Script Date: 27/11/2014 01:37:36 PM ******/
CREATE ROLE [aspnet_Membership_ReportingAccess]
GO
/****** Object:  DatabaseRole [aspnet_Membership_FullAccess]    Script Date: 27/11/2014 01:37:36 PM ******/
CREATE ROLE [aspnet_Membership_FullAccess]
GO
/****** Object:  DatabaseRole [aspnet_Membership_BasicAccess]    Script Date: 27/11/2014 01:37:36 PM ******/
CREATE ROLE [aspnet_Membership_BasicAccess]
GO
ALTER ROLE [aspnet_Roles_BasicAccess] ADD MEMBER [aspnet_Roles_FullAccess]
GO
ALTER ROLE [aspnet_Roles_ReportingAccess] ADD MEMBER [aspnet_Roles_FullAccess]
GO
ALTER ROLE [aspnet_Profile_BasicAccess] ADD MEMBER [aspnet_Profile_FullAccess]
GO
ALTER ROLE [aspnet_Profile_ReportingAccess] ADD MEMBER [aspnet_Profile_FullAccess]
GO
ALTER ROLE [aspnet_Personalization_BasicAccess] ADD MEMBER [aspnet_Personalization_FullAccess]
GO
ALTER ROLE [aspnet_Personalization_ReportingAccess] ADD MEMBER [aspnet_Personalization_FullAccess]
GO
ALTER ROLE [aspnet_Membership_BasicAccess] ADD MEMBER [aspnet_Membership_FullAccess]
GO
ALTER ROLE [aspnet_Membership_ReportingAccess] ADD MEMBER [aspnet_Membership_FullAccess]
GO
/****** Object:  Schema [aspnet_Membership_BasicAccess]    Script Date: 27/11/2014 01:37:36 PM ******/
CREATE SCHEMA [aspnet_Membership_BasicAccess]
GO
/****** Object:  Schema [aspnet_Membership_FullAccess]    Script Date: 27/11/2014 01:37:36 PM ******/
CREATE SCHEMA [aspnet_Membership_FullAccess]
GO
/****** Object:  Schema [aspnet_Membership_ReportingAccess]    Script Date: 27/11/2014 01:37:36 PM ******/
CREATE SCHEMA [aspnet_Membership_ReportingAccess]
GO
/****** Object:  Schema [aspnet_Personalization_BasicAccess]    Script Date: 27/11/2014 01:37:36 PM ******/
CREATE SCHEMA [aspnet_Personalization_BasicAccess]
GO
/****** Object:  Schema [aspnet_Personalization_FullAccess]    Script Date: 27/11/2014 01:37:36 PM ******/
CREATE SCHEMA [aspnet_Personalization_FullAccess]
GO
/****** Object:  Schema [aspnet_Personalization_ReportingAccess]    Script Date: 27/11/2014 01:37:36 PM ******/
CREATE SCHEMA [aspnet_Personalization_ReportingAccess]
GO
/****** Object:  Schema [aspnet_Profile_BasicAccess]    Script Date: 27/11/2014 01:37:36 PM ******/
CREATE SCHEMA [aspnet_Profile_BasicAccess]
GO
/****** Object:  Schema [aspnet_Profile_FullAccess]    Script Date: 27/11/2014 01:37:36 PM ******/
CREATE SCHEMA [aspnet_Profile_FullAccess]
GO
/****** Object:  Schema [aspnet_Profile_ReportingAccess]    Script Date: 27/11/2014 01:37:36 PM ******/
CREATE SCHEMA [aspnet_Profile_ReportingAccess]
GO
/****** Object:  Schema [aspnet_Roles_BasicAccess]    Script Date: 27/11/2014 01:37:36 PM ******/
CREATE SCHEMA [aspnet_Roles_BasicAccess]
GO
/****** Object:  Schema [aspnet_Roles_FullAccess]    Script Date: 27/11/2014 01:37:36 PM ******/
CREATE SCHEMA [aspnet_Roles_FullAccess]
GO
/****** Object:  Schema [aspnet_Roles_ReportingAccess]    Script Date: 27/11/2014 01:37:36 PM ******/
CREATE SCHEMA [aspnet_Roles_ReportingAccess]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_AnyDataInTables]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[aspnet_AnyDataInTables]
    @TablesToCheck int
AS
BEGIN
    -- Check Membership table if (@TablesToCheck & 1) is set
    IF ((@TablesToCheck & 1) <> 0 AND
        (EXISTS (SELECT name FROM sysobjects WHERE (name = N'vw_aspnet_MembershipUsers') AND (type = 'V'))))
    BEGIN
        IF (EXISTS(SELECT TOP 1 UserId FROM dbo.aspnet_Membership))
        BEGIN
            SELECT N'aspnet_Membership'
            RETURN
        END
    END

    -- Check aspnet_Roles table if (@TablesToCheck & 2) is set
    IF ((@TablesToCheck & 2) <> 0  AND
        (EXISTS (SELECT name FROM sysobjects WHERE (name = N'vw_aspnet_Roles') AND (type = 'V'))) )
    BEGIN
        IF (EXISTS(SELECT TOP 1 RoleId FROM dbo.aspnet_Roles))
        BEGIN
            SELECT N'aspnet_Roles'
            RETURN
        END
    END

    -- Check aspnet_Profile table if (@TablesToCheck & 4) is set
    IF ((@TablesToCheck & 4) <> 0  AND
        (EXISTS (SELECT name FROM sysobjects WHERE (name = N'vw_aspnet_Profiles') AND (type = 'V'))) )
    BEGIN
        IF (EXISTS(SELECT TOP 1 UserId FROM dbo.aspnet_Profile))
        BEGIN
            SELECT N'aspnet_Profile'
            RETURN
        END
    END

    -- Check aspnet_PersonalizationPerUser table if (@TablesToCheck & 8) is set
    IF ((@TablesToCheck & 8) <> 0  AND
        (EXISTS (SELECT name FROM sysobjects WHERE (name = N'vw_aspnet_WebPartState_User') AND (type = 'V'))) )
    BEGIN
        IF (EXISTS(SELECT TOP 1 UserId FROM dbo.aspnet_PersonalizationPerUser))
        BEGIN
            SELECT N'aspnet_PersonalizationPerUser'
            RETURN
        END
    END

    -- Check aspnet_PersonalizationPerUser table if (@TablesToCheck & 16) is set
    IF ((@TablesToCheck & 16) <> 0  AND
        (EXISTS (SELECT name FROM sysobjects WHERE (name = N'aspnet_WebEvent_LogEvent') AND (type = 'P'))) )
    BEGIN
        IF (EXISTS(SELECT TOP 1 * FROM dbo.aspnet_WebEvent_Events))
        BEGIN
            SELECT N'aspnet_WebEvent_Events'
            RETURN
        END
    END

    -- Check aspnet_Users table if (@TablesToCheck & 1,2,4 & 8) are all set
    IF ((@TablesToCheck & 1) <> 0 AND
        (@TablesToCheck & 2) <> 0 AND
        (@TablesToCheck & 4) <> 0 AND
        (@TablesToCheck & 8) <> 0 AND
        (@TablesToCheck & 32) <> 0 AND
        (@TablesToCheck & 128) <> 0 AND
        (@TablesToCheck & 256) <> 0 AND
        (@TablesToCheck & 512) <> 0 AND
        (@TablesToCheck & 1024) <> 0)
    BEGIN
        IF (EXISTS(SELECT TOP 1 UserId FROM dbo.aspnet_Users))
        BEGIN
            SELECT N'aspnet_Users'
            RETURN
        END
        IF (EXISTS(SELECT TOP 1 ApplicationId FROM dbo.aspnet_Applications))
        BEGIN
            SELECT N'aspnet_Applications'
            RETURN
        END
    END
END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_Applications_CreateApplication]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

CREATE PROCEDURE [dbo].[aspnet_Applications_CreateApplication]
    @ApplicationName      nvarchar(256),
    @ApplicationId        uniqueidentifier OUTPUT
AS
BEGIN
    SELECT  @ApplicationId = ApplicationId FROM dbo.aspnet_Applications WHERE LOWER(@ApplicationName) = LoweredApplicationName

    IF(@ApplicationId IS NULL)
    BEGIN
        DECLARE @TranStarted   bit
        SET @TranStarted = 0

        IF( @@TRANCOUNT = 0 )
        BEGIN
	        BEGIN TRANSACTION
	        SET @TranStarted = 1
        END
        ELSE
    	    SET @TranStarted = 0

        SELECT  @ApplicationId = ApplicationId
        FROM dbo.aspnet_Applications WITH (UPDLOCK, HOLDLOCK)
        WHERE LOWER(@ApplicationName) = LoweredApplicationName

        IF(@ApplicationId IS NULL)
        BEGIN
            SELECT  @ApplicationId = NEWID()
            INSERT  dbo.aspnet_Applications (ApplicationId, ApplicationName, LoweredApplicationName)
            VALUES  (@ApplicationId, @ApplicationName, LOWER(@ApplicationName))
        END


        IF( @TranStarted = 1 )
        BEGIN
            IF(@@ERROR = 0)
            BEGIN
	        SET @TranStarted = 0
	        COMMIT TRANSACTION
            END
            ELSE
            BEGIN
                SET @TranStarted = 0
                ROLLBACK TRANSACTION
            END
        END
    END
END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_CheckSchemaVersion]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

CREATE PROCEDURE [dbo].[aspnet_CheckSchemaVersion]
    @Feature                   nvarchar(128),
    @CompatibleSchemaVersion   nvarchar(128)
AS
BEGIN
    IF (EXISTS( SELECT  *
                FROM    dbo.aspnet_SchemaVersions
                WHERE   Feature = LOWER( @Feature ) AND
                        CompatibleSchemaVersion = @CompatibleSchemaVersion ))
        RETURN 0

    RETURN 1
END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_Membership_ChangePasswordQuestionAndAnswer]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[aspnet_Membership_ChangePasswordQuestionAndAnswer]
    @ApplicationName       nvarchar(256),
    @UserName              nvarchar(256),
    @NewPasswordQuestion   nvarchar(256),
    @NewPasswordAnswer     nvarchar(128)
AS
BEGIN
    DECLARE @UserId uniqueidentifier
    SELECT  @UserId = NULL
    SELECT  @UserId = u.UserId
    FROM    dbo.aspnet_Membership m, dbo.aspnet_Users u, dbo.aspnet_Applications a
    WHERE   LoweredUserName = LOWER(@UserName) AND
            u.ApplicationId = a.ApplicationId  AND
            LOWER(@ApplicationName) = a.LoweredApplicationName AND
            u.UserId = m.UserId
    IF (@UserId IS NULL)
    BEGIN
        RETURN(1)
    END

    UPDATE dbo.aspnet_Membership
    SET    PasswordQuestion = @NewPasswordQuestion, PasswordAnswer = @NewPasswordAnswer
    WHERE  UserId=@UserId
    RETURN(0)
END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_Membership_CreateUser]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[aspnet_Membership_CreateUser]
    @ApplicationName                        nvarchar(256),
    @UserName                               nvarchar(256),
    @Password                               nvarchar(128),
    @PasswordSalt                           nvarchar(128),
    @Email                                  nvarchar(256),
    @PasswordQuestion                       nvarchar(256),
    @PasswordAnswer                         nvarchar(128),
    @IsApproved                             bit,
    @CurrentTimeUtc                         datetime,
    @CreateDate                             datetime = NULL,
    @UniqueEmail                            int      = 0,
    @PasswordFormat                         int      = 0,
    @UserId                                 uniqueidentifier OUTPUT
AS
BEGIN
    DECLARE @ApplicationId uniqueidentifier
    SELECT  @ApplicationId = NULL

    DECLARE @NewUserId uniqueidentifier
    SELECT @NewUserId = NULL

    DECLARE @IsLockedOut bit
    SET @IsLockedOut = 0

    DECLARE @LastLockoutDate  datetime
    SET @LastLockoutDate = CONVERT( datetime, '17540101', 112 )

    DECLARE @FailedPasswordAttemptCount int
    SET @FailedPasswordAttemptCount = 0

    DECLARE @FailedPasswordAttemptWindowStart  datetime
    SET @FailedPasswordAttemptWindowStart = CONVERT( datetime, '17540101', 112 )

    DECLARE @FailedPasswordAnswerAttemptCount int
    SET @FailedPasswordAnswerAttemptCount = 0

    DECLARE @FailedPasswordAnswerAttemptWindowStart  datetime
    SET @FailedPasswordAnswerAttemptWindowStart = CONVERT( datetime, '17540101', 112 )

    DECLARE @NewUserCreated bit
    DECLARE @ReturnValue   int
    SET @ReturnValue = 0

    DECLARE @ErrorCode     int
    SET @ErrorCode = 0

    DECLARE @TranStarted   bit
    SET @TranStarted = 0

    IF( @@TRANCOUNT = 0 )
    BEGIN
	    BEGIN TRANSACTION
	    SET @TranStarted = 1
    END
    ELSE
    	SET @TranStarted = 0

    EXEC dbo.aspnet_Applications_CreateApplication @ApplicationName, @ApplicationId OUTPUT

    IF( @@ERROR <> 0 )
    BEGIN
        SET @ErrorCode = -1
        GOTO Cleanup
    END

    SET @CreateDate = @CurrentTimeUtc

    SELECT  @NewUserId = UserId FROM dbo.aspnet_Users WHERE LOWER(@UserName) = LoweredUserName AND @ApplicationId = ApplicationId
    IF ( @NewUserId IS NULL )
    BEGIN
        SET @NewUserId = @UserId
        EXEC @ReturnValue = dbo.aspnet_Users_CreateUser @ApplicationId, @UserName, 0, @CreateDate, @NewUserId OUTPUT
        SET @NewUserCreated = 1
    END
    ELSE
    BEGIN
        SET @NewUserCreated = 0
        IF( @NewUserId <> @UserId AND @UserId IS NOT NULL )
        BEGIN
            SET @ErrorCode = 6
            GOTO Cleanup
        END
    END

    IF( @@ERROR <> 0 )
    BEGIN
        SET @ErrorCode = -1
        GOTO Cleanup
    END

    IF( @ReturnValue = -1 )
    BEGIN
        SET @ErrorCode = 10
        GOTO Cleanup
    END

    IF ( EXISTS ( SELECT UserId
                  FROM   dbo.aspnet_Membership
                  WHERE  @NewUserId = UserId ) )
    BEGIN
        SET @ErrorCode = 6
        GOTO Cleanup
    END

    SET @UserId = @NewUserId

    IF (@UniqueEmail = 1)
    BEGIN
        IF (EXISTS (SELECT *
                    FROM  dbo.aspnet_Membership m WITH ( UPDLOCK, HOLDLOCK )
                    WHERE ApplicationId = @ApplicationId AND LoweredEmail = LOWER(@Email)))
        BEGIN
            SET @ErrorCode = 7
            GOTO Cleanup
        END
    END

    IF (@NewUserCreated = 0)
    BEGIN
        UPDATE dbo.aspnet_Users
        SET    LastActivityDate = @CreateDate
        WHERE  @UserId = UserId
        IF( @@ERROR <> 0 )
        BEGIN
            SET @ErrorCode = -1
            GOTO Cleanup
        END
    END

    INSERT INTO dbo.aspnet_Membership
                ( ApplicationId,
                  UserId,
                  Password,
                  PasswordSalt,
                  Email,
                  LoweredEmail,
                  PasswordQuestion,
                  PasswordAnswer,
                  PasswordFormat,
                  IsApproved,
                  IsLockedOut,
                  CreateDate,
                  LastLoginDate,
                  LastPasswordChangedDate,
                  LastLockoutDate,
                  FailedPasswordAttemptCount,
                  FailedPasswordAttemptWindowStart,
                  FailedPasswordAnswerAttemptCount,
                  FailedPasswordAnswerAttemptWindowStart )
         VALUES ( @ApplicationId,
                  @UserId,
                  @Password,
                  @PasswordSalt,
                  @Email,
                  LOWER(@Email),
                  @PasswordQuestion,
                  @PasswordAnswer,
                  @PasswordFormat,
                  @IsApproved,
                  @IsLockedOut,
                  @CreateDate,
                  @CreateDate,
                  @CreateDate,
                  @LastLockoutDate,
                  @FailedPasswordAttemptCount,
                  @FailedPasswordAttemptWindowStart,
                  @FailedPasswordAnswerAttemptCount,
                  @FailedPasswordAnswerAttemptWindowStart )

    IF( @@ERROR <> 0 )
    BEGIN
        SET @ErrorCode = -1
        GOTO Cleanup
    END

    IF( @TranStarted = 1 )
    BEGIN
	    SET @TranStarted = 0
	    COMMIT TRANSACTION
    END

    RETURN 0

Cleanup:

    IF( @TranStarted = 1 )
    BEGIN
        SET @TranStarted = 0
    	ROLLBACK TRANSACTION
    END

    RETURN @ErrorCode

END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_Membership_FindUsersByEmail]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[aspnet_Membership_FindUsersByEmail]
    @ApplicationName       nvarchar(256),
    @EmailToMatch          nvarchar(256),
    @PageIndex             int,
    @PageSize              int
AS
BEGIN
    DECLARE @ApplicationId uniqueidentifier
    SELECT  @ApplicationId = NULL
    SELECT  @ApplicationId = ApplicationId FROM dbo.aspnet_Applications WHERE LOWER(@ApplicationName) = LoweredApplicationName
    IF (@ApplicationId IS NULL)
        RETURN 0

    -- Set the page bounds
    DECLARE @PageLowerBound int
    DECLARE @PageUpperBound int
    DECLARE @TotalRecords   int
    SET @PageLowerBound = @PageSize * @PageIndex
    SET @PageUpperBound = @PageSize - 1 + @PageLowerBound

    -- Create a temp table TO store the select results
    CREATE TABLE #PageIndexForUsers
    (
        IndexId int IDENTITY (0, 1) NOT NULL,
        UserId uniqueidentifier
    )

    -- Insert into our temp table
    IF( @EmailToMatch IS NULL )
        INSERT INTO #PageIndexForUsers (UserId)
            SELECT u.UserId
            FROM   dbo.aspnet_Users u, dbo.aspnet_Membership m
            WHERE  u.ApplicationId = @ApplicationId AND m.UserId = u.UserId AND m.Email IS NULL
            ORDER BY m.LoweredEmail
    ELSE
        INSERT INTO #PageIndexForUsers (UserId)
            SELECT u.UserId
            FROM   dbo.aspnet_Users u, dbo.aspnet_Membership m
            WHERE  u.ApplicationId = @ApplicationId AND m.UserId = u.UserId AND m.LoweredEmail LIKE LOWER(@EmailToMatch)
            ORDER BY m.LoweredEmail

    SELECT  u.UserName, m.Email, m.PasswordQuestion, m.Comment, m.IsApproved,
            m.CreateDate,
            m.LastLoginDate,
            u.LastActivityDate,
            m.LastPasswordChangedDate,
            u.UserId, m.IsLockedOut,
            m.LastLockoutDate
    FROM   dbo.aspnet_Membership m, dbo.aspnet_Users u, #PageIndexForUsers p
    WHERE  u.UserId = p.UserId AND u.UserId = m.UserId AND
           p.IndexId >= @PageLowerBound AND p.IndexId <= @PageUpperBound
    ORDER BY m.LoweredEmail

    SELECT  @TotalRecords = COUNT(*)
    FROM    #PageIndexForUsers
    RETURN @TotalRecords
END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_Membership_FindUsersByName]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[aspnet_Membership_FindUsersByName]
    @ApplicationName       nvarchar(256),
    @UserNameToMatch       nvarchar(256),
    @PageIndex             int,
    @PageSize              int
AS
BEGIN
    DECLARE @ApplicationId uniqueidentifier
    SELECT  @ApplicationId = NULL
    SELECT  @ApplicationId = ApplicationId FROM dbo.aspnet_Applications WHERE LOWER(@ApplicationName) = LoweredApplicationName
    IF (@ApplicationId IS NULL)
        RETURN 0

    -- Set the page bounds
    DECLARE @PageLowerBound int
    DECLARE @PageUpperBound int
    DECLARE @TotalRecords   int
    SET @PageLowerBound = @PageSize * @PageIndex
    SET @PageUpperBound = @PageSize - 1 + @PageLowerBound

    -- Create a temp table TO store the select results
    CREATE TABLE #PageIndexForUsers
    (
        IndexId int IDENTITY (0, 1) NOT NULL,
        UserId uniqueidentifier
    )

    -- Insert into our temp table
    INSERT INTO #PageIndexForUsers (UserId)
        SELECT u.UserId
        FROM   dbo.aspnet_Users u, dbo.aspnet_Membership m
        WHERE  u.ApplicationId = @ApplicationId AND m.UserId = u.UserId AND u.LoweredUserName LIKE LOWER(@UserNameToMatch)
        ORDER BY u.UserName


    SELECT  u.UserName, m.Email, m.PasswordQuestion, m.Comment, m.IsApproved,
            m.CreateDate,
            m.LastLoginDate,
            u.LastActivityDate,
            m.LastPasswordChangedDate,
            u.UserId, m.IsLockedOut,
            m.LastLockoutDate
    FROM   dbo.aspnet_Membership m, dbo.aspnet_Users u, #PageIndexForUsers p
    WHERE  u.UserId = p.UserId AND u.UserId = m.UserId AND
           p.IndexId >= @PageLowerBound AND p.IndexId <= @PageUpperBound
    ORDER BY u.UserName

    SELECT  @TotalRecords = COUNT(*)
    FROM    #PageIndexForUsers
    RETURN @TotalRecords
END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_Membership_GetAllUsers]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[aspnet_Membership_GetAllUsers]
    @ApplicationName       nvarchar(256),
    @PageIndex             int,
    @PageSize              int
AS
BEGIN
    DECLARE @ApplicationId uniqueidentifier
    SELECT  @ApplicationId = NULL
    SELECT  @ApplicationId = ApplicationId FROM dbo.aspnet_Applications WHERE LOWER(@ApplicationName) = LoweredApplicationName
    IF (@ApplicationId IS NULL)
        RETURN 0


    -- Set the page bounds
    DECLARE @PageLowerBound int
    DECLARE @PageUpperBound int
    DECLARE @TotalRecords   int
    SET @PageLowerBound = @PageSize * @PageIndex
    SET @PageUpperBound = @PageSize - 1 + @PageLowerBound

    -- Create a temp table TO store the select results
    CREATE TABLE #PageIndexForUsers
    (
        IndexId int IDENTITY (0, 1) NOT NULL,
        UserId uniqueidentifier
    )

    -- Insert into our temp table
    INSERT INTO #PageIndexForUsers (UserId)
    SELECT u.UserId
    FROM   dbo.aspnet_Membership m, dbo.aspnet_Users u
    WHERE  u.ApplicationId = @ApplicationId AND u.UserId = m.UserId
    ORDER BY u.UserName

    SELECT @TotalRecords = @@ROWCOUNT

    SELECT u.UserName, m.Email, m.PasswordQuestion, m.Comment, m.IsApproved,
            m.CreateDate,
            m.LastLoginDate,
            u.LastActivityDate,
            m.LastPasswordChangedDate,
            u.UserId, m.IsLockedOut,
            m.LastLockoutDate
    FROM   dbo.aspnet_Membership m, dbo.aspnet_Users u, #PageIndexForUsers p
    WHERE  u.UserId = p.UserId AND u.UserId = m.UserId AND
           p.IndexId >= @PageLowerBound AND p.IndexId <= @PageUpperBound
    ORDER BY u.UserName
    RETURN @TotalRecords
END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_Membership_GetNumberOfUsersOnline]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[aspnet_Membership_GetNumberOfUsersOnline]
    @ApplicationName            nvarchar(256),
    @MinutesSinceLastInActive   int,
    @CurrentTimeUtc             datetime
AS
BEGIN
    DECLARE @DateActive datetime
    SELECT  @DateActive = DATEADD(minute,  -(@MinutesSinceLastInActive), @CurrentTimeUtc)

    DECLARE @NumOnline int
    SELECT  @NumOnline = COUNT(*)
    FROM    dbo.aspnet_Users u(NOLOCK),
            dbo.aspnet_Applications a(NOLOCK),
            dbo.aspnet_Membership m(NOLOCK)
    WHERE   u.ApplicationId = a.ApplicationId                  AND
            LastActivityDate > @DateActive                     AND
            a.LoweredApplicationName = LOWER(@ApplicationName) AND
            u.UserId = m.UserId
    RETURN(@NumOnline)
END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_Membership_GetPassword]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[aspnet_Membership_GetPassword]
    @ApplicationName                nvarchar(256),
    @UserName                       nvarchar(256),
    @MaxInvalidPasswordAttempts     int,
    @PasswordAttemptWindow          int,
    @CurrentTimeUtc                 datetime,
    @PasswordAnswer                 nvarchar(128) = NULL
AS
BEGIN
    DECLARE @UserId                                 uniqueidentifier
    DECLARE @PasswordFormat                         int
    DECLARE @Password                               nvarchar(128)
    DECLARE @passAns                                nvarchar(128)
    DECLARE @IsLockedOut                            bit
    DECLARE @LastLockoutDate                        datetime
    DECLARE @FailedPasswordAttemptCount             int
    DECLARE @FailedPasswordAttemptWindowStart       datetime
    DECLARE @FailedPasswordAnswerAttemptCount       int
    DECLARE @FailedPasswordAnswerAttemptWindowStart datetime

    DECLARE @ErrorCode     int
    SET @ErrorCode = 0

    DECLARE @TranStarted   bit
    SET @TranStarted = 0

    IF( @@TRANCOUNT = 0 )
    BEGIN
	    BEGIN TRANSACTION
	    SET @TranStarted = 1
    END
    ELSE
    	SET @TranStarted = 0

    SELECT  @UserId = u.UserId,
            @Password = m.Password,
            @passAns = m.PasswordAnswer,
            @PasswordFormat = m.PasswordFormat,
            @IsLockedOut = m.IsLockedOut,
            @LastLockoutDate = m.LastLockoutDate,
            @FailedPasswordAttemptCount = m.FailedPasswordAttemptCount,
            @FailedPasswordAttemptWindowStart = m.FailedPasswordAttemptWindowStart,
            @FailedPasswordAnswerAttemptCount = m.FailedPasswordAnswerAttemptCount,
            @FailedPasswordAnswerAttemptWindowStart = m.FailedPasswordAnswerAttemptWindowStart
    FROM    dbo.aspnet_Applications a, dbo.aspnet_Users u, dbo.aspnet_Membership m WITH ( UPDLOCK )
    WHERE   LOWER(@ApplicationName) = a.LoweredApplicationName AND
            u.ApplicationId = a.ApplicationId    AND
            u.UserId = m.UserId AND
            LOWER(@UserName) = u.LoweredUserName

    IF ( @@rowcount = 0 )
    BEGIN
        SET @ErrorCode = 1
        GOTO Cleanup
    END

    IF( @IsLockedOut = 1 )
    BEGIN
        SET @ErrorCode = 99
        GOTO Cleanup
    END

    IF ( NOT( @PasswordAnswer IS NULL ) )
    BEGIN
        IF( ( @passAns IS NULL ) OR ( LOWER( @passAns ) <> LOWER( @PasswordAnswer ) ) )
        BEGIN
            IF( @CurrentTimeUtc > DATEADD( minute, @PasswordAttemptWindow, @FailedPasswordAnswerAttemptWindowStart ) )
            BEGIN
                SET @FailedPasswordAnswerAttemptWindowStart = @CurrentTimeUtc
                SET @FailedPasswordAnswerAttemptCount = 1
            END
            ELSE
            BEGIN
                SET @FailedPasswordAnswerAttemptCount = @FailedPasswordAnswerAttemptCount + 1
                SET @FailedPasswordAnswerAttemptWindowStart = @CurrentTimeUtc
            END

            BEGIN
                IF( @FailedPasswordAnswerAttemptCount >= @MaxInvalidPasswordAttempts )
                BEGIN
                    SET @IsLockedOut = 1
                    SET @LastLockoutDate = @CurrentTimeUtc
                END
            END

            SET @ErrorCode = 3
        END
        ELSE
        BEGIN
            IF( @FailedPasswordAnswerAttemptCount > 0 )
            BEGIN
                SET @FailedPasswordAnswerAttemptCount = 0
                SET @FailedPasswordAnswerAttemptWindowStart = CONVERT( datetime, '17540101', 112 )
            END
        END

        UPDATE dbo.aspnet_Membership
        SET IsLockedOut = @IsLockedOut, LastLockoutDate = @LastLockoutDate,
            FailedPasswordAttemptCount = @FailedPasswordAttemptCount,
            FailedPasswordAttemptWindowStart = @FailedPasswordAttemptWindowStart,
            FailedPasswordAnswerAttemptCount = @FailedPasswordAnswerAttemptCount,
            FailedPasswordAnswerAttemptWindowStart = @FailedPasswordAnswerAttemptWindowStart
        WHERE @UserId = UserId

        IF( @@ERROR <> 0 )
        BEGIN
            SET @ErrorCode = -1
            GOTO Cleanup
        END
    END

    IF( @TranStarted = 1 )
    BEGIN
	SET @TranStarted = 0
	COMMIT TRANSACTION
    END

    IF( @ErrorCode = 0 )
        SELECT @Password, @PasswordFormat

    RETURN @ErrorCode

Cleanup:

    IF( @TranStarted = 1 )
    BEGIN
        SET @TranStarted = 0
    	ROLLBACK TRANSACTION
    END

    RETURN @ErrorCode

END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_Membership_GetPasswordWithFormat]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[aspnet_Membership_GetPasswordWithFormat]
    @ApplicationName                nvarchar(256),
    @UserName                       nvarchar(256),
    @UpdateLastLoginActivityDate    bit,
    @CurrentTimeUtc                 datetime
AS
BEGIN
    DECLARE @IsLockedOut                        bit
    DECLARE @UserId                             uniqueidentifier
    DECLARE @Password                           nvarchar(128)
    DECLARE @PasswordSalt                       nvarchar(128)
    DECLARE @PasswordFormat                     int
    DECLARE @FailedPasswordAttemptCount         int
    DECLARE @FailedPasswordAnswerAttemptCount   int
    DECLARE @IsApproved                         bit
    DECLARE @LastActivityDate                   datetime
    DECLARE @LastLoginDate                      datetime

    SELECT  @UserId          = NULL

    SELECT  @UserId = u.UserId, @IsLockedOut = m.IsLockedOut, @Password=Password, @PasswordFormat=PasswordFormat,
            @PasswordSalt=PasswordSalt, @FailedPasswordAttemptCount=FailedPasswordAttemptCount,
		    @FailedPasswordAnswerAttemptCount=FailedPasswordAnswerAttemptCount, @IsApproved=IsApproved,
            @LastActivityDate = LastActivityDate, @LastLoginDate = LastLoginDate
    FROM    dbo.aspnet_Applications a, dbo.aspnet_Users u, dbo.aspnet_Membership m
    WHERE   LOWER(@ApplicationName) = a.LoweredApplicationName AND
            u.ApplicationId = a.ApplicationId    AND
            u.UserId = m.UserId AND
            LOWER(@UserName) = u.LoweredUserName

    IF (@UserId IS NULL)
        RETURN 1

    IF (@IsLockedOut = 1)
        RETURN 99

    SELECT   @Password, @PasswordFormat, @PasswordSalt, @FailedPasswordAttemptCount,
             @FailedPasswordAnswerAttemptCount, @IsApproved, @LastLoginDate, @LastActivityDate

    IF (@UpdateLastLoginActivityDate = 1 AND @IsApproved = 1)
    BEGIN
        UPDATE  dbo.aspnet_Membership
        SET     LastLoginDate = @CurrentTimeUtc
        WHERE   UserId = @UserId

        UPDATE  dbo.aspnet_Users
        SET     LastActivityDate = @CurrentTimeUtc
        WHERE   @UserId = UserId
    END


    RETURN 0
END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_Membership_GetUserByEmail]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[aspnet_Membership_GetUserByEmail]
    @ApplicationName  nvarchar(256),
    @Email            nvarchar(256)
AS
BEGIN
    IF( @Email IS NULL )
        SELECT  u.UserName
        FROM    dbo.aspnet_Applications a, dbo.aspnet_Users u, dbo.aspnet_Membership m
        WHERE   LOWER(@ApplicationName) = a.LoweredApplicationName AND
                u.ApplicationId = a.ApplicationId    AND
                u.UserId = m.UserId AND
                m.ApplicationId = a.ApplicationId AND
                m.LoweredEmail IS NULL
    ELSE
        SELECT  u.UserName
        FROM    dbo.aspnet_Applications a, dbo.aspnet_Users u, dbo.aspnet_Membership m
        WHERE   LOWER(@ApplicationName) = a.LoweredApplicationName AND
                u.ApplicationId = a.ApplicationId    AND
                u.UserId = m.UserId AND
                m.ApplicationId = a.ApplicationId AND
                LOWER(@Email) = m.LoweredEmail

    IF (@@rowcount = 0)
        RETURN(1)
    RETURN(0)
END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_Membership_GetUserByName]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[aspnet_Membership_GetUserByName]
    @ApplicationName      nvarchar(256),
    @UserName             nvarchar(256),
    @CurrentTimeUtc       datetime,
    @UpdateLastActivity   bit = 0
AS
BEGIN
    DECLARE @UserId uniqueidentifier

    IF (@UpdateLastActivity = 1)
    BEGIN
        -- select user ID from aspnet_users table
        SELECT TOP 1 @UserId = u.UserId
        FROM    dbo.aspnet_Applications a, dbo.aspnet_Users u, dbo.aspnet_Membership m
        WHERE    LOWER(@ApplicationName) = a.LoweredApplicationName AND
                u.ApplicationId = a.ApplicationId    AND
                LOWER(@UserName) = u.LoweredUserName AND u.UserId = m.UserId

        IF (@@ROWCOUNT = 0) -- Username not found
            RETURN -1

        UPDATE   dbo.aspnet_Users
        SET      LastActivityDate = @CurrentTimeUtc
        WHERE    @UserId = UserId

        SELECT m.Email, m.PasswordQuestion, m.Comment, m.IsApproved,
                m.CreateDate, m.LastLoginDate, u.LastActivityDate, m.LastPasswordChangedDate,
                u.UserId, m.IsLockedOut, m.LastLockoutDate
        FROM    dbo.aspnet_Applications a, dbo.aspnet_Users u, dbo.aspnet_Membership m
        WHERE  @UserId = u.UserId AND u.UserId = m.UserId 
    END
    ELSE
    BEGIN
        SELECT TOP 1 m.Email, m.PasswordQuestion, m.Comment, m.IsApproved,
                m.CreateDate, m.LastLoginDate, u.LastActivityDate, m.LastPasswordChangedDate,
                u.UserId, m.IsLockedOut,m.LastLockoutDate
        FROM    dbo.aspnet_Applications a, dbo.aspnet_Users u, dbo.aspnet_Membership m
        WHERE    LOWER(@ApplicationName) = a.LoweredApplicationName AND
                u.ApplicationId = a.ApplicationId    AND
                LOWER(@UserName) = u.LoweredUserName AND u.UserId = m.UserId

        IF (@@ROWCOUNT = 0) -- Username not found
            RETURN -1
    END

    RETURN 0
END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_Membership_GetUserByUserId]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[aspnet_Membership_GetUserByUserId]
    @UserId               uniqueidentifier,
    @CurrentTimeUtc       datetime,
    @UpdateLastActivity   bit = 0
AS
BEGIN
    IF ( @UpdateLastActivity = 1 )
    BEGIN
        UPDATE   dbo.aspnet_Users
        SET      LastActivityDate = @CurrentTimeUtc
        FROM     dbo.aspnet_Users
        WHERE    @UserId = UserId

        IF ( @@ROWCOUNT = 0 ) -- User ID not found
            RETURN -1
    END

    SELECT  m.Email, m.PasswordQuestion, m.Comment, m.IsApproved,
            m.CreateDate, m.LastLoginDate, u.LastActivityDate,
            m.LastPasswordChangedDate, u.UserName, m.IsLockedOut,
            m.LastLockoutDate
    FROM    dbo.aspnet_Users u, dbo.aspnet_Membership m
    WHERE   @UserId = u.UserId AND u.UserId = m.UserId

    IF ( @@ROWCOUNT = 0 ) -- User ID not found
       RETURN -1

    RETURN 0
END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_Membership_ResetPassword]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[aspnet_Membership_ResetPassword]
    @ApplicationName             nvarchar(256),
    @UserName                    nvarchar(256),
    @NewPassword                 nvarchar(128),
    @MaxInvalidPasswordAttempts  int,
    @PasswordAttemptWindow       int,
    @PasswordSalt                nvarchar(128),
    @CurrentTimeUtc              datetime,
    @PasswordFormat              int = 0,
    @PasswordAnswer              nvarchar(128) = NULL
AS
BEGIN
    DECLARE @IsLockedOut                            bit
    DECLARE @LastLockoutDate                        datetime
    DECLARE @FailedPasswordAttemptCount             int
    DECLARE @FailedPasswordAttemptWindowStart       datetime
    DECLARE @FailedPasswordAnswerAttemptCount       int
    DECLARE @FailedPasswordAnswerAttemptWindowStart datetime

    DECLARE @UserId                                 uniqueidentifier
    SET     @UserId = NULL

    DECLARE @ErrorCode     int
    SET @ErrorCode = 0

    DECLARE @TranStarted   bit
    SET @TranStarted = 0

    IF( @@TRANCOUNT = 0 )
    BEGIN
	    BEGIN TRANSACTION
	    SET @TranStarted = 1
    END
    ELSE
    	SET @TranStarted = 0

    SELECT  @UserId = u.UserId
    FROM    dbo.aspnet_Users u, dbo.aspnet_Applications a, dbo.aspnet_Membership m
    WHERE   LoweredUserName = LOWER(@UserName) AND
            u.ApplicationId = a.ApplicationId  AND
            LOWER(@ApplicationName) = a.LoweredApplicationName AND
            u.UserId = m.UserId

    IF ( @UserId IS NULL )
    BEGIN
        SET @ErrorCode = 1
        GOTO Cleanup
    END

    SELECT @IsLockedOut = IsLockedOut,
           @LastLockoutDate = LastLockoutDate,
           @FailedPasswordAttemptCount = FailedPasswordAttemptCount,
           @FailedPasswordAttemptWindowStart = FailedPasswordAttemptWindowStart,
           @FailedPasswordAnswerAttemptCount = FailedPasswordAnswerAttemptCount,
           @FailedPasswordAnswerAttemptWindowStart = FailedPasswordAnswerAttemptWindowStart
    FROM dbo.aspnet_Membership WITH ( UPDLOCK )
    WHERE @UserId = UserId

    IF( @IsLockedOut = 1 )
    BEGIN
        SET @ErrorCode = 99
        GOTO Cleanup
    END

    UPDATE dbo.aspnet_Membership
    SET    Password = @NewPassword,
           LastPasswordChangedDate = @CurrentTimeUtc,
           PasswordFormat = @PasswordFormat,
           PasswordSalt = @PasswordSalt
    WHERE  @UserId = UserId AND
           ( ( @PasswordAnswer IS NULL ) OR ( LOWER( PasswordAnswer ) = LOWER( @PasswordAnswer ) ) )

    IF ( @@ROWCOUNT = 0 )
        BEGIN
            IF( @CurrentTimeUtc > DATEADD( minute, @PasswordAttemptWindow, @FailedPasswordAnswerAttemptWindowStart ) )
            BEGIN
                SET @FailedPasswordAnswerAttemptWindowStart = @CurrentTimeUtc
                SET @FailedPasswordAnswerAttemptCount = 1
            END
            ELSE
            BEGIN
                SET @FailedPasswordAnswerAttemptWindowStart = @CurrentTimeUtc
                SET @FailedPasswordAnswerAttemptCount = @FailedPasswordAnswerAttemptCount + 1
            END

            BEGIN
                IF( @FailedPasswordAnswerAttemptCount >= @MaxInvalidPasswordAttempts )
                BEGIN
                    SET @IsLockedOut = 1
                    SET @LastLockoutDate = @CurrentTimeUtc
                END
            END

            SET @ErrorCode = 3
        END
    ELSE
        BEGIN
            IF( @FailedPasswordAnswerAttemptCount > 0 )
            BEGIN
                SET @FailedPasswordAnswerAttemptCount = 0
                SET @FailedPasswordAnswerAttemptWindowStart = CONVERT( datetime, '17540101', 112 )
            END
        END

    IF( NOT ( @PasswordAnswer IS NULL ) )
    BEGIN
        UPDATE dbo.aspnet_Membership
        SET IsLockedOut = @IsLockedOut, LastLockoutDate = @LastLockoutDate,
            FailedPasswordAttemptCount = @FailedPasswordAttemptCount,
            FailedPasswordAttemptWindowStart = @FailedPasswordAttemptWindowStart,
            FailedPasswordAnswerAttemptCount = @FailedPasswordAnswerAttemptCount,
            FailedPasswordAnswerAttemptWindowStart = @FailedPasswordAnswerAttemptWindowStart
        WHERE @UserId = UserId

        IF( @@ERROR <> 0 )
        BEGIN
            SET @ErrorCode = -1
            GOTO Cleanup
        END
    END

    IF( @TranStarted = 1 )
    BEGIN
	SET @TranStarted = 0
	COMMIT TRANSACTION
    END

    RETURN @ErrorCode

Cleanup:

    IF( @TranStarted = 1 )
    BEGIN
        SET @TranStarted = 0
    	ROLLBACK TRANSACTION
    END

    RETURN @ErrorCode

END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_Membership_SetPassword]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[aspnet_Membership_SetPassword]
    @ApplicationName  nvarchar(256),
    @UserName         nvarchar(256),
    @NewPassword      nvarchar(128),
    @PasswordSalt     nvarchar(128),
    @CurrentTimeUtc   datetime,
    @PasswordFormat   int = 0
AS
BEGIN
    DECLARE @UserId uniqueidentifier
    SELECT  @UserId = NULL
    SELECT  @UserId = u.UserId
    FROM    dbo.aspnet_Users u, dbo.aspnet_Applications a, dbo.aspnet_Membership m
    WHERE   LoweredUserName = LOWER(@UserName) AND
            u.ApplicationId = a.ApplicationId  AND
            LOWER(@ApplicationName) = a.LoweredApplicationName AND
            u.UserId = m.UserId

    IF (@UserId IS NULL)
        RETURN(1)

    UPDATE dbo.aspnet_Membership
    SET Password = @NewPassword, PasswordFormat = @PasswordFormat, PasswordSalt = @PasswordSalt,
        LastPasswordChangedDate = @CurrentTimeUtc
    WHERE @UserId = UserId
    RETURN(0)
END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_Membership_UnlockUser]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[aspnet_Membership_UnlockUser]
    @ApplicationName                         nvarchar(256),
    @UserName                                nvarchar(256)
AS
BEGIN
    DECLARE @UserId uniqueidentifier
    SELECT  @UserId = NULL
    SELECT  @UserId = u.UserId
    FROM    dbo.aspnet_Users u, dbo.aspnet_Applications a, dbo.aspnet_Membership m
    WHERE   LoweredUserName = LOWER(@UserName) AND
            u.ApplicationId = a.ApplicationId  AND
            LOWER(@ApplicationName) = a.LoweredApplicationName AND
            u.UserId = m.UserId

    IF ( @UserId IS NULL )
        RETURN 1

    UPDATE dbo.aspnet_Membership
    SET IsLockedOut = 0,
        FailedPasswordAttemptCount = 0,
        FailedPasswordAttemptWindowStart = CONVERT( datetime, '17540101', 112 ),
        FailedPasswordAnswerAttemptCount = 0,
        FailedPasswordAnswerAttemptWindowStart = CONVERT( datetime, '17540101', 112 ),
        LastLockoutDate = CONVERT( datetime, '17540101', 112 )
    WHERE @UserId = UserId

    RETURN 0
END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_Membership_UpdateUser]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[aspnet_Membership_UpdateUser]
    @ApplicationName      nvarchar(256),
    @UserName             nvarchar(256),
    @Email                nvarchar(256),
    @Comment              ntext,
    @IsApproved           bit,
    @LastLoginDate        datetime,
    @LastActivityDate     datetime,
    @UniqueEmail          int,
    @CurrentTimeUtc       datetime
AS
BEGIN
    DECLARE @UserId uniqueidentifier
    DECLARE @ApplicationId uniqueidentifier
    SELECT  @UserId = NULL
    SELECT  @UserId = u.UserId, @ApplicationId = a.ApplicationId
    FROM    dbo.aspnet_Users u, dbo.aspnet_Applications a, dbo.aspnet_Membership m
    WHERE   LoweredUserName = LOWER(@UserName) AND
            u.ApplicationId = a.ApplicationId  AND
            LOWER(@ApplicationName) = a.LoweredApplicationName AND
            u.UserId = m.UserId

    IF (@UserId IS NULL)
        RETURN(1)

    IF (@UniqueEmail = 1)
    BEGIN
        IF (EXISTS (SELECT *
                    FROM  dbo.aspnet_Membership WITH (UPDLOCK, HOLDLOCK)
                    WHERE ApplicationId = @ApplicationId  AND @UserId <> UserId AND LoweredEmail = LOWER(@Email)))
        BEGIN
            RETURN(7)
        END
    END

    DECLARE @TranStarted   bit
    SET @TranStarted = 0

    IF( @@TRANCOUNT = 0 )
    BEGIN
	    BEGIN TRANSACTION
	    SET @TranStarted = 1
    END
    ELSE
	SET @TranStarted = 0

    UPDATE dbo.aspnet_Users WITH (ROWLOCK)
    SET
         LastActivityDate = @LastActivityDate
    WHERE
       @UserId = UserId

    IF( @@ERROR <> 0 )
        GOTO Cleanup

    UPDATE dbo.aspnet_Membership WITH (ROWLOCK)
    SET
         Email            = @Email,
         LoweredEmail     = LOWER(@Email),
         Comment          = @Comment,
         IsApproved       = @IsApproved,
         LastLoginDate    = @LastLoginDate
    WHERE
       @UserId = UserId

    IF( @@ERROR <> 0 )
        GOTO Cleanup

    IF( @TranStarted = 1 )
    BEGIN
	SET @TranStarted = 0
	COMMIT TRANSACTION
    END

    RETURN 0

Cleanup:

    IF( @TranStarted = 1 )
    BEGIN
        SET @TranStarted = 0
    	ROLLBACK TRANSACTION
    END

    RETURN -1
END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_Membership_UpdateUserInfo]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[aspnet_Membership_UpdateUserInfo]
    @ApplicationName                nvarchar(256),
    @UserName                       nvarchar(256),
    @IsPasswordCorrect              bit,
    @UpdateLastLoginActivityDate    bit,
    @MaxInvalidPasswordAttempts     int,
    @PasswordAttemptWindow          int,
    @CurrentTimeUtc                 datetime,
    @LastLoginDate                  datetime,
    @LastActivityDate               datetime
AS
BEGIN
    DECLARE @UserId                                 uniqueidentifier
    DECLARE @IsApproved                             bit
    DECLARE @IsLockedOut                            bit
    DECLARE @LastLockoutDate                        datetime
    DECLARE @FailedPasswordAttemptCount             int
    DECLARE @FailedPasswordAttemptWindowStart       datetime
    DECLARE @FailedPasswordAnswerAttemptCount       int
    DECLARE @FailedPasswordAnswerAttemptWindowStart datetime

    DECLARE @ErrorCode     int
    SET @ErrorCode = 0

    DECLARE @TranStarted   bit
    SET @TranStarted = 0

    IF( @@TRANCOUNT = 0 )
    BEGIN
	    BEGIN TRANSACTION
	    SET @TranStarted = 1
    END
    ELSE
    	SET @TranStarted = 0

    SELECT  @UserId = u.UserId,
            @IsApproved = m.IsApproved,
            @IsLockedOut = m.IsLockedOut,
            @LastLockoutDate = m.LastLockoutDate,
            @FailedPasswordAttemptCount = m.FailedPasswordAttemptCount,
            @FailedPasswordAttemptWindowStart = m.FailedPasswordAttemptWindowStart,
            @FailedPasswordAnswerAttemptCount = m.FailedPasswordAnswerAttemptCount,
            @FailedPasswordAnswerAttemptWindowStart = m.FailedPasswordAnswerAttemptWindowStart
    FROM    dbo.aspnet_Applications a, dbo.aspnet_Users u, dbo.aspnet_Membership m WITH ( UPDLOCK )
    WHERE   LOWER(@ApplicationName) = a.LoweredApplicationName AND
            u.ApplicationId = a.ApplicationId    AND
            u.UserId = m.UserId AND
            LOWER(@UserName) = u.LoweredUserName

    IF ( @@rowcount = 0 )
    BEGIN
        SET @ErrorCode = 1
        GOTO Cleanup
    END

    IF( @IsLockedOut = 1 )
    BEGIN
        GOTO Cleanup
    END

    IF( @IsPasswordCorrect = 0 )
    BEGIN
        IF( @CurrentTimeUtc > DATEADD( minute, @PasswordAttemptWindow, @FailedPasswordAttemptWindowStart ) )
        BEGIN
            SET @FailedPasswordAttemptWindowStart = @CurrentTimeUtc
            SET @FailedPasswordAttemptCount = 1
        END
        ELSE
        BEGIN
            SET @FailedPasswordAttemptWindowStart = @CurrentTimeUtc
            SET @FailedPasswordAttemptCount = @FailedPasswordAttemptCount + 1
        END

        BEGIN
            IF( @FailedPasswordAttemptCount >= @MaxInvalidPasswordAttempts )
            BEGIN
                SET @IsLockedOut = 1
                SET @LastLockoutDate = @CurrentTimeUtc
            END
        END
    END
    ELSE
    BEGIN
        IF( @FailedPasswordAttemptCount > 0 OR @FailedPasswordAnswerAttemptCount > 0 )
        BEGIN
            SET @FailedPasswordAttemptCount = 0
            SET @FailedPasswordAttemptWindowStart = CONVERT( datetime, '17540101', 112 )
            SET @FailedPasswordAnswerAttemptCount = 0
            SET @FailedPasswordAnswerAttemptWindowStart = CONVERT( datetime, '17540101', 112 )
            SET @LastLockoutDate = CONVERT( datetime, '17540101', 112 )
        END
    END

    IF( @UpdateLastLoginActivityDate = 1 )
    BEGIN
        UPDATE  dbo.aspnet_Users
        SET     LastActivityDate = @LastActivityDate
        WHERE   @UserId = UserId

        IF( @@ERROR <> 0 )
        BEGIN
            SET @ErrorCode = -1
            GOTO Cleanup
        END

        UPDATE  dbo.aspnet_Membership
        SET     LastLoginDate = @LastLoginDate
        WHERE   UserId = @UserId

        IF( @@ERROR <> 0 )
        BEGIN
            SET @ErrorCode = -1
            GOTO Cleanup
        END
    END


    UPDATE dbo.aspnet_Membership
    SET IsLockedOut = @IsLockedOut, LastLockoutDate = @LastLockoutDate,
        FailedPasswordAttemptCount = @FailedPasswordAttemptCount,
        FailedPasswordAttemptWindowStart = @FailedPasswordAttemptWindowStart,
        FailedPasswordAnswerAttemptCount = @FailedPasswordAnswerAttemptCount,
        FailedPasswordAnswerAttemptWindowStart = @FailedPasswordAnswerAttemptWindowStart
    WHERE @UserId = UserId

    IF( @@ERROR <> 0 )
    BEGIN
        SET @ErrorCode = -1
        GOTO Cleanup
    END

    IF( @TranStarted = 1 )
    BEGIN
	SET @TranStarted = 0
	COMMIT TRANSACTION
    END

    RETURN @ErrorCode

Cleanup:

    IF( @TranStarted = 1 )
    BEGIN
        SET @TranStarted = 0
    	ROLLBACK TRANSACTION
    END

    RETURN @ErrorCode

END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_Paths_CreatePath]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[aspnet_Paths_CreatePath]
    @ApplicationId UNIQUEIDENTIFIER,
    @Path           NVARCHAR(256),
    @PathId         UNIQUEIDENTIFIER OUTPUT
AS
BEGIN
    BEGIN TRANSACTION
    IF (NOT EXISTS(SELECT * FROM dbo.aspnet_Paths WHERE LoweredPath = LOWER(@Path) AND ApplicationId = @ApplicationId))
    BEGIN
        INSERT dbo.aspnet_Paths (ApplicationId, Path, LoweredPath) VALUES (@ApplicationId, @Path, LOWER(@Path))
    END
    COMMIT TRANSACTION
    SELECT @PathId = PathId FROM dbo.aspnet_Paths WHERE LOWER(@Path) = LoweredPath AND ApplicationId = @ApplicationId
END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_Personalization_GetApplicationId]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[aspnet_Personalization_GetApplicationId] (
    @ApplicationName NVARCHAR(256),
    @ApplicationId UNIQUEIDENTIFIER OUT)
AS
BEGIN
    SELECT @ApplicationId = ApplicationId FROM dbo.aspnet_Applications WHERE LOWER(@ApplicationName) = LoweredApplicationName
END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_PersonalizationAdministration_DeleteAllState]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[aspnet_PersonalizationAdministration_DeleteAllState] (
    @AllUsersScope bit,
    @ApplicationName NVARCHAR(256),
    @Count int OUT)
AS
BEGIN
    DECLARE @ApplicationId UNIQUEIDENTIFIER
    EXEC dbo.aspnet_Personalization_GetApplicationId @ApplicationName, @ApplicationId OUTPUT
    IF (@ApplicationId IS NULL)
        SELECT @Count = 0
    ELSE
    BEGIN
        IF (@AllUsersScope = 1)
            DELETE FROM aspnet_PersonalizationAllUsers
            WHERE PathId IN
               (SELECT Paths.PathId
                FROM dbo.aspnet_Paths Paths
                WHERE Paths.ApplicationId = @ApplicationId)
        ELSE
            DELETE FROM aspnet_PersonalizationPerUser
            WHERE PathId IN
               (SELECT Paths.PathId
                FROM dbo.aspnet_Paths Paths
                WHERE Paths.ApplicationId = @ApplicationId)

        SELECT @Count = @@ROWCOUNT
    END
END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_PersonalizationAdministration_FindState]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[aspnet_PersonalizationAdministration_FindState] (
    @AllUsersScope bit,
    @ApplicationName NVARCHAR(256),
    @PageIndex              INT,
    @PageSize               INT,
    @Path NVARCHAR(256) = NULL,
    @UserName NVARCHAR(256) = NULL,
    @InactiveSinceDate DATETIME = NULL)
AS
BEGIN
    DECLARE @ApplicationId UNIQUEIDENTIFIER
    EXEC dbo.aspnet_Personalization_GetApplicationId @ApplicationName, @ApplicationId OUTPUT
    IF (@ApplicationId IS NULL)
        RETURN

    -- Set the page bounds
    DECLARE @PageLowerBound INT
    DECLARE @PageUpperBound INT
    DECLARE @TotalRecords   INT
    SET @PageLowerBound = @PageSize * @PageIndex
    SET @PageUpperBound = @PageSize - 1 + @PageLowerBound

    -- Create a temp table to store the selected results
    CREATE TABLE #PageIndex (
        IndexId int IDENTITY (0, 1) NOT NULL,
        ItemId UNIQUEIDENTIFIER
    )

    IF (@AllUsersScope = 1)
    BEGIN
        -- Insert into our temp table
        INSERT INTO #PageIndex (ItemId)
        SELECT Paths.PathId
        FROM dbo.aspnet_Paths Paths,
             ((SELECT Paths.PathId
               FROM dbo.aspnet_PersonalizationAllUsers AllUsers, dbo.aspnet_Paths Paths
               WHERE Paths.ApplicationId = @ApplicationId
                      AND AllUsers.PathId = Paths.PathId
                      AND (@Path IS NULL OR Paths.LoweredPath LIKE LOWER(@Path))
              ) AS SharedDataPerPath
              FULL OUTER JOIN
              (SELECT DISTINCT Paths.PathId
               FROM dbo.aspnet_PersonalizationPerUser PerUser, dbo.aspnet_Paths Paths
               WHERE Paths.ApplicationId = @ApplicationId
                      AND PerUser.PathId = Paths.PathId
                      AND (@Path IS NULL OR Paths.LoweredPath LIKE LOWER(@Path))
              ) AS UserDataPerPath
              ON SharedDataPerPath.PathId = UserDataPerPath.PathId
             )
        WHERE Paths.PathId = SharedDataPerPath.PathId OR Paths.PathId = UserDataPerPath.PathId
        ORDER BY Paths.Path ASC

        SELECT @TotalRecords = @@ROWCOUNT

        SELECT Paths.Path,
               SharedDataPerPath.LastUpdatedDate,
               SharedDataPerPath.SharedDataLength,
               UserDataPerPath.UserDataLength,
               UserDataPerPath.UserCount
        FROM dbo.aspnet_Paths Paths,
             ((SELECT PageIndex.ItemId AS PathId,
                      AllUsers.LastUpdatedDate AS LastUpdatedDate,
                      DATALENGTH(AllUsers.PageSettings) AS SharedDataLength
               FROM dbo.aspnet_PersonalizationAllUsers AllUsers, #PageIndex PageIndex
               WHERE AllUsers.PathId = PageIndex.ItemId
                     AND PageIndex.IndexId >= @PageLowerBound AND PageIndex.IndexId <= @PageUpperBound
              ) AS SharedDataPerPath
              FULL OUTER JOIN
              (SELECT PageIndex.ItemId AS PathId,
                      SUM(DATALENGTH(PerUser.PageSettings)) AS UserDataLength,
                      COUNT(*) AS UserCount
               FROM aspnet_PersonalizationPerUser PerUser, #PageIndex PageIndex
               WHERE PerUser.PathId = PageIndex.ItemId
                     AND PageIndex.IndexId >= @PageLowerBound AND PageIndex.IndexId <= @PageUpperBound
               GROUP BY PageIndex.ItemId
              ) AS UserDataPerPath
              ON SharedDataPerPath.PathId = UserDataPerPath.PathId
             )
        WHERE Paths.PathId = SharedDataPerPath.PathId OR Paths.PathId = UserDataPerPath.PathId
        ORDER BY Paths.Path ASC
    END
    ELSE
    BEGIN
        -- Insert into our temp table
        INSERT INTO #PageIndex (ItemId)
        SELECT PerUser.Id
        FROM dbo.aspnet_PersonalizationPerUser PerUser, dbo.aspnet_Users Users, dbo.aspnet_Paths Paths
        WHERE Paths.ApplicationId = @ApplicationId
              AND PerUser.UserId = Users.UserId
              AND PerUser.PathId = Paths.PathId
              AND (@Path IS NULL OR Paths.LoweredPath LIKE LOWER(@Path))
              AND (@UserName IS NULL OR Users.LoweredUserName LIKE LOWER(@UserName))
              AND (@InactiveSinceDate IS NULL OR Users.LastActivityDate <= @InactiveSinceDate)
        ORDER BY Paths.Path ASC, Users.UserName ASC

        SELECT @TotalRecords = @@ROWCOUNT

        SELECT Paths.Path, PerUser.LastUpdatedDate, DATALENGTH(PerUser.PageSettings), Users.UserName, Users.LastActivityDate
        FROM dbo.aspnet_PersonalizationPerUser PerUser, dbo.aspnet_Users Users, dbo.aspnet_Paths Paths, #PageIndex PageIndex
        WHERE PerUser.Id = PageIndex.ItemId
              AND PerUser.UserId = Users.UserId
              AND PerUser.PathId = Paths.PathId
              AND PageIndex.IndexId >= @PageLowerBound AND PageIndex.IndexId <= @PageUpperBound
        ORDER BY Paths.Path ASC, Users.UserName ASC
    END

    RETURN @TotalRecords
END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_PersonalizationAdministration_GetCountOfState]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[aspnet_PersonalizationAdministration_GetCountOfState] (
    @Count int OUT,
    @AllUsersScope bit,
    @ApplicationName NVARCHAR(256),
    @Path NVARCHAR(256) = NULL,
    @UserName NVARCHAR(256) = NULL,
    @InactiveSinceDate DATETIME = NULL)
AS
BEGIN

    DECLARE @ApplicationId UNIQUEIDENTIFIER
    EXEC dbo.aspnet_Personalization_GetApplicationId @ApplicationName, @ApplicationId OUTPUT
    IF (@ApplicationId IS NULL)
        SELECT @Count = 0
    ELSE
        IF (@AllUsersScope = 1)
            SELECT @Count = COUNT(*)
            FROM dbo.aspnet_PersonalizationAllUsers AllUsers, dbo.aspnet_Paths Paths
            WHERE Paths.ApplicationId = @ApplicationId
                  AND AllUsers.PathId = Paths.PathId
                  AND (@Path IS NULL OR Paths.LoweredPath LIKE LOWER(@Path))
        ELSE
            SELECT @Count = COUNT(*)
            FROM dbo.aspnet_PersonalizationPerUser PerUser, dbo.aspnet_Users Users, dbo.aspnet_Paths Paths
            WHERE Paths.ApplicationId = @ApplicationId
                  AND PerUser.UserId = Users.UserId
                  AND PerUser.PathId = Paths.PathId
                  AND (@Path IS NULL OR Paths.LoweredPath LIKE LOWER(@Path))
                  AND (@UserName IS NULL OR Users.LoweredUserName LIKE LOWER(@UserName))
                  AND (@InactiveSinceDate IS NULL OR Users.LastActivityDate <= @InactiveSinceDate)
END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_PersonalizationAdministration_ResetSharedState]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[aspnet_PersonalizationAdministration_ResetSharedState] (
    @Count int OUT,
    @ApplicationName NVARCHAR(256),
    @Path NVARCHAR(256))
AS
BEGIN
    DECLARE @ApplicationId UNIQUEIDENTIFIER
    EXEC dbo.aspnet_Personalization_GetApplicationId @ApplicationName, @ApplicationId OUTPUT
    IF (@ApplicationId IS NULL)
        SELECT @Count = 0
    ELSE
    BEGIN
        DELETE FROM dbo.aspnet_PersonalizationAllUsers
        WHERE PathId IN
            (SELECT AllUsers.PathId
             FROM dbo.aspnet_PersonalizationAllUsers AllUsers, dbo.aspnet_Paths Paths
             WHERE Paths.ApplicationId = @ApplicationId
                   AND AllUsers.PathId = Paths.PathId
                   AND Paths.LoweredPath = LOWER(@Path))

        SELECT @Count = @@ROWCOUNT
    END
END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_PersonalizationAdministration_ResetUserState]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[aspnet_PersonalizationAdministration_ResetUserState] (
    @Count                  int                 OUT,
    @ApplicationName        NVARCHAR(256),
    @InactiveSinceDate      DATETIME            = NULL,
    @UserName               NVARCHAR(256)       = NULL,
    @Path                   NVARCHAR(256)       = NULL)
AS
BEGIN
    DECLARE @ApplicationId UNIQUEIDENTIFIER
    EXEC dbo.aspnet_Personalization_GetApplicationId @ApplicationName, @ApplicationId OUTPUT
    IF (@ApplicationId IS NULL)
        SELECT @Count = 0
    ELSE
    BEGIN
        DELETE FROM dbo.aspnet_PersonalizationPerUser
        WHERE Id IN (SELECT PerUser.Id
                     FROM dbo.aspnet_PersonalizationPerUser PerUser, dbo.aspnet_Users Users, dbo.aspnet_Paths Paths
                     WHERE Paths.ApplicationId = @ApplicationId
                           AND PerUser.UserId = Users.UserId
                           AND PerUser.PathId = Paths.PathId
                           AND (@InactiveSinceDate IS NULL OR Users.LastActivityDate <= @InactiveSinceDate)
                           AND (@UserName IS NULL OR Users.LoweredUserName = LOWER(@UserName))
                           AND (@Path IS NULL OR Paths.LoweredPath = LOWER(@Path)))

        SELECT @Count = @@ROWCOUNT
    END
END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_PersonalizationAllUsers_GetPageSettings]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[aspnet_PersonalizationAllUsers_GetPageSettings] (
    @ApplicationName  NVARCHAR(256),
    @Path              NVARCHAR(256))
AS
BEGIN
    DECLARE @ApplicationId UNIQUEIDENTIFIER
    DECLARE @PathId UNIQUEIDENTIFIER

    SELECT @ApplicationId = NULL
    SELECT @PathId = NULL

    EXEC dbo.aspnet_Personalization_GetApplicationId @ApplicationName, @ApplicationId OUTPUT
    IF (@ApplicationId IS NULL)
    BEGIN
        RETURN
    END

    SELECT @PathId = u.PathId FROM dbo.aspnet_Paths u WHERE u.ApplicationId = @ApplicationId AND u.LoweredPath = LOWER(@Path)
    IF (@PathId IS NULL)
    BEGIN
        RETURN
    END

    SELECT p.PageSettings FROM dbo.aspnet_PersonalizationAllUsers p WHERE p.PathId = @PathId
END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_PersonalizationAllUsers_ResetPageSettings]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[aspnet_PersonalizationAllUsers_ResetPageSettings] (
    @ApplicationName  NVARCHAR(256),
    @Path              NVARCHAR(256))
AS
BEGIN
    DECLARE @ApplicationId UNIQUEIDENTIFIER
    DECLARE @PathId UNIQUEIDENTIFIER

    SELECT @ApplicationId = NULL
    SELECT @PathId = NULL

    EXEC dbo.aspnet_Personalization_GetApplicationId @ApplicationName, @ApplicationId OUTPUT
    IF (@ApplicationId IS NULL)
    BEGIN
        RETURN
    END

    SELECT @PathId = u.PathId FROM dbo.aspnet_Paths u WHERE u.ApplicationId = @ApplicationId AND u.LoweredPath = LOWER(@Path)
    IF (@PathId IS NULL)
    BEGIN
        RETURN
    END

    DELETE FROM dbo.aspnet_PersonalizationAllUsers WHERE PathId = @PathId
    RETURN 0
END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_PersonalizationAllUsers_SetPageSettings]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[aspnet_PersonalizationAllUsers_SetPageSettings] (
    @ApplicationName  NVARCHAR(256),
    @Path             NVARCHAR(256),
    @PageSettings     IMAGE,
    @CurrentTimeUtc   DATETIME)
AS
BEGIN
    DECLARE @ApplicationId UNIQUEIDENTIFIER
    DECLARE @PathId UNIQUEIDENTIFIER

    SELECT @ApplicationId = NULL
    SELECT @PathId = NULL

    EXEC dbo.aspnet_Applications_CreateApplication @ApplicationName, @ApplicationId OUTPUT

    SELECT @PathId = u.PathId FROM dbo.aspnet_Paths u WHERE u.ApplicationId = @ApplicationId AND u.LoweredPath = LOWER(@Path)
    IF (@PathId IS NULL)
    BEGIN
        EXEC dbo.aspnet_Paths_CreatePath @ApplicationId, @Path, @PathId OUTPUT
    END

    IF (EXISTS(SELECT PathId FROM dbo.aspnet_PersonalizationAllUsers WHERE PathId = @PathId))
        UPDATE dbo.aspnet_PersonalizationAllUsers SET PageSettings = @PageSettings, LastUpdatedDate = @CurrentTimeUtc WHERE PathId = @PathId
    ELSE
        INSERT INTO dbo.aspnet_PersonalizationAllUsers(PathId, PageSettings, LastUpdatedDate) VALUES (@PathId, @PageSettings, @CurrentTimeUtc)
    RETURN 0
END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_PersonalizationPerUser_GetPageSettings]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[aspnet_PersonalizationPerUser_GetPageSettings] (
    @ApplicationName  NVARCHAR(256),
    @UserName         NVARCHAR(256),
    @Path             NVARCHAR(256),
    @CurrentTimeUtc   DATETIME)
AS
BEGIN
    DECLARE @ApplicationId UNIQUEIDENTIFIER
    DECLARE @PathId UNIQUEIDENTIFIER
    DECLARE @UserId UNIQUEIDENTIFIER

    SELECT @ApplicationId = NULL
    SELECT @PathId = NULL
    SELECT @UserId = NULL

    EXEC dbo.aspnet_Personalization_GetApplicationId @ApplicationName, @ApplicationId OUTPUT
    IF (@ApplicationId IS NULL)
    BEGIN
        RETURN
    END

    SELECT @PathId = u.PathId FROM dbo.aspnet_Paths u WHERE u.ApplicationId = @ApplicationId AND u.LoweredPath = LOWER(@Path)
    IF (@PathId IS NULL)
    BEGIN
        RETURN
    END

    SELECT @UserId = u.UserId FROM dbo.aspnet_Users u WHERE u.ApplicationId = @ApplicationId AND u.LoweredUserName = LOWER(@UserName)
    IF (@UserId IS NULL)
    BEGIN
        RETURN
    END

    UPDATE   dbo.aspnet_Users WITH (ROWLOCK)
    SET      LastActivityDate = @CurrentTimeUtc
    WHERE    UserId = @UserId
    IF (@@ROWCOUNT = 0) -- Username not found
        RETURN

    SELECT p.PageSettings FROM dbo.aspnet_PersonalizationPerUser p WHERE p.PathId = @PathId AND p.UserId = @UserId
END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_PersonalizationPerUser_ResetPageSettings]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[aspnet_PersonalizationPerUser_ResetPageSettings] (
    @ApplicationName  NVARCHAR(256),
    @UserName         NVARCHAR(256),
    @Path             NVARCHAR(256),
    @CurrentTimeUtc   DATETIME)
AS
BEGIN
    DECLARE @ApplicationId UNIQUEIDENTIFIER
    DECLARE @PathId UNIQUEIDENTIFIER
    DECLARE @UserId UNIQUEIDENTIFIER

    SELECT @ApplicationId = NULL
    SELECT @PathId = NULL
    SELECT @UserId = NULL

    EXEC dbo.aspnet_Personalization_GetApplicationId @ApplicationName, @ApplicationId OUTPUT
    IF (@ApplicationId IS NULL)
    BEGIN
        RETURN
    END

    SELECT @PathId = u.PathId FROM dbo.aspnet_Paths u WHERE u.ApplicationId = @ApplicationId AND u.LoweredPath = LOWER(@Path)
    IF (@PathId IS NULL)
    BEGIN
        RETURN
    END

    SELECT @UserId = u.UserId FROM dbo.aspnet_Users u WHERE u.ApplicationId = @ApplicationId AND u.LoweredUserName = LOWER(@UserName)
    IF (@UserId IS NULL)
    BEGIN
        RETURN
    END

    UPDATE   dbo.aspnet_Users WITH (ROWLOCK)
    SET      LastActivityDate = @CurrentTimeUtc
    WHERE    UserId = @UserId
    IF (@@ROWCOUNT = 0) -- Username not found
        RETURN

    DELETE FROM dbo.aspnet_PersonalizationPerUser WHERE PathId = @PathId AND UserId = @UserId
    RETURN 0
END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_PersonalizationPerUser_SetPageSettings]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[aspnet_PersonalizationPerUser_SetPageSettings] (
    @ApplicationName  NVARCHAR(256),
    @UserName         NVARCHAR(256),
    @Path             NVARCHAR(256),
    @PageSettings     IMAGE,
    @CurrentTimeUtc   DATETIME)
AS
BEGIN
    DECLARE @ApplicationId UNIQUEIDENTIFIER
    DECLARE @PathId UNIQUEIDENTIFIER
    DECLARE @UserId UNIQUEIDENTIFIER

    SELECT @ApplicationId = NULL
    SELECT @PathId = NULL
    SELECT @UserId = NULL

    EXEC dbo.aspnet_Applications_CreateApplication @ApplicationName, @ApplicationId OUTPUT

    SELECT @PathId = u.PathId FROM dbo.aspnet_Paths u WHERE u.ApplicationId = @ApplicationId AND u.LoweredPath = LOWER(@Path)
    IF (@PathId IS NULL)
    BEGIN
        EXEC dbo.aspnet_Paths_CreatePath @ApplicationId, @Path, @PathId OUTPUT
    END

    SELECT @UserId = u.UserId FROM dbo.aspnet_Users u WHERE u.ApplicationId = @ApplicationId AND u.LoweredUserName = LOWER(@UserName)
    IF (@UserId IS NULL)
    BEGIN
        EXEC dbo.aspnet_Users_CreateUser @ApplicationId, @UserName, 0, @CurrentTimeUtc, @UserId OUTPUT
    END

    UPDATE   dbo.aspnet_Users WITH (ROWLOCK)
    SET      LastActivityDate = @CurrentTimeUtc
    WHERE    UserId = @UserId
    IF (@@ROWCOUNT = 0) -- Username not found
        RETURN

    IF (EXISTS(SELECT PathId FROM dbo.aspnet_PersonalizationPerUser WHERE UserId = @UserId AND PathId = @PathId))
        UPDATE dbo.aspnet_PersonalizationPerUser SET PageSettings = @PageSettings, LastUpdatedDate = @CurrentTimeUtc WHERE UserId = @UserId AND PathId = @PathId
    ELSE
        INSERT INTO dbo.aspnet_PersonalizationPerUser(UserId, PathId, PageSettings, LastUpdatedDate) VALUES (@UserId, @PathId, @PageSettings, @CurrentTimeUtc)
    RETURN 0
END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_Profile_DeleteInactiveProfiles]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

CREATE PROCEDURE [dbo].[aspnet_Profile_DeleteInactiveProfiles]
    @ApplicationName        nvarchar(256),
    @ProfileAuthOptions     int,
    @InactiveSinceDate      datetime
AS
BEGIN
    DECLARE @ApplicationId uniqueidentifier
    SELECT  @ApplicationId = NULL
    SELECT  @ApplicationId = ApplicationId FROM aspnet_Applications WHERE LOWER(@ApplicationName) = LoweredApplicationName
    IF (@ApplicationId IS NULL)
    BEGIN
        SELECT  0
        RETURN
    END

    DELETE
    FROM    dbo.aspnet_Profile
    WHERE   UserId IN
            (   SELECT  UserId
                FROM    dbo.aspnet_Users u
                WHERE   ApplicationId = @ApplicationId
                        AND (LastActivityDate <= @InactiveSinceDate)
                        AND (
                                (@ProfileAuthOptions = 2)
                             OR (@ProfileAuthOptions = 0 AND IsAnonymous = 1)
                             OR (@ProfileAuthOptions = 1 AND IsAnonymous = 0)
                            )
            )

    SELECT  @@ROWCOUNT
END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_Profile_DeleteProfiles]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

CREATE PROCEDURE [dbo].[aspnet_Profile_DeleteProfiles]
    @ApplicationName        nvarchar(256),
    @UserNames              nvarchar(4000)
AS
BEGIN
    DECLARE @UserName     nvarchar(256)
    DECLARE @CurrentPos   int
    DECLARE @NextPos      int
    DECLARE @NumDeleted   int
    DECLARE @DeletedUser  int
    DECLARE @TranStarted  bit
    DECLARE @ErrorCode    int

    SET @ErrorCode = 0
    SET @CurrentPos = 1
    SET @NumDeleted = 0
    SET @TranStarted = 0

    IF( @@TRANCOUNT = 0 )
    BEGIN
        BEGIN TRANSACTION
        SET @TranStarted = 1
    END
    ELSE
    	SET @TranStarted = 0

    WHILE (@CurrentPos <= LEN(@UserNames))
    BEGIN
        SELECT @NextPos = CHARINDEX(N',', @UserNames,  @CurrentPos)
        IF (@NextPos = 0 OR @NextPos IS NULL)
            SELECT @NextPos = LEN(@UserNames) + 1

        SELECT @UserName = SUBSTRING(@UserNames, @CurrentPos, @NextPos - @CurrentPos)
        SELECT @CurrentPos = @NextPos+1

        IF (LEN(@UserName) > 0)
        BEGIN
            SELECT @DeletedUser = 0
            EXEC dbo.aspnet_Users_DeleteUser @ApplicationName, @UserName, 4, @DeletedUser OUTPUT
            IF( @@ERROR <> 0 )
            BEGIN
                SET @ErrorCode = -1
                GOTO Cleanup
            END
            IF (@DeletedUser <> 0)
                SELECT @NumDeleted = @NumDeleted + 1
        END
    END
    SELECT @NumDeleted
    IF (@TranStarted = 1)
    BEGIN
    	SET @TranStarted = 0
    	COMMIT TRANSACTION
    END
    SET @TranStarted = 0

    RETURN 0

Cleanup:
    IF (@TranStarted = 1 )
    BEGIN
        SET @TranStarted = 0
    	ROLLBACK TRANSACTION
    END
    RETURN @ErrorCode
END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_Profile_GetNumberOfInactiveProfiles]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

CREATE PROCEDURE [dbo].[aspnet_Profile_GetNumberOfInactiveProfiles]
    @ApplicationName        nvarchar(256),
    @ProfileAuthOptions     int,
    @InactiveSinceDate      datetime
AS
BEGIN
    DECLARE @ApplicationId uniqueidentifier
    SELECT  @ApplicationId = NULL
    SELECT  @ApplicationId = ApplicationId FROM aspnet_Applications WHERE LOWER(@ApplicationName) = LoweredApplicationName
    IF (@ApplicationId IS NULL)
    BEGIN
        SELECT 0
        RETURN
    END

    SELECT  COUNT(*)
    FROM    dbo.aspnet_Users u, dbo.aspnet_Profile p
    WHERE   ApplicationId = @ApplicationId
        AND u.UserId = p.UserId
        AND (LastActivityDate <= @InactiveSinceDate)
        AND (
                (@ProfileAuthOptions = 2)
                OR (@ProfileAuthOptions = 0 AND IsAnonymous = 1)
                OR (@ProfileAuthOptions = 1 AND IsAnonymous = 0)
            )
END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_Profile_GetProfiles]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

CREATE PROCEDURE [dbo].[aspnet_Profile_GetProfiles]
    @ApplicationName        nvarchar(256),
    @ProfileAuthOptions     int,
    @PageIndex              int,
    @PageSize               int,
    @UserNameToMatch        nvarchar(256) = NULL,
    @InactiveSinceDate      datetime      = NULL
AS
BEGIN
    DECLARE @ApplicationId uniqueidentifier
    SELECT  @ApplicationId = NULL
    SELECT  @ApplicationId = ApplicationId FROM aspnet_Applications WHERE LOWER(@ApplicationName) = LoweredApplicationName
    IF (@ApplicationId IS NULL)
        RETURN

    -- Set the page bounds
    DECLARE @PageLowerBound int
    DECLARE @PageUpperBound int
    DECLARE @TotalRecords   int
    SET @PageLowerBound = @PageSize * @PageIndex
    SET @PageUpperBound = @PageSize - 1 + @PageLowerBound

    -- Create a temp table TO store the select results
    CREATE TABLE #PageIndexForUsers
    (
        IndexId int IDENTITY (0, 1) NOT NULL,
        UserId uniqueidentifier
    )

    -- Insert into our temp table
    INSERT INTO #PageIndexForUsers (UserId)
        SELECT  u.UserId
        FROM    dbo.aspnet_Users u, dbo.aspnet_Profile p
        WHERE   ApplicationId = @ApplicationId
            AND u.UserId = p.UserId
            AND (@InactiveSinceDate IS NULL OR LastActivityDate <= @InactiveSinceDate)
            AND (     (@ProfileAuthOptions = 2)
                   OR (@ProfileAuthOptions = 0 AND IsAnonymous = 1)
                   OR (@ProfileAuthOptions = 1 AND IsAnonymous = 0)
                 )
            AND (@UserNameToMatch IS NULL OR LoweredUserName LIKE LOWER(@UserNameToMatch))
        ORDER BY UserName

    SELECT  u.UserName, u.IsAnonymous, u.LastActivityDate, p.LastUpdatedDate,
            DATALENGTH(p.PropertyNames) + DATALENGTH(p.PropertyValuesString) + DATALENGTH(p.PropertyValuesBinary)
    FROM    dbo.aspnet_Users u, dbo.aspnet_Profile p, #PageIndexForUsers i
    WHERE   u.UserId = p.UserId AND p.UserId = i.UserId AND i.IndexId >= @PageLowerBound AND i.IndexId <= @PageUpperBound

    SELECT COUNT(*)
    FROM   #PageIndexForUsers

    DROP TABLE #PageIndexForUsers
END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_Profile_GetProperties]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

CREATE PROCEDURE [dbo].[aspnet_Profile_GetProperties]
    @ApplicationName      nvarchar(256),
    @UserName             nvarchar(256),
    @CurrentTimeUtc       datetime
AS
BEGIN
    DECLARE @ApplicationId uniqueidentifier
    SELECT  @ApplicationId = NULL
    SELECT  @ApplicationId = ApplicationId FROM dbo.aspnet_Applications WHERE LOWER(@ApplicationName) = LoweredApplicationName
    IF (@ApplicationId IS NULL)
        RETURN

    DECLARE @UserId uniqueidentifier
    SELECT  @UserId = NULL

    SELECT @UserId = UserId
    FROM   dbo.aspnet_Users
    WHERE  ApplicationId = @ApplicationId AND LoweredUserName = LOWER(@UserName)

    IF (@UserId IS NULL)
        RETURN
    SELECT TOP 1 PropertyNames, PropertyValuesString, PropertyValuesBinary
    FROM         dbo.aspnet_Profile
    WHERE        UserId = @UserId

    IF (@@ROWCOUNT > 0)
    BEGIN
        UPDATE dbo.aspnet_Users
        SET    LastActivityDate=@CurrentTimeUtc
        WHERE  UserId = @UserId
    END
END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_Profile_SetProperties]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

CREATE PROCEDURE [dbo].[aspnet_Profile_SetProperties]
    @ApplicationName        nvarchar(256),
    @PropertyNames          ntext,
    @PropertyValuesString   ntext,
    @PropertyValuesBinary   image,
    @UserName               nvarchar(256),
    @IsUserAnonymous        bit,
    @CurrentTimeUtc         datetime
AS
BEGIN
    DECLARE @ApplicationId uniqueidentifier
    SELECT  @ApplicationId = NULL

    DECLARE @ErrorCode     int
    SET @ErrorCode = 0

    DECLARE @TranStarted   bit
    SET @TranStarted = 0

    IF( @@TRANCOUNT = 0 )
    BEGIN
       BEGIN TRANSACTION
       SET @TranStarted = 1
    END
    ELSE
    	SET @TranStarted = 0

    EXEC dbo.aspnet_Applications_CreateApplication @ApplicationName, @ApplicationId OUTPUT

    IF( @@ERROR <> 0 )
    BEGIN
        SET @ErrorCode = -1
        GOTO Cleanup
    END

    DECLARE @UserId uniqueidentifier
    DECLARE @LastActivityDate datetime
    SELECT  @UserId = NULL
    SELECT  @LastActivityDate = @CurrentTimeUtc

    SELECT @UserId = UserId
    FROM   dbo.aspnet_Users
    WHERE  ApplicationId = @ApplicationId AND LoweredUserName = LOWER(@UserName)
    IF (@UserId IS NULL)
        EXEC dbo.aspnet_Users_CreateUser @ApplicationId, @UserName, @IsUserAnonymous, @LastActivityDate, @UserId OUTPUT

    IF( @@ERROR <> 0 )
    BEGIN
        SET @ErrorCode = -1
        GOTO Cleanup
    END

    UPDATE dbo.aspnet_Users
    SET    LastActivityDate=@CurrentTimeUtc
    WHERE  UserId = @UserId

    IF( @@ERROR <> 0 )
    BEGIN
        SET @ErrorCode = -1
        GOTO Cleanup
    END

    IF (EXISTS( SELECT *
               FROM   dbo.aspnet_Profile
               WHERE  UserId = @UserId))
        UPDATE dbo.aspnet_Profile
        SET    PropertyNames=@PropertyNames, PropertyValuesString = @PropertyValuesString,
               PropertyValuesBinary = @PropertyValuesBinary, LastUpdatedDate=@CurrentTimeUtc
        WHERE  UserId = @UserId
    ELSE
        INSERT INTO dbo.aspnet_Profile(UserId, PropertyNames, PropertyValuesString, PropertyValuesBinary, LastUpdatedDate)
             VALUES (@UserId, @PropertyNames, @PropertyValuesString, @PropertyValuesBinary, @CurrentTimeUtc)

    IF( @@ERROR <> 0 )
    BEGIN
        SET @ErrorCode = -1
        GOTO Cleanup
    END

    IF( @TranStarted = 1 )
    BEGIN
    	SET @TranStarted = 0
    	COMMIT TRANSACTION
    END

    RETURN 0

Cleanup:

    IF( @TranStarted = 1 )
    BEGIN
        SET @TranStarted = 0
    	ROLLBACK TRANSACTION
    END

    RETURN @ErrorCode

END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_RegisterSchemaVersion]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

CREATE PROCEDURE [dbo].[aspnet_RegisterSchemaVersion]
    @Feature                   nvarchar(128),
    @CompatibleSchemaVersion   nvarchar(128),
    @IsCurrentVersion          bit,
    @RemoveIncompatibleSchema  bit
AS
BEGIN
    IF( @RemoveIncompatibleSchema = 1 )
    BEGIN
        DELETE FROM dbo.aspnet_SchemaVersions WHERE Feature = LOWER( @Feature )
    END
    ELSE
    BEGIN
        IF( @IsCurrentVersion = 1 )
        BEGIN
            UPDATE dbo.aspnet_SchemaVersions
            SET IsCurrentVersion = 0
            WHERE Feature = LOWER( @Feature )
        END
    END

    INSERT  dbo.aspnet_SchemaVersions( Feature, CompatibleSchemaVersion, IsCurrentVersion )
    VALUES( LOWER( @Feature ), @CompatibleSchemaVersion, @IsCurrentVersion )
END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_Roles_CreateRole]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[aspnet_Roles_CreateRole]
    @ApplicationName  nvarchar(256),
    @RoleName         nvarchar(256)
AS
BEGIN
    DECLARE @ApplicationId uniqueidentifier
    SELECT  @ApplicationId = NULL

    DECLARE @ErrorCode     int
    SET @ErrorCode = 0

    DECLARE @TranStarted   bit
    SET @TranStarted = 0

    IF( @@TRANCOUNT = 0 )
    BEGIN
        BEGIN TRANSACTION
        SET @TranStarted = 1
    END
    ELSE
        SET @TranStarted = 0

    EXEC dbo.aspnet_Applications_CreateApplication @ApplicationName, @ApplicationId OUTPUT

    IF( @@ERROR <> 0 )
    BEGIN
        SET @ErrorCode = -1
        GOTO Cleanup
    END

    IF (EXISTS(SELECT RoleId FROM dbo.aspnet_Roles WHERE LoweredRoleName = LOWER(@RoleName) AND ApplicationId = @ApplicationId))
    BEGIN
        SET @ErrorCode = 1
        GOTO Cleanup
    END

    INSERT INTO dbo.aspnet_Roles
                (ApplicationId, RoleName, LoweredRoleName)
         VALUES (@ApplicationId, @RoleName, LOWER(@RoleName))

    IF( @@ERROR <> 0 )
    BEGIN
        SET @ErrorCode = -1
        GOTO Cleanup
    END

    IF( @TranStarted = 1 )
    BEGIN
        SET @TranStarted = 0
        COMMIT TRANSACTION
    END

    RETURN(0)

Cleanup:

    IF( @TranStarted = 1 )
    BEGIN
        SET @TranStarted = 0
        ROLLBACK TRANSACTION
    END

    RETURN @ErrorCode

END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_Roles_DeleteRole]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

CREATE PROCEDURE [dbo].[aspnet_Roles_DeleteRole]
    @ApplicationName            nvarchar(256),
    @RoleName                   nvarchar(256),
    @DeleteOnlyIfRoleIsEmpty    bit
AS
BEGIN
    DECLARE @ApplicationId uniqueidentifier
    SELECT  @ApplicationId = NULL
    SELECT  @ApplicationId = ApplicationId FROM aspnet_Applications WHERE LOWER(@ApplicationName) = LoweredApplicationName
    IF (@ApplicationId IS NULL)
        RETURN(1)

    DECLARE @ErrorCode     int
    SET @ErrorCode = 0

    DECLARE @TranStarted   bit
    SET @TranStarted = 0

    IF( @@TRANCOUNT = 0 )
    BEGIN
        BEGIN TRANSACTION
        SET @TranStarted = 1
    END
    ELSE
        SET @TranStarted = 0

    DECLARE @RoleId   uniqueidentifier
    SELECT  @RoleId = NULL
    SELECT  @RoleId = RoleId FROM dbo.aspnet_Roles WHERE LoweredRoleName = LOWER(@RoleName) AND ApplicationId = @ApplicationId

    IF (@RoleId IS NULL)
    BEGIN
        SELECT @ErrorCode = 1
        GOTO Cleanup
    END
    IF (@DeleteOnlyIfRoleIsEmpty <> 0)
    BEGIN
        IF (EXISTS (SELECT RoleId FROM dbo.aspnet_UsersInRoles  WHERE @RoleId = RoleId))
        BEGIN
            SELECT @ErrorCode = 2
            GOTO Cleanup
        END
    END


    DELETE FROM dbo.aspnet_UsersInRoles  WHERE @RoleId = RoleId

    IF( @@ERROR <> 0 )
    BEGIN
        SET @ErrorCode = -1
        GOTO Cleanup
    END

    DELETE FROM dbo.aspnet_Roles WHERE @RoleId = RoleId  AND ApplicationId = @ApplicationId

    IF( @@ERROR <> 0 )
    BEGIN
        SET @ErrorCode = -1
        GOTO Cleanup
    END

    IF( @TranStarted = 1 )
    BEGIN
        SET @TranStarted = 0
        COMMIT TRANSACTION
    END

    RETURN(0)

Cleanup:

    IF( @TranStarted = 1 )
    BEGIN
        SET @TranStarted = 0
        ROLLBACK TRANSACTION
    END

    RETURN @ErrorCode
END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_Roles_GetAllRoles]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

CREATE PROCEDURE [dbo].[aspnet_Roles_GetAllRoles] (
    @ApplicationName           nvarchar(256))
AS
BEGIN
    DECLARE @ApplicationId uniqueidentifier
    SELECT  @ApplicationId = NULL
    SELECT  @ApplicationId = ApplicationId FROM aspnet_Applications WHERE LOWER(@ApplicationName) = LoweredApplicationName
    IF (@ApplicationId IS NULL)
        RETURN
    SELECT RoleName
    FROM   dbo.aspnet_Roles WHERE ApplicationId = @ApplicationId
    ORDER BY RoleName
END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_Roles_RoleExists]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

CREATE PROCEDURE [dbo].[aspnet_Roles_RoleExists]
    @ApplicationName  nvarchar(256),
    @RoleName         nvarchar(256)
AS
BEGIN
    DECLARE @ApplicationId uniqueidentifier
    SELECT  @ApplicationId = NULL
    SELECT  @ApplicationId = ApplicationId FROM aspnet_Applications WHERE LOWER(@ApplicationName) = LoweredApplicationName
    IF (@ApplicationId IS NULL)
        RETURN(0)
    IF (EXISTS (SELECT RoleName FROM dbo.aspnet_Roles WHERE LOWER(@RoleName) = LoweredRoleName AND ApplicationId = @ApplicationId ))
        RETURN(1)
    ELSE
        RETURN(0)
END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_Setup_RemoveAllRoleMembers]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

CREATE PROCEDURE [dbo].[aspnet_Setup_RemoveAllRoleMembers]
    @name   sysname
AS
BEGIN
    CREATE TABLE #aspnet_RoleMembers
    (
        Group_name      sysname,
        Group_id        smallint,
        Users_in_group  sysname,
        User_id         smallint
    )

    INSERT INTO #aspnet_RoleMembers
    EXEC sp_helpuser @name

    DECLARE @user_id smallint
    DECLARE @cmd nvarchar(500)
    DECLARE c1 cursor FORWARD_ONLY FOR
        SELECT User_id FROM #aspnet_RoleMembers

    OPEN c1

    FETCH c1 INTO @user_id
    WHILE (@@fetch_status = 0)
    BEGIN
        SET @cmd = 'EXEC sp_droprolemember ' + '''' + @name + ''', ''' + USER_NAME(@user_id) + ''''
        EXEC (@cmd)
        FETCH c1 INTO @user_id
    END

    CLOSE c1
    DEALLOCATE c1
END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_Setup_RestorePermissions]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

CREATE PROCEDURE [dbo].[aspnet_Setup_RestorePermissions]
    @name   sysname
AS
BEGIN
    DECLARE @object sysname
    DECLARE @protectType char(10)
    DECLARE @action varchar(60)
    DECLARE @grantee sysname
    DECLARE @cmd nvarchar(500)
    DECLARE c1 cursor FORWARD_ONLY FOR
        SELECT Object, ProtectType, [Action], Grantee FROM #aspnet_Permissions where Object = @name

    OPEN c1

    FETCH c1 INTO @object, @protectType, @action, @grantee
    WHILE (@@fetch_status = 0)
    BEGIN
        SET @cmd = @protectType + ' ' + @action + ' on ' + @object + ' TO [' + @grantee + ']'
        EXEC (@cmd)
        FETCH c1 INTO @object, @protectType, @action, @grantee
    END

    CLOSE c1
    DEALLOCATE c1
END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_UnRegisterSchemaVersion]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

CREATE PROCEDURE [dbo].[aspnet_UnRegisterSchemaVersion]
    @Feature                   nvarchar(128),
    @CompatibleSchemaVersion   nvarchar(128)
AS
BEGIN
    DELETE FROM dbo.aspnet_SchemaVersions
        WHERE   Feature = LOWER(@Feature) AND @CompatibleSchemaVersion = CompatibleSchemaVersion
END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_Users_CreateUser]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

CREATE PROCEDURE [dbo].[aspnet_Users_CreateUser]
    @ApplicationId    uniqueidentifier,
    @UserName         nvarchar(256),
    @IsUserAnonymous  bit,
    @LastActivityDate DATETIME,
    @UserId           uniqueidentifier OUTPUT
AS
BEGIN
    IF( @UserId IS NULL )
        SELECT @UserId = NEWID()
    ELSE
    BEGIN
        IF( EXISTS( SELECT UserId FROM dbo.aspnet_Users
                    WHERE @UserId = UserId ) )
            RETURN -1
    END

    INSERT dbo.aspnet_Users (ApplicationId, UserId, UserName, LoweredUserName, IsAnonymous, LastActivityDate)
    VALUES (@ApplicationId, @UserId, @UserName, LOWER(@UserName), @IsUserAnonymous, @LastActivityDate)

    RETURN 0
END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_Users_DeleteUser]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[aspnet_Users_DeleteUser]
    @ApplicationName  nvarchar(256),
    @UserName         nvarchar(256),
    @TablesToDeleteFrom int,
    @NumTablesDeletedFrom int OUTPUT
AS
BEGIN
    DECLARE @UserId               uniqueidentifier
    SELECT  @UserId               = NULL
    SELECT  @NumTablesDeletedFrom = 0

    DECLARE @TranStarted   bit
    SET @TranStarted = 0

    IF( @@TRANCOUNT = 0 )
    BEGIN
	    BEGIN TRANSACTION
	    SET @TranStarted = 1
    END
    ELSE
	SET @TranStarted = 0

    DECLARE @ErrorCode   int
    DECLARE @RowCount    int

    SET @ErrorCode = 0
    SET @RowCount  = 0

    SELECT  @UserId = u.UserId
    FROM    dbo.aspnet_Users u, dbo.aspnet_Applications a
    WHERE   u.LoweredUserName       = LOWER(@UserName)
        AND u.ApplicationId         = a.ApplicationId
        AND LOWER(@ApplicationName) = a.LoweredApplicationName

    IF (@UserId IS NULL)
    BEGIN
        GOTO Cleanup
    END

    -- Delete from Membership table if (@TablesToDeleteFrom & 1) is set
    IF ((@TablesToDeleteFrom & 1) <> 0 AND
        (EXISTS (SELECT name FROM sysobjects WHERE (name = N'vw_aspnet_MembershipUsers') AND (type = 'V'))))
    BEGIN
        DELETE FROM dbo.aspnet_Membership WHERE @UserId = UserId

        SELECT @ErrorCode = @@ERROR,
               @RowCount = @@ROWCOUNT

        IF( @ErrorCode <> 0 )
            GOTO Cleanup

        IF (@RowCount <> 0)
            SELECT  @NumTablesDeletedFrom = @NumTablesDeletedFrom + 1
    END

    -- Delete from aspnet_UsersInRoles table if (@TablesToDeleteFrom & 2) is set
    IF ((@TablesToDeleteFrom & 2) <> 0  AND
        (EXISTS (SELECT name FROM sysobjects WHERE (name = N'vw_aspnet_UsersInRoles') AND (type = 'V'))) )
    BEGIN
        DELETE FROM dbo.aspnet_UsersInRoles WHERE @UserId = UserId

        SELECT @ErrorCode = @@ERROR,
                @RowCount = @@ROWCOUNT

        IF( @ErrorCode <> 0 )
            GOTO Cleanup

        IF (@RowCount <> 0)
            SELECT  @NumTablesDeletedFrom = @NumTablesDeletedFrom + 1
    END

    -- Delete from aspnet_Profile table if (@TablesToDeleteFrom & 4) is set
    IF ((@TablesToDeleteFrom & 4) <> 0  AND
        (EXISTS (SELECT name FROM sysobjects WHERE (name = N'vw_aspnet_Profiles') AND (type = 'V'))) )
    BEGIN
        DELETE FROM dbo.aspnet_Profile WHERE @UserId = UserId

        SELECT @ErrorCode = @@ERROR,
                @RowCount = @@ROWCOUNT

        IF( @ErrorCode <> 0 )
            GOTO Cleanup

        IF (@RowCount <> 0)
            SELECT  @NumTablesDeletedFrom = @NumTablesDeletedFrom + 1
    END

    -- Delete from aspnet_PersonalizationPerUser table if (@TablesToDeleteFrom & 8) is set
    IF ((@TablesToDeleteFrom & 8) <> 0  AND
        (EXISTS (SELECT name FROM sysobjects WHERE (name = N'vw_aspnet_WebPartState_User') AND (type = 'V'))) )
    BEGIN
        DELETE FROM dbo.aspnet_PersonalizationPerUser WHERE @UserId = UserId

        SELECT @ErrorCode = @@ERROR,
                @RowCount = @@ROWCOUNT

        IF( @ErrorCode <> 0 )
            GOTO Cleanup

        IF (@RowCount <> 0)
            SELECT  @NumTablesDeletedFrom = @NumTablesDeletedFrom + 1
    END

    -- Delete from aspnet_Users table if (@TablesToDeleteFrom & 1,2,4 & 8) are all set
    IF ((@TablesToDeleteFrom & 1) <> 0 AND
        (@TablesToDeleteFrom & 2) <> 0 AND
        (@TablesToDeleteFrom & 4) <> 0 AND
        (@TablesToDeleteFrom & 8) <> 0 AND
        (EXISTS (SELECT UserId FROM dbo.aspnet_Users WHERE @UserId = UserId)))
    BEGIN
        DELETE FROM dbo.aspnet_Users WHERE @UserId = UserId

        SELECT @ErrorCode = @@ERROR,
                @RowCount = @@ROWCOUNT

        IF( @ErrorCode <> 0 )
            GOTO Cleanup

        IF (@RowCount <> 0)
            SELECT  @NumTablesDeletedFrom = @NumTablesDeletedFrom + 1
    END

    IF( @TranStarted = 1 )
    BEGIN
	    SET @TranStarted = 0
	    COMMIT TRANSACTION
    END

    RETURN 0

Cleanup:
    SET @NumTablesDeletedFrom = 0

    IF( @TranStarted = 1 )
    BEGIN
        SET @TranStarted = 0
	    ROLLBACK TRANSACTION
    END

    RETURN @ErrorCode

END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_UsersInRoles_AddUsersToRoles]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

CREATE PROCEDURE [dbo].[aspnet_UsersInRoles_AddUsersToRoles]
	@ApplicationName  nvarchar(256),
	@UserNames		  nvarchar(4000),
	@RoleNames		  nvarchar(4000),
	@CurrentTimeUtc   datetime
AS
BEGIN
	DECLARE @AppId uniqueidentifier
	SELECT  @AppId = NULL
	SELECT  @AppId = ApplicationId FROM aspnet_Applications WHERE LOWER(@ApplicationName) = LoweredApplicationName
	IF (@AppId IS NULL)
		RETURN(2)
	DECLARE @TranStarted   bit
	SET @TranStarted = 0

	IF( @@TRANCOUNT = 0 )
	BEGIN
		BEGIN TRANSACTION
		SET @TranStarted = 1
	END

	DECLARE @tbNames	table(Name nvarchar(256) NOT NULL PRIMARY KEY)
	DECLARE @tbRoles	table(RoleId uniqueidentifier NOT NULL PRIMARY KEY)
	DECLARE @tbUsers	table(UserId uniqueidentifier NOT NULL PRIMARY KEY)
	DECLARE @Num		int
	DECLARE @Pos		int
	DECLARE @NextPos	int
	DECLARE @Name		nvarchar(256)

	SET @Num = 0
	SET @Pos = 1
	WHILE(@Pos <= LEN(@RoleNames))
	BEGIN
		SELECT @NextPos = CHARINDEX(N',', @RoleNames,  @Pos)
		IF (@NextPos = 0 OR @NextPos IS NULL)
			SELECT @NextPos = LEN(@RoleNames) + 1
		SELECT @Name = RTRIM(LTRIM(SUBSTRING(@RoleNames, @Pos, @NextPos - @Pos)))
		SELECT @Pos = @NextPos+1

		INSERT INTO @tbNames VALUES (@Name)
		SET @Num = @Num + 1
	END

	INSERT INTO @tbRoles
	  SELECT RoleId
	  FROM   dbo.aspnet_Roles ar, @tbNames t
	  WHERE  LOWER(t.Name) = ar.LoweredRoleName AND ar.ApplicationId = @AppId

	IF (@@ROWCOUNT <> @Num)
	BEGIN
		SELECT TOP 1 Name
		FROM   @tbNames
		WHERE  LOWER(Name) NOT IN (SELECT ar.LoweredRoleName FROM dbo.aspnet_Roles ar,  @tbRoles r WHERE r.RoleId = ar.RoleId)
		IF( @TranStarted = 1 )
			ROLLBACK TRANSACTION
		RETURN(2)
	END

	DELETE FROM @tbNames WHERE 1=1
	SET @Num = 0
	SET @Pos = 1

	WHILE(@Pos <= LEN(@UserNames))
	BEGIN
		SELECT @NextPos = CHARINDEX(N',', @UserNames,  @Pos)
		IF (@NextPos = 0 OR @NextPos IS NULL)
			SELECT @NextPos = LEN(@UserNames) + 1
		SELECT @Name = RTRIM(LTRIM(SUBSTRING(@UserNames, @Pos, @NextPos - @Pos)))
		SELECT @Pos = @NextPos+1

		INSERT INTO @tbNames VALUES (@Name)
		SET @Num = @Num + 1
	END

	INSERT INTO @tbUsers
	  SELECT UserId
	  FROM   dbo.aspnet_Users ar, @tbNames t
	  WHERE  LOWER(t.Name) = ar.LoweredUserName AND ar.ApplicationId = @AppId

	IF (@@ROWCOUNT <> @Num)
	BEGIN
		DELETE FROM @tbNames
		WHERE LOWER(Name) IN (SELECT LoweredUserName FROM dbo.aspnet_Users au,  @tbUsers u WHERE au.UserId = u.UserId)

		INSERT dbo.aspnet_Users (ApplicationId, UserId, UserName, LoweredUserName, IsAnonymous, LastActivityDate)
		  SELECT @AppId, NEWID(), Name, LOWER(Name), 0, @CurrentTimeUtc
		  FROM   @tbNames

		INSERT INTO @tbUsers
		  SELECT  UserId
		  FROM	dbo.aspnet_Users au, @tbNames t
		  WHERE   LOWER(t.Name) = au.LoweredUserName AND au.ApplicationId = @AppId
	END

	IF (EXISTS (SELECT * FROM dbo.aspnet_UsersInRoles ur, @tbUsers tu, @tbRoles tr WHERE tu.UserId = ur.UserId AND tr.RoleId = ur.RoleId))
	BEGIN
		SELECT TOP 1 UserName, RoleName
		FROM		 dbo.aspnet_UsersInRoles ur, @tbUsers tu, @tbRoles tr, aspnet_Users u, aspnet_Roles r
		WHERE		u.UserId = tu.UserId AND r.RoleId = tr.RoleId AND tu.UserId = ur.UserId AND tr.RoleId = ur.RoleId

		IF( @TranStarted = 1 )
			ROLLBACK TRANSACTION
		RETURN(3)
	END

	INSERT INTO dbo.aspnet_UsersInRoles (UserId, RoleId)
	SELECT UserId, RoleId
	FROM @tbUsers, @tbRoles

	IF( @TranStarted = 1 )
		COMMIT TRANSACTION
	RETURN(0)
END                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    
GO
/****** Object:  StoredProcedure [dbo].[aspnet_UsersInRoles_FindUsersInRole]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

CREATE PROCEDURE [dbo].[aspnet_UsersInRoles_FindUsersInRole]
    @ApplicationName  nvarchar(256),
    @RoleName         nvarchar(256),
    @UserNameToMatch  nvarchar(256)
AS
BEGIN
    DECLARE @ApplicationId uniqueidentifier
    SELECT  @ApplicationId = NULL
    SELECT  @ApplicationId = ApplicationId FROM aspnet_Applications WHERE LOWER(@ApplicationName) = LoweredApplicationName
    IF (@ApplicationId IS NULL)
        RETURN(1)
     DECLARE @RoleId uniqueidentifier
     SELECT  @RoleId = NULL

     SELECT  @RoleId = RoleId
     FROM    dbo.aspnet_Roles
     WHERE   LOWER(@RoleName) = LoweredRoleName AND ApplicationId = @ApplicationId

     IF (@RoleId IS NULL)
         RETURN(1)

    SELECT u.UserName
    FROM   dbo.aspnet_Users u, dbo.aspnet_UsersInRoles ur
    WHERE  u.UserId = ur.UserId AND @RoleId = ur.RoleId AND u.ApplicationId = @ApplicationId AND LoweredUserName LIKE LOWER(@UserNameToMatch)
    ORDER BY u.UserName
    RETURN(0)
END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_UsersInRoles_GetRolesForUser]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

CREATE PROCEDURE [dbo].[aspnet_UsersInRoles_GetRolesForUser]
    @ApplicationName  nvarchar(256),
    @UserName         nvarchar(256)
AS
BEGIN
    DECLARE @ApplicationId uniqueidentifier
    SELECT  @ApplicationId = NULL
    SELECT  @ApplicationId = ApplicationId FROM aspnet_Applications WHERE LOWER(@ApplicationName) = LoweredApplicationName
    IF (@ApplicationId IS NULL)
        RETURN(1)
    DECLARE @UserId uniqueidentifier
    SELECT  @UserId = NULL

    SELECT  @UserId = UserId
    FROM    dbo.aspnet_Users
    WHERE   LoweredUserName = LOWER(@UserName) AND ApplicationId = @ApplicationId

    IF (@UserId IS NULL)
        RETURN(1)

    SELECT r.RoleName
    FROM   dbo.aspnet_Roles r, dbo.aspnet_UsersInRoles ur
    WHERE  r.RoleId = ur.RoleId AND r.ApplicationId = @ApplicationId AND ur.UserId = @UserId
    ORDER BY r.RoleName
    RETURN (0)
END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_UsersInRoles_GetUsersInRoles]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

CREATE PROCEDURE [dbo].[aspnet_UsersInRoles_GetUsersInRoles]
    @ApplicationName  nvarchar(256),
    @RoleName         nvarchar(256)
AS
BEGIN
    DECLARE @ApplicationId uniqueidentifier
    SELECT  @ApplicationId = NULL
    SELECT  @ApplicationId = ApplicationId FROM aspnet_Applications WHERE LOWER(@ApplicationName) = LoweredApplicationName
    IF (@ApplicationId IS NULL)
        RETURN(1)
     DECLARE @RoleId uniqueidentifier
     SELECT  @RoleId = NULL

     SELECT  @RoleId = RoleId
     FROM    dbo.aspnet_Roles
     WHERE   LOWER(@RoleName) = LoweredRoleName AND ApplicationId = @ApplicationId

     IF (@RoleId IS NULL)
         RETURN(1)

    SELECT u.UserName
    FROM   dbo.aspnet_Users u, dbo.aspnet_UsersInRoles ur
    WHERE  u.UserId = ur.UserId AND @RoleId = ur.RoleId AND u.ApplicationId = @ApplicationId
    ORDER BY u.UserName
    RETURN(0)
END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_UsersInRoles_IsUserInRole]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

CREATE PROCEDURE [dbo].[aspnet_UsersInRoles_IsUserInRole]
    @ApplicationName  nvarchar(256),
    @UserName         nvarchar(256),
    @RoleName         nvarchar(256)
AS
BEGIN
    DECLARE @ApplicationId uniqueidentifier
    SELECT  @ApplicationId = NULL
    SELECT  @ApplicationId = ApplicationId FROM aspnet_Applications WHERE LOWER(@ApplicationName) = LoweredApplicationName
    IF (@ApplicationId IS NULL)
        RETURN(2)
    DECLARE @UserId uniqueidentifier
    SELECT  @UserId = NULL
    DECLARE @RoleId uniqueidentifier
    SELECT  @RoleId = NULL

    SELECT  @UserId = UserId
    FROM    dbo.aspnet_Users
    WHERE   LoweredUserName = LOWER(@UserName) AND ApplicationId = @ApplicationId

    IF (@UserId IS NULL)
        RETURN(2)

    SELECT  @RoleId = RoleId
    FROM    dbo.aspnet_Roles
    WHERE   LoweredRoleName = LOWER(@RoleName) AND ApplicationId = @ApplicationId

    IF (@RoleId IS NULL)
        RETURN(3)

    IF (EXISTS( SELECT * FROM dbo.aspnet_UsersInRoles WHERE  UserId = @UserId AND RoleId = @RoleId))
        RETURN(1)
    ELSE
        RETURN(0)
END

GO
/****** Object:  StoredProcedure [dbo].[aspnet_UsersInRoles_RemoveUsersFromRoles]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

CREATE PROCEDURE [dbo].[aspnet_UsersInRoles_RemoveUsersFromRoles]
	@ApplicationName  nvarchar(256),
	@UserNames		  nvarchar(4000),
	@RoleNames		  nvarchar(4000)
AS
BEGIN
	DECLARE @AppId uniqueidentifier
	SELECT  @AppId = NULL
	SELECT  @AppId = ApplicationId FROM aspnet_Applications WHERE LOWER(@ApplicationName) = LoweredApplicationName
	IF (@AppId IS NULL)
		RETURN(2)


	DECLARE @TranStarted   bit
	SET @TranStarted = 0

	IF( @@TRANCOUNT = 0 )
	BEGIN
		BEGIN TRANSACTION
		SET @TranStarted = 1
	END

	DECLARE @tbNames  table(Name nvarchar(256) NOT NULL PRIMARY KEY)
	DECLARE @tbRoles  table(RoleId uniqueidentifier NOT NULL PRIMARY KEY)
	DECLARE @tbUsers  table(UserId uniqueidentifier NOT NULL PRIMARY KEY)
	DECLARE @Num	  int
	DECLARE @Pos	  int
	DECLARE @NextPos  int
	DECLARE @Name	  nvarchar(256)
	DECLARE @CountAll int
	DECLARE @CountU	  int
	DECLARE @CountR	  int


	SET @Num = 0
	SET @Pos = 1
	WHILE(@Pos <= LEN(@RoleNames))
	BEGIN
		SELECT @NextPos = CHARINDEX(N',', @RoleNames,  @Pos)
		IF (@NextPos = 0 OR @NextPos IS NULL)
			SELECT @NextPos = LEN(@RoleNames) + 1
		SELECT @Name = RTRIM(LTRIM(SUBSTRING(@RoleNames, @Pos, @NextPos - @Pos)))
		SELECT @Pos = @NextPos+1

		INSERT INTO @tbNames VALUES (@Name)
		SET @Num = @Num + 1
	END

	INSERT INTO @tbRoles
	  SELECT RoleId
	  FROM   dbo.aspnet_Roles ar, @tbNames t
	  WHERE  LOWER(t.Name) = ar.LoweredRoleName AND ar.ApplicationId = @AppId
	SELECT @CountR = @@ROWCOUNT

	IF (@CountR <> @Num)
	BEGIN
		SELECT TOP 1 N'', Name
		FROM   @tbNames
		WHERE  LOWER(Name) NOT IN (SELECT ar.LoweredRoleName FROM dbo.aspnet_Roles ar,  @tbRoles r WHERE r.RoleId = ar.RoleId)
		IF( @TranStarted = 1 )
			ROLLBACK TRANSACTION
		RETURN(2)
	END


	DELETE FROM @tbNames WHERE 1=1
	SET @Num = 0
	SET @Pos = 1


	WHILE(@Pos <= LEN(@UserNames))
	BEGIN
		SELECT @NextPos = CHARINDEX(N',', @UserNames,  @Pos)
		IF (@NextPos = 0 OR @NextPos IS NULL)
			SELECT @NextPos = LEN(@UserNames) + 1
		SELECT @Name = RTRIM(LTRIM(SUBSTRING(@UserNames, @Pos, @NextPos - @Pos)))
		SELECT @Pos = @NextPos+1

		INSERT INTO @tbNames VALUES (@Name)
		SET @Num = @Num + 1
	END

	INSERT INTO @tbUsers
	  SELECT UserId
	  FROM   dbo.aspnet_Users ar, @tbNames t
	  WHERE  LOWER(t.Name) = ar.LoweredUserName AND ar.ApplicationId = @AppId

	SELECT @CountU = @@ROWCOUNT
	IF (@CountU <> @Num)
	BEGIN
		SELECT TOP 1 Name, N''
		FROM   @tbNames
		WHERE  LOWER(Name) NOT IN (SELECT au.LoweredUserName FROM dbo.aspnet_Users au,  @tbUsers u WHERE u.UserId = au.UserId)

		IF( @TranStarted = 1 )
			ROLLBACK TRANSACTION
		RETURN(1)
	END

	SELECT  @CountAll = COUNT(*)
	FROM	dbo.aspnet_UsersInRoles ur, @tbUsers u, @tbRoles r
	WHERE   ur.UserId = u.UserId AND ur.RoleId = r.RoleId

	IF (@CountAll <> @CountU * @CountR)
	BEGIN
		SELECT TOP 1 UserName, RoleName
		FROM		 @tbUsers tu, @tbRoles tr, dbo.aspnet_Users u, dbo.aspnet_Roles r
		WHERE		 u.UserId = tu.UserId AND r.RoleId = tr.RoleId AND
					 tu.UserId NOT IN (SELECT ur.UserId FROM dbo.aspnet_UsersInRoles ur WHERE ur.RoleId = tr.RoleId) AND
					 tr.RoleId NOT IN (SELECT ur.RoleId FROM dbo.aspnet_UsersInRoles ur WHERE ur.UserId = tu.UserId)
		IF( @TranStarted = 1 )
			ROLLBACK TRANSACTION
		RETURN(3)
	END

	DELETE FROM dbo.aspnet_UsersInRoles
	WHERE UserId IN (SELECT UserId FROM @tbUsers)
	  AND RoleId IN (SELECT RoleId FROM @tbRoles)
	IF( @TranStarted = 1 )
		COMMIT TRANSACTION
	RETURN(0)
END
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_Budget]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[f_Admin_Insert_Budget]
			@BudgetDate datetime,
		@Amount decimal,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int,
		@Removed bit
	
AS
INSERT INTO [dbo].[l_Budget] 
		([BudgetDate]
      ,[Amount]
      ,[CompanyID]
      ,[ModifiedDate]
      ,[ModifiedBy]
	  ,Removed )

	VALUES
		(
		@BudgetDate,
		@Amount,
		@CompanyID,
		@ModifiedDate,
		@ModifiedBy,
		@Removed 
		)
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN

GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_CashBox]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[f_Admin_Insert_CashBox]
			@ActualDate datetime,
		@Amount decimal,
		@CreatedDate datetime,
		@MovementTypeID int,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int,
		@Removed bit
	
AS
INSERT INTO [dbo].[t_CashBox] 
		([ActualDate]
      ,[Amount]
      ,[CreatedDate]
      ,[MovementTypeID]
      ,[CompanyID]
      ,[ModifiedDate]
      ,[ModifiedBy]
	  ,[Removed])

	VALUES
		(
		@ActualDate,
		@Amount,
		@CreatedDate,
		@MovementTypeID,
		@CompanyID,
		@ModifiedDate,
		@ModifiedBy,
		@Removed
		)
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN

GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_CashMovement]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[f_Admin_Insert_CashMovement]
			@ActualDate datetime,
		@Amount decimal,
		@CreatedDate datetime,
		@CashTypeID int,
		@MoneyUnitID int,
		@UserID int,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int,
		@Removed bit
	
AS
INSERT INTO [dbo].[t_CashMovement] 
		([ActualDate]
      ,[Amount]
      ,[CreatedDate]
      ,[CashTypeID]
      ,[MoneyUnitID]
      ,[UserID]
      ,[CompanyID]
      ,[ModifiedDate]
      ,[ModifiedBy]
	  ,[Removed])

	VALUES
		(
		@ActualDate,
		@Amount,
		@CreatedDate,
		@CashTypeID,
		@MoneyUnitID,
		@UserID,
		@CompanyID,
		@ModifiedDate,
		@ModifiedBy,
		@Removed
		)
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN

GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_CashReconciliation]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[f_Admin_Insert_CashReconciliation]
			@ActualDate datetime,
		@CreatedDate datetime,
		@ReconcilationTypeID int,
		@UserID int,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int,
		@Removed bit
	
AS
INSERT INTO [dbo].[t_CashReconciliation] 
		([ActualDate]
	  ,[CreatedDate]
      ,[ReconciliationTypeID]
      ,[UserID]
      ,[CompanyID]
      ,[ModifiedDate]
      ,[ModifiedBy]
	  ,[Removed])

	VALUES
		(
		@ActualDate,
		@CreatedDate,
		@ReconcilationTypeID,
		@UserID,
		@CompanyID,
		@ModifiedDate,
		@ModifiedBy,
		@Removed  
		)
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN

GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_CashType]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[f_Admin_Insert_CashType]
			@CashType varchar(50),
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int,
		@Removed bit
	
AS
INSERT INTO [dbo].[l_CashType] 
		([CashType]
		,[CompanyID]
		,[ModifiedDate]
		,[ModifiedBy]
		,[Removed])

	VALUES
		(
		@CashType, 
		@CompanyID,
		@ModifiedDate,
		@ModifiedBy,
		@Removed
		)
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN

GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_CoinMovement]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[f_Admin_Insert_CoinMovement]
			@ActualDate datetime,
		@Amount decimal(18,2),
		@CreatedDate datetime,
		@MovementTypeID int,
		@MoneyUnitID int,
		@UserID int,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int,
		@Removed bit
	
AS
INSERT INTO [dbo].[t_CoinMovement] 
		([ActualDate]
      ,[Amount]
      ,[CreatedDate]
      ,[MovementTypeID]
      ,[MoneyUnitID]
      ,[UserID]
      ,[CompanyID]
      ,[ModifiedDate]
      ,[ModifiedBy]
	  ,[Removed])

	VALUES
		(
		@ActualDate,
		@Amount,
		@CreatedDate,
		@MovementTypeID,
		@MoneyUnitID,
		@UserID,
		@CompanyID,
		@ModifiedDate,
		@ModifiedBy,
		@Removed
		)
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN

GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_Comment]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[f_Admin_Insert_Comment]
			@Comment varchar(50),
		@CreatedDate datetime,	
		@CommentTypeID int,
        @CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int,
		@Removed bit
	
AS
INSERT INTO [dbo].[t_Comment] 
		([Comment]
	  ,[CreatedDate]
      ,[CommentTypeID]
      ,[CompanyID]
      ,[ModifiedDate]
      ,[ModifiedBy]
	  ,[Removed])

	VALUES
		(
		@Comment,
		@CreatedDate,
		@CommentTypeID,
		@CompanyID,
		@ModifiedDate ,
		@ModifiedBy ,
		@Removed 
		)
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN

GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_CommentType]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[f_Admin_Insert_CommentType]
			@CommentType varchar(50),
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int,
		@Removed bit
	
AS
INSERT INTO [dbo].[l_CommentType] 
		([CommentType]
		,[CompanyID]
		,[ModifiedDate]
		,[ModifiedBy]
		,[Removed])

	VALUES
		(
		@CommentType,
		@CompanyID,
		@ModifiedDate,
		@ModifiedBy,
		@Removed
	    )
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN

GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_ElectronicFund]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[f_Admin_Insert_ElectronicFund]
			@ElectronicFund varchar(50),
		@Total decimal(18,2),
		@CreatedDate datetime,
		@ElectronicTypeID int,
		@UserID int,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int,
		@Removed bit
	
AS
INSERT INTO [dbo].[t_ElectronicFund] 
		([ElectronicFund]
      ,[Total]
      ,[CreatedDate]
      ,[ElectronicTypeID]
      ,[UserID]
      ,[CompanyID]
      ,[ModifiedDate]
      ,[ModifiedBy]
	  ,[Removed])

	VALUES
		(
		@ElectronicFund,
		@Total,
		@CreatedDate,
		@ElectronicTypeID,
		@UserID,
		@CompanyID,
		@ModifiedDate,
		@ModifiedBy,
		@Removed
		)
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN

GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_ElectronicType]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[f_Admin_Insert_ElectronicType]
			@ElectronicType varchar(50),
		@ElectronicTypeDescription varchar(50),
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int,
		@Removed bit
	
AS
INSERT INTO [dbo].[l_ElectronicType] 
		([ElectronicType]
		,[ElectronicTypeDescription]
		,[CompanyID]
		,[ModifiedDate]
		,[ModifiedBy]
		,[Removed])

	VALUES
		(
		@ElectronicType,
		@ElectronicTypeDescription,
		@CompanyID,
		@ModifiedDate,
		@ModifiedBy,
		@Removed
		)
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN

GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_FNB]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[f_Admin_Insert_FNB]
			@ActualDate datetime,
		@Amount decimal(18,2),
		@CreatedDate datetime,
		@FNBTypeID int,
		@UserID int,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int,
		@Removed bit
	
AS
INSERT INTO [dbo].[t_FNB] 
		([ActualDate]
      ,[Amount]
      ,[CreatedDate]
      ,[FNBTypeID]
      ,[UserID]
      ,[CompanyID]
      ,[ModifiedDate]
      ,[ModifiedBy]
	  ,[Removed])

	VALUES
		(
		@ActualDate,
		@Amount,
		@CreatedDate,
		@FNBTypeID,
		@UserID,
		@CompanyID,
		@ModifiedDate,
		@ModifiedBy,
		@Removed  
		)
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN

GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_FNBType]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[f_Admin_Insert_FNBType]
			@FNBType varchar(100),
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int,
		@Removed bit	
	
AS
INSERT INTO [dbo].[l_FNBType] 
		([FNBType]
		,[CompanyID]
		,[ModifiedDate]
		,[ModifiedBy]
		,[Removed])

	VALUES
		(
		@FNBType,
		@CompanyID,
		@ModifiedDate,
		@ModifiedBy,
		@Removed 
		)
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN

GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_GRVList]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[f_Admin_Insert_GRVList]
			@InvoiceNumber varchar(50),
		@StateDate datetime,
		@Number varchar(50),
		@PayDate datetime,
		@PinkSlipNumber varchar(10),
		@GRVDate datetime,
		@InvoiceDate datetime,
		@ExcludingVat decimal,
		@IncludingVat decimal,
		@CreatedDate datetime,
		@GRVTypeID int,
		@SupplierID int,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int,
		@Removed bit
	
AS
INSERT INTO [dbo].[t_GRVList] 
		([InvoiceNumber]
      ,[StateDate]
      ,[Number]
      ,[PayDate]
      ,[PinkSlipNumber]
      ,[GRVDate]
      ,[InvoiceDate]
      ,[ExcludingVat]
      ,[IncludingVat]
      ,[CreatedDate]
      ,[GRVTypeID]
      ,[SupplierID]
      ,[CompanyID]
      ,[ModifiedDate]
      ,[ModifiedBy]
	  ,[Removed])

	VALUES
		(
		@InvoiceNumber,
		@StateDate,
		@Number,
		@PayDate,
		@PinkSlipNumber,
		@GRVDate,
		@InvoiceDate,
		@ExcludingVat,
		@IncludingVat,
		@CreatedDate,
		@GRVTypeID,
		@SupplierID,
		@CompanyID,
		@ModifiedDate,
		@ModifiedBy,
		@Removed
		)
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN

GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_GRVType]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[f_Admin_Insert_GRVType]
			@GRVType varchar(50),
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int,
		@Removed bit
	
AS
INSERT INTO [dbo].[l_GRVType] 
		([GRVType]
		,[CompanyID]
		,[ModifiedDate]
		,[ModifiedBy]
		,[Removed])

	VALUES
		(
		@GRVType, 
		@CompanyID,
		@ModifiedDate,
		@ModifiedBy,
		@Removed
		)
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN

GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_InstantMoney]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[f_Admin_Insert_InstantMoney]
			@ActualDate datetime,
		@Amount decimal(18,2),
		@CreatedDate datetime,
		@InstantMoneyTypeID int,
		@UserID int,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int,
		@Removed bit
	
AS
INSERT INTO [dbo].[t_InstantMoney] 
		([ActualDate]
      ,[Amount]
      ,[CreatedDate]
      ,[InstantMoneyTypeID]
      ,[UserID]
      ,[CompanyID]
      ,[ModifiedDate]
      ,[ModifiedBy]
	  ,[Removed])

	VALUES
		(
		@ActualDate,
		@Amount,
		@CreatedDate,
		@InstantMoneyTypeID,
		@UserID,
		@CompanyID,
		@ModifiedDate ,
		@ModifiedBy ,
		@Removed
		)
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN

GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_InstantMoneyType]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[f_Admin_Insert_InstantMoneyType]
			@InstantMoneyType varchar(50),
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int,
		@Removed bit	
	
AS
INSERT INTO [dbo].[l_InstantMoneyType] 
		([InstantMoneyType]
		,[CompanyID]
		,[ModifiedDate]
		,[ModifiedBy]
		,[Removed])

	VALUES
		(
		@InstantMoneyType,
		@CompanyID,
		@ModifiedDate,
		@ModifiedBy,
		@Removed
		)
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN

GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_KwikPay]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[f_Admin_Insert_KwikPay]
			@ActualDate datetime,
		@Amount decimal(18,2),
		@CreatedDate datetime,
		@KwikPayTypeID int,
		@UserID int,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int,
		@Removed bit
	
AS
INSERT INTO [dbo].[t_KwikPay] 
		([ActualDate]
      ,[Amount]
      ,[CreatedDate]
      ,[KwikPayTypeID]
      ,[UserID]
      ,[CompanyID]
      ,[ModifiedDate]
      ,[ModifiedBy]
	  ,Removed)

	VALUES
		(
		@ActualDate,
		@Amount,
		@CreatedDate,
		@KwikPayTypeID,
		@UserID,
		@CompanyID,
		@ModifiedDate,
		@ModifiedBy,
		@Removed
		)
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN

GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_KwikPayType]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[f_Admin_Insert_KwikPayType]
			@KwikPayType varchar(50),
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int,
		@Removed bit
	
AS
INSERT INTO [dbo].[l_KwikPayType] 
		([KwikPayType]
		,[CompanyID]
		,[ModifiedDate] 
		,[ModifiedBy]  
		,[Removed]) 

	VALUES
		(
		@KwikPayType,
		@CompanyID,
		@ModifiedDate,
		@ModifiedBy,
		@Removed 
		)
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN

GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_MemberSpouse]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[f_Admin_Insert_MemberSpouse]
			@InstantMoneyType varchar(50),
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int,
		@Removed bit	
	
AS
INSERT INTO [dbo].[l_InstantMoneyType] 
		([InstantMoneyType]
		,[CompanyID]
		,[ModifiedDate]
		,[ModifiedBy]
		,[Removed])

	VALUES
		(
		@InstantMoneyType,
		@CompanyID,
		@ModifiedDate,
		@ModifiedBy,
		@Removed
		)
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN

GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_MoneyUnit]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[f_Admin_Insert_MoneyUnit]
				@MoneyUnit varchar(50),
			@CompanyID int,
			@ModifiedDate datetime,
			@ModifiedBy int,
			@Removed bit
	
AS
INSERT INTO [dbo].[l_MoneyUnit] 
		([MoneyUnit]
		,[CompanyID]
		,[ModifiedDate]
		,[ModifiedBy]
		,[Removed])

	VALUES
		(
		@MoneyUnit,
		@CompanyID,
		@ModifiedDate,
		@ModifiedBy,
		@Removed
		)
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN

GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_MovementType]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[f_Admin_Insert_MovementType]
			@MovementType varchar(50),
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int,
		@Removed bit
AS
INSERT INTO [dbo].[l_MovementType] 
		([MovementType]
		,[CompanyID]
		,[ModifiedDate]
		,[ModifiedBy]
		,[Removed])

	VALUES
		(
		@MovementType,
		@CompanyID,
		@ModifiedDate,
		@ModifiedBy,
		@Removed
		)
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN

GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_Order]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[f_Admin_Insert_Order]
			@OrderDate datetime,
		@ExpectedDeliveryDate datetime,
		@Amount decimal(18,2),
		@CreatedDate datetime,
		@SupplierID int,
		@UserID int,
		@CommentID int,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int,
		@Removed bit
	
AS
INSERT INTO [dbo].[t_Order] 
		([OrderDate]
      ,[ExpectedDeliveryDate]
      ,[Amount]
      ,[CreatedDate]
      ,[SupplierID]
      ,[UserID]
      ,[CommentID]
      ,[CompanyID]
      ,[ModifiedDate]
      ,[ModifiedBy]
	  ,Removed)

	VALUES
		(
		@OrderDate,
		@ExpectedDeliveryDate,
		@Amount,
		@CreatedDate,
		@SupplierID,
		@UserID,
		@CommentID,
		@CompanyID,
		@ModifiedDate,
		@ModifiedBy,
		@Removed
		)
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN

GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_Permission]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[f_Admin_Insert_Permission]
			@Permissions int
	
AS
INSERT INTO [dbo].[l_Permission] 
		([Permission])

	VALUES
		(
		@Permissions )
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN

GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_PickUp]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[f_Admin_Insert_PickUp]
			@ActualDate datetime,
		@Amount decimal,
		@CreatedDate datetime,
		@CashTypeID int,
		@UserID int,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int,
		@Removed bit
	
AS
INSERT INTO [dbo].[t_PickUp] 
		([ActualDate]
      ,[Amount]
      ,[CreatedDate]
      ,[CashTypeID]
      ,[UserID]
      ,[CompanyID]
      ,[ModifiedDate]
      ,[ModifiedBy]
	  ,[Removed])

	VALUES
		(
		@ActualDate,
		@Amount,
		@CreatedDate,
		@CashTypeID,
		@UserID,
		@CompanyID,
		@ModifiedDate,
		@ModifiedBy,
		@Removed
		)
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN

GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_Product]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[f_Admin_Insert_Product]
			@Products int,
		@ProductDescription varchar(50),
		@Price decimal(18,2),
		@Quantity int,
		@Total int,
		@BTW decimal(18,2),
		@CreatedDate datetime,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int,
		@Removed bit,
		@SupplierID int

	
AS
INSERT INTO [dbo].[t_Product] 
		([Product]
      ,[ProductDescription]
      ,[Price]
      ,[Quantity]
      ,[Total]
      ,[BTW]
      ,[CreatedDate]
      ,[CompanyID]
      ,[ModifiedDate]
      ,[ModifiedBy]
	  ,[Removed]
	  ,[SupplierID])

	VALUES
		(
		@Products,
		@ProductDescription,
		@Price,
		@Quantity,
		@Total,
		@BTW,
		@CreatedDate,
		@CompanyID,
		@ModifiedDate,
		@ModifiedBy,
		@Removed,
		@SupplierID  
		)
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN

GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_ProofOfPayment]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[f_Admin_Insert_ProofOfPayment]
			@ActualDate datetime,
		@PaymentDescription varchar(50),
		@CreatedDate datetime,
		@SupplierID int,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int,
		@Removed bit
	
AS
INSERT INTO [dbo].[t_ProofOfPayment] 
		([ActualDate]
      ,[PaymentDescription]
      ,[CreatedDate]
      ,[SupplierID]
      ,[CompanyID] 
      ,[ModifiedDate]
      ,[ModifiedBy]
	  ,Removed)

	VALUES
		(
		@ActualDate,
		@PaymentDescription,
		@CreatedDate,
		@SupplierID,
		@CompanyID,
		@ModifiedDate,
		@ModifiedBy,
		@Removed
		)
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN

GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_Reconciliation]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[f_Admin_Insert_Reconciliation]
			@ActualDate datetime,
		@UserID int,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int,
		@Removed bit
	
AS
INSERT INTO [dbo].[l_Reconciliation] 
		([ActualDate]
		,[UserID]
		,[CompanyID]
		,[ModifiedDate]
		,[ModifiedBy]
		,[Removed])

	VALUES
		(
		@ActualDate,
		@UserID,
		@CompanyID,
		@ModifiedDate,
		@ModifiedBy,
		@Removed
		)
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN

GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_Status]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[f_Admin_Insert_Status]
			@StatusName varchar(50),
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int,
		@Removed bit	
	
AS
INSERT INTO [dbo].[l_Status] 
		([StatusName]
		,[CompanyID]
		,[ModifiedDate]
		,[ModifiedBy]
		,[Removed])

	VALUES
		(
		@StatusName,
		@CompanyID,
		@ModifiedDate,
		@ModifiedBy,
		@Removed
		)
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN

GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_Supplier]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[f_Admin_Insert_Supplier]
			@Supplier int,
		@StockCondition varchar(50),
		@Term varchar(50),
		@CreatedDate datetime,
		@SupplierTypeID int,
		
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int,
		@Removed bit
		
	
AS
INSERT INTO [dbo].[t_Supplier] 
		([Supplier]
      ,[StockCondition]
      ,[Term]
      ,[CreatedDate]
      ,[SupplierTypeID]
    
      ,[CompanyID]
      ,[ModifiedDate]
      ,[ModifiedBy]
	  ,[Removed])

	VALUES
		(
		@Supplier,
		@StockCondition,
		@Term,
		@CreatedDate,
		@SupplierTypeID,

		@CompanyID,
		@ModifiedDate,
		@ModifiedBy,
		@Removed
		 )
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN

GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_SupplierType]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[f_Admin_Insert_SupplierType]
			@SupplierType varchar(50),
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int,
		@Removed bit
	
AS
INSERT INTO [dbo].[l_SupplierType] 
		([SupplierType]
		,[CompanyID]
		,[ModifiedDate]
		,[ModifiedBy]
		,[Removed])

	VALUES
		(
		@SupplierType,
		@CompanyID,
		@ModifiedDate,
		@ModifiedBy,
		@Removed
		)
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN

GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_Transit]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[f_Admin_Insert_Transit]
			@ActualDate datetime,
		@Amount decimal,
		@CreatedDate datetime,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int,
		@Removed bit
	
AS
INSERT INTO [dbo].[t_Transit] 
		([ActualDate]
      ,[Amount]
      ,[CreatedDate]
      ,[CompanyID]
      ,[ModifiedDate]
      ,[ModifiedBy]
	  ,[Removed])

	VALUES
		(
		@ActualDate,
		@Amount,
		@CreatedDate,
		@CompanyID,
		@ModifiedDate,
		@ModifiedBy,
		@Removed  
		)
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN

GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_UserType]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[f_Admin_Insert_UserType]
			@UserTypes varchar(50)
	
AS
INSERT INTO [dbo].[l_UserType] 
		([UserType])

	VALUES
		(
		@UserTypes )
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN

GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Insert_UserTypePermission]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[f_Admin_Insert_UserTypePermission]
			@PermissionID int,
		@UserTypeID varchar(50)
	
AS
INSERT INTO [dbo].[t_UserTypePermission] 
		([PermissionID]
      ,[UserTypeID])

	VALUES
		(
		@PermissionID,
		@UserTypeID )
SELECT CAST(SCOPE_IDENTITY() AS int);
SET NOCOUNT ON
RETURN

GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Remove_Budget]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Remove_Budget] 
	@BudgetID int,
	@ModifiedDate datetime,
	@ModifiedBy int,
	@Removed bit
   
AS
UPDATE [l_Budget] 
SET         
	ModifiedDate = @ModifiedDate,
	ModifiedBy = @ModifiedBy,
	Removed = @Removed
WHERE BudgetID = @BudgetID
          
	
SET NOCOUNT ON 
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Remove_CashBox]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Remove_CashBox] 
	@CashBoxID int,
	@ModifiedDate datetime,
	@ModifiedBy int,
	@Removed bit
   
AS
UPDATE [t_CashBox] 
SET         
	ModifiedDate = @ModifiedDate,
	ModifiedBy = @ModifiedBy,
	Removed = @Removed
WHERE CashBoxID = @CashBoxID 
          
	
SET NOCOUNT ON 
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Remove_CashReconciliation]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Remove_CashReconciliation] 
	@CashReconcilationID int,
	@ModifiedDate datetime,
	@ModifiedBy int,
	@Removed bit
   
AS
UPDATE [t_CashReconciliation] 
SET         
	ModifiedDate = @ModifiedDate,
	ModifiedBy = @ModifiedBy,
	Removed = @Removed
WHERE CashReconcilationID = @CashReconcilationID
          
	
SET NOCOUNT ON 
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Remove_CoinMovement]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Remove_CoinMovement] 
	@CoinMovementID int,
	@ModifiedDate datetime,
	@ModifiedBy int,
	@Removed bit
   
AS
UPDATE [t_CoinMovement] 
SET         
	ModifiedDate = @ModifiedDate,
	ModifiedBy = @ModifiedBy,
	Removed = @Removed
WHERE CoinMovementID = @CoinMovementID
          
	
SET NOCOUNT ON 
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Remove_Comment]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Remove_Comment] 
	@CommentID int,
	@ModifiedDate datetime,
	@ModifiedBy int,
	@Removed bit
   
AS
UPDATE [t_Comment] 
SET         
	ModifiedDate = @ModifiedDate,
	ModifiedBy = @ModifiedBy,
	Removed = @Removed
WHERE CommentID = @CommentID
          
	
SET NOCOUNT ON 
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Remove_ElectronicFund]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Remove_ElectronicFund] 
		@ElectronicFundID int,
	@ModifiedDate datetime,
	@ModifiedBy int,
	@Removed bit
   
AS
UPDATE [t_ElectronicFund] 
SET         
	ModifiedDate = @ModifiedDate,
	ModifiedBy = @ModifiedBy,
	Removed = @Removed
WHERE ElectronicFundID = @ElectronicFundID
          
	
SET NOCOUNT ON 
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Remove_FNB]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Remove_FNB] 
	@FNBID int,
	@ModifiedDate datetime,
	@ModifiedBy int,
	@Removed bit
   
AS
UPDATE [t_FNB] 
SET         
	ModifiedDate = @ModifiedDate,
	ModifiedBy = @ModifiedBy,
	Removed = @Removed
WHERE FNBID = @FNBID
          
	
SET NOCOUNT ON 
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Remove_GRVList]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Remove_GRVList] 
	@GRVListID int,
	@ModifiedDate datetime,
	@ModifiedBy int,
	@Remove bit
   
AS
UPDATE [t_GRVList] 
SET         
	@ModifiedDate = @ModifiedDate,
	@ModifiedBy = @ModifiedBy,
	@Remove = @Remove
WHERE GRVListID = @GRVListID
          
	
SET NOCOUNT ON 
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Remove_InstantMoney]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

CREATE PROCEDURE [dbo].[f_Admin_Remove_InstantMoney] 
	@InstantMoneyID int,
	@ModifiedDate datetime,
	@ModifiedBy int,
	@Removed bit
   
AS
UPDATE [t_InstantMoney] 
SET         
	ModifiedDate = @ModifiedDate,
	ModifiedBy = @ModifiedBy,
	Removed = @Removed
WHERE InstantMoneyID = @InstantMoneyID
          
	
SET NOCOUNT ON 
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Remove_KwikPay]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Remove_KwikPay] 
	@KwikPayID int,
	@ModifiedDate datetime,
	@ModifiedBy int,
	@Removed bit
   
AS
UPDATE [t_KwikPay] 
SET         
	ModifiedDate = @ModifiedDate,
	ModifiedBy = @ModifiedBy,
	Removed = @Removed
WHERE KwikPayID = @KwikPayID 
          
	
SET NOCOUNT ON 
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Remove_Order]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Remove_Order] 
	@OrderID int,
	@ModifiedDate datetime,
	@ModifiedBy int,
	@Removed bit
   
AS
UPDATE [t_Order] 
SET         
	ModifiedDate = @ModifiedDate,
	ModifiedBy = @ModifiedBy,
	Removed = @Removed
WHERE OrderID = @OrderID
          
	
SET NOCOUNT ON 
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Remove_PickUp]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Remove_PickUp] 
	@PickUpID int,
	@ModifiedDate datetime,
	@ModifiedBy int,
	@Removed bit
   
AS
UPDATE [t_PickUp] 
SET         
	ModifiedDate = @ModifiedDate,
	ModifiedBy = @ModifiedBy,
	Removed = @Removed
WHERE PickUpID = @PickUpID
          
	
SET NOCOUNT ON 
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Remove_Product]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Remove_Product] 
	@ProductID int,
	@ModifiedDate datetime,
	@ModifiedBy int,
	@Removed bit
   
AS
UPDATE [t_Product] 
SET         
	ModifiedDate = @ModifiedDate,
	ModifiedBy = @ModifiedBy,
	Removed = @Removed
WHERE ProductID = @ProductID
          
	
SET NOCOUNT ON 
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Remove_ProofOfPayment]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Remove_ProofOfPayment] 
	@ProofOfPaymentID int,
	@ModifiedDate datetime,
	@ModifiedBy int,
	@Removed bit
   
AS
UPDATE [t_ProofOfPayment] 
SET         
	ModifiedDate = @ModifiedDate,
	ModifiedBy = @ModifiedBy,
	Removed = @Removed
WHERE ProofOfPaymentID = @ProofOfPaymentID
          
	
SET NOCOUNT ON 
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Remove_Supplier]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Remove_Supplier] 
	@SupplierID int,
	@ModifiedDate datetime,
	@ModifiedBy int,
	@Removed bit
   
AS
UPDATE [t_Supplier] 
SET         
	
	ModifiedBy = @ModifiedBy,
	ModifiedDate = @ModifiedDate,
	Removed = @Removed
WHERE SupplierID = @SupplierID 
          
	
SET NOCOUNT ON 
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Remove_Transit]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Remove_Transit] 
	@TransitID int,
	@ModifiedDate datetime,
	@ModifiedBy int,
	@Removed bit
   
AS
UPDATE [t_Transit] 
SET         
	ModifiedDate = @ModifiedDate,
	ModifiedBy = @ModifiedBy,
	Removed = @Removed
WHERE TransitID = @TransitID 
          
	
SET NOCOUNT ON 
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_Budget]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Update_Budget] 
		@BudgetID int,
		@BudgetDate datetime,
		@Amount decimal,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int,
		@Removed bit
	
   
AS
UPDATE [l_Budget] 
           SET
		BudgetDate=@BudgetDate,
		Amount=@Amount,
		CompanyID=@CompanyID,
		ModifiedDate=@ModifiedDate,
		ModifiedBy=@ModifiedBy,
		Removed=@Removed
where BudgetID =@BudgetID
          
	
SET NOCOUNT ON 
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_CashBox]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Update_CashBox] 
		@CashBoxID int,
		@ActualDate datetime,
		@Amount decimal(18,2),
		@CreatedDate datetime,
		@MovementTypeID int,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int
   
AS
UPDATE [t_CashBox] 
           SET
		ActualDate=@ActualDate,
		Amount=@Amount,
		CreatedDate=@CreatedDate,
		MovementTypeID=@MovementTypeID,
		CompanyID=@CompanyID,
		ModifiedDate=@ModifiedDate,
		ModifiedBy=@ModifiedBy  
where CashBoxID =@CashBoxID 
          
	
SET NOCOUNT ON 
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_CashMovement]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Update_CashMovement] 
		@CashMovementID int,
		@ActualDate datetime,
		@Amount decimal,
		@CreatedDate datetime,
		@CashTypeID int,
		@MoneyUnitID int,
		@UserID int,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int
	
   
AS
UPDATE [t_CashMovement] 
           SET
		ActualDate=@ActualDate,
		Amount=@Amount,
		CreatedDate=@CreatedDate,
		CashTypeID=@CashTypeID,
		MoneyUnitID=@MoneyUnitID,
		UserID=@UserID,
		CompanyID=@CompanyID,
		ModifiedDate=@ModifiedDate,
		ModifiedBy=@ModifiedBy  
where CashMovementID =@CashMovementID
          
	
SET NOCOUNT ON 
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_CashReconciliation]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Update_CashReconciliation] 
		@CashReconciliationID int,
		@ActualDate datetime,
		@CreatedDate datetime,
		@ReconciliationTypeID int,
		@UserID int,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int
   
AS
UPDATE t_CashReconcilation 
           SET
		ActualDate=@ActualDate,
		CreatedDate=@CreatedDate,
		ReconciliationTypeID=@ReconciliationTypeID,
		UserID=@UserID,
		CompanyID=@CompanyID,
		ModifiedDate=@ModifiedDate,
		ModifiedBy=@ModifiedBy  
where CashReconcilationID =@CashReconciliationID
          
	
SET NOCOUNT ON 
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_CoinMovement]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Update_CoinMovement] 
		@CoinMovementID int,
		@ActualDate datetime,
		@Amount decimal(18,2),
		@CreatedDate datetime,
		@MovementTypeID int,
		@MoneyUnitID int,
		@UserID int,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int
	
   
AS
UPDATE [t_CoinMovement] 
           SET
		ActualDate=@ActualDate,
		Amount=@Amount,
		CreatedDate=@CreatedDate,
		MovementTypeID=@MovementTypeID,
		MoneyUnitID=@MoneyUnitID,
		UserID=@UserID,
		CompanyID=@CompanyID,
		ModifiedDate=@ModifiedDate,
		ModifiedBy=@ModifiedBy  
where CoinMovementID =@CoinMovementID
          
	
SET NOCOUNT ON 
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_Comment]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Update_Comment] 
		@CommentID int,
		@Comment varchar(50),
		@CreatedDate datetime,
		@CommentTypeID int,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int
	
   
AS
UPDATE [t_Comment] 
           SET
		Comment=@Comment,
		CreatedDate=@CreatedDate,
		CommentTypeID=@CommentTypeID,
		@CompanyID=@CompanyID,
		ModifiedDate=@ModifiedDate ,
		ModifiedBy=@ModifiedBy  
where CommentID =@CommentID 
          
	
SET NOCOUNT ON 
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_ElectronicFund]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Update_ElectronicFund] 
		@ElectronicFundID int,
		@ElectronicFund varchar(50),
		@Total decimal(18,2),
		@CreatedDate datetime,
		@ElectronicTypeID int,
		@UserID int,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int
	
   
AS
UPDATE [t_ElectronicFund] 
           SET
		ElectronicFund=@ElectronicFund,
		Total=@Total,
		CreatedDate=@CreatedDate,
		ElectronicTypeID=@ElectronicTypeID,
		UserID=@UserID,
		CompanyID=@CompanyID,
		ModifiedDate=@ModifiedDate,
		ModifiedBy=@ModifiedBy  
where ElectronicFundID =@ElectronicFundID
          
	
SET NOCOUNT ON 
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_FNB]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Update_FNB] 
		@FNBID int,
		@ActualDate datetime,
		@Amount decimal(18,2),
		@CreatedDate datetime,
		@FNBTypeID int,
		@UserID int,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int	
   
AS
UPDATE [t_FNB] 
           SET
		ActualDate=@ActualDate,
		Amount=@Amount,
		CreatedDate=@CreatedDate,
		FNBTypeID=@FNBTypeID,
		UserID=@UserID,
		CompanyID=@CompanyID ,
		ModifiedDate=@ModifiedDate ,
		ModifiedBy=@ModifiedBy  
where FNBID =@FNBID
          
	
SET NOCOUNT ON 
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_GRVList]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Update_GRVList] 
		@GRVListID int,
		@InvoiceNumber varchar(50),
		@StateDate datetime,
		@Number varchar(50),
		@PayDate datetime,
		@PinkSlipNumber varchar(10),
		@GRVDate datetime,
		@InvoiceDate datetime,
		@ExcludingVat decimal,
		@IncludingVat decimal,
		@CreatedDate datetime,
		@GRVTypeID int,
		@SupplierID int,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int
	
   
AS
UPDATE [t_GRVList] 
           SET
		InvoiceNumber=@InvoiceNumber,
		StateDate=@StateDate,
		Number=@Number,
		PayDate=@PayDate,
		PinkSlipNumber=@PinkSlipNumber,
		GRVDate=@GRVDate,
		InvoiceDate=@InvoiceDate,
		ExcludingVat=@ExcludingVat,
		IncludingVat=@IncludingVat,
		CreatedDate=@CreatedDate,
		GRVTypeID=@GRVTypeID,
		SupplierID=@SupplierID,
		CompanyID=@CompanyID,
		ModifiedDate=@ModifiedDate,
		ModifiedBy=@ModifiedBy  
where GRVListID =@GRVListID
          
	
SET NOCOUNT ON 
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_InstantMoney]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Update_InstantMoney] 
		@InstantMoneyID int,
		@ActualDate datetime,
		@Amount decimal(18,2),
		@CreatedDate datetime,
		@InstantMoneyTypeID int,
		@UserID int,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int
	
AS
UPDATE [t_InstantMoney] 
           SET
		ActualDate=@ActualDate,
		Amount=@Amount,
		CreatedDate=@CreatedDate,
		InstantMoneyTypeID=@InstantMoneyTypeID,
		UserID=@UserID,
		CompanyID=@CompanyID,
		ModifiedDate=@ModifiedDate,
		ModifiedBy=@ModifiedBy  
where InstantMoneyID =@InstantMoneyID
          
	
SET NOCOUNT ON 
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_KwikPay]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Update_KwikPay] 
		@KwikPayID int,
		@ActualDate datetime,
		@Amount decimal(18,2),
		@CreatedDate datetime,
		@KwikPayTypeID int,
		@UserID int,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int
	
   
AS
UPDATE [t_KwikPay] 
           SET
		ActualDate=@ActualDate,
		Amount=@Amount,
		CreatedDate=@CreatedDate,
		KwikPayTypeID=@KwikPayTypeID,
		UserID=@UserID,
		CompanyID=@CompanyID ,
		ModifiedDate=@ModifiedDate ,
		ModifiedBy=@ModifiedBy  
where KwikPayID =@KwikPayID
          
	
SET NOCOUNT ON 
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_Order]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Update_Order] 
		@OrderID int,
		@OrderDate datetime,
		@ExpectedDeliveryDate datetime,
		@Amount decimal(18,2),
		@CreatedDate datetime,
		@SupplierID int,
		@UserID int,
		@CommentID int,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int
	
   
AS
UPDATE [t_Order] 
           SET
		OrderDate=@OrderDate,
		ExpectedDeliveryDate=@ExpectedDeliveryDate,
		Amount=@Amount,
		CreatedDate=@CreatedDate,
		SupplierID=@SupplierID,
		UserID=@UserID,
		CommentID=@CommentID,
		CompanyID=@CompanyID,
		ModifiedDate=@ModifiedDate,
		ModifiedBy=@ModifiedBy  
where OrderID =@OrderID 
          
	
SET NOCOUNT ON 
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_PickUp]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Update_PickUp] 
		@PickUpID int,
		@ActualDate datetime,
		@Amount decimal,
		@CreatedDate datetime,
		@CashTypeID int,
		@UserID int,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int
	
   
AS
UPDATE [t_PickUp] 
           SET
		ActualDate=@ActualDate,
		Amount=@Amount,
		CreatedDate=@CreatedDate,
		CashTypeID=@CashTypeID,
		UserID=@UserID,
		CompanyID=@CompanyID,
		ModifiedDate=@ModifiedDate,
		ModifiedBy=@ModifiedBy  
where PickUpID =@PickUpID 
          
	
SET NOCOUNT ON 
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_Product]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

CREATE PROCEDURE [dbo].[f_Admin_Update_Product] 
		@ProductID int,
		@Products varchar(50),
		@ProductDescription varchar(50),
		@Price decimal(18,2),
		@Quantity varchar(50),
		@Total int,
		@BTW decimal(18,2),
		@CreatedDate datetime,
		@CamponyID int,
		@ModifiedDate datetime,
		@ModifiedBy int,
		@Removed bit,
		@SupplierID int
	
   
AS
UPDATE [t_Product] 
           SET
		Product=@Products,
		ProductDescription=@ProductDescription,
		Price=@Price,
		Quantity=@Quantity,
		Total=@Total,
		BTW=@BTW,
		Removed=@Removed ,
		ModifiedDate=@ModifiedDate,
		ModifiedBy=@ModifiedBy,
		SupplierID = @SupplierID  
where ProductID =@ProductID
          
	
SET NOCOUNT ON 
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_ProofOfPayment]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Update_ProofOfPayment] 
		@ProofOfPaymentID int,
		@ActualDate datetime,
		@PaymentDescription varchar(50),
		@CreatedDate datetime,
		@SupplierID int,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int
	
AS
UPDATE [t_ProofOfPayment] 
           SET
		ActualDate=@ActualDate,
		PaymentDescription=@PaymentDescription,
		CreatedDate=@CreatedDate,
		SupplierID=@SupplierID,
		CompanyID=@CompanyID,
		ModifiedDate=@ModifiedDate,
		ModifiedBy=@ModifiedBy  
where ProofOfPaymentID =@ProofOfPaymentID 
          
	
SET NOCOUNT ON 
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_Status]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Update_Status] 
		(
		@StatusID int,
		@StatusName varchar(50),
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int

	)
   
AS
UPDATE l_Status 
           SET
		StatusName =@StatusName,
		CompanyID=@CompanyID,
		ModifiedDate=@ModifiedDate,
		ModifiedBy=@ModifiedBy  
where StatusID =@StatusID
          
	
SET NOCOUNT ON 
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_SupllierType]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Update_SupllierType] 
		(
		@SupplierTypeID int,
		@SupplierType varchar(50),
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int

	)
   
AS
UPDATE l_SupplierType 
           SET
		SupplierType =@SupplierType,
		CompanyID=@CompanyID,
		ModifiedDate=@ModifiedDate,
		ModifiedBy=@ModifiedBy  
where SupplierTypeID =@SupplierTypeID
          
	
SET NOCOUNT ON 
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_Supplier]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

CREATE PROCEDURE [dbo].[f_Admin_Update_Supplier] 
		@SupplierID int,
		@Supplier varchar(50),
		@StockCondition varchar(50),
		@Term varchar(50),
		@CreatedDate datetime,
		@SupplierTypeID int,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int
	
   
AS
UPDATE [t_Supplier] 
           SET
		Supplier=@Supplier,
		StockCondition=@StockCondition,
		Term=@Term,
		CreatedDate=@CreatedDate,
		SupplierTypeID=@SupplierTypeID,
		CompanyID=@CompanyID,
		ModifiedDate=@ModifiedDate,
		ModifiedBy=@ModifiedBy  
where SupplierID =@SupplierID
          
	
SET NOCOUNT ON 
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_SupplierType]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Update_SupplierType] 
		(
		@SupplierTypeID int,
		@SupplierType varchar(50),
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int

	)
   
AS
UPDATE l_SupplierType 
           SET
		SupplierType =@SupplierType,
		CompanyID=@CompanyID,
		ModifiedDate=@ModifiedDate,
		ModifiedBy=@ModifiedBy  
where SupplierTypeID =@SupplierTypeID
          
	
SET NOCOUNT ON 
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[f_Admin_Update_Transit]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

Create PROCEDURE [dbo].[f_Admin_Update_Transit] 
		@TransitID int,
		@ActualDate datetime,
		@Amount decimal,
		@CreatedDate datetime,
		@CompanyID int,
		@ModifiedDate datetime,
		@ModifiedBy int
	
   
AS
UPDATE [t_Transit] 
           SET
		ActualDate=@ActualDate,
		Amount=@Amount,
		CreatedDate=@CreatedDate,
		CompanyID=@CompanyID,
		ModifiedDate=@ModifiedDate,
		ModifiedBy=@ModifiedBy  
where TransitID =@TransitID 
          
	
SET NOCOUNT ON 
	RETURN
GO
/****** Object:  Table [dbo].[aspnet_Applications]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[aspnet_Applications](
	[ApplicationName] [nvarchar](256) NOT NULL,
	[LoweredApplicationName] [nvarchar](256) NOT NULL,
	[ApplicationId] [uniqueidentifier] NOT NULL,
	[Description] [nvarchar](256) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[aspnet_Membership]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[aspnet_Membership](
	[ApplicationId] [uniqueidentifier] NOT NULL,
	[UserId] [uniqueidentifier] NOT NULL,
	[Password] [nvarchar](128) NOT NULL,
	[PasswordFormat] [int] NOT NULL,
	[PasswordSalt] [nvarchar](128) NOT NULL,
	[MobilePIN] [nvarchar](16) NULL,
	[Email] [nvarchar](256) NULL,
	[LoweredEmail] [nvarchar](256) NULL,
	[PasswordQuestion] [nvarchar](256) NULL,
	[PasswordAnswer] [nvarchar](128) NULL,
	[IsApproved] [bit] NOT NULL,
	[IsLockedOut] [bit] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastLoginDate] [datetime] NOT NULL,
	[LastPasswordChangedDate] [datetime] NOT NULL,
	[LastLockoutDate] [datetime] NOT NULL,
	[FailedPasswordAttemptCount] [int] NOT NULL,
	[FailedPasswordAttemptWindowStart] [datetime] NOT NULL,
	[FailedPasswordAnswerAttemptCount] [int] NOT NULL,
	[FailedPasswordAnswerAttemptWindowStart] [datetime] NOT NULL,
	[Comment] [ntext] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[aspnet_Paths]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[aspnet_Paths](
	[ApplicationId] [uniqueidentifier] NOT NULL,
	[PathId] [uniqueidentifier] NOT NULL,
	[Path] [nvarchar](256) NOT NULL,
	[LoweredPath] [nvarchar](256) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[aspnet_PersonalizationAllUsers]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[aspnet_PersonalizationAllUsers](
	[PathId] [uniqueidentifier] NOT NULL,
	[PageSettings] [image] NOT NULL,
	[LastUpdatedDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PathId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[aspnet_PersonalizationPerUser]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[aspnet_PersonalizationPerUser](
	[Id] [uniqueidentifier] NOT NULL,
	[PathId] [uniqueidentifier] NULL,
	[UserId] [uniqueidentifier] NULL,
	[PageSettings] [image] NOT NULL,
	[LastUpdatedDate] [datetime] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[aspnet_Profile]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[aspnet_Profile](
	[UserId] [uniqueidentifier] NOT NULL,
	[PropertyNames] [ntext] NOT NULL,
	[PropertyValuesString] [ntext] NOT NULL,
	[PropertyValuesBinary] [image] NOT NULL,
	[LastUpdatedDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[aspnet_Roles]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[aspnet_Roles](
	[ApplicationId] [uniqueidentifier] NOT NULL,
	[RoleId] [uniqueidentifier] NOT NULL,
	[RoleName] [nvarchar](256) NOT NULL,
	[LoweredRoleName] [nvarchar](256) NOT NULL,
	[Description] [nvarchar](256) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[aspnet_SchemaVersions]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[aspnet_SchemaVersions](
	[Feature] [nvarchar](128) NOT NULL,
	[CompatibleSchemaVersion] [nvarchar](128) NOT NULL,
	[IsCurrentVersion] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Feature] ASC,
	[CompatibleSchemaVersion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[aspnet_Users]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[aspnet_Users](
	[ApplicationId] [uniqueidentifier] NOT NULL,
	[UserId] [uniqueidentifier] NOT NULL,
	[UserName] [nvarchar](256) NOT NULL,
	[LoweredUserName] [nvarchar](256) NOT NULL,
	[MobileAlias] [nvarchar](16) NULL,
	[IsAnonymous] [bit] NOT NULL,
	[LastActivityDate] [datetime] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[aspnet_UsersInRoles]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[aspnet_UsersInRoles](
	[UserId] [uniqueidentifier] NOT NULL,
	[RoleId] [uniqueidentifier] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[l_Budget]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[l_Budget](
	[BudgetID] [int] IDENTITY(1,1) NOT NULL,
	[BudgetDate] [datetime] NULL,
	[Amount] [decimal](18, 2) NULL,
	[CompanyID] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[Removed] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[BudgetID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[l_CashType]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[l_CashType](
	[CashTypeID] [int] IDENTITY(1,1) NOT NULL,
	[CashType] [varchar](50) NULL,
	[CompanyID] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[Removed] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[CashTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[l_CommentType]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[l_CommentType](
	[CommentTypeID] [int] IDENTITY(1,1) NOT NULL,
	[CommentType] [varchar](50) NULL,
	[CompanyID] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[Removed] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[CommentTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[l_ElectronicType]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[l_ElectronicType](
	[ElectronicTypeID] [int] IDENTITY(1,1) NOT NULL,
	[ElectronicType] [varchar](50) NULL,
	[ElectronicTypeDescription] [varchar](50) NULL,
	[CompanyID] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[Removed] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ElectronicTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[l_FNBType]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[l_FNBType](
	[FNBTypeID] [int] IDENTITY(1,1) NOT NULL,
	[FNBType] [varchar](50) NULL,
	[CompanyID] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[Removed] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[FNBTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[l_GRVType]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[l_GRVType](
	[GRVTypeID] [int] IDENTITY(1,1) NOT NULL,
	[GRVType] [varchar](50) NULL,
	[CompanyID] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[Removed] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[GRVTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[l_InstantMoneyType]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[l_InstantMoneyType](
	[InstantMoneyTypeID] [int] IDENTITY(1,1) NOT NULL,
	[InstantMoneyType] [varchar](50) NULL,
	[CompanyID] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[Removed] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[InstantMoneyTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[l_KwikPayType]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[l_KwikPayType](
	[KwikPayTypeID] [int] IDENTITY(1,1) NOT NULL,
	[KwikPayType] [varchar](50) NULL,
	[CompanyID] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[Removed] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[KwikPayTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[l_MoneyUnit]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[l_MoneyUnit](
	[MoneyUnitID] [int] IDENTITY(1,1) NOT NULL,
	[MoneyUnit] [varchar](50) NULL,
	[CompanyID] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[Removed] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MoneyUnitID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[l_MovementType]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[l_MovementType](
	[MovementTypeID] [int] IDENTITY(1,1) NOT NULL,
	[MovementType] [varchar](50) NULL,
	[CompanyID] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[Removed] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MovementTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[l_Permission]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[l_Permission](
	[PermissionID] [int] IDENTITY(1,1) NOT NULL,
	[Permission] [varchar](50) NULL,
	[CompanyID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[PermissionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[l_ReconciliationType]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[l_ReconciliationType](
	[ReconciliationTypeID] [int] IDENTITY(1,1) NOT NULL,
	[ActualDate] [datetime] NULL,
	[UserID] [int] NULL,
	[CompanyID] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[Removed] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ReconciliationTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[l_Status]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[l_Status](
	[StatusID] [int] IDENTITY(1,1) NOT NULL,
	[StatusName] [varchar](50) NULL,
	[CompanyID] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[Removed] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[StatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[l_SupplierType]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[l_SupplierType](
	[SupplierTypeID] [int] IDENTITY(1,1) NOT NULL,
	[SupplierType] [varchar](50) NULL,
	[CompanyID] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[Removed] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[SupplierTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[l_UserType]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[l_UserType](
	[UserTypeID] [int] IDENTITY(1,1) NOT NULL,
	[UserType] [varchar](50) NULL,
	[CompanyID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[t_CashBox]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_CashBox](
	[CashBoxID] [int] IDENTITY(1,1) NOT NULL,
	[ActualDate] [datetime] NULL,
	[Amount] [decimal](18, 2) NULL,
	[CreatedDate] [datetime] NULL,
	[MovementTypeID] [int] NULL,
	[CompanyID] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[Removed] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[CashBoxID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[t_CashMovement]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_CashMovement](
	[CashMovementID] [int] IDENTITY(1,1) NOT NULL,
	[ActualDate] [datetime] NULL,
	[Amount] [decimal](18, 2) NULL,
	[CreatedDate] [datetime] NULL,
	[CashTypeID] [int] NULL,
	[MoneyUnitID] [int] NULL,
	[UserID] [int] NULL,
	[CompanyID] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[Removed] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[CashMovementID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[t_CashReconciliation]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_CashReconciliation](
	[CashReconcilationID] [int] IDENTITY(1,1) NOT NULL,
	[ActualDate] [datetime] NULL,
	[CreatedDate] [datetime] NULL,
	[ReconciliationTypeID] [int] NULL,
	[UserID] [int] NULL,
	[CompanyID] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[Removed] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[CashReconcilationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[t_CoinMovement]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_CoinMovement](
	[CoinMovementID] [int] IDENTITY(1,1) NOT NULL,
	[ActualDate] [datetime] NULL,
	[Amount] [decimal](18, 2) NULL,
	[CreatedDate] [datetime] NULL,
	[MovementTypeID] [int] NULL,
	[MoneyUnitID] [int] NULL,
	[UserID] [int] NULL,
	[CompanyID] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[Removed] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[CoinMovementID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[t_Comment]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_Comment](
	[CommentID] [int] IDENTITY(1,1) NOT NULL,
	[Comment] [varchar](100) NULL,
	[CreatedDate] [datetime] NULL,
	[CommentTypeID] [int] NULL,
	[CompanyID] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[Removed] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[CommentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[t_ElectronicFund]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_ElectronicFund](
	[ElectronicFundID] [int] IDENTITY(1,1) NOT NULL,
	[ElectronicFund] [varchar](50) NULL,
	[Total] [decimal](18, 2) NULL,
	[CreatedDate] [datetime] NULL,
	[ElectronicTypeID] [int] NULL,
	[UserID] [int] NULL,
	[CompanyID] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[Removed] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ElectronicFundID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[t_FNB]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_FNB](
	[FNBID] [int] IDENTITY(1,1) NOT NULL,
	[ActualDate] [datetime] NULL,
	[Amount] [decimal](18, 2) NULL,
	[CreatedDate] [datetime] NULL,
	[FNBTypeID] [int] NULL,
	[UserID] [int] NULL,
	[CompanyID] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[Removed] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[FNBID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[t_GRVList]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_GRVList](
	[GRVListID] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceNumber] [varchar](50) NULL,
	[StateDate] [datetime] NULL,
	[Number] [varchar](50) NULL,
	[PayDate] [datetime] NULL,
	[PinkSlipNumber] [varchar](10) NULL,
	[GRVDate] [datetime] NULL,
	[InvoiceDate] [datetime] NULL,
	[ExcludingVat] [decimal](18, 2) NULL,
	[IncludingVat] [decimal](18, 2) NULL,
	[CreatedDate] [datetime] NULL,
	[GRVTypeID] [int] NULL,
	[SupplierID] [int] NULL,
	[CompanyID] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[Removed] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[GRVListID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[t_InstantMoney]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_InstantMoney](
	[InstantMoneyID] [int] IDENTITY(1,1) NOT NULL,
	[ActualDate] [datetime] NULL,
	[Amount] [decimal](18, 2) NULL,
	[CreatedDate] [datetime] NULL,
	[InstantMoneyTypeID] [int] NULL,
	[UserID] [int] NULL,
	[CompanyID] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[Removed] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[InstantMoneyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[t_KwikPay]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_KwikPay](
	[KwikPayID] [int] IDENTITY(1,1) NOT NULL,
	[ActualDate] [datetime] NULL,
	[Amount] [decimal](18, 2) NULL,
	[CreatedDate] [datetime] NULL,
	[KwikPayTypeID] [int] NULL,
	[UserID] [int] NULL,
	[CompanyID] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[Removed] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[KwikPayID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[t_Order]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_Order](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[OrderDate] [datetime] NULL,
	[ExpectedDeliveryDate] [datetime] NULL,
	[Amount] [decimal](18, 2) NULL,
	[CreatedDate] [datetime] NULL,
	[SupplierID] [int] NULL,
	[UserID] [int] NULL,
	[CommentID] [int] NULL,
	[CompanyID] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[Removed] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[t_OrderProduct]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_OrderProduct](
	[OrderProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NULL,
	[Quantity] [int] NULL,
	[StatusID] [int] NULL,
	[OrderID] [int] NULL,
	[CompanyID] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[Removed] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[t_PickUp]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_PickUp](
	[PickUpID] [int] IDENTITY(1,1) NOT NULL,
	[ActualDate] [datetime] NULL,
	[Amount] [decimal](18, 2) NULL,
	[CreatedDate] [datetime] NULL,
	[CashTypeID] [int] NULL,
	[UserID] [int] NULL,
	[CompanyID] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[Removed] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[PickUpID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[t_PinkSlipOrder]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_PinkSlipOrder](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[OrderNumber] [int] NULL,
	[StatusID] [int] NULL,
	[NumProducts] [int] NULL,
	[SupllierID] [int] NULL,
	[OrderDate] [datetime] NULL,
	[CompanyID] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[Removed] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[t_Product]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_Product](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[Product] [varchar](50) NULL,
	[ProductDescription] [varchar](50) NULL,
	[Price] [decimal](18, 2) NULL,
	[Quantity] [int] NULL,
	[Total] [int] NULL,
	[BTW] [decimal](18, 2) NULL,
	[CreatedDate] [datetime] NULL,
	[CompanyID] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[Removed] [bit] NULL,
	[SupplierID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[t_ProofOfPayment]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_ProofOfPayment](
	[ProofOfPaymentID] [int] IDENTITY(1,1) NOT NULL,
	[ActualDate] [datetime] NULL,
	[PaymentDescription] [varchar](50) NULL,
	[CreatedDate] [datetime] NULL,
	[SupplierID] [int] NULL,
	[CompanyID] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[Removed] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ProofOfPaymentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[t_Supplier]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_Supplier](
	[SupplierID] [int] IDENTITY(1,1) NOT NULL,
	[Supplier] [varchar](50) NULL,
	[StockCondition] [varchar](50) NULL,
	[Term] [varchar](50) NULL,
	[CreatedDate] [datetime] NULL,
	[SupplierTypeID] [int] NULL,
	[CompanyID] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[Removed] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[t_Transit]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_Transit](
	[TransitID] [int] IDENTITY(1,1) NOT NULL,
	[ActualDate] [datetime] NULL,
	[Amount] [decimal](18, 2) NULL,
	[CreatedDate] [datetime] NULL,
	[CompanyID] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[Removed] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[TransitID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[t_User]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_User](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NULL,
	[UserSurname] [varchar](50) NULL,
	[ID] [varchar](50) NULL,
	[UserCell] [varchar](20) NULL,
	[UserEmail] [varchar](50) NULL,
	[UserTypeID] [int] NULL,
	[CompanyID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[t_UserTypePermission]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_UserTypePermission](
	[UserTypePermissionID] [int] IDENTITY(1,1) NOT NULL,
	[PermissionID] [int] NULL,
	[UserTypeID] [int] NULL,
	[CompanyID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserTypePermissionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[vw_aspnet_Applications]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

  CREATE VIEW [dbo].[vw_aspnet_Applications]
  AS SELECT [dbo].[aspnet_Applications].[ApplicationName], [dbo].[aspnet_Applications].[LoweredApplicationName], [dbo].[aspnet_Applications].[ApplicationId], [dbo].[aspnet_Applications].[Description]
  FROM [dbo].[aspnet_Applications]
  
GO
/****** Object:  View [dbo].[vw_aspnet_MembershipUsers]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

  CREATE VIEW [dbo].[vw_aspnet_MembershipUsers]
  AS SELECT [dbo].[aspnet_Membership].[UserId],
            [dbo].[aspnet_Membership].[PasswordFormat],
            [dbo].[aspnet_Membership].[MobilePIN],
            [dbo].[aspnet_Membership].[Email],
            [dbo].[aspnet_Membership].[LoweredEmail],
            [dbo].[aspnet_Membership].[PasswordQuestion],
            [dbo].[aspnet_Membership].[PasswordAnswer],
            [dbo].[aspnet_Membership].[IsApproved],
            [dbo].[aspnet_Membership].[IsLockedOut],
            [dbo].[aspnet_Membership].[CreateDate],
            [dbo].[aspnet_Membership].[LastLoginDate],
            [dbo].[aspnet_Membership].[LastPasswordChangedDate],
            [dbo].[aspnet_Membership].[LastLockoutDate],
            [dbo].[aspnet_Membership].[FailedPasswordAttemptCount],
            [dbo].[aspnet_Membership].[FailedPasswordAttemptWindowStart],
            [dbo].[aspnet_Membership].[FailedPasswordAnswerAttemptCount],
            [dbo].[aspnet_Membership].[FailedPasswordAnswerAttemptWindowStart],
            [dbo].[aspnet_Membership].[Comment],
            [dbo].[aspnet_Users].[ApplicationId],
            [dbo].[aspnet_Users].[UserName],
            [dbo].[aspnet_Users].[MobileAlias],
            [dbo].[aspnet_Users].[IsAnonymous],
            [dbo].[aspnet_Users].[LastActivityDate]
  FROM [dbo].[aspnet_Membership] INNER JOIN [dbo].[aspnet_Users]
      ON [dbo].[aspnet_Membership].[UserId] = [dbo].[aspnet_Users].[UserId]
  
GO
/****** Object:  View [dbo].[vw_aspnet_Profiles]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

  CREATE VIEW [dbo].[vw_aspnet_Profiles]
  AS SELECT [dbo].[aspnet_Profile].[UserId], [dbo].[aspnet_Profile].[LastUpdatedDate],
      [DataSize]=  DATALENGTH([dbo].[aspnet_Profile].[PropertyNames])
                 + DATALENGTH([dbo].[aspnet_Profile].[PropertyValuesString])
                 + DATALENGTH([dbo].[aspnet_Profile].[PropertyValuesBinary])
  FROM [dbo].[aspnet_Profile]
  
GO
/****** Object:  View [dbo].[vw_aspnet_Roles]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

  CREATE VIEW [dbo].[vw_aspnet_Roles]
  AS SELECT [dbo].[aspnet_Roles].[ApplicationId], [dbo].[aspnet_Roles].[RoleId], [dbo].[aspnet_Roles].[RoleName], [dbo].[aspnet_Roles].[LoweredRoleName], [dbo].[aspnet_Roles].[Description]
  FROM [dbo].[aspnet_Roles]
  
GO
/****** Object:  View [dbo].[vw_aspnet_Users]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

  CREATE VIEW [dbo].[vw_aspnet_Users]
  AS SELECT [dbo].[aspnet_Users].[ApplicationId], [dbo].[aspnet_Users].[UserId], [dbo].[aspnet_Users].[UserName], [dbo].[aspnet_Users].[LoweredUserName], [dbo].[aspnet_Users].[MobileAlias], [dbo].[aspnet_Users].[IsAnonymous], [dbo].[aspnet_Users].[LastActivityDate]
  FROM [dbo].[aspnet_Users]
  
GO
/****** Object:  View [dbo].[vw_aspnet_UsersInRoles]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

  CREATE VIEW [dbo].[vw_aspnet_UsersInRoles]
  AS SELECT [dbo].[aspnet_UsersInRoles].[UserId], [dbo].[aspnet_UsersInRoles].[RoleId]
  FROM [dbo].[aspnet_UsersInRoles]
  
GO
/****** Object:  View [dbo].[vw_aspnet_WebPartState_Paths]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

  CREATE VIEW [dbo].[vw_aspnet_WebPartState_Paths]
  AS SELECT [dbo].[aspnet_Paths].[ApplicationId], [dbo].[aspnet_Paths].[PathId], [dbo].[aspnet_Paths].[Path], [dbo].[aspnet_Paths].[LoweredPath]
  FROM [dbo].[aspnet_Paths]
  
GO
/****** Object:  View [dbo].[vw_aspnet_WebPartState_Shared]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

  CREATE VIEW [dbo].[vw_aspnet_WebPartState_Shared]
  AS SELECT [dbo].[aspnet_PersonalizationAllUsers].[PathId], [DataSize]=DATALENGTH([dbo].[aspnet_PersonalizationAllUsers].[PageSettings]), [dbo].[aspnet_PersonalizationAllUsers].[LastUpdatedDate]
  FROM [dbo].[aspnet_PersonalizationAllUsers]
  
GO
/****** Object:  View [dbo].[vw_aspnet_WebPartState_User]    Script Date: 27/11/2014 01:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

  CREATE VIEW [dbo].[vw_aspnet_WebPartState_User]
  AS SELECT [dbo].[aspnet_PersonalizationPerUser].[PathId], [dbo].[aspnet_PersonalizationPerUser].[UserId], [DataSize]=DATALENGTH([dbo].[aspnet_PersonalizationPerUser].[PageSettings]), [dbo].[aspnet_PersonalizationPerUser].[LastUpdatedDate]
  FROM [dbo].[aspnet_PersonalizationPerUser]
  
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [aspnet_Applications_Index]    Script Date: 27/11/2014 01:37:36 PM ******/
CREATE CLUSTERED INDEX [aspnet_Applications_Index] ON [dbo].[aspnet_Applications]
(
	[LoweredApplicationName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [aspnet_Membership_index]    Script Date: 27/11/2014 01:37:36 PM ******/
CREATE CLUSTERED INDEX [aspnet_Membership_index] ON [dbo].[aspnet_Membership]
(
	[ApplicationId] ASC,
	[LoweredEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [aspnet_Paths_index]    Script Date: 27/11/2014 01:37:36 PM ******/
CREATE UNIQUE CLUSTERED INDEX [aspnet_Paths_index] ON [dbo].[aspnet_Paths]
(
	[ApplicationId] ASC,
	[LoweredPath] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [aspnet_PersonalizationPerUser_index1]    Script Date: 27/11/2014 01:37:36 PM ******/
CREATE UNIQUE CLUSTERED INDEX [aspnet_PersonalizationPerUser_index1] ON [dbo].[aspnet_PersonalizationPerUser]
(
	[PathId] ASC,
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [aspnet_Roles_index1]    Script Date: 27/11/2014 01:37:36 PM ******/
CREATE UNIQUE CLUSTERED INDEX [aspnet_Roles_index1] ON [dbo].[aspnet_Roles]
(
	[ApplicationId] ASC,
	[LoweredRoleName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [aspnet_Users_Index]    Script Date: 27/11/2014 01:37:36 PM ******/
CREATE UNIQUE CLUSTERED INDEX [aspnet_Users_Index] ON [dbo].[aspnet_Users]
(
	[ApplicationId] ASC,
	[LoweredUserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
INSERT [dbo].[aspnet_Applications] ([ApplicationName], [LoweredApplicationName], [ApplicationId], [Description]) VALUES (N'/', N'/', N'35723c82-475c-49e0-b7a1-4a9d9a2d0fa8', NULL)
INSERT [dbo].[aspnet_Membership] ([ApplicationId], [UserId], [Password], [PasswordFormat], [PasswordSalt], [MobilePIN], [Email], [LoweredEmail], [PasswordQuestion], [PasswordAnswer], [IsApproved], [IsLockedOut], [CreateDate], [LastLoginDate], [LastPasswordChangedDate], [LastLockoutDate], [FailedPasswordAttemptCount], [FailedPasswordAttemptWindowStart], [FailedPasswordAnswerAttemptCount], [FailedPasswordAnswerAttemptWindowStart], [Comment]) VALUES (N'35723c82-475c-49e0-b7a1-4a9d9a2d0fa8', N'7b3b7e2f-6892-42dd-8875-28a21a20193d', N'34jyE8KceHoMdaKfip/FmQTN7fg=', 1, N'fNHBA6m82QwrXXp1zsgaSg==', NULL, N'Ice@me.com', N'ice@me.com', N'My Name', N'mjObFr0aoM7G4+jgjh97R3WlXkE=', 1, 0, CAST(0x0000A3ED00B06760 AS DateTime), CAST(0x0000A3F0007160E0 AS DateTime), CAST(0x0000A3ED00B06760 AS DateTime), CAST(0xFFFF2FB300000000 AS DateTime), 0, CAST(0xFFFF2FB300000000 AS DateTime), 0, CAST(0xFFFF2FB300000000 AS DateTime), NULL)
INSERT [dbo].[aspnet_Roles] ([ApplicationId], [RoleId], [RoleName], [LoweredRoleName], [Description]) VALUES (N'35723c82-475c-49e0-b7a1-4a9d9a2d0fa8', N'40365638-9598-4bf6-9ea2-6ee7db792b53', N'admin', N'admin', NULL)
INSERT [dbo].[aspnet_SchemaVersions] ([Feature], [CompatibleSchemaVersion], [IsCurrentVersion]) VALUES (N'common', N'1', 1)
INSERT [dbo].[aspnet_SchemaVersions] ([Feature], [CompatibleSchemaVersion], [IsCurrentVersion]) VALUES (N'membership', N'1', 1)
INSERT [dbo].[aspnet_SchemaVersions] ([Feature], [CompatibleSchemaVersion], [IsCurrentVersion]) VALUES (N'personalization', N'1', 1)
INSERT [dbo].[aspnet_SchemaVersions] ([Feature], [CompatibleSchemaVersion], [IsCurrentVersion]) VALUES (N'profile', N'1', 1)
INSERT [dbo].[aspnet_SchemaVersions] ([Feature], [CompatibleSchemaVersion], [IsCurrentVersion]) VALUES (N'role manager', N'1', 1)
INSERT [dbo].[aspnet_Users] ([ApplicationId], [UserId], [UserName], [LoweredUserName], [MobileAlias], [IsAnonymous], [LastActivityDate]) VALUES (N'35723c82-475c-49e0-b7a1-4a9d9a2d0fa8', N'7b3b7e2f-6892-42dd-8875-28a21a20193d', N'admin', N'admin', NULL, 0, CAST(0x0000A3F0007160E0 AS DateTime))
INSERT [dbo].[aspnet_UsersInRoles] ([UserId], [RoleId]) VALUES (N'7b3b7e2f-6892-42dd-8875-28a21a20193d', N'40365638-9598-4bf6-9ea2-6ee7db792b53')
SET IDENTITY_INSERT [dbo].[l_Budget] ON 

INSERT [dbo].[l_Budget] ([BudgetID], [BudgetDate], [Amount], [CompanyID], [ModifiedDate], [ModifiedBy], [Removed]) VALUES (1, CAST(0x0000A3D800000000 AS DateTime), CAST(12.00 AS Decimal(18, 2)), 0, CAST(0x0000A3D8009FCCFC AS DateTime), 0, 0)
SET IDENTITY_INSERT [dbo].[l_Budget] OFF
SET IDENTITY_INSERT [dbo].[l_CashType] ON 

INSERT [dbo].[l_CashType] ([CashTypeID], [CashType], [CompanyID], [ModifiedDate], [ModifiedBy], [Removed]) VALUES (1, N'as', 0, CAST(0x0000A3D8009C0C0C AS DateTime), 0, 0)
INSERT [dbo].[l_CashType] ([CashTypeID], [CashType], [CompanyID], [ModifiedDate], [ModifiedBy], [Removed]) VALUES (2, N'dsgf', 0, CAST(0x0000A3D8002526F0 AS DateTime), 0, 0)
SET IDENTITY_INSERT [dbo].[l_CashType] OFF
SET IDENTITY_INSERT [dbo].[l_CommentType] ON 

INSERT [dbo].[l_CommentType] ([CommentTypeID], [CommentType], [CompanyID], [ModifiedDate], [ModifiedBy], [Removed]) VALUES (1, N'as', 0, CAST(0x0000A3D8009C18F0 AS DateTime), 0, 0)
SET IDENTITY_INSERT [dbo].[l_CommentType] OFF
SET IDENTITY_INSERT [dbo].[l_ElectronicType] ON 

INSERT [dbo].[l_ElectronicType] ([ElectronicTypeID], [ElectronicType], [ElectronicTypeDescription], [CompanyID], [ModifiedDate], [ModifiedBy], [Removed]) VALUES (1, N'as', N'as', 0, CAST(0x0000A3D8009ECC58 AS DateTime), 0, 0)
INSERT [dbo].[l_ElectronicType] ([ElectronicTypeID], [ElectronicType], [ElectronicTypeDescription], [CompanyID], [ModifiedDate], [ModifiedBy], [Removed]) VALUES (2, N'as', N'as', 0, CAST(0x0000A3D8009ED810 AS DateTime), 0, 0)
SET IDENTITY_INSERT [dbo].[l_ElectronicType] OFF
SET IDENTITY_INSERT [dbo].[l_FNBType] ON 

INSERT [dbo].[l_FNBType] ([FNBTypeID], [FNBType], [CompanyID], [ModifiedDate], [ModifiedBy], [Removed]) VALUES (1, N'as', 0, CAST(0x0000A3D8009FAB00 AS DateTime), 0, 0)
SET IDENTITY_INSERT [dbo].[l_FNBType] OFF
SET IDENTITY_INSERT [dbo].[l_GRVType] ON 

INSERT [dbo].[l_GRVType] ([GRVTypeID], [GRVType], [CompanyID], [ModifiedDate], [ModifiedBy], [Removed]) VALUES (1, N'ed', 0, CAST(0x0000A3D8009B8548 AS DateTime), 0, 0)
SET IDENTITY_INSERT [dbo].[l_GRVType] OFF
SET IDENTITY_INSERT [dbo].[l_InstantMoneyType] ON 

INSERT [dbo].[l_InstantMoneyType] ([InstantMoneyTypeID], [InstantMoneyType], [CompanyID], [ModifiedDate], [ModifiedBy], [Removed]) VALUES (1, N'a', 0, CAST(0x0000A3D8009D1994 AS DateTime), 0, 0)
SET IDENTITY_INSERT [dbo].[l_InstantMoneyType] OFF
SET IDENTITY_INSERT [dbo].[l_KwikPayType] ON 

INSERT [dbo].[l_KwikPayType] ([KwikPayTypeID], [KwikPayType], [CompanyID], [ModifiedDate], [ModifiedBy], [Removed]) VALUES (1, N'AirTime', 0, CAST(0x0000A3D80094CE24 AS DateTime), 0, 0)
SET IDENTITY_INSERT [dbo].[l_KwikPayType] OFF
SET IDENTITY_INSERT [dbo].[l_MoneyUnit] ON 

INSERT [dbo].[l_MoneyUnit] ([MoneyUnitID], [MoneyUnit], [CompanyID], [ModifiedDate], [ModifiedBy], [Removed]) VALUES (1, N'R', 0, CAST(0x0000A3D8009D3230 AS DateTime), 0, 0)
SET IDENTITY_INSERT [dbo].[l_MoneyUnit] OFF
SET IDENTITY_INSERT [dbo].[l_MovementType] ON 

INSERT [dbo].[l_MovementType] ([MovementTypeID], [MovementType], [CompanyID], [ModifiedDate], [ModifiedBy], [Removed]) VALUES (1, N'a', 0, CAST(0x0000A3D8009D3B90 AS DateTime), 0, 0)
SET IDENTITY_INSERT [dbo].[l_MovementType] OFF
SET IDENTITY_INSERT [dbo].[l_Status] ON 

INSERT [dbo].[l_Status] ([StatusID], [StatusName], [CompanyID], [ModifiedDate], [ModifiedBy], [Removed]) VALUES (1, N'Completed', 0, CAST(0x0000A3F00094BB64 AS DateTime), 0, 0)
SET IDENTITY_INSERT [dbo].[l_Status] OFF
SET IDENTITY_INSERT [dbo].[l_SupplierType] ON 

INSERT [dbo].[l_SupplierType] ([SupplierTypeID], [SupplierType], [CompanyID], [ModifiedDate], [ModifiedBy], [Removed]) VALUES (1, N'Ds', 0, CAST(0x0000A3F0009B2C38 AS DateTime), 0, 0)
INSERT [dbo].[l_SupplierType] ([SupplierTypeID], [SupplierType], [CompanyID], [ModifiedDate], [ModifiedBy], [Removed]) VALUES (2, N'Di', 0, CAST(0x0000A3F0009B44D4 AS DateTime), 0, 0)
SET IDENTITY_INSERT [dbo].[l_SupplierType] OFF
SET IDENTITY_INSERT [dbo].[t_CashBox] ON 

INSERT [dbo].[t_CashBox] ([CashBoxID], [ActualDate], [Amount], [CreatedDate], [MovementTypeID], [CompanyID], [ModifiedDate], [ModifiedBy], [Removed]) VALUES (1, CAST(0x0000A3D800000000 AS DateTime), CAST(12.00 AS Decimal(18, 2)), CAST(0x0000A3D800AD0BF2 AS DateTime), 1, 0, CAST(0x0000A3D800AD0B38 AS DateTime), 0, 0)
SET IDENTITY_INSERT [dbo].[t_CashBox] OFF
SET IDENTITY_INSERT [dbo].[t_CashMovement] ON 

INSERT [dbo].[t_CashMovement] ([CashMovementID], [ActualDate], [Amount], [CreatedDate], [CashTypeID], [MoneyUnitID], [UserID], [CompanyID], [ModifiedDate], [ModifiedBy], [Removed]) VALUES (1, CAST(0x0000A3D800000000 AS DateTime), CAST(1233.00 AS Decimal(18, 2)), CAST(0x0000A3D80091475D AS DateTime), 1, 0, 0, 0, CAST(0x0000A3D8009140C4 AS DateTime), 0, 0)
INSERT [dbo].[t_CashMovement] ([CashMovementID], [ActualDate], [Amount], [CreatedDate], [CashTypeID], [MoneyUnitID], [UserID], [CompanyID], [ModifiedDate], [ModifiedBy], [Removed]) VALUES (2, CAST(0x0000A3D800000000 AS DateTime), CAST(21.00 AS Decimal(18, 2)), CAST(0x0000A3D800941887 AS DateTime), 2, 0, 0, 0, CAST(0x0000A3D8009412A4 AS DateTime), 0, 0)
SET IDENTITY_INSERT [dbo].[t_CashMovement] OFF
SET IDENTITY_INSERT [dbo].[t_Order] ON 

INSERT [dbo].[t_Order] ([OrderID], [OrderDate], [ExpectedDeliveryDate], [Amount], [CreatedDate], [SupplierID], [UserID], [CommentID], [CompanyID], [ModifiedDate], [ModifiedBy], [Removed]) VALUES (1, CAST(0x0000A32800000000 AS DateTime), CAST(0x0000A34600000000 AS DateTime), CAST(150.00 AS Decimal(18, 2)), CAST(0x0000A3F000A8C680 AS DateTime), 1, 0, 0, 0, CAST(0x0000A3F000A8B31C AS DateTime), 0, 0)
SET IDENTITY_INSERT [dbo].[t_Order] OFF
SET IDENTITY_INSERT [dbo].[t_PickUp] ON 

INSERT [dbo].[t_PickUp] ([PickUpID], [ActualDate], [Amount], [CreatedDate], [CashTypeID], [UserID], [CompanyID], [ModifiedDate], [ModifiedBy], [Removed]) VALUES (1, CAST(0x0000A3D800000000 AS DateTime), CAST(12.00 AS Decimal(18, 2)), CAST(0x0000A3D8008E911E AS DateTime), 0, 0, 0, CAST(0x0000A3D8008E90E0 AS DateTime), 0, 0)
SET IDENTITY_INSERT [dbo].[t_PickUp] OFF
SET IDENTITY_INSERT [dbo].[t_Supplier] ON 

INSERT [dbo].[t_Supplier] ([SupplierID], [Supplier], [StockCondition], [Term], [CreatedDate], [SupplierTypeID], [CompanyID], [ModifiedDate], [ModifiedBy], [Removed]) VALUES (1, N'Spar', N'New', N'30', CAST(0x0000A3D800000000 AS DateTime), 1, 0, CAST(0x0000A3D800000000 AS DateTime), 1, 0)
SET IDENTITY_INSERT [dbo].[t_Supplier] OFF
SET IDENTITY_INSERT [dbo].[t_Transit] ON 

INSERT [dbo].[t_Transit] ([TransitID], [ActualDate], [Amount], [CreatedDate], [CompanyID], [ModifiedDate], [ModifiedBy], [Removed]) VALUES (1, CAST(0x0000A3D800000000 AS DateTime), CAST(121.00 AS Decimal(18, 2)), CAST(0x0000A3D800AC914C AS DateTime), 0, CAST(0x0000A3D800AC8CA8 AS DateTime), 0, 0)
SET IDENTITY_INSERT [dbo].[t_Transit] OFF
/****** Object:  Index [PK__aspnet_A__C93A4C9847E47FE4]    Script Date: 27/11/2014 01:37:36 PM ******/
ALTER TABLE [dbo].[aspnet_Applications] ADD PRIMARY KEY NONCLUSTERED 
(
	[ApplicationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__aspnet_A__17477DE454D2D67A]    Script Date: 27/11/2014 01:37:36 PM ******/
ALTER TABLE [dbo].[aspnet_Applications] ADD UNIQUE NONCLUSTERED 
(
	[LoweredApplicationName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__aspnet_A__309103314AA8C318]    Script Date: 27/11/2014 01:37:36 PM ******/
ALTER TABLE [dbo].[aspnet_Applications] ADD UNIQUE NONCLUSTERED 
(
	[ApplicationName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK__aspnet_M__1788CC4DF07B864C]    Script Date: 27/11/2014 01:37:36 PM ******/
ALTER TABLE [dbo].[aspnet_Membership] ADD PRIMARY KEY NONCLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK__aspnet_P__CD67DC582B1F8581]    Script Date: 27/11/2014 01:37:36 PM ******/
ALTER TABLE [dbo].[aspnet_Paths] ADD PRIMARY KEY NONCLUSTERED 
(
	[PathId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK__aspnet_P__3214EC068567DC80]    Script Date: 27/11/2014 01:37:36 PM ******/
ALTER TABLE [dbo].[aspnet_PersonalizationPerUser] ADD PRIMARY KEY NONCLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [aspnet_PersonalizationPerUser_ncindex2]    Script Date: 27/11/2014 01:37:36 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [aspnet_PersonalizationPerUser_ncindex2] ON [dbo].[aspnet_PersonalizationPerUser]
(
	[UserId] ASC,
	[PathId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK__aspnet_R__8AFACE1BEBDB130E]    Script Date: 27/11/2014 01:37:36 PM ******/
ALTER TABLE [dbo].[aspnet_Roles] ADD PRIMARY KEY NONCLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK__aspnet_U__1788CC4D6D9153D9]    Script Date: 27/11/2014 01:37:36 PM ******/
ALTER TABLE [dbo].[aspnet_Users] ADD PRIMARY KEY NONCLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [aspnet_Users_Index2]    Script Date: 27/11/2014 01:37:36 PM ******/
CREATE NONCLUSTERED INDEX [aspnet_Users_Index2] ON [dbo].[aspnet_Users]
(
	[ApplicationId] ASC,
	[LastActivityDate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [aspnet_UsersInRoles_index]    Script Date: 27/11/2014 01:37:36 PM ******/
CREATE NONCLUSTERED INDEX [aspnet_UsersInRoles_index] ON [dbo].[aspnet_UsersInRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[aspnet_Applications] ADD  DEFAULT (newid()) FOR [ApplicationId]
GO
ALTER TABLE [dbo].[aspnet_Membership] ADD  DEFAULT ((0)) FOR [PasswordFormat]
GO
ALTER TABLE [dbo].[aspnet_Paths] ADD  DEFAULT (newid()) FOR [PathId]
GO
ALTER TABLE [dbo].[aspnet_PersonalizationPerUser] ADD  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[aspnet_Roles] ADD  DEFAULT (newid()) FOR [RoleId]
GO
ALTER TABLE [dbo].[aspnet_Users] ADD  DEFAULT (newid()) FOR [UserId]
GO
ALTER TABLE [dbo].[aspnet_Users] ADD  DEFAULT (NULL) FOR [MobileAlias]
GO
ALTER TABLE [dbo].[aspnet_Users] ADD  DEFAULT ((0)) FOR [IsAnonymous]
GO
ALTER TABLE [dbo].[aspnet_Membership]  WITH CHECK ADD FOREIGN KEY([ApplicationId])
REFERENCES [dbo].[aspnet_Applications] ([ApplicationId])
GO
ALTER TABLE [dbo].[aspnet_Membership]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[aspnet_Users] ([UserId])
GO
ALTER TABLE [dbo].[aspnet_Paths]  WITH CHECK ADD FOREIGN KEY([ApplicationId])
REFERENCES [dbo].[aspnet_Applications] ([ApplicationId])
GO
ALTER TABLE [dbo].[aspnet_PersonalizationAllUsers]  WITH CHECK ADD FOREIGN KEY([PathId])
REFERENCES [dbo].[aspnet_Paths] ([PathId])
GO
ALTER TABLE [dbo].[aspnet_PersonalizationPerUser]  WITH CHECK ADD FOREIGN KEY([PathId])
REFERENCES [dbo].[aspnet_Paths] ([PathId])
GO
ALTER TABLE [dbo].[aspnet_PersonalizationPerUser]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[aspnet_Users] ([UserId])
GO
ALTER TABLE [dbo].[aspnet_Profile]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[aspnet_Users] ([UserId])
GO
ALTER TABLE [dbo].[aspnet_Roles]  WITH CHECK ADD FOREIGN KEY([ApplicationId])
REFERENCES [dbo].[aspnet_Applications] ([ApplicationId])
GO
ALTER TABLE [dbo].[aspnet_Users]  WITH CHECK ADD FOREIGN KEY([ApplicationId])
REFERENCES [dbo].[aspnet_Applications] ([ApplicationId])
GO
ALTER TABLE [dbo].[aspnet_UsersInRoles]  WITH CHECK ADD FOREIGN KEY([RoleId])
REFERENCES [dbo].[aspnet_Roles] ([RoleId])
GO
ALTER TABLE [dbo].[aspnet_UsersInRoles]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[aspnet_Users] ([UserId])
GO
USE [master]
GO
ALTER DATABASE [Spar_Database] SET  READ_WRITE 
GO
