USE [veterinariaBD]
GO
/****** Object:  Table [dbo].[Citas]    Script Date: 01/08/2022 16:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Citas](
	[NumeroCita] [int] IDENTITY(1,1) NOT NULL,
	[IDCliente] [int] NULL,
	[IDMascota] [int] NULL,
	[FechaCita] [date] NULL,
	[IDDiagnostico] [int] NULL,
 CONSTRAINT [PK_Citas] PRIMARY KEY CLUSTERED 
(
	[NumeroCita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 01/08/2022 16:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[IDCliente] [int] NOT NULL,
	[Nombre] [varchar](12) NULL,
	[PrimerApellido] [varchar](12) NULL,
	[SegundoApellido] [varchar](12) NULL,
	[Telefono] [int] NULL,
	[CorreoElectronico] [varchar](50) NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[IDCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Diagnósticos]    Script Date: 01/08/2022 16:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diagnósticos](
	[IDDiagnostico] [int] NOT NULL,
	[DescripcionDiagnostico] [varchar](100) NULL,
	[NumeroCita] [int] NULL,
 CONSTRAINT [PK_Diagnósticos] PRIMARY KEY CLUSTERED 
(
	[IDDiagnostico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Facturacion]    Script Date: 01/08/2022 16:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facturacion](
	[NumeroFactura] [int] NOT NULL,
	[Descripcion] [varchar](100) NULL,
	[NumeroCita] [int] NULL,
	[NombreCliente] [varchar](12) NULL,
	[NombreMascota] [varchar](12) NULL,
	[FechaCita] [date] NULL,
 CONSTRAINT [PK_Facturacion] PRIMARY KEY CLUSTERED 
(
	[NumeroFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 01/08/2022 16:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[NombreUsuario] [varchar](12) NULL,
	[Contraseña] [varchar](18) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mascotas]    Script Date: 01/08/2022 16:04:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mascotas](
	[IDMascota] [int] NOT NULL,
	[Nombre] [varchar](12) NULL,
	[IdCliente] [int] NULL,
 CONSTRAINT [PK_Mascotas] PRIMARY KEY CLUSTERED 
(
	[IDMascota] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Citas]  WITH CHECK ADD  CONSTRAINT [FK_Citas_Clientes] FOREIGN KEY([IDCliente])
REFERENCES [dbo].[Clientes] ([IDCliente])
GO
ALTER TABLE [dbo].[Citas] CHECK CONSTRAINT [FK_Citas_Clientes]
GO
ALTER TABLE [dbo].[Citas]  WITH CHECK ADD  CONSTRAINT [FK_Citas_Diagnósticos] FOREIGN KEY([IDDiagnostico])
REFERENCES [dbo].[Diagnósticos] ([IDDiagnostico])
GO
ALTER TABLE [dbo].[Citas] CHECK CONSTRAINT [FK_Citas_Diagnósticos]
GO
ALTER TABLE [dbo].[Citas]  WITH CHECK ADD  CONSTRAINT [FK_Citas_Mascotas] FOREIGN KEY([IDMascota])
REFERENCES [dbo].[Mascotas] ([IDMascota])
GO
ALTER TABLE [dbo].[Citas] CHECK CONSTRAINT [FK_Citas_Mascotas]
GO
ALTER TABLE [dbo].[Facturacion]  WITH CHECK ADD  CONSTRAINT [FK_Facturacion_Citas] FOREIGN KEY([NumeroCita])
REFERENCES [dbo].[Citas] ([NumeroCita])
GO
ALTER TABLE [dbo].[Facturacion] CHECK CONSTRAINT [FK_Facturacion_Citas]
GO
