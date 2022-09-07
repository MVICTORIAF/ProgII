USE [Carreras1]
GO
/****** Object:  StoredProcedure [dbo].[SP_REPORTE_CARRERA]    Script Date: 6/9/2022 16:01:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SP_RE_CARRERA]
@letra_desde varchar(40),
@letra_hasta varchar(30)
AS
BEGIN
select titulo
from carrera c
where titulo like '['+@letra_desde+'-'+@letra_hasta+']%'
END
