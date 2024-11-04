CREATE DATABASE Parcial2Bsb;
GO

USE Parcial2Bsb;
GO

USE [master];
GO
CREATE LOGIN [usrparcial2] WITH PASSWORD=N'12345678',
    DEFAULT_DATABASE = Parcial2Bsb,
    CHECK_EXPIRATION = OFF,
    CHECK_POLICY = ON;
GO
USE Parcial2Bsb;
GO
CREATE USER [usrparcial2] FOR LOGIN [usrparcial2];
GO
ALTER ROLE [db_owner] ADD MEMBER [usrparcial2];
GO

DROP TABLE IF EXISTS Serie;

CREATE TABLE Serie (
    id INT IDENTITY(1,1) PRIMARY KEY,
    titulo VARCHAR(250),
    sinopsis VARCHAR(5000),
    director VARCHAR(100),
    episodios INT,
    fechaEstreno DATE,
    idiomaPrincipal varchar (20),
    estado SMALLINT NOT NULL DEFAULT 1  -- -1: Eliminado, 0: Inactivo, 1: Activo
);
GO

alter PROC paSerieListar @parametro VARCHAR(50)
AS
    SELECT *  FROM Serie
    WHERE estado<>-1 AND titulo LIKE '%'+REPLACE(@parametro, ' ', '%')+'%'


INSERT INTO Serie (titulo, sinopsis, director, episodios, fecha_estreno, estado)
VALUES 
('Breaking Bad', 'Un profesor de química se convierte en fabricante de metanfetaminas para asegurar el futuro financiero de su familia tras ser diagnosticado con cáncer.', 'Vince Gilligan', 62, '2008-01-20', 1),
('Stranger Things', 'Un grupo de niños descubre misterios sobrenaturales y secretos del gobierno en su pequeña ciudad.', 'Los Hermanos Duffer', 34, '2016-07-15', 1),
('Game of Thrones', 'Nobles familias luchan por el control del Trono de Hierro en el continente de Westeros.', 'David Benioff y D.B. Weiss', 73, '2011-04-17', 1);
GO
