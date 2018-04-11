USE [HeMart]
GO
/****** Object:  Table [dbo].[Faktura]    Script Date: 11.4.2018 16:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Faktura](
	[FakturaID] [int] IDENTITY(1,1) NOT NULL,
	[DatumVystavenia] [datetime] NOT NULL,
	[DatumSplatnosti] [datetime] NOT NULL,
	[Suma] [decimal](18, 2) NOT NULL,
	[Zmazana] [bit] NOT NULL,
	[Vystavil_ZamestnanecID] [int] NULL,
	[Pacient_PacientID] [int] NULL,
 CONSTRAINT [PK_dbo.Faktura] PRIMARY KEY CLUSTERED 
(
	[FakturaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Liek]    Script Date: 11.4.2018 16:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Liek](
	[LiekID] [int] IDENTITY(1,1) NOT NULL,
	[Sukl] [nvarchar](max) NULL,
	[Nazov] [nvarchar](max) NULL,
	[Poznamka] [nvarchar](max) NULL,
	[Davkovanie] [nvarchar](max) NULL,
	[Zmazany] [bit] NOT NULL,
	[Zamestnanec_ZamestnanecID] [int] NULL,
 CONSTRAINT [PK_dbo.Liek] PRIMARY KEY CLUSTERED 
(
	[LiekID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LiekNaRecepte]    Script Date: 11.4.2018 16:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LiekNaRecepte](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Mnozstvo] [int] NOT NULL,
	[Liek_LiekID] [int] NULL,
	[Recept_ReceptID] [int] NULL,
 CONSTRAINT [PK_dbo.LiekNaRecepte] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pacient]    Script Date: 11.4.2018 16:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pacient](
	[PacientID] [int] IDENTITY(1,1) NOT NULL,
	[Meno] [nvarchar](max) NULL,
	[Priezvisko] [nvarchar](max) NULL,
	[Ulica] [nvarchar](max) NULL,
	[Cislo] [nvarchar](max) NULL,
	[PSC] [nvarchar](max) NULL,
	[Mesto] [nvarchar](max) NULL,
	[RodneCislo] [nvarchar](max) NULL,
	[DatumNarodenia] [datetime] NOT NULL,
	[DatumVytvorenia] [datetime] NOT NULL,
	[Zmazany] [bit] NOT NULL,
	[EvidujuciZamestnanec_ZamestnanecID] [int] NULL,
 CONSTRAINT [PK_dbo.Pacient] PRIMARY KEY CLUSTERED 
(
	[PacientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Recept]    Script Date: 11.4.2018 16:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Recept](
	[ReceptID] [int] IDENTITY(1,1) NOT NULL,
	[DatumVytvorenia] [datetime] NOT NULL,
	[DatumPlatnosti] [datetime] NOT NULL,
	[Zmazany] [bit] NOT NULL,
	[Pacient_PacientID] [int] NULL,
	[Zamestnanec_ZamestnanecID] [int] NULL,
 CONSTRAINT [PK_dbo.Recept] PRIMARY KEY CLUSTERED 
(
	[ReceptID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ukon]    Script Date: 11.4.2018 16:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ukon](
	[UkonID] [int] IDENTITY(1,1) NOT NULL,
	[Nazov] [nvarchar](max) NULL,
	[Popis] [nvarchar](max) NULL,
	[Cena] [decimal](18, 2) NOT NULL,
	[Zmazany] [bit] NOT NULL,
	[Vytvoril_ZamestnanecID] [int] NULL,
	[Pacient_PacientID] [int] NULL,
 CONSTRAINT [PK_dbo.Ukon] PRIMARY KEY CLUSTERED 
(
	[UkonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UkonPacient]    Script Date: 11.4.2018 16:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UkonPacient](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DatumVytvorenia] [datetime] NOT NULL,
	[Pocetnost] [float] NOT NULL,
	[Popis] [nvarchar](max) NULL,
	[Pacient_PacientID] [int] NULL,
	[Ukon_UkonID] [int] NULL,
	[Zamestnanec_ZamestnanecID] [int] NULL,
 CONSTRAINT [PK_dbo.UkonPacient] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Zamestnanec]    Script Date: 11.4.2018 16:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zamestnanec](
	[ZamestnanecID] [int] IDENTITY(1,1) NOT NULL,
	[Meno] [nvarchar](max) NULL,
	[Priezvisko] [nvarchar](max) NULL,
	[Ulica] [nvarchar](max) NULL,
	[Cislo] [nvarchar](max) NULL,
	[PSC] [nvarchar](max) NULL,
	[Mesto] [nvarchar](max) NULL,
	[Zmazany] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.Zamestnanec] PRIMARY KEY CLUSTERED 
(
	[ZamestnanecID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Liek] ON 

INSERT [dbo].[Liek] ([LiekID], [Sukl], [Nazov], [Poznamka], [Davkovanie], [Zmazany], [Zamestnanec_ZamestnanecID]) VALUES (1, N'AA1234', N'Paralen', N'Paralen poznamka', N'3x1', 0, 1)
INSERT [dbo].[Liek] ([LiekID], [Sukl], [Nazov], [Poznamka], [Davkovanie], [Zmazany], [Zamestnanec_ZamestnanecID]) VALUES (2, N'AA1235', N'Acilpirin', N'Acilpirin poznamka', N'2x1', 0, 1)
SET IDENTITY_INSERT [dbo].[Liek] OFF
SET IDENTITY_INSERT [dbo].[LiekNaRecepte] ON 

INSERT [dbo].[LiekNaRecepte] ([ID], [Mnozstvo], [Liek_LiekID], [Recept_ReceptID]) VALUES (1, 1, 1, 1)
INSERT [dbo].[LiekNaRecepte] ([ID], [Mnozstvo], [Liek_LiekID], [Recept_ReceptID]) VALUES (2, 2, 2, 1)
INSERT [dbo].[LiekNaRecepte] ([ID], [Mnozstvo], [Liek_LiekID], [Recept_ReceptID]) VALUES (3, 3, 1, 1)
INSERT [dbo].[LiekNaRecepte] ([ID], [Mnozstvo], [Liek_LiekID], [Recept_ReceptID]) VALUES (4, 1, 1, 3)
INSERT [dbo].[LiekNaRecepte] ([ID], [Mnozstvo], [Liek_LiekID], [Recept_ReceptID]) VALUES (5, 1, 2, 3)
SET IDENTITY_INSERT [dbo].[LiekNaRecepte] OFF
SET IDENTITY_INSERT [dbo].[Pacient] ON 

INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (1, N'Ondro', N'Tadanai', N'Zeleznicna', N'7/8', N'94501', N'Komarno', N'891107/6856', CAST(0x0000803100000000 AS DateTime), CAST(0x0000A8B900000000 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (2, N'Ondro', N'Tadanai', N'Zeleznicna', N'7/8', N'94501', N'Komarno', N'891107/6856', CAST(0x0000803100000000 AS DateTime), CAST(0x0000A8B900000000 AS DateTime), 0, 2)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (3, N'Ondro', N'Tadanai', N'Zeleznicna', N'7/8', N'94501', N'Komarno', N'891107/6856', CAST(0x0000803100000000 AS DateTime), CAST(0x0000A8B900000000 AS DateTime), 0, 3)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (5, N'meno1', N'priezvisko1', N'ulica1', N'1', N'psc1', N'mesto1', N'rc1', CAST(0x0000A8B9012B73BB AS DateTime), CAST(0x0000A8B9012B73BB AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (6, N'meno2', N'priezvisko2', N'ulica2', N'2', N'psc2', N'mesto2', N'rc2', CAST(0x0000A8B9012B742F AS DateTime), CAST(0x0000A8B9012B742F AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (7, N'meno3', N'priezvisko3', N'ulica3', N'3', N'psc3', N'mesto3', N'rc3', CAST(0x0000A8B9012B744F AS DateTime), CAST(0x0000A8B9012B744F AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (8, N'meno4', N'priezvisko4', N'ulica4', N'4', N'psc4', N'mesto4', N'rc4', CAST(0x0000A8B9012B7471 AS DateTime), CAST(0x0000A8B9012B7471 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (9, N'meno5', N'priezvisko5', N'ulica5', N'5', N'psc5', N'mesto5', N'rc5', CAST(0x0000A8B9012B7491 AS DateTime), CAST(0x0000A8B9012B7491 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (10, N'meno6', N'priezvisko6', N'ulica6', N'6', N'psc6', N'mesto6', N'rc6', CAST(0x0000A8B9012B74B9 AS DateTime), CAST(0x0000A8B9012B74B9 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (11, N'meno7', N'priezvisko7', N'ulica7', N'7', N'psc7', N'mesto7', N'rc7', CAST(0x0000A8B9012B74DC AS DateTime), CAST(0x0000A8B9012B74DC AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (12, N'meno8', N'priezvisko8', N'ulica8', N'8', N'psc8', N'mesto8', N'rc8', CAST(0x0000A8B9012B74FD AS DateTime), CAST(0x0000A8B9012B74FD AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (13, N'meno9', N'priezvisko9', N'ulica9', N'9', N'psc9', N'mesto9', N'rc9', CAST(0x0000A8B9012B751D AS DateTime), CAST(0x0000A8B9012B751D AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (14, N'meno10', N'priezvisko10', N'ulica10', N'10', N'psc10', N'mesto10', N'rc10', CAST(0x0000A8B9012B7540 AS DateTime), CAST(0x0000A8B9012B7540 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (15, N'meno11', N'priezvisko11', N'ulica11', N'11', N'psc11', N'mesto11', N'rc11', CAST(0x0000A8B9012B7562 AS DateTime), CAST(0x0000A8B9012B7562 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (16, N'meno12', N'priezvisko12', N'ulica12', N'12', N'psc12', N'mesto12', N'rc12', CAST(0x0000A8B9012B7584 AS DateTime), CAST(0x0000A8B9012B7584 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (17, N'meno13', N'priezvisko13', N'ulica13', N'13', N'psc13', N'mesto13', N'rc13', CAST(0x0000A8B9012B75A5 AS DateTime), CAST(0x0000A8B9012B75A5 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (18, N'meno14', N'priezvisko14', N'ulica14', N'14', N'psc14', N'mesto14', N'rc14', CAST(0x0000A8B9012B75C7 AS DateTime), CAST(0x0000A8B9012B75C7 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (19, N'meno15', N'priezvisko15', N'ulica15', N'15', N'psc15', N'mesto15', N'rc15', CAST(0x0000A8B9012B75E9 AS DateTime), CAST(0x0000A8B9012B75E9 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (20, N'meno16', N'priezvisko16', N'ulica16', N'16', N'psc16', N'mesto16', N'rc16', CAST(0x0000A8B9012B760A AS DateTime), CAST(0x0000A8B9012B760A AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (21, N'meno17', N'priezvisko17', N'ulica17', N'17', N'psc17', N'mesto17', N'rc17', CAST(0x0000A8B9012B762B AS DateTime), CAST(0x0000A8B9012B762B AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (22, N'meno18', N'priezvisko18', N'ulica18', N'18', N'psc18', N'mesto18', N'rc18', CAST(0x0000A8B9012B764D AS DateTime), CAST(0x0000A8B9012B764D AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (23, N'meno19', N'priezvisko19', N'ulica19', N'19', N'psc19', N'mesto19', N'rc19', CAST(0x0000A8B9012B7678 AS DateTime), CAST(0x0000A8B9012B7678 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (24, N'meno20', N'priezvisko20', N'ulica20', N'20', N'psc20', N'mesto20', N'rc20', CAST(0x0000A8B9012B769A AS DateTime), CAST(0x0000A8B9012B769A AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (25, N'meno21', N'priezvisko21', N'ulica21', N'21', N'psc21', N'mesto21', N'rc21', CAST(0x0000A8B9012B76BB AS DateTime), CAST(0x0000A8B9012B76BB AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (26, N'meno22', N'priezvisko22', N'ulica22', N'22', N'psc22', N'mesto22', N'rc22', CAST(0x0000A8B9012B76DC AS DateTime), CAST(0x0000A8B9012B76DC AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (27, N'meno23', N'priezvisko23', N'ulica23', N'23', N'psc23', N'mesto23', N'rc23', CAST(0x0000A8B9012B76FF AS DateTime), CAST(0x0000A8B9012B76FF AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (28, N'meno24', N'priezvisko24', N'ulica24', N'24', N'psc24', N'mesto24', N'rc24', CAST(0x0000A8B9012B772E AS DateTime), CAST(0x0000A8B9012B772E AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (29, N'meno25', N'priezvisko25', N'ulica25', N'25', N'psc25', N'mesto25', N'rc25', CAST(0x0000A8B9012B774E AS DateTime), CAST(0x0000A8B9012B774E AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (30, N'meno26', N'priezvisko26', N'ulica26', N'26', N'psc26', N'mesto26', N'rc26', CAST(0x0000A8B9012B7772 AS DateTime), CAST(0x0000A8B9012B7772 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (31, N'meno27', N'priezvisko27', N'ulica27', N'27', N'psc27', N'mesto27', N'rc27', CAST(0x0000A8B9012B7795 AS DateTime), CAST(0x0000A8B9012B7795 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (32, N'meno28', N'priezvisko28', N'ulica28', N'28', N'psc28', N'mesto28', N'rc28', CAST(0x0000A8B9012B77B9 AS DateTime), CAST(0x0000A8B9012B77B9 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (33, N'meno29', N'priezvisko29', N'ulica29', N'29', N'psc29', N'mesto29', N'rc29', CAST(0x0000A8B9012B77DB AS DateTime), CAST(0x0000A8B9012B77DB AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (34, N'meno30', N'priezvisko30', N'ulica30', N'30', N'psc30', N'mesto30', N'rc30', CAST(0x0000A8B9012B77FA AS DateTime), CAST(0x0000A8B9012B77FA AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (35, N'meno31', N'priezvisko31', N'ulica31', N'31', N'psc31', N'mesto31', N'rc31', CAST(0x0000A8B9012B7824 AS DateTime), CAST(0x0000A8B9012B7824 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (36, N'meno32', N'priezvisko32', N'ulica32', N'32', N'psc32', N'mesto32', N'rc32', CAST(0x0000A8B9012B7845 AS DateTime), CAST(0x0000A8B9012B7845 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (37, N'meno33', N'priezvisko33', N'ulica33', N'33', N'psc33', N'mesto33', N'rc33', CAST(0x0000A8B9012B786B AS DateTime), CAST(0x0000A8B9012B786B AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (38, N'meno34', N'priezvisko34', N'ulica34', N'34', N'psc34', N'mesto34', N'rc34', CAST(0x0000A8B9012B788C AS DateTime), CAST(0x0000A8B9012B788C AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (39, N'meno35', N'priezvisko35', N'ulica35', N'35', N'psc35', N'mesto35', N'rc35', CAST(0x0000A8B9012B78B1 AS DateTime), CAST(0x0000A8B9012B78B1 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (40, N'meno36', N'priezvisko36', N'ulica36', N'36', N'psc36', N'mesto36', N'rc36', CAST(0x0000A8B9012B78D3 AS DateTime), CAST(0x0000A8B9012B78D3 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (41, N'meno37', N'priezvisko37', N'ulica37', N'37', N'psc37', N'mesto37', N'rc37', CAST(0x0000A8B9012B78F7 AS DateTime), CAST(0x0000A8B9012B78F7 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (42, N'meno38', N'priezvisko38', N'ulica38', N'38', N'psc38', N'mesto38', N'rc38', CAST(0x0000A8B9012B791A AS DateTime), CAST(0x0000A8B9012B791A AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (43, N'meno39', N'priezvisko39', N'ulica39', N'39', N'psc39', N'mesto39', N'rc39', CAST(0x0000A8B9012B793E AS DateTime), CAST(0x0000A8B9012B793E AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (44, N'meno40', N'priezvisko40', N'ulica40', N'40', N'psc40', N'mesto40', N'rc40', CAST(0x0000A8B9012B7963 AS DateTime), CAST(0x0000A8B9012B7963 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (45, N'meno41', N'priezvisko41', N'ulica41', N'41', N'psc41', N'mesto41', N'rc41', CAST(0x0000A8B9012B7984 AS DateTime), CAST(0x0000A8B9012B7984 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (46, N'meno42', N'priezvisko42', N'ulica42', N'42', N'psc42', N'mesto42', N'rc42', CAST(0x0000A8B9012B79A6 AS DateTime), CAST(0x0000A8B9012B79A6 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (47, N'meno43', N'priezvisko43', N'ulica43', N'43', N'psc43', N'mesto43', N'rc43', CAST(0x0000A8B9012B79CE AS DateTime), CAST(0x0000A8B9012B79CE AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (48, N'meno44', N'priezvisko44', N'ulica44', N'44', N'psc44', N'mesto44', N'rc44', CAST(0x0000A8B9012B79F5 AS DateTime), CAST(0x0000A8B9012B79F5 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (49, N'meno45', N'priezvisko45', N'ulica45', N'45', N'psc45', N'mesto45', N'rc45', CAST(0x0000A8B9012B7A1B AS DateTime), CAST(0x0000A8B9012B7A1B AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (50, N'meno46', N'priezvisko46', N'ulica46', N'46', N'psc46', N'mesto46', N'rc46', CAST(0x0000A8B9012B7A3E AS DateTime), CAST(0x0000A8B9012B7A3E AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (51, N'meno47', N'priezvisko47', N'ulica47', N'47', N'psc47', N'mesto47', N'rc47', CAST(0x0000A8B9012B7A64 AS DateTime), CAST(0x0000A8B9012B7A64 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (52, N'meno48', N'priezvisko48', N'ulica48', N'48', N'psc48', N'mesto48', N'rc48', CAST(0x0000A8B9012B7A89 AS DateTime), CAST(0x0000A8B9012B7A89 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (53, N'meno49', N'priezvisko49', N'ulica49', N'49', N'psc49', N'mesto49', N'rc49', CAST(0x0000A8B9012B7AAC AS DateTime), CAST(0x0000A8B9012B7AAC AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (54, N'meno50', N'priezvisko50', N'ulica50', N'50', N'psc50', N'mesto50', N'rc50', CAST(0x0000A8B9012B7ACF AS DateTime), CAST(0x0000A8B9012B7ACF AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (55, N'meno51', N'priezvisko51', N'ulica51', N'51', N'psc51', N'mesto51', N'rc51', CAST(0x0000A8B9012B7AF3 AS DateTime), CAST(0x0000A8B9012B7AF3 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (56, N'meno52', N'priezvisko52', N'ulica52', N'52', N'psc52', N'mesto52', N'rc52', CAST(0x0000A8B9012B7B1F AS DateTime), CAST(0x0000A8B9012B7B1F AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (57, N'meno53', N'priezvisko53', N'ulica53', N'53', N'psc53', N'mesto53', N'rc53', CAST(0x0000A8B9012B7B43 AS DateTime), CAST(0x0000A8B9012B7B43 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (58, N'meno54', N'priezvisko54', N'ulica54', N'54', N'psc54', N'mesto54', N'rc54', CAST(0x0000A8B9012B7B64 AS DateTime), CAST(0x0000A8B9012B7B64 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (59, N'meno55', N'priezvisko55', N'ulica55', N'55', N'psc55', N'mesto55', N'rc55', CAST(0x0000A8B9012B7B8A AS DateTime), CAST(0x0000A8B9012B7B8A AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (60, N'meno56', N'priezvisko56', N'ulica56', N'56', N'psc56', N'mesto56', N'rc56', CAST(0x0000A8B9012B7BAB AS DateTime), CAST(0x0000A8B9012B7BAB AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (61, N'meno57', N'priezvisko57', N'ulica57', N'57', N'psc57', N'mesto57', N'rc57', CAST(0x0000A8B9012B7BD2 AS DateTime), CAST(0x0000A8B9012B7BD2 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (62, N'meno58', N'priezvisko58', N'ulica58', N'58', N'psc58', N'mesto58', N'rc58', CAST(0x0000A8B9012B7BF9 AS DateTime), CAST(0x0000A8B9012B7BF9 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (63, N'meno59', N'priezvisko59', N'ulica59', N'59', N'psc59', N'mesto59', N'rc59', CAST(0x0000A8B9012B7C1C AS DateTime), CAST(0x0000A8B9012B7C1C AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (64, N'meno60', N'priezvisko60', N'ulica60', N'60', N'psc60', N'mesto60', N'rc60', CAST(0x0000A8B9012B7C42 AS DateTime), CAST(0x0000A8B9012B7C42 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (65, N'meno61', N'priezvisko61', N'ulica61', N'61', N'psc61', N'mesto61', N'rc61', CAST(0x0000A8B9012B7C62 AS DateTime), CAST(0x0000A8B9012B7C62 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (66, N'meno62', N'priezvisko62', N'ulica62', N'62', N'psc62', N'mesto62', N'rc62', CAST(0x0000A8B9012B7C85 AS DateTime), CAST(0x0000A8B9012B7C85 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (67, N'meno63', N'priezvisko63', N'ulica63', N'63', N'psc63', N'mesto63', N'rc63', CAST(0x0000A8B9012B7CB5 AS DateTime), CAST(0x0000A8B9012B7CB5 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (68, N'meno64', N'priezvisko64', N'ulica64', N'64', N'psc64', N'mesto64', N'rc64', CAST(0x0000A8B9012B7CED AS DateTime), CAST(0x0000A8B9012B7CED AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (69, N'meno65', N'priezvisko65', N'ulica65', N'65', N'psc65', N'mesto65', N'rc65', CAST(0x0000A8B9012B7D12 AS DateTime), CAST(0x0000A8B9012B7D12 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (70, N'meno66', N'priezvisko66', N'ulica66', N'66', N'psc66', N'mesto66', N'rc66', CAST(0x0000A8B9012B7D38 AS DateTime), CAST(0x0000A8B9012B7D38 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (71, N'meno67', N'priezvisko67', N'ulica67', N'67', N'psc67', N'mesto67', N'rc67', CAST(0x0000A8B9012B7D5C AS DateTime), CAST(0x0000A8B9012B7D5C AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (72, N'meno68', N'priezvisko68', N'ulica68', N'68', N'psc68', N'mesto68', N'rc68', CAST(0x0000A8B9012B7D8C AS DateTime), CAST(0x0000A8B9012B7D8C AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (73, N'meno69', N'priezvisko69', N'ulica69', N'69', N'psc69', N'mesto69', N'rc69', CAST(0x0000A8B9012B7DB0 AS DateTime), CAST(0x0000A8B9012B7DB0 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (74, N'meno70', N'priezvisko70', N'ulica70', N'70', N'psc70', N'mesto70', N'rc70', CAST(0x0000A8B9012B7DD0 AS DateTime), CAST(0x0000A8B9012B7DD0 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (75, N'meno71', N'priezvisko71', N'ulica71', N'71', N'psc71', N'mesto71', N'rc71', CAST(0x0000A8B9012B7E07 AS DateTime), CAST(0x0000A8B9012B7E07 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (76, N'meno72', N'priezvisko72', N'ulica72', N'72', N'psc72', N'mesto72', N'rc72', CAST(0x0000A8B9012B7E4A AS DateTime), CAST(0x0000A8B9012B7E4A AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (77, N'meno73', N'priezvisko73', N'ulica73', N'73', N'psc73', N'mesto73', N'rc73', CAST(0x0000A8B9012B7E7F AS DateTime), CAST(0x0000A8B9012B7E7F AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (78, N'meno74', N'priezvisko74', N'ulica74', N'74', N'psc74', N'mesto74', N'rc74', CAST(0x0000A8B9012B7EAD AS DateTime), CAST(0x0000A8B9012B7EAD AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (79, N'meno75', N'priezvisko75', N'ulica75', N'75', N'psc75', N'mesto75', N'rc75', CAST(0x0000A8B9012B7ED7 AS DateTime), CAST(0x0000A8B9012B7ED7 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (80, N'meno76', N'priezvisko76', N'ulica76', N'76', N'psc76', N'mesto76', N'rc76', CAST(0x0000A8B9012B7F0C AS DateTime), CAST(0x0000A8B9012B7F0C AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (81, N'meno77', N'priezvisko77', N'ulica77', N'77', N'psc77', N'mesto77', N'rc77', CAST(0x0000A8B9012B7F44 AS DateTime), CAST(0x0000A8B9012B7F44 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (82, N'meno78', N'priezvisko78', N'ulica78', N'78', N'psc78', N'mesto78', N'rc78', CAST(0x0000A8B9012B7F6A AS DateTime), CAST(0x0000A8B9012B7F6A AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (83, N'meno79', N'priezvisko79', N'ulica79', N'79', N'psc79', N'mesto79', N'rc79', CAST(0x0000A8B9012B7F97 AS DateTime), CAST(0x0000A8B9012B7F97 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (84, N'meno80', N'priezvisko80', N'ulica80', N'80', N'psc80', N'mesto80', N'rc80', CAST(0x0000A8B9012B7FBC AS DateTime), CAST(0x0000A8B9012B7FBC AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (85, N'meno81', N'priezvisko81', N'ulica81', N'81', N'psc81', N'mesto81', N'rc81', CAST(0x0000A8B9012B7FE0 AS DateTime), CAST(0x0000A8B9012B7FE0 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (86, N'meno82', N'priezvisko82', N'ulica82', N'82', N'psc82', N'mesto82', N'rc82', CAST(0x0000A8B9012B8002 AS DateTime), CAST(0x0000A8B9012B8002 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (87, N'meno83', N'priezvisko83', N'ulica83', N'83', N'psc83', N'mesto83', N'rc83', CAST(0x0000A8B9012B8024 AS DateTime), CAST(0x0000A8B9012B8024 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (88, N'meno84', N'priezvisko84', N'ulica84', N'84', N'psc84', N'mesto84', N'rc84', CAST(0x0000A8B9012B8045 AS DateTime), CAST(0x0000A8B9012B8045 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (89, N'meno85', N'priezvisko85', N'ulica85', N'85', N'psc85', N'mesto85', N'rc85', CAST(0x0000A8B9012B806B AS DateTime), CAST(0x0000A8B9012B806B AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (90, N'meno86', N'priezvisko86', N'ulica86', N'86', N'psc86', N'mesto86', N'rc86', CAST(0x0000A8B9012B809A AS DateTime), CAST(0x0000A8B9012B809A AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (91, N'meno87', N'priezvisko87', N'ulica87', N'87', N'psc87', N'mesto87', N'rc87', CAST(0x0000A8B9012B80BD AS DateTime), CAST(0x0000A8B9012B80BD AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (92, N'meno88', N'priezvisko88', N'ulica88', N'88', N'psc88', N'mesto88', N'rc88', CAST(0x0000A8B9012B80E3 AS DateTime), CAST(0x0000A8B9012B80E3 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (93, N'meno89', N'priezvisko89', N'ulica89', N'89', N'psc89', N'mesto89', N'rc89', CAST(0x0000A8B9012B8108 AS DateTime), CAST(0x0000A8B9012B8108 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (94, N'meno90', N'priezvisko90', N'ulica90', N'90', N'psc90', N'mesto90', N'rc90', CAST(0x0000A8B9012B812A AS DateTime), CAST(0x0000A8B9012B812A AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (95, N'meno91', N'priezvisko91', N'ulica91', N'91', N'psc91', N'mesto91', N'rc91', CAST(0x0000A8B9012B814C AS DateTime), CAST(0x0000A8B9012B814C AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (96, N'meno92', N'priezvisko92', N'ulica92', N'92', N'psc92', N'mesto92', N'rc92', CAST(0x0000A8B9012B816D AS DateTime), CAST(0x0000A8B9012B816D AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (97, N'meno93', N'priezvisko93', N'ulica93', N'93', N'psc93', N'mesto93', N'rc93', CAST(0x0000A8B9012B8191 AS DateTime), CAST(0x0000A8B9012B8191 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (98, N'meno94', N'priezvisko94', N'ulica94', N'94', N'psc94', N'mesto94', N'rc94', CAST(0x0000A8B9012B81B1 AS DateTime), CAST(0x0000A8B9012B81B1 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (99, N'meno95', N'priezvisko95', N'ulica95', N'95', N'psc95', N'mesto95', N'rc95', CAST(0x0000A8B9012B81D3 AS DateTime), CAST(0x0000A8B9012B81D3 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (100, N'meno96', N'priezvisko96', N'ulica96', N'96', N'psc96', N'mesto96', N'rc96', CAST(0x0000A8B9012B81F3 AS DateTime), CAST(0x0000A8B9012B81F3 AS DateTime), 0, 1)
GO
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (101, N'meno97', N'priezvisko97', N'ulica97', N'97', N'psc97', N'mesto97', N'rc97', CAST(0x0000A8B9012B8216 AS DateTime), CAST(0x0000A8B9012B8216 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (102, N'meno98', N'priezvisko98', N'ulica98', N'98', N'psc98', N'mesto98', N'rc98', CAST(0x0000A8B9012B8238 AS DateTime), CAST(0x0000A8B9012B8238 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (103, N'meno99', N'priezvisko99', N'ulica99', N'99', N'psc99', N'mesto99', N'rc99', CAST(0x0000A8B9012B8267 AS DateTime), CAST(0x0000A8B9012B8267 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (104, N'meno100', N'priezvisko100', N'ulica100', N'100', N'psc100', N'mesto100', N'rc100', CAST(0x0000A8B9012B8294 AS DateTime), CAST(0x0000A8B9012B8294 AS DateTime), 0, 1)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (105, N'meno1', N'priezvisko1', N'ulica1', N'1', N'psc1', N'mesto1', N'rc1', CAST(0x0000A8BA00B302C8 AS DateTime), CAST(0x0000A8BA00B302C8 AS DateTime), 0, 4)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (106, N'meno2', N'priezvisko2', N'ulica2', N'2', N'psc2', N'mesto2', N'rc2', CAST(0x0000A8BA00B33413 AS DateTime), CAST(0x0000A8BA00B33413 AS DateTime), 0, 5)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (107, N'meno3', N'priezvisko3', N'ulica3', N'3', N'psc3', N'mesto3', N'rc3', CAST(0x0000A8BA00B335A9 AS DateTime), CAST(0x0000A8BA00B335A9 AS DateTime), 0, 6)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (108, N'meno4', N'priezvisko4', N'ulica4', N'4', N'psc4', N'mesto4', N'rc4', CAST(0x0000A8BA00B336F8 AS DateTime), CAST(0x0000A8BA00B336F8 AS DateTime), 0, 7)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (109, N'meno5', N'priezvisko5', N'ulica5', N'5', N'psc5', N'mesto5', N'rc5', CAST(0x0000A8BA00B3392D AS DateTime), CAST(0x0000A8BA00B3392D AS DateTime), 0, 8)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (110, N'meno6', N'priezvisko6', N'ulica6', N'6', N'psc6', N'mesto6', N'rc6', CAST(0x0000A8BA00B33AFE AS DateTime), CAST(0x0000A8BA00B33AFE AS DateTime), 0, 9)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (111, N'meno7', N'priezvisko7', N'ulica7', N'7', N'psc7', N'mesto7', N'rc7', CAST(0x0000A8BA00B33E88 AS DateTime), CAST(0x0000A8BA00B33E88 AS DateTime), 0, 10)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (112, N'meno8', N'priezvisko8', N'ulica8', N'8', N'psc8', N'mesto8', N'rc8', CAST(0x0000A8BA00B3401D AS DateTime), CAST(0x0000A8BA00B3401D AS DateTime), 0, 11)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (113, N'meno9', N'priezvisko9', N'ulica9', N'9', N'psc9', N'mesto9', N'rc9', CAST(0x0000A8BA00B341DF AS DateTime), CAST(0x0000A8BA00B341DF AS DateTime), 0, 12)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (114, N'meno10', N'priezvisko10', N'ulica10', N'10', N'psc10', N'mesto10', N'rc10', CAST(0x0000A8BA00B345E5 AS DateTime), CAST(0x0000A8BA00B345E5 AS DateTime), 0, 13)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (115, N'meno11', N'priezvisko11', N'ulica11', N'11', N'psc11', N'mesto11', N'rc11', CAST(0x0000A8BA00B3481D AS DateTime), CAST(0x0000A8BA00B3481D AS DateTime), 0, 14)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (116, N'meno12', N'priezvisko12', N'ulica12', N'12', N'psc12', N'mesto12', N'rc12', CAST(0x0000A8BA00B349B7 AS DateTime), CAST(0x0000A8BA00B349B7 AS DateTime), 0, 15)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (117, N'meno13', N'priezvisko13', N'ulica13', N'13', N'psc13', N'mesto13', N'rc13', CAST(0x0000A8BA00B34CBD AS DateTime), CAST(0x0000A8BA00B34CBD AS DateTime), 0, 16)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (118, N'meno14', N'priezvisko14', N'ulica14', N'14', N'psc14', N'mesto14', N'rc14', CAST(0x0000A8BA00B34F7A AS DateTime), CAST(0x0000A8BA00B34F7A AS DateTime), 0, 17)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (119, N'meno15', N'priezvisko15', N'ulica15', N'15', N'psc15', N'mesto15', N'rc15', CAST(0x0000A8BA00B351DC AS DateTime), CAST(0x0000A8BA00B351DC AS DateTime), 0, 18)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (120, N'meno16', N'priezvisko16', N'ulica16', N'16', N'psc16', N'mesto16', N'rc16', CAST(0x0000A8BA00B35472 AS DateTime), CAST(0x0000A8BA00B35472 AS DateTime), 0, 19)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (121, N'meno17', N'priezvisko17', N'ulica17', N'17', N'psc17', N'mesto17', N'rc17', CAST(0x0000A8BA00B356A1 AS DateTime), CAST(0x0000A8BA00B356A1 AS DateTime), 0, 20)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (122, N'meno18', N'priezvisko18', N'ulica18', N'18', N'psc18', N'mesto18', N'rc18', CAST(0x0000A8BA00B35890 AS DateTime), CAST(0x0000A8BA00B35890 AS DateTime), 0, 21)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (123, N'meno19', N'priezvisko19', N'ulica19', N'19', N'psc19', N'mesto19', N'rc19', CAST(0x0000A8BA00B35B00 AS DateTime), CAST(0x0000A8BA00B35B00 AS DateTime), 0, 22)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (124, N'meno20', N'priezvisko20', N'ulica20', N'20', N'psc20', N'mesto20', N'rc20', CAST(0x0000A8BA00B35DFD AS DateTime), CAST(0x0000A8BA00B35DFD AS DateTime), 0, 23)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (125, N'meno21', N'priezvisko21', N'ulica21', N'21', N'psc21', N'mesto21', N'rc21', CAST(0x0000A8BA00B36020 AS DateTime), CAST(0x0000A8BA00B36020 AS DateTime), 0, 24)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (126, N'meno22', N'priezvisko22', N'ulica22', N'22', N'psc22', N'mesto22', N'rc22', CAST(0x0000A8BA00B3628D AS DateTime), CAST(0x0000A8BA00B3628D AS DateTime), 0, 25)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (127, N'meno23', N'priezvisko23', N'ulica23', N'23', N'psc23', N'mesto23', N'rc23', CAST(0x0000A8BA00B3661C AS DateTime), CAST(0x0000A8BA00B3661C AS DateTime), 0, 26)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (128, N'meno24', N'priezvisko24', N'ulica24', N'24', N'psc24', N'mesto24', N'rc24', CAST(0x0000A8BA00B36828 AS DateTime), CAST(0x0000A8BA00B36828 AS DateTime), 0, 27)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (129, N'meno25', N'priezvisko25', N'ulica25', N'25', N'psc25', N'mesto25', N'rc25', CAST(0x0000A8BA00B36A53 AS DateTime), CAST(0x0000A8BA00B36A53 AS DateTime), 0, 28)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (130, N'meno26', N'priezvisko26', N'ulica26', N'26', N'psc26', N'mesto26', N'rc26', CAST(0x0000A8BA00B3765E AS DateTime), CAST(0x0000A8BA00B3765E AS DateTime), 0, 29)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (131, N'meno27', N'priezvisko27', N'ulica27', N'27', N'psc27', N'mesto27', N'rc27', CAST(0x0000A8BA00B378E2 AS DateTime), CAST(0x0000A8BA00B378E2 AS DateTime), 0, 30)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (132, N'meno28', N'priezvisko28', N'ulica28', N'28', N'psc28', N'mesto28', N'rc28', CAST(0x0000A8BA00B37B66 AS DateTime), CAST(0x0000A8BA00B37B66 AS DateTime), 0, 31)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (133, N'meno29', N'priezvisko29', N'ulica29', N'29', N'psc29', N'mesto29', N'rc29', CAST(0x0000A8BA00B37EA2 AS DateTime), CAST(0x0000A8BA00B37EA2 AS DateTime), 0, 32)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (134, N'meno30', N'priezvisko30', N'ulica30', N'30', N'psc30', N'mesto30', N'rc30', CAST(0x0000A8BA00B38104 AS DateTime), CAST(0x0000A8BA00B38104 AS DateTime), 0, 33)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (135, N'meno31', N'priezvisko31', N'ulica31', N'31', N'psc31', N'mesto31', N'rc31', CAST(0x0000A8BA00B382D4 AS DateTime), CAST(0x0000A8BA00B382D4 AS DateTime), 0, 34)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (136, N'meno32', N'priezvisko32', N'ulica32', N'32', N'psc32', N'mesto32', N'rc32', CAST(0x0000A8BA00B38515 AS DateTime), CAST(0x0000A8BA00B38515 AS DateTime), 0, 35)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (137, N'meno33', N'priezvisko33', N'ulica33', N'33', N'psc33', N'mesto33', N'rc33', CAST(0x0000A8BA00B38861 AS DateTime), CAST(0x0000A8BA00B38861 AS DateTime), 0, 36)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (138, N'meno34', N'priezvisko34', N'ulica34', N'34', N'psc34', N'mesto34', N'rc34', CAST(0x0000A8BA00B38A9B AS DateTime), CAST(0x0000A8BA00B38A9B AS DateTime), 0, 37)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (139, N'meno35', N'priezvisko35', N'ulica35', N'35', N'psc35', N'mesto35', N'rc35', CAST(0x0000A8BA00B38D07 AS DateTime), CAST(0x0000A8BA00B38D07 AS DateTime), 0, 38)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (140, N'meno36', N'priezvisko36', N'ulica36', N'36', N'psc36', N'mesto36', N'rc36', CAST(0x0000A8BA00B390E7 AS DateTime), CAST(0x0000A8BA00B390E7 AS DateTime), 0, 39)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (141, N'meno37', N'priezvisko37', N'ulica37', N'37', N'psc37', N'mesto37', N'rc37', CAST(0x0000A8BA00B39326 AS DateTime), CAST(0x0000A8BA00B39326 AS DateTime), 0, 40)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (142, N'meno38', N'priezvisko38', N'ulica38', N'38', N'psc38', N'mesto38', N'rc38', CAST(0x0000A8BA00B39559 AS DateTime), CAST(0x0000A8BA00B39559 AS DateTime), 0, 41)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (143, N'meno39', N'priezvisko39', N'ulica39', N'39', N'psc39', N'mesto39', N'rc39', CAST(0x0000A8BA00B39833 AS DateTime), CAST(0x0000A8BA00B39833 AS DateTime), 0, 42)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (144, N'meno40', N'priezvisko40', N'ulica40', N'40', N'psc40', N'mesto40', N'rc40', CAST(0x0000A8BA00B399C4 AS DateTime), CAST(0x0000A8BA00B399C4 AS DateTime), 0, 43)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (145, N'meno41', N'priezvisko41', N'ulica41', N'41', N'psc41', N'mesto41', N'rc41', CAST(0x0000A8BA00B39B4C AS DateTime), CAST(0x0000A8BA00B39B4C AS DateTime), 0, 44)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (146, N'meno42', N'priezvisko42', N'ulica42', N'42', N'psc42', N'mesto42', N'rc42', CAST(0x0000A8BA00B39D12 AS DateTime), CAST(0x0000A8BA00B39D12 AS DateTime), 0, 45)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (147, N'meno43', N'priezvisko43', N'ulica43', N'43', N'psc43', N'mesto43', N'rc43', CAST(0x0000A8BA00B39F24 AS DateTime), CAST(0x0000A8BA00B39F24 AS DateTime), 0, 46)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (148, N'meno44', N'priezvisko44', N'ulica44', N'44', N'psc44', N'mesto44', N'rc44', CAST(0x0000A8BA00B3A2BD AS DateTime), CAST(0x0000A8BA00B3A2BD AS DateTime), 0, 47)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (149, N'meno45', N'priezvisko45', N'ulica45', N'45', N'psc45', N'mesto45', N'rc45', CAST(0x0000A8BA00B3A42D AS DateTime), CAST(0x0000A8BA00B3A42D AS DateTime), 0, 48)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (150, N'meno46', N'priezvisko46', N'ulica46', N'46', N'psc46', N'mesto46', N'rc46', CAST(0x0000A8BA00B3A5E9 AS DateTime), CAST(0x0000A8BA00B3A5E9 AS DateTime), 0, 49)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (151, N'meno47', N'priezvisko47', N'ulica47', N'47', N'psc47', N'mesto47', N'rc47', CAST(0x0000A8BA00B3A8A3 AS DateTime), CAST(0x0000A8BA00B3A8A3 AS DateTime), 0, 50)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (152, N'meno48', N'priezvisko48', N'ulica48', N'48', N'psc48', N'mesto48', N'rc48', CAST(0x0000A8BA00B3ACC6 AS DateTime), CAST(0x0000A8BA00B3ACC6 AS DateTime), 0, 51)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (153, N'meno49', N'priezvisko49', N'ulica49', N'49', N'psc49', N'mesto49', N'rc49', CAST(0x0000A8BA00B3B057 AS DateTime), CAST(0x0000A8BA00B3B057 AS DateTime), 0, 52)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (154, N'meno50', N'priezvisko50', N'ulica50', N'50', N'psc50', N'mesto50', N'rc50', CAST(0x0000A8BA00B3B214 AS DateTime), CAST(0x0000A8BA00B3B214 AS DateTime), 0, 53)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (155, N'meno51', N'priezvisko51', N'ulica51', N'51', N'psc51', N'mesto51', N'rc51', CAST(0x0000A8BA00B3B4BA AS DateTime), CAST(0x0000A8BA00B3B4BB AS DateTime), 0, 54)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (156, N'meno52', N'priezvisko52', N'ulica52', N'52', N'psc52', N'mesto52', N'rc52', CAST(0x0000A8BA00B3B75A AS DateTime), CAST(0x0000A8BA00B3B75A AS DateTime), 0, 55)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (157, N'meno53', N'priezvisko53', N'ulica53', N'53', N'psc53', N'mesto53', N'rc53', CAST(0x0000A8BA00B3BB63 AS DateTime), CAST(0x0000A8BA00B3BB63 AS DateTime), 0, 56)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (158, N'meno54', N'priezvisko54', N'ulica54', N'54', N'psc54', N'mesto54', N'rc54', CAST(0x0000A8BA00B3BD12 AS DateTime), CAST(0x0000A8BA00B3BD12 AS DateTime), 0, 57)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (159, N'meno55', N'priezvisko55', N'ulica55', N'55', N'psc55', N'mesto55', N'rc55', CAST(0x0000A8BA00B3BF24 AS DateTime), CAST(0x0000A8BA00B3BF24 AS DateTime), 0, 58)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (160, N'meno56', N'priezvisko56', N'ulica56', N'56', N'psc56', N'mesto56', N'rc56', CAST(0x0000A8BA00B3C0EA AS DateTime), CAST(0x0000A8BA00B3C0EA AS DateTime), 0, 59)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (161, N'meno57', N'priezvisko57', N'ulica57', N'57', N'psc57', N'mesto57', N'rc57', CAST(0x0000A8BA00B3C599 AS DateTime), CAST(0x0000A8BA00B3C599 AS DateTime), 0, 60)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (162, N'meno58', N'priezvisko58', N'ulica58', N'58', N'psc58', N'mesto58', N'rc58', CAST(0x0000A8BA00B3C870 AS DateTime), CAST(0x0000A8BA00B3C870 AS DateTime), 0, 61)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (163, N'meno59', N'priezvisko59', N'ulica59', N'59', N'psc59', N'mesto59', N'rc59', CAST(0x0000A8BA00B3CC3A AS DateTime), CAST(0x0000A8BA00B3CC3A AS DateTime), 0, 62)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (164, N'meno60', N'priezvisko60', N'ulica60', N'60', N'psc60', N'mesto60', N'rc60', CAST(0x0000A8BA00B3CF37 AS DateTime), CAST(0x0000A8BA00B3CF37 AS DateTime), 0, 63)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (165, N'meno61', N'priezvisko61', N'ulica61', N'61', N'psc61', N'mesto61', N'rc61', CAST(0x0000A8BA00B3D1ED AS DateTime), CAST(0x0000A8BA00B3D1ED AS DateTime), 0, 64)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (166, N'meno62', N'priezvisko62', N'ulica62', N'62', N'psc62', N'mesto62', N'rc62', CAST(0x0000A8BA00B3D4CA AS DateTime), CAST(0x0000A8BA00B3D4CA AS DateTime), 0, 65)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (167, N'meno63', N'priezvisko63', N'ulica63', N'63', N'psc63', N'mesto63', N'rc63', CAST(0x0000A8BA00B3D7DF AS DateTime), CAST(0x0000A8BA00B3D7DF AS DateTime), 0, 66)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (168, N'meno64', N'priezvisko64', N'ulica64', N'64', N'psc64', N'mesto64', N'rc64', CAST(0x0000A8BA00B3D968 AS DateTime), CAST(0x0000A8BA00B3D968 AS DateTime), 0, 67)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (169, N'meno65', N'priezvisko65', N'ulica65', N'65', N'psc65', N'mesto65', N'rc65', CAST(0x0000A8BA00B3DBBA AS DateTime), CAST(0x0000A8BA00B3DBBA AS DateTime), 0, 68)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (170, N'meno66', N'priezvisko66', N'ulica66', N'66', N'psc66', N'mesto66', N'rc66', CAST(0x0000A8BA00B3DEF1 AS DateTime), CAST(0x0000A8BA00B3DEF1 AS DateTime), 0, 69)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (171, N'meno67', N'priezvisko67', N'ulica67', N'67', N'psc67', N'mesto67', N'rc67', CAST(0x0000A8BA00B3E2A2 AS DateTime), CAST(0x0000A8BA00B3E2A2 AS DateTime), 0, 70)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (172, N'meno68', N'priezvisko68', N'ulica68', N'68', N'psc68', N'mesto68', N'rc68', CAST(0x0000A8BA00B3E578 AS DateTime), CAST(0x0000A8BA00B3E578 AS DateTime), 0, 71)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (173, N'meno69', N'priezvisko69', N'ulica69', N'69', N'psc69', N'mesto69', N'rc69', CAST(0x0000A8BA00B3E84C AS DateTime), CAST(0x0000A8BA00B3E84C AS DateTime), 0, 72)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (174, N'meno70', N'priezvisko70', N'ulica70', N'70', N'psc70', N'mesto70', N'rc70', CAST(0x0000A8BA00B3EADD AS DateTime), CAST(0x0000A8BA00B3EADD AS DateTime), 0, 73)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (175, N'meno71', N'priezvisko71', N'ulica71', N'71', N'psc71', N'mesto71', N'rc71', CAST(0x0000A8BA00B3EEE1 AS DateTime), CAST(0x0000A8BA00B3EEE1 AS DateTime), 0, 74)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (176, N'meno72', N'priezvisko72', N'ulica72', N'72', N'psc72', N'mesto72', N'rc72', CAST(0x0000A8BA00B3F1F3 AS DateTime), CAST(0x0000A8BA00B3F1F3 AS DateTime), 0, 75)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (177, N'meno73', N'priezvisko73', N'ulica73', N'73', N'psc73', N'mesto73', N'rc73', CAST(0x0000A8BA00B3F4B4 AS DateTime), CAST(0x0000A8BA00B3F4B4 AS DateTime), 0, 76)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (178, N'meno74', N'priezvisko74', N'ulica74', N'74', N'psc74', N'mesto74', N'rc74', CAST(0x0000A8BA00B3F8A7 AS DateTime), CAST(0x0000A8BA00B3F8A7 AS DateTime), 0, 77)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (179, N'meno75', N'priezvisko75', N'ulica75', N'75', N'psc75', N'mesto75', N'rc75', CAST(0x0000A8BA00B3FAD0 AS DateTime), CAST(0x0000A8BA00B3FAD0 AS DateTime), 0, 78)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (180, N'meno76', N'priezvisko76', N'ulica76', N'76', N'psc76', N'mesto76', N'rc76', CAST(0x0000A8BA00B3FD7D AS DateTime), CAST(0x0000A8BA00B3FD7D AS DateTime), 0, 79)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (181, N'meno77', N'priezvisko77', N'ulica77', N'77', N'psc77', N'mesto77', N'rc77', CAST(0x0000A8BA00B40046 AS DateTime), CAST(0x0000A8BA00B40046 AS DateTime), 0, 80)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (182, N'meno78', N'priezvisko78', N'ulica78', N'78', N'psc78', N'mesto78', N'rc78', CAST(0x0000A8BA00B40319 AS DateTime), CAST(0x0000A8BA00B40319 AS DateTime), 0, 81)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (183, N'meno79', N'priezvisko79', N'ulica79', N'79', N'psc79', N'mesto79', N'rc79', CAST(0x0000A8BA00B404E9 AS DateTime), CAST(0x0000A8BA00B404E9 AS DateTime), 0, 82)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (184, N'meno80', N'priezvisko80', N'ulica80', N'80', N'psc80', N'mesto80', N'rc80', CAST(0x0000A8BA00B40717 AS DateTime), CAST(0x0000A8BA00B40717 AS DateTime), 0, 83)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (185, N'meno81', N'priezvisko81', N'ulica81', N'81', N'psc81', N'mesto81', N'rc81', CAST(0x0000A8BA00B40998 AS DateTime), CAST(0x0000A8BA00B40998 AS DateTime), 0, 84)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (186, N'meno82', N'priezvisko82', N'ulica82', N'82', N'psc82', N'mesto82', N'rc82', CAST(0x0000A8BA00B40CD2 AS DateTime), CAST(0x0000A8BA00B40CD2 AS DateTime), 0, 85)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (187, N'meno83', N'priezvisko83', N'ulica83', N'83', N'psc83', N'mesto83', N'rc83', CAST(0x0000A8BA00B410A7 AS DateTime), CAST(0x0000A8BA00B410A7 AS DateTime), 0, 86)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (188, N'meno84', N'priezvisko84', N'ulica84', N'84', N'psc84', N'mesto84', N'rc84', CAST(0x0000A8BA00B4140F AS DateTime), CAST(0x0000A8BA00B4140F AS DateTime), 0, 87)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (189, N'meno85', N'priezvisko85', N'ulica85', N'85', N'psc85', N'mesto85', N'rc85', CAST(0x0000A8BA00B4180C AS DateTime), CAST(0x0000A8BA00B4180C AS DateTime), 0, 88)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (190, N'meno86', N'priezvisko86', N'ulica86', N'86', N'psc86', N'mesto86', N'rc86', CAST(0x0000A8BA00B41AB6 AS DateTime), CAST(0x0000A8BA00B41AB6 AS DateTime), 0, 89)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (191, N'meno87', N'priezvisko87', N'ulica87', N'87', N'psc87', N'mesto87', N'rc87', CAST(0x0000A8BA00B41DE3 AS DateTime), CAST(0x0000A8BA00B41DE3 AS DateTime), 0, 90)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (192, N'meno88', N'priezvisko88', N'ulica88', N'88', N'psc88', N'mesto88', N'rc88', CAST(0x0000A8BA00B420E8 AS DateTime), CAST(0x0000A8BA00B420E8 AS DateTime), 0, 91)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (193, N'meno89', N'priezvisko89', N'ulica89', N'89', N'psc89', N'mesto89', N'rc89', CAST(0x0000A8BA00B422D0 AS DateTime), CAST(0x0000A8BA00B422D0 AS DateTime), 0, 92)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (194, N'meno90', N'priezvisko90', N'ulica90', N'90', N'psc90', N'mesto90', N'rc90', CAST(0x0000A8BA00B42575 AS DateTime), CAST(0x0000A8BA00B42575 AS DateTime), 0, 93)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (195, N'meno91', N'priezvisko91', N'ulica91', N'91', N'psc91', N'mesto91', N'rc91', CAST(0x0000A8BA00B42866 AS DateTime), CAST(0x0000A8BA00B42866 AS DateTime), 0, 94)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (196, N'meno92', N'priezvisko92', N'ulica92', N'92', N'psc92', N'mesto92', N'rc92', CAST(0x0000A8BA00B42BA3 AS DateTime), CAST(0x0000A8BA00B42BA3 AS DateTime), 0, 95)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (197, N'meno93', N'priezvisko93', N'ulica93', N'93', N'psc93', N'mesto93', N'rc93', CAST(0x0000A8BA00B42DA0 AS DateTime), CAST(0x0000A8BA00B42DA0 AS DateTime), 0, 96)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (198, N'meno94', N'priezvisko94', N'ulica94', N'94', N'psc94', N'mesto94', N'rc94', CAST(0x0000A8BA00B4303E AS DateTime), CAST(0x0000A8BA00B4303E AS DateTime), 0, 97)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (199, N'meno95', N'priezvisko95', N'ulica95', N'95', N'psc95', N'mesto95', N'rc95', CAST(0x0000A8BA00B432D0 AS DateTime), CAST(0x0000A8BA00B432D0 AS DateTime), 0, 98)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (200, N'meno96', N'priezvisko96', N'ulica96', N'96', N'psc96', N'mesto96', N'rc96', CAST(0x0000A8BA00B43632 AS DateTime), CAST(0x0000A8BA00B43632 AS DateTime), 0, 99)
GO
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (201, N'meno97', N'priezvisko97', N'ulica97', N'97', N'psc97', N'mesto97', N'rc97', CAST(0x0000A8BA00B43976 AS DateTime), CAST(0x0000A8BA00B43976 AS DateTime), 0, 100)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (202, N'meno98', N'priezvisko98', N'ulica98', N'98', N'psc98', N'mesto98', N'rc98', CAST(0x0000A8BA00B43BD4 AS DateTime), CAST(0x0000A8BA00B43BD4 AS DateTime), 0, 101)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (203, N'meno99', N'priezvisko99', N'ulica99', N'99', N'psc99', N'mesto99', N'rc99', CAST(0x0000A8BA00B44086 AS DateTime), CAST(0x0000A8BA00B44086 AS DateTime), 0, 102)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (204, N'meno100', N'priezvisko100', N'ulica100', N'100', N'psc100', N'mesto100', N'rc100', CAST(0x0000A8BA00B442C9 AS DateTime), CAST(0x0000A8BA00B442C9 AS DateTime), 0, 103)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (205, N'meno1', N'priezvisko1', N'ulica1', N'1', N'psc1', N'mesto1', N'rc1', CAST(0x0000A8BB01098369 AS DateTime), CAST(0x0000A8BB01098369 AS DateTime), 0, 104)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (206, N'meno2', N'priezvisko2', N'ulica2', N'2', N'psc2', N'mesto2', N'rc2', CAST(0x0000A8BB01098CF3 AS DateTime), CAST(0x0000A8BB01098CF3 AS DateTime), 0, 105)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (207, N'meno3', N'priezvisko3', N'ulica3', N'3', N'psc3', N'mesto3', N'rc3', CAST(0x0000A8BB01098E4E AS DateTime), CAST(0x0000A8BB01098E4E AS DateTime), 0, 106)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (208, N'meno4', N'priezvisko4', N'ulica4', N'4', N'psc4', N'mesto4', N'rc4', CAST(0x0000A8BB01098F1D AS DateTime), CAST(0x0000A8BB01098F1D AS DateTime), 0, 107)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (209, N'meno5', N'priezvisko5', N'ulica5', N'5', N'psc5', N'mesto5', N'rc5', CAST(0x0000A8BB01098F50 AS DateTime), CAST(0x0000A8BB01098F50 AS DateTime), 0, 108)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (210, N'meno6', N'priezvisko6', N'ulica6', N'6', N'psc6', N'mesto6', N'rc6', CAST(0x0000A8BB01099049 AS DateTime), CAST(0x0000A8BB01099049 AS DateTime), 0, 109)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (211, N'meno7', N'priezvisko7', N'ulica7', N'7', N'psc7', N'mesto7', N'rc7', CAST(0x0000A8BB01099192 AS DateTime), CAST(0x0000A8BB01099192 AS DateTime), 0, 110)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (212, N'meno8', N'priezvisko8', N'ulica8', N'8', N'psc8', N'mesto8', N'rc8', CAST(0x0000A8BB010991DD AS DateTime), CAST(0x0000A8BB010991DD AS DateTime), 0, 111)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (213, N'meno9', N'priezvisko9', N'ulica9', N'9', N'psc9', N'mesto9', N'rc9', CAST(0x0000A8BB0109920E AS DateTime), CAST(0x0000A8BB0109920E AS DateTime), 0, 112)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (214, N'meno10', N'priezvisko10', N'ulica10', N'10', N'psc10', N'mesto10', N'rc10', CAST(0x0000A8BB01099297 AS DateTime), CAST(0x0000A8BB01099297 AS DateTime), 0, 113)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (215, N'meno11', N'priezvisko11', N'ulica11', N'11', N'psc11', N'mesto11', N'rc11', CAST(0x0000A8BB01099380 AS DateTime), CAST(0x0000A8BB01099380 AS DateTime), 0, 114)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (216, N'meno12', N'priezvisko12', N'ulica12', N'12', N'psc12', N'mesto12', N'rc12', CAST(0x0000A8BB010994DB AS DateTime), CAST(0x0000A8BB010994DB AS DateTime), 0, 115)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (217, N'meno13', N'priezvisko13', N'ulica13', N'13', N'psc13', N'mesto13', N'rc13', CAST(0x0000A8BB01099589 AS DateTime), CAST(0x0000A8BB01099589 AS DateTime), 0, 116)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (218, N'meno14', N'priezvisko14', N'ulica14', N'14', N'psc14', N'mesto14', N'rc14', CAST(0x0000A8BB010995B7 AS DateTime), CAST(0x0000A8BB010995B7 AS DateTime), 0, 117)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (219, N'meno15', N'priezvisko15', N'ulica15', N'15', N'psc15', N'mesto15', N'rc15', CAST(0x0000A8BB01099607 AS DateTime), CAST(0x0000A8BB01099607 AS DateTime), 0, 118)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (220, N'meno16', N'priezvisko16', N'ulica16', N'16', N'psc16', N'mesto16', N'rc16', CAST(0x0000A8BB01099738 AS DateTime), CAST(0x0000A8BB01099738 AS DateTime), 0, 119)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (221, N'meno17', N'priezvisko17', N'ulica17', N'17', N'psc17', N'mesto17', N'rc17', CAST(0x0000A8BB01099838 AS DateTime), CAST(0x0000A8BB01099838 AS DateTime), 0, 120)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (222, N'meno18', N'priezvisko18', N'ulica18', N'18', N'psc18', N'mesto18', N'rc18', CAST(0x0000A8BB01099870 AS DateTime), CAST(0x0000A8BB01099870 AS DateTime), 0, 121)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (223, N'meno19', N'priezvisko19', N'ulica19', N'19', N'psc19', N'mesto19', N'rc19', CAST(0x0000A8BB010998A9 AS DateTime), CAST(0x0000A8BB010998A9 AS DateTime), 0, 122)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (224, N'meno20', N'priezvisko20', N'ulica20', N'20', N'psc20', N'mesto20', N'rc20', CAST(0x0000A8BB010998D8 AS DateTime), CAST(0x0000A8BB010998D8 AS DateTime), 0, 123)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (225, N'meno21', N'priezvisko21', N'ulica21', N'21', N'psc21', N'mesto21', N'rc21', CAST(0x0000A8BB0109990B AS DateTime), CAST(0x0000A8BB0109990B AS DateTime), 0, 124)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (226, N'meno22', N'priezvisko22', N'ulica22', N'22', N'psc22', N'mesto22', N'rc22', CAST(0x0000A8BB01099981 AS DateTime), CAST(0x0000A8BB01099981 AS DateTime), 0, 125)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (227, N'meno23', N'priezvisko23', N'ulica23', N'23', N'psc23', N'mesto23', N'rc23', CAST(0x0000A8BB01099A91 AS DateTime), CAST(0x0000A8BB01099A91 AS DateTime), 0, 126)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (228, N'meno24', N'priezvisko24', N'ulica24', N'24', N'psc24', N'mesto24', N'rc24', CAST(0x0000A8BB01099B5D AS DateTime), CAST(0x0000A8BB01099B5D AS DateTime), 0, 127)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (229, N'meno25', N'priezvisko25', N'ulica25', N'25', N'psc25', N'mesto25', N'rc25', CAST(0x0000A8BB01099C4E AS DateTime), CAST(0x0000A8BB01099C4E AS DateTime), 0, 128)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (230, N'meno26', N'priezvisko26', N'ulica26', N'26', N'psc26', N'mesto26', N'rc26', CAST(0x0000A8BB01099CD6 AS DateTime), CAST(0x0000A8BB01099CD6 AS DateTime), 0, 129)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (231, N'meno27', N'priezvisko27', N'ulica27', N'27', N'psc27', N'mesto27', N'rc27', CAST(0x0000A8BB01099D09 AS DateTime), CAST(0x0000A8BB01099D09 AS DateTime), 0, 130)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (232, N'meno28', N'priezvisko28', N'ulica28', N'28', N'psc28', N'mesto28', N'rc28', CAST(0x0000A8BB01099D36 AS DateTime), CAST(0x0000A8BB01099D36 AS DateTime), 0, 131)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (233, N'meno29', N'priezvisko29', N'ulica29', N'29', N'psc29', N'mesto29', N'rc29', CAST(0x0000A8BB01099D82 AS DateTime), CAST(0x0000A8BB01099D82 AS DateTime), 0, 132)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (234, N'meno30', N'priezvisko30', N'ulica30', N'30', N'psc30', N'mesto30', N'rc30', CAST(0x0000A8BB01099E66 AS DateTime), CAST(0x0000A8BB01099E66 AS DateTime), 0, 133)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (235, N'meno31', N'priezvisko31', N'ulica31', N'31', N'psc31', N'mesto31', N'rc31', CAST(0x0000A8BB01099FA1 AS DateTime), CAST(0x0000A8BB01099FA1 AS DateTime), 0, 134)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (236, N'meno32', N'priezvisko32', N'ulica32', N'32', N'psc32', N'mesto32', N'rc32', CAST(0x0000A8BB0109A079 AS DateTime), CAST(0x0000A8BB0109A079 AS DateTime), 0, 135)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (237, N'meno33', N'priezvisko33', N'ulica33', N'33', N'psc33', N'mesto33', N'rc33', CAST(0x0000A8BB0109A0A9 AS DateTime), CAST(0x0000A8BB0109A0A9 AS DateTime), 0, 136)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (238, N'meno34', N'priezvisko34', N'ulica34', N'34', N'psc34', N'mesto34', N'rc34', CAST(0x0000A8BB0109A0DD AS DateTime), CAST(0x0000A8BB0109A0DD AS DateTime), 0, 137)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (239, N'meno35', N'priezvisko35', N'ulica35', N'35', N'psc35', N'mesto35', N'rc35', CAST(0x0000A8BB0109A119 AS DateTime), CAST(0x0000A8BB0109A119 AS DateTime), 0, 138)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (240, N'meno36', N'priezvisko36', N'ulica36', N'36', N'psc36', N'mesto36', N'rc36', CAST(0x0000A8BB0109A214 AS DateTime), CAST(0x0000A8BB0109A214 AS DateTime), 0, 139)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (241, N'meno37', N'priezvisko37', N'ulica37', N'37', N'psc37', N'mesto37', N'rc37', CAST(0x0000A8BB0109A328 AS DateTime), CAST(0x0000A8BB0109A328 AS DateTime), 0, 140)
INSERT [dbo].[Pacient] ([PacientID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [RodneCislo], [DatumNarodenia], [DatumVytvorenia], [Zmazany], [EvidujuciZamestnanec_ZamestnanecID]) VALUES (242, N'meno38', N'priezvisko38', N'ulica38', N'38', N'psc38', N'mesto38', N'rc38', CAST(0x0000A8BB0109A43D AS DateTime), CAST(0x0000A8BB0109A43D AS DateTime), 0, 141)
SET IDENTITY_INSERT [dbo].[Pacient] OFF
SET IDENTITY_INSERT [dbo].[Recept] ON 

INSERT [dbo].[Recept] ([ReceptID], [DatumVytvorenia], [DatumPlatnosti], [Zmazany], [Pacient_PacientID], [Zamestnanec_ZamestnanecID]) VALUES (1, CAST(0x0000A8BA00000000 AS DateTime), CAST(0x0000A8C400000000 AS DateTime), 0, 1, 1)
INSERT [dbo].[Recept] ([ReceptID], [DatumVytvorenia], [DatumPlatnosti], [Zmazany], [Pacient_PacientID], [Zamestnanec_ZamestnanecID]) VALUES (3, CAST(0x0000A8BA00000000 AS DateTime), CAST(0x0000A8C400000000 AS DateTime), 0, 2, 1)
SET IDENTITY_INSERT [dbo].[Recept] OFF
SET IDENTITY_INSERT [dbo].[Zamestnanec] ON 

INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (1, N'Ondro', N'Tadanai', N'Zeleznicna', N'7/8', N'94501', N'Komarno', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (2, N'Ondro', N'Tadanai', N'Zeleznicna', N'7/8', N'94501', N'Komarno', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (3, N'Ondro', N'Tadanai', N'Zeleznicna', N'7/8', N'94501', N'Komarno', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (4, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (5, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (6, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (7, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (8, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (9, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (10, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (11, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (12, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (13, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (14, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (15, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (16, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (17, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (18, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (19, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (20, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (21, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (22, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (23, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (24, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (25, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (26, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (27, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (28, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (29, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (30, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (31, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (32, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (33, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (34, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (35, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (36, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (37, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (38, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (39, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (40, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (41, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (42, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (43, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (44, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (45, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (46, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (47, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (48, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (49, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (50, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (51, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (52, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (53, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (54, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (55, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (56, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (57, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (58, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (59, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (60, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (61, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (62, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (63, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (64, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (65, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (66, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (67, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (68, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (69, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (70, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (71, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (72, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (73, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (74, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (75, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (76, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (77, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (78, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (79, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (80, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (81, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (82, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (83, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (84, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (85, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (86, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (87, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (88, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (89, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (90, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (91, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (92, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (93, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (94, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (95, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (96, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (97, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (98, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (99, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
GO
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (100, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (101, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (102, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (103, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (104, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (105, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (106, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (107, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (108, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (109, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (110, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (111, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (112, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (113, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (114, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (115, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (116, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (117, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (118, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (119, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (120, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (121, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (122, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (123, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (124, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (125, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (126, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (127, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (128, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (129, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (130, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (131, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (132, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (133, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (134, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (135, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (136, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (137, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (138, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (139, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (140, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
INSERT [dbo].[Zamestnanec] ([ZamestnanecID], [Meno], [Priezvisko], [Ulica], [Cislo], [PSC], [Mesto], [Zmazany]) VALUES (141, N'menoaa', N'priezviskoaa', N'ulicaaa', N'aa', N'pscaa', N'mestoaa', 0)
SET IDENTITY_INSERT [dbo].[Zamestnanec] OFF
ALTER TABLE [dbo].[Faktura]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Faktura_dbo.Pacient_Pacient_PacientID] FOREIGN KEY([Pacient_PacientID])
REFERENCES [dbo].[Pacient] ([PacientID])
GO
ALTER TABLE [dbo].[Faktura] CHECK CONSTRAINT [FK_dbo.Faktura_dbo.Pacient_Pacient_PacientID]
GO
ALTER TABLE [dbo].[Faktura]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Faktura_dbo.Zamestnanec_Vystavil_ZamestnanecID] FOREIGN KEY([Vystavil_ZamestnanecID])
REFERENCES [dbo].[Zamestnanec] ([ZamestnanecID])
GO
ALTER TABLE [dbo].[Faktura] CHECK CONSTRAINT [FK_dbo.Faktura_dbo.Zamestnanec_Vystavil_ZamestnanecID]
GO
ALTER TABLE [dbo].[Liek]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Liek_dbo.Zamestnanec_Zamestnanec_ZamestnanecID] FOREIGN KEY([Zamestnanec_ZamestnanecID])
REFERENCES [dbo].[Zamestnanec] ([ZamestnanecID])
GO
ALTER TABLE [dbo].[Liek] CHECK CONSTRAINT [FK_dbo.Liek_dbo.Zamestnanec_Zamestnanec_ZamestnanecID]
GO
ALTER TABLE [dbo].[LiekNaRecepte]  WITH CHECK ADD  CONSTRAINT [FK_dbo.LiekNaRecepte_dbo.Liek_Liek_LiekID] FOREIGN KEY([Liek_LiekID])
REFERENCES [dbo].[Liek] ([LiekID])
GO
ALTER TABLE [dbo].[LiekNaRecepte] CHECK CONSTRAINT [FK_dbo.LiekNaRecepte_dbo.Liek_Liek_LiekID]
GO
ALTER TABLE [dbo].[LiekNaRecepte]  WITH CHECK ADD  CONSTRAINT [FK_dbo.LiekNaRecepte_dbo.Recept_Recept_ReceptID] FOREIGN KEY([Recept_ReceptID])
REFERENCES [dbo].[Recept] ([ReceptID])
GO
ALTER TABLE [dbo].[LiekNaRecepte] CHECK CONSTRAINT [FK_dbo.LiekNaRecepte_dbo.Recept_Recept_ReceptID]
GO
ALTER TABLE [dbo].[Pacient]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Pacient_dbo.Zamestnanec_EvidujuciZamestnanec_ZamestnanecID] FOREIGN KEY([EvidujuciZamestnanec_ZamestnanecID])
REFERENCES [dbo].[Zamestnanec] ([ZamestnanecID])
GO
ALTER TABLE [dbo].[Pacient] CHECK CONSTRAINT [FK_dbo.Pacient_dbo.Zamestnanec_EvidujuciZamestnanec_ZamestnanecID]
GO
ALTER TABLE [dbo].[Recept]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Recept_dbo.Pacient_Pacient_PacientID] FOREIGN KEY([Pacient_PacientID])
REFERENCES [dbo].[Pacient] ([PacientID])
GO
ALTER TABLE [dbo].[Recept] CHECK CONSTRAINT [FK_dbo.Recept_dbo.Pacient_Pacient_PacientID]
GO
ALTER TABLE [dbo].[Recept]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Recept_dbo.Zamestnanec_Zamestnanec_ZamestnanecID] FOREIGN KEY([Zamestnanec_ZamestnanecID])
REFERENCES [dbo].[Zamestnanec] ([ZamestnanecID])
GO
ALTER TABLE [dbo].[Recept] CHECK CONSTRAINT [FK_dbo.Recept_dbo.Zamestnanec_Zamestnanec_ZamestnanecID]
GO
ALTER TABLE [dbo].[Ukon]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Ukon_dbo.Pacient_Pacient_PacientID] FOREIGN KEY([Pacient_PacientID])
REFERENCES [dbo].[Pacient] ([PacientID])
GO
ALTER TABLE [dbo].[Ukon] CHECK CONSTRAINT [FK_dbo.Ukon_dbo.Pacient_Pacient_PacientID]
GO
ALTER TABLE [dbo].[Ukon]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Ukon_dbo.Zamestnanec_Vytvoril_ZamestnanecID] FOREIGN KEY([Vytvoril_ZamestnanecID])
REFERENCES [dbo].[Zamestnanec] ([ZamestnanecID])
GO
ALTER TABLE [dbo].[Ukon] CHECK CONSTRAINT [FK_dbo.Ukon_dbo.Zamestnanec_Vytvoril_ZamestnanecID]
GO
ALTER TABLE [dbo].[UkonPacient]  WITH CHECK ADD  CONSTRAINT [FK_dbo.UkonPacient_dbo.Pacient_Pacient_PacientID] FOREIGN KEY([Pacient_PacientID])
REFERENCES [dbo].[Pacient] ([PacientID])
GO
ALTER TABLE [dbo].[UkonPacient] CHECK CONSTRAINT [FK_dbo.UkonPacient_dbo.Pacient_Pacient_PacientID]
GO
ALTER TABLE [dbo].[UkonPacient]  WITH CHECK ADD  CONSTRAINT [FK_dbo.UkonPacient_dbo.Ukon_Ukon_UkonID] FOREIGN KEY([Ukon_UkonID])
REFERENCES [dbo].[Ukon] ([UkonID])
GO
ALTER TABLE [dbo].[UkonPacient] CHECK CONSTRAINT [FK_dbo.UkonPacient_dbo.Ukon_Ukon_UkonID]
GO
ALTER TABLE [dbo].[UkonPacient]  WITH CHECK ADD  CONSTRAINT [FK_dbo.UkonPacient_dbo.Zamestnanec_Zamestnanec_ZamestnanecID] FOREIGN KEY([Zamestnanec_ZamestnanecID])
REFERENCES [dbo].[Zamestnanec] ([ZamestnanecID])
GO
ALTER TABLE [dbo].[UkonPacient] CHECK CONSTRAINT [FK_dbo.UkonPacient_dbo.Zamestnanec_Zamestnanec_ZamestnanecID]
GO
