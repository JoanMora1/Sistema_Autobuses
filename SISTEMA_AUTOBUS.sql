CREATE DATABASE SISTEMA_AUTOBUS
USE SISTEMA_AUTOBUS

CREATE TABLE CHOFER(
ID_CHOFER INT IDENtity (1,1) NOT NULL PRIMARY KEY,
NOMBRE VARCHAR(40),
APELLIDO VARCHAR(40),
NACIMIENTO DATETIME,
CEDULA VARCHAR(15),
DISPON VARCHAR (5) DEFAULT 'V'
)

CREATE TABLE AUTOBUS(
ID_AUTOBUS INT IDENtity (1,1) NOT NULL PRIMARY KEY,
MARCA VARCHAR(40),
MODELO VARCHAR(40),
PLACA VARCHAR(20),
COLOR VARCHAR(30),
ANO VARCHAR(20),
DISPON VARCHAR (5) DEFAULT 'V'
)

CREATE TABLE RUTAS(
ID_RUTA INT IDENtity (1,1) NOT NULL PRIMARY KEY,
NOMBRE VARCHAR(40),
DISPON VARCHAR (5) DEFAULT 'V'
)

CREATE TABLE VIAJES(
ID_VIAJE INT IDENtity (1,1) NOT NULL PRIMARY KEY,
CHOFER VARCHAR(40),
AUTOBUS VARCHAR(40),
RUTA VARCHAR(20),
)

--STORED PROCEDURES

--CRUD CHOFERES

--INSERTAR CHOFER
CREATE PROC SP_INSERTAR_CHOFER
@NOMBRE VARCHAR(40),
@APELLIDO VARCHAR(40),
@NACIMIENTO DATETIME,
@CEDULA VARCHAR(15)
AS
INSERT INTO CHOFER(NOMBRE,APELLIDO,NACIMIENTO,CEDULA) VALUES (@NOMBRE,@APELLIDO,@NACIMIENTO,@CEDULA)

--EDITAR CHOFER
CREATE PROC SP_EDITAR_CHOFER
@ID_CHOFER INT,
@NOMBRE VARCHAR(40),
@APELLIDO VARCHAR(40),
@NACIMIENTO DATETIME,
@CEDULA VARCHAR(15)
AS
UPDATE CHOFER SET NOMBRE=@NOMBRE, APELLIDO=@APELLIDO, NACIMIENTO=@NACIMIENTO, CEDULA=@CEDULA
WHERE ID_CHOFER=@ID_CHOFER

--ELIMINAR CHOFER
CREATE PROC SP_ELIMINAR_CHOFER
@ID_CHOFER INT
AS
DELETE CHOFER
WHERE ID_CHOFER=@ID_CHOFER

--BUSCAR CHOFER
CREATE PROC SP_BUSCAR_CHOFER
@BUSCAR NVARCHAR(40)
AS
SELECT * FROM CHOFER
WHERE NOMBRE LIKE @BUSCAR + '%'


/*CRUD AUTOBUS*/

--INSERTAR AUTOBUS
CREATE PROC SP_INSERTAR_AUTOBUS
@MARCA VARCHAR(40),
@MODELO VARCHAR(40),
@PLACA VARCHAR(40),
@COLOR VARCHAR(15),
@ANO VARCHAR(10)
AS
INSERT INTO AUTOBUS(MARCA,MODELO,PLACA,COLOR,ANO) VALUES (@MARCA,@MODELO,@PLACA,@COLOR,@ANO)

--EDITAR AUTOBUS
CREATE PROC SP_EDITAR_AUTOBUS
@ID_AUTOBUS INT,
@MARCA VARCHAR(40),
@MODELO VARCHAR(40),
@PLACA VARCHAR(40),
@COLOR VARCHAR(15),
@ANO VARCHAR(10)
AS
UPDATE AUTOBUS SET MARCA=@MARCA, MODELO=@MODELO, PLACA=@PLACA, COLOR=@COLOR, ANO=@ANO
WHERE ID_AUTOBUS=@ID_AUTOBUS

--ELIMINAR AUTOBUS
CREATE PROC SP_ELIMINAR_AUTOBUS
@ID_AUTOBUS INT
AS
DELETE AUTOBUS
WHERE ID_AUTOBUS=@ID_AUTOBUS

--BUSCAR AUTOBUS
CREATE PROC SP_BUSCAR_AUTOBUS
@BUSCAR NVARCHAR (40)
AS
SELECT * FROM AUTOBUS
WHERE MODELO LIKE @BUSCAR + '%'

--CRUD RUTAS

--INSERTAR RUTA
CREATE PROC SP_INSERTAR_RUTA
@NOMBRE VARCHAR(40)
AS
INSERT INTO RUTAS(NOMBRE) VALUES (@NOMBRE)

--EDITAR RUTA
CREATE PROC SP_EDITAR_RUTA
@ID_RUTA INT,
@NOMBRE VARCHAR(40)
AS
UPDATE RUTAS SET NOMBRE=@NOMBRE
WHERE ID_RUTA=@ID_RUTA

--ELIMINAR RUTA
CREATE PROC SP_ELIMINAR_RUTA
@ID_RUTA INT
AS
DELETE RUTAS
WHERE ID_RUTA=@ID_RUTA

--BUSCAR RUTA
CREATE PROC SP_BUSCAR_RUTA
@BUSCAR NVARCHAR(40)
AS
SELECT * FROM RUTAS 
WHERE NOMBRE LIKE @BUSCAR + '%'

-- CARGAR CBX CHOFER
CREATE PROC SP_CARGAR_CHOFER
AS
SELECT NOMBRE FROM CHOFER 
WHERE DISPON = 'V'

--CARGAR CBX AUTOBUS 
CREATE PROC SP_CARGAR_AUTOBUS
AS
SELECT MODELO, CONCAT(MARCA, ' ', PLACA) AUTOBUS FROM AUTOBUS 
WHERE DISPON='V'

--CARGAR CBX RUTA 
CREATE PROC SP_CARGAR_RUTA
AS
SELECT NOMBRE AS RUTAS FROM RUTAS
WHERE DISPON='V'

--BUSCAR VIAJE
CREATE PROC SP_BUSCAR_VIAJE
@BUSCAR NVARCHAR(30)
AS
SELECT * FROM VIAJES
WHERE CHOFER LIKE @BUSCAR + '%'

--INSERTAR VIAJE
CREATE PROC SP_INSERTAR_VIAJE
@CHOFER VARCHAR(30),
@AUTOBUS VARCHAR(30),
@RUTA VARCHAR(30)
AS
INSERT INTO VIAJES(CHOFER,AUTOBUS,RUTA) VALUES (@CHOFER,@AUTOBUS,@RUTA)

CREATE PROC SP_DISPON_CHOFER	
@NOMBRE VARCHAR(40)
AS
UPDATE CHOFER SET DISPON='F' WHERE NOMBRE=@NOMBRE

CREATE PROC SP_DISPON_AUTOBUS
@MODELO VARCHAR(30)
AS
UPDATE AUTOBUS SET DISPON='F' WHERE MODELO=@MODELO

CREATE PROC SP_DISPON_RUTA
@RUTA VARCHAR(40)
AS
UPDATE RUTAS SET DISPON='F' WHERE NOMBRE=@RUTA

CREATE PROC SP_DISPONIBLE_C
@NOMBRE VARCHAR(30)
AS
UPDATE CHOFER SET DISPON='V' WHERE NOMBRE=@NOMBRE

CREATE PROC SP_DISPONIBLE_A
@MODELO VARCHAR(30)
AS
UPDATE AUTOBUS SET DISPON='V' WHERE MODELO=@MODELO

CREATE PROC SP_DISPONIBLE_R
@NOMBRE VARCHAR(30)
AS
UPDATE RUTAS SET DISPON='V' WHERE NOMBRE=@NOMBRE

CREATE PROC SP_FIN_VIAJE
@ID_VIAJE INT
AS
DELETE FROM VIAJES WHERE ID_VIAJE=@ID_VIAJE

