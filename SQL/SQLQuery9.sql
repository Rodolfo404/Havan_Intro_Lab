USE [HavanLabs]
GO
-- Create
CREATE TABLE Categorias
(
	ID INT IDENTITY(1,1) NOT NULL
	,Nome VARCHAR(50) NOT NULL
)

--Delete
DROP TABLE Produto





/****** Object:  Table [dbo].[Produto]    Script Date: 12/07/2021 14:01:06 
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Produto](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Descrição] [varchar](150) NULL
) ON [PRIMARY]
GO
******/



