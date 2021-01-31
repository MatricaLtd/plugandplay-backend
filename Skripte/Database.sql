DECLARE @Sql NVARCHAR(500) DECLARE @Cursor CURSOR

SET @Cursor = CURSOR FAST_FORWARD FOR
SELECT DISTINCT sql = 'ALTER TABLE [' + tc2.TABLE_SCHEMA + '].[' +  tc2.TABLE_NAME + '] DROP [' + rc1.CONSTRAINT_NAME + '];'
FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS rc1
LEFT JOIN INFORMATION_SCHEMA.TABLE_CONSTRAINTS tc2 ON tc2.CONSTRAINT_NAME =rc1.CONSTRAINT_NAME

OPEN @Cursor FETCH NEXT FROM @Cursor INTO @Sql

WHILE (@@FETCH_STATUS = 0)
BEGIN
Exec sp_executesql @Sql
FETCH NEXT FROM @Cursor INTO @Sql
END

CLOSE @Cursor DEALLOCATE @Cursor
GO

EXEC sp_MSforeachtable 'DROP TABLE ?'
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



/****** Object:  Table [dbo].[Klijent]    ******/
CREATE TABLE [dbo].[Klijent](
	[Id] [int] IDENTITY(1,1) NOT NULL
	
    
	, [naziv] [nvarchar](max)
	
	
    
	, [partnerId] [integer]
	
	
    
	, [primarniKontaktId] [integer]
	
	
    
	, [napomena] [nvarchar](max)
	
	
    
	, [kontaktiId] [integer]
	
	
    
	, [adresa] [nvarchar](max)
	
	
    
	, [mjestoId] [integer]
	
	
	
 CONSTRAINT [PK_Klijent] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Kontakt]    ******/
CREATE TABLE [dbo].[Kontakt](
	[Id] [int] IDENTITY(1,1) NOT NULL
	
    
	, [aktivan] [bit]
	
	
    
	, [prefiks] [nvarchar](max)
	
	
    
	, [ime] [nvarchar](max)
	
	
    
	, [prezime] [nvarchar](max)
	
	
    
	, [funkcija] [nvarchar](max)
	
	
    
	, [email] [nvarchar](max)
	
	
    
	, [telefon] [nvarchar](max)
	
	
    
	, [jezik] [nvarchar](max)
	
	
    
	, [napomena] [nvarchar](max)
	
	
	
    , [KlijentId] [integer],
	
 CONSTRAINT [PK_Kontakt] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Partner]    ******/
CREATE TABLE [dbo].[Partner](
	[Id] [int] IDENTITY(1,1) NOT NULL
	
    
	, [naziv] [nvarchar](max)
	
	
    
	, [oIB] [nvarchar](max)
	
	
    
	, [adresa] [nvarchar](max)
	
	
    
	, [mjestoId] [integer]
	
	
    
	, [agencija] [bit]
	
	
    
	, [aktivan] [bit]
	
	
    
	, [izvoz] [bit]
	
	
    
	, [račun] [nvarchar](max)
	
	
    
	, [pDV] [bit]
	
	
    
	, [valuta] [nvarchar](max)
	
	
    
	, [primarniKontaktId] [integer]
	
	
    
	, [eRačun] [bit]
	
	
    
	, [eRačunEmail] [nvarchar](max)
	
	
    
	, [telefon] [nvarchar](max)
	
	
    
	, [uvjet] [nvarchar](max)
	
	
    
	, [napomena] [nvarchar](max)
	
	
    
	, [kontaktiId] [integer]
	
	
    
	, [limit] [decimal](9, 6)
	
	
    
	, [realizirano] [decimal](9, 6)
	
	
    
	, [naplaceno] [decimal](9, 6)
	
	
    
	, [duguje] [decimal](9, 6)
	
	
    
	, [odgoda] [integer]
	
	
    
	, [bonitet] [nvarchar](max)
	
	
    
	, [napomenaUvjet] [nvarchar](max)
	
	
	
 CONSTRAINT [PK_Partner] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Ponuda]    ******/
CREATE TABLE [dbo].[Ponuda](
	[Id] [int] IDENTITY(1,1) NOT NULL
	
    
	, [broj] [nvarchar](max)
	
	
    
	, [status] [nvarchar](max)
	
	
    
	, [statusDatum] [datetimeoffset](7)
	
	
    
	, [statusUser] [integer]
	
	
    
	, [datumKreiranja] [datetimeoffset](7)
	
	
    
	, [vlasnikUser] [integer]
	
	
    
	, [valutaPlaćanja] [integer]
	
	
    
	, [startDatum] [datetimeoffset](7)
	
	
    
	, [endDatum] [datetimeoffset](7)
	
	
    
	, [oIB] [nvarchar](max)
	
	
    
	, [brand] [nvarchar](max)
	
	
    
	, [izvoz] [bit]
	
	
    
	, [valuta] [nvarchar](max)
	
	
    
	, [napomena] [nvarchar](max)
	
	
    
	, [ukupno] [decimal](9, 6)
	
	
    
	, [pDV] [bit]
	
	
    
	, [zaPlatiti] [decimal](9, 6)
	
	
    
	, [stavkaId] [integer]
	
	
    
	, [stavkePopustaId] [integer]
	
	
    
	, [ugovorId] [integer]
	
	
    
	, [partnerId] [integer]
	
	
    
	, [klijentId] [integer]
	
	
	
 CONSTRAINT [PK_Ponuda] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[StavkaPonude]    ******/
CREATE TABLE [dbo].[StavkaPonude](
	[Id] [int] IDENTITY(1,1) NOT NULL
	
    
	, [kampanjaTip] [integer]
	
	
    
	, [kampanja] [integer]
	
	
    
	, [opis] [nvarchar](max)
	
	
    
	, [količina] [decimal](9, 6)
	
	
    
	, [jediničnaCijena] [decimal](9, 6)
	
	
    
	, [cijena] [decimal](9, 6)
	
	
    
	, [popust] [decimal](9, 6)
	
	
    
	, [iznos] [decimal](9, 6)
	
	
	
    , [PonudaId] [integer],
	
 CONSTRAINT [PK_StavkaPonude] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[StavkaPopust]    ******/
CREATE TABLE [dbo].[StavkaPopust](
	[Id] [int] IDENTITY(1,1) NOT NULL
	
    
	, [agePopust] [decimal](9, 6)
	
	
    
	, [ageIznos] [decimal](9, 6)
	
	
    
	, [avansPopust] [decimal](9, 6)
	
	
    
	, [avansIznos] [decimal](9, 6)
	
	
	
    , [PonudaId] [integer],
	
 CONSTRAINT [PK_StavkaPopust] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Ugovor]    ******/
CREATE TABLE [dbo].[Ugovor](
	[Id] [int] IDENTITY(1,1) NOT NULL
	
    
	, [naziv] [nvarchar](max)
	
	
    
	, [godina] [integer]
	
	
    
	, [aktivan] [bit]
	
	
    
	, [realizirano] [decimal](9, 6)
	
	
    
	, [naplaćeno] [decimal](9, 6)
	
	
    
	, [valuta] [nvarchar](max)
	
	
    
	, [valutaPlaćanja] [integer]
	
	
    
	, [aVB] [bit]
	
	
    
	, [commit] [decimal](9, 6)
	
	
    
	, [agePopust] [decimal](9, 6)
	
	
    
	, [ugovorFlatPopust] [decimal](9, 6)
	
	
    
	, [ugovorKoličinaPopust] [decimal](9, 6)
	
	
    
	, [avansKoličina] [decimal](9, 6)
	
	
    
	, [napomena] [nvarchar](max)
	
	
    
	, [filename] [varbinary]
	
	
    
	, [klijentId] [integer]
	
	
    
	, [partnerId] [integer]
	
	
	
 CONSTRAINT [PK_Ugovor] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Mjesto]    ******/
CREATE TABLE [dbo].[Mjesto](
	[Id] [int] IDENTITY(1,1) NOT NULL
	
    
	, [postanskiBroj] [nvarchar](max)
	
	
    
	, [naziv] [nvarchar](max)
	
	
    
	, [drzavaId] [integer]
	
	
	
 CONSTRAINT [PK_Mjesto] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Drzava]    ******/
CREATE TABLE [dbo].[Drzava](
	[Id] [int] IDENTITY(1,1) NOT NULL
	
    
	, [naziv] [nvarchar](max)
	
	
	
 CONSTRAINT [PK_Drzava] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO




CREATE TABLE [dbo].[User](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[FirstName] [nvarchar](200) NULL,
	[LastName] [nvarchar](200) NULL,
	[Password] [nvarchar](200) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[RefreshToken](
	[IdRefreshToken] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[Token] [nvarchar](256) NOT NULL,
	[Expires] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_RefreshToken] PRIMARY KEY CLUSTERED 
(
	[IdRefreshToken] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[RefreshToken]  WITH CHECK ADD  CONSTRAINT [FK_RefreshToken_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([UserId])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[RefreshToken] CHECK CONSTRAINT [FK_RefreshToken_User]
GO

INSERT INTO [dbo].[User] ([Name], [FirstName] ,[LastName]) 
VALUES ('administrator','Administrator','Administrator')

GO


CREATE TABLE [dbo].[Command](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CommandName] [nvarchar](500) NOT NULL,
	[CommandData] [nvarchar](max) NOT NULL,
	[Username] [nvarchar](200) NOT NULL,
	[StartTime] [datetime2](6) NOT NULL CONSTRAINT [DF_Command_StartTime]  DEFAULT (sysdatetime()),
	[EndTime] [datetime2](6) NULL,
	[Error] [nvarchar](max) NULL,
	[Success] [bit] NULL CONSTRAINT [DF_Command_Success]  DEFAULT ((0)),
 CONSTRAINT [PK_Command] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

CREATE TABLE [dbo].[NLog](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MachineName] [nvarchar](200) NULL,
	[Logged] [datetime] NOT NULL,
	[Level] [varchar](5) NOT NULL,
	[Message] [nvarchar](max) NOT NULL,
	[Logger] [nvarchar](300) NULL,
	[Properties] [nvarchar](max) NULL,
	[Callsite] [nvarchar](300) NULL,
	[Exception] [nvarchar](max) NULL,
	[Url] [nvarchar](max) NULL,
	[QueryString] [nvarchar](max) NULL,
	[Action] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Log] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

DROP PROCEDURE [dbo].[ap_AddNLogEntry]
GO

CREATE PROCEDURE [dbo].[ap_AddNLogEntry] (
  @machineName nvarchar(200),
  @logged datetime,
  @level varchar(5),
  @message nvarchar(max),
  @logger nvarchar(300),
  @properties nvarchar(max),
  @callsite nvarchar(300),
  @exception nvarchar(max),
  @url nvarchar(max),
  @queryString nvarchar(max),
  @action nvarchar(max)
) AS
BEGIN
  INSERT INTO [dbo].[NLog] (
    [MachineName],
    [Logged],
    [Level],
    [Message],
    [Logger],
    [Properties],
    [Callsite],
    [Exception],
    [Url],
	  [QueryString],
	  [Action]
  ) VALUES (
    @machineName,
    @logged,
    @level,
    @message,
    @logger,
    @properties,
    @callsite,
    @exception,
    @url,
	  @queryString,
	  @action
  );
END

GO