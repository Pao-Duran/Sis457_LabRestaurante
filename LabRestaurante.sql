CREATE DATABASE LabRestaurante;

USE master
GO

CREATE LOGIN usrrestaurante WITH PASSWORD=N'123456',
	DEFAULT_DATABASE=LabRestaurante,
	CHECK_EXPIRATION=OFF,
	CHECK_POLICY=ON
GO

USE LabRestaurante
GO

CREATE USER usrrestaurante FOR LOGIN usrrestaurante
GO
ALTER ROLE db_owner ADD MEMBER usrrestaurante
GO

--ELIMINAR TABLAS 
DROP TABLE Cliente;
DROP TABLE Empleado;
DROP TABLE Comida;
DROP TABLE detalleFactura;
DROP TABLE Bebida;
DROP TABLE Usuario;

--CREACION DE TABLAS 

CREATE TABLE Usuario (
  id INT PRIMARY KEY IDENTITY (1,1),
  nombre VARCHAR(30) NOT NULL,
  clave VARCHAR(10) NOT NULL,
  idEmpleado INT NOT NULL,

  CONSTRAINT fk_Usuario_Empleado FOREIGN KEY(idEmpleado) REFERENCES Empleado(id)

);


CREATE TABLE Cliente (
id INT PRIMARY KEY IDENTITY (1,1),
nombre VARCHAR (50) NOT NULL,
primerApellido VARCHAR (30) NOT NULL,
segundoApellido VARCHAR(30) NOT NULL,
cedulaIdentidad VARCHAR (10) NOT NULL,

);

CREATE TABLE Empleado (
id INT PRIMARY KEY IDENTITY(1,1),
nombre VARCHAR(30) NOT NULL,
primerApellido VARCHAR (30) NOT NULL,
segundoApellido VARCHAR(30) NOT NULL,
telefono BIGINT NOT NULL,
direccion VARCHAR(30) NOT NULL,
cargo VARCHAR(30) NOT NULL
);


CREATE TABLE Comida (
id INT PRIMARY KEY IDENTITY(1,1),
nombre VARCHAR (50) NOT NULL,
precio DECIMAL NOT NULL
);


CREATE TABLE DetalleFactura (
id INT PRIMARY KEY IDENTITY(1,1),
idCliente INT NOT NULL,
idEmpleado INT NOT NULL,
idComida INT NOT NULL,
idBebida INT NOT NULL,


 CONSTRAINT fk_DetalleFactura_Cliente FOREIGN KEY(idCliente) REFERENCES Cliente(id),
 CONSTRAINT fk_DetalleFactura_Empleado FOREIGN KEY(idEmpleado) REFERENCES Empleado(id),
 CONSTRAINT fk_DetalleFactura_Comida FOREIGN KEY(idComida) REFERENCES Comida(id),
 CONSTRAINT fk_DetalleFactura_Bebida FOREIGN KEY(idBebida) REFERENCES Bebida(id),

);


CREATE TABLE Bebida (
id INT PRIMARY KEY IDENTITY(1,1),
nombre VARCHAR (50) NOT NULL,
precio DECIMAL NOT NULL,
marca VARCHAR(50),
descripcion VARCHAR(100) NOT NULL
);

ALTER TABLE Usuario  ADD usuarioRegistro VARCHAR (20) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Usuario ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Usuario ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: eliminacion logica, 0: inactivo, 1: activo


ALTER TABLE Cliente  ADD usuarioRegistro VARCHAR (20) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Cliente ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Cliente ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: eliminacion logica, 0: inactivo, 1: activo

ALTER TABLE DetalleFactura  ADD usuarioRegistro VARCHAR (20) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE DetalleFactura ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE DetalleFactura ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: eliminacion logica, 0: inactivo, 1: activo

ALTER TABLE Empleado  ADD usuarioRegistro VARCHAR (20) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Empleado ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Empleado ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: eliminacion logica, 0: inactivo, 1: activo


ALTER TABLE Comida  ADD usuarioRegistro VARCHAR (20) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Comida ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Comida ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: eliminacion logica, 0: inactivo, 1: activo

ALTER TABLE Bebida  ADD usuarioRegistro VARCHAR (20) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Bebida ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Bebida ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: eliminacion logica, 0: inactivo, 1: activo

--USUARIO
CREATE PROC paUsuarioListar @parametro VARCHAR(50)
AS
  SELECT id,nombre,clave,idEmpleado,usuarioRegistro,fechaRegistro, estado
  FROM Usuario
  WHERE estado <> -1 AND nombre LIKE '%'+ REPLACE (@parametro,' ','%')+'%';


  SELECT *FROM Usuario

--CLIENTES
CREATE PROC paClienteListar @parametro Varchar(50)
AS
  SELECT id,nombre,primerApellido,segundoApellido,cedulaIdentidad
  FROM Cliente
  WHERE estado <> -1 AND nombre LIKE '%'+ REPLACE (@parametro,' ','%')+'%';

INSERT INTO Cliente(nombre,primerApellido,segundoApellido,cedulaIdentidad,Telefono)
VALUES ('Luis','Perez','Mendoza','14181556','47852136');
INSERT INTO Cliente(nombre,primerApellido,segundoApellido,cedulaIdentidad,Telefono)
VALUES ('Pablo','Padilla','Arandia ','14181556','47852136');
INSERT INTO Cliente(nombre,primerApellido,segundoApellido,cedulaIdentidad,Telefono)
VALUES ('Mariana','Velazco','Gutierrez','7895411','16457845');

SELECT *FROM Cliente 

-- PLATOS
CREATE PROC paComidaListar @parametro VARCHAR(50) 
AS
  SELECT id,nombre,precio,usuarioRegistro,fechaRegistro, estado 
  FROM Comida
  WHERE estado <> -1 AND nombre LIKE '%'+ REPLACE (@parametro,' ','%')+'%';


  INSERT INTO Comida(nombre,precio)
  VALUES ('Lasaña',45);

  SELECT *FROM Comida 

  --EMPLEADO
CREATE PROC paEmpleadoListar @parametro VARCHAR(50) 
AS
  SELECT id,nombre,primerApellido,segundoApellido,telefono,direccion,cargo,usuarioRegistro,fechaRegistro, estado 
  FROM Empleado
  WHERE estado <> -1 AND nombre LIKE '%'+ REPLACE (@parametro,' ','%')+'%';


  INSERT INTO Empleado(nombre,primerApellido,segundoApellido,telefono,direccion,cargo)
  VALUES ('Paola','Duran',' ',78963254,'avaroa 47','Gerente');

  INSERT INTO Empleado(nombre,primerApellido,segundoApellido,telefono,direccion,cargo)
  VALUES ('Micaela','Mamani',' ',7892547,'mendizabal 7','Cajero');


  SELECT *FROM Empleado



  --DETALLE FACTURA
  CREATE PROC paDetalleFacturaListar @parametro VARCHAR(50) 
AS
  SELECT id,idCliente,idEmpleado,idComida,idBebida,usuarioRegistro,fechaRegistro, estado 
  FROM detalleFactura
  WHERE estado <> -1 AND idCliente LIKE '%'+ REPLACE (@parametro,' ','%')+'%';




  SELECT *FROM DetalleFactura



--BEBIDA
CREATE PROC paBebidaListar @parametro VARCHAR(50)
AS
  SELECT id, nombre, precio, marca, descripcion, usuarioRegistro,fechaRegistro, estado 
  FROM Bebida
  WHERE estado <> -1 AND descripcion LIKE '%'+ REPLACE (@parametro,' ','%')+'%';



  SELECT *FROM Bebida 