USE [Carreras1]
GO
/****** Object:  Table [dbo].[asignatura]    Script Date: 30/8/2022 20:27:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[asignatura](
	[id_asignatura] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](250) NULL,
 CONSTRAINT [pk_id_asignatura] PRIMARY KEY CLUSTERED 
(
	[id_asignatura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[carrera]    Script Date: 30/8/2022 20:27:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[carrera](
	[id_carrera] [int] IDENTITY(1,1) NOT NULL,
	[titulo] [varchar](250) NULL,
	[banActivo] [bit] NULL,
 CONSTRAINT [pk_id_carrera] PRIMARY KEY CLUSTERED 
(
	[id_carrera] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalleCarrera]    Script Date: 30/8/2022 20:27:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalleCarrera](
	[id_detalle_carrera] [int] IDENTITY(1,1) NOT NULL,
	[anioCarrera] [int] NULL,
	[cuatrimestre] [int] NULL,
	[id_carrera] [int] NULL,
	[id_asignatura] [int] NULL,
 CONSTRAINT [pk_detalle_carrera] PRIMARY KEY CLUSTERED 
(
	[id_detalle_carrera] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[asignatura] ON 

INSERT [dbo].[asignatura] ([id_asignatura], [nombre]) VALUES (1, N'Matematica')
INSERT [dbo].[asignatura] ([id_asignatura], [nombre]) VALUES (2, N'Biologia')
INSERT [dbo].[asignatura] ([id_asignatura], [nombre]) VALUES (3, N'Laboratorio')
INSERT [dbo].[asignatura] ([id_asignatura], [nombre]) VALUES (4, N'Ingles')
INSERT [dbo].[asignatura] ([id_asignatura], [nombre]) VALUES (5, N'Quimica')
INSERT [dbo].[asignatura] ([id_asignatura], [nombre]) VALUES (6, N'Estadistica')
INSERT [dbo].[asignatura] ([id_asignatura], [nombre]) VALUES (7, N'Fisica')
INSERT [dbo].[asignatura] ([id_asignatura], [nombre]) VALUES (8, N'Sistema de Datos')
INSERT [dbo].[asignatura] ([id_asignatura], [nombre]) VALUES (9, N'Contabilidad')
SET IDENTITY_INSERT [dbo].[asignatura] OFF
GO
SET IDENTITY_INSERT [dbo].[carrera] ON 

INSERT [dbo].[carrera] ([id_carrera], [titulo], [banActivo]) VALUES (1, N'Programacion en Sistemas', NULL)
INSERT [dbo].[carrera] ([id_carrera], [titulo], [banActivo]) VALUES (2, N'Odontologia', NULL)
INSERT [dbo].[carrera] ([id_carrera], [titulo], [banActivo]) VALUES (3, N'Medicina', NULL)
INSERT [dbo].[carrera] ([id_carrera], [titulo], [banActivo]) VALUES (4, N'Farmacia', NULL)
INSERT [dbo].[carrera] ([id_carrera], [titulo], [banActivo]) VALUES (5, N'Abogacia', NULL)
INSERT [dbo].[carrera] ([id_carrera], [titulo], [banActivo]) VALUES (6, N'Contabilidad', NULL)
INSERT [dbo].[carrera] ([id_carrera], [titulo], [banActivo]) VALUES (7, N'Ing. en Sistemas', NULL)
INSERT [dbo].[carrera] ([id_carrera], [titulo], [banActivo]) VALUES (8, N'Enfermeria', NULL)
INSERT [dbo].[carrera] ([id_carrera], [titulo], [banActivo]) VALUES (9, N'turismo', NULL)
INSERT [dbo].[carrera] ([id_carrera], [titulo], [banActivo]) VALUES (10, N'turismo', NULL)
INSERT [dbo].[carrera] ([id_carrera], [titulo], [banActivo]) VALUES (11, N'reere', NULL)
INSERT [dbo].[carrera] ([id_carrera], [titulo], [banActivo]) VALUES (12, N'hola', NULL)
INSERT [dbo].[carrera] ([id_carrera], [titulo], [banActivo]) VALUES (13, N'jjjj', NULL)
INSERT [dbo].[carrera] ([id_carrera], [titulo], [banActivo]) VALUES (14, N'hola', NULL)
INSERT [dbo].[carrera] ([id_carrera], [titulo], [banActivo]) VALUES (15, N'turismo ', NULL)
INSERT [dbo].[carrera] ([id_carrera], [titulo], [banActivo]) VALUES (16, N'TURISMO', NULL)
INSERT [dbo].[carrera] ([id_carrera], [titulo], [banActivo]) VALUES (17, N'programacion', NULL)
INSERT [dbo].[carrera] ([id_carrera], [titulo], [banActivo]) VALUES (18, N'programacion', NULL)
SET IDENTITY_INSERT [dbo].[carrera] OFF
GO
SET IDENTITY_INSERT [dbo].[detalleCarrera] ON 

INSERT [dbo].[detalleCarrera] ([id_detalle_carrera], [anioCarrera], [cuatrimestre], [id_carrera], [id_asignatura]) VALUES (1, 2020, 2, 1, 1)
INSERT [dbo].[detalleCarrera] ([id_detalle_carrera], [anioCarrera], [cuatrimestre], [id_carrera], [id_asignatura]) VALUES (2, 2019, 1, 1, 3)
INSERT [dbo].[detalleCarrera] ([id_detalle_carrera], [anioCarrera], [cuatrimestre], [id_carrera], [id_asignatura]) VALUES (3, 2021, 1, 9, 3)
INSERT [dbo].[detalleCarrera] ([id_detalle_carrera], [anioCarrera], [cuatrimestre], [id_carrera], [id_asignatura]) VALUES (4, 2021, 1, 11, 3)
INSERT [dbo].[detalleCarrera] ([id_detalle_carrera], [anioCarrera], [cuatrimestre], [id_carrera], [id_asignatura]) VALUES (5, 2021, 1, 12, 1)
INSERT [dbo].[detalleCarrera] ([id_detalle_carrera], [anioCarrera], [cuatrimestre], [id_carrera], [id_asignatura]) VALUES (6, 7965, 1, 13, 1)
SET IDENTITY_INSERT [dbo].[detalleCarrera] OFF
GO
ALTER TABLE [dbo].[detalleCarrera]  WITH CHECK ADD  CONSTRAINT [fk_id_asignatura] FOREIGN KEY([id_asignatura])
REFERENCES [dbo].[asignatura] ([id_asignatura])
GO
ALTER TABLE [dbo].[detalleCarrera] CHECK CONSTRAINT [fk_id_asignatura]
GO
ALTER TABLE [dbo].[detalleCarrera]  WITH CHECK ADD  CONSTRAINT [fk_id_carrera] FOREIGN KEY([id_carrera])
REFERENCES [dbo].[carrera] ([id_carrera])
GO
ALTER TABLE [dbo].[detalleCarrera] CHECK CONSTRAINT [fk_id_carrera]
GO
/****** Object:  StoredProcedure [dbo].[SP_BORRAR_CARRERA]    Script Date: 30/8/2022 20:27:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[SP_BORRAR_CARRERA]
AS
BEGIN
	
	SELECT * from carrera;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_consultar_asignaturas]    Script Date: 30/8/2022 20:27:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_consultar_asignaturas]
AS
BEGIN
	
	SELECT * from asignatura;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_consultar_carrera]    Script Date: 30/8/2022 20:27:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_consultar_carrera]
AS
BEGIN
	
	SELECT * from carrera;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_insertar_carrera]    Script Date: 30/8/2022 20:27:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_insertar_carrera] 
	@titulo varchar(250),
	@id_carrera int OUTPUT
AS
BEGIN
	INSERT INTO carrera(titulo)
    VALUES (@titulo);
    SET @id_carrera = SCOPE_IDENTITY();

END
GO
/****** Object:  StoredProcedure [dbo].[SP_insertar_detalleCarreras]    Script Date: 30/8/2022 20:27:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_insertar_detalleCarreras]
	@anioCarrera int, 
	@cuatrimestre varchar (250),
	@id_carrera int,
	@id_asignatura int

AS
BEGIN
	INSERT INTO detalleCarrera(anioCarrera, cuatrimestre, id_carrera, id_asignatura)
    VALUES (@anioCarrera, @cuatrimestre, @id_carrera, @id_asignatura);
  
END
GO
