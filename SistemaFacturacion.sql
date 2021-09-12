	CREATE DATABASE SistemaFacturacionInventario
	GO

	USE SistemaFacturacionInventario
	Go

------------------------------------------------------------- Tablas ----------------------------------------------------------------------
	CREATE TABLE Usuario(
			idUsuario		INT IDENTITY(1,1) PRIMARY KEY	NOT NULL,
			cedula			VARCHAR(50)						NOT NULL,
			nombre			VARCHAR(50)						NOT NULL,
			apellidos		VARCHAR(50)						NOT NULL,
			correo			VARCHAR(50)						NOT NULL,
			contraseña		VARCHAR(50)						NOT NULL,
			usuario			VARCHAR(50)						NOT NULL
	)

	CREATE TABLE Cliente(
			idCliente		INT IDENTITY(1,1) PRIMARY KEY	NOT NULL,
			cedula			VARCHAR(50)						NOT NULL,
			nombre			VARCHAR(50)						NOT NULL,
			apellidos		VARCHAR(50)						NOT NULL,
			telefono		VARCHAR(50)						NOT NULL,
			correo			VARCHAR(50)						NOT NULL
	)

	CREATE TABLE Marcas(
			idMarca			INT IDENTITY(1,1) PRIMARY KEY	NOT NULL,
			nombre			VARCHAR(50)						NOT NULL,
			descripcion		VARCHAR(50)						NOT NULL
	)

	CREATE TABLE Categorias(
			idCategoria		INT IDENTITY(1,1) PRIMARY KEY	NOT NULL,
			nombre			VARCHAR(50)						NOT NULL,
			descripcion		VARCHAR(50)						NOT NULL
	)	

	CREATE TABLE Articulos(
			idArticulo		INT IDENTITY(1,1) PRIMARY KEY	NOT NULL,
			precioUnitario	MONEY							NOT NULL,
			descripcion		VARCHAR(50)						NOT NULL,
			producto		VARCHAR(50)						NOT NULL,
			idMarca			INT			NOT NULL	FOREIGN KEY (idMarca) REFERENCES dbo.Marcas(idMarca),
			idCategoria     INT        	NOT NULL	FOREIGN KEY(idCategoria) REFERENCES dbo.Categorias(idCategoria)
	)

	CREATE TABLE Factura(
			idFactura		INT IDENTITY(1,1) PRIMARY KEY	NOT NULL,
			fecha			DATE							NOT NULL,
			cantidad		INT								NOT NULL,
			idCliente		INT    NOT NULL			FOREIGN KEY (idCliente) REFERENCES dbo.Cliente(idCliente),
			idArticulo		INT    NOT NULL 		FOREIGN KEY (idArticulo)REFERENCES dbo.Articulos(idArticulo),
			total			MONEY  NOT NULL
	)

	INSERT Usuario (cedula,nombre,apellidos,correo,contraseña, usuario) VALUES ('111111111','Usuario Administrador','Admin Admin','Admin@gmail.com','admin', 'admin')
	INSERT Usuario (cedula,nombre,apellidos,correo,contraseña, usuario) VALUES ('305020911', 'Keylor','Calvo Marin','KeylorCM@gmail.com','654321','Keylor_CM2020')
	INSERT Usuario (cedula,nombre,apellidos,correo,contraseña, usuario) VALUES ('304970773', 'Anthony', 'Rojas Calderon','anthomy773@gmail.com', '03333', 'Anthony_RC')

	INSERT Marcas (nombre,descripcion) VALUES ('Sardimar','Atunes en diferentes presentaciones')
	INSERT Marcas (nombre,descripcion) VALUES ('Tio Pelon','Arroz 100% Grano Entero')
	INSERT Marcas (nombre,descripcion) VALUES ('Gallito','Golosinas')
	
	INSERT Categorias (nombre,descripcion) VALUES ('Consumo básico', 'Son indispensables')
	INSERT Categorias (nombre,descripcion) VALUES ('Urgencia', 'Medicamentos o productos de limpieza')

	INSERT Cliente (cedula,nombre,apellidos,telefono,correo) VALUES ('702350815', 'Natalia','Reyes Reyes','72025858','NataliaCR@gmail.com')
	INSERT Cliente (cedula,nombre,apellidos,telefono,correo) VALUES ('602340022', 'Francisco','Mejia Marin','77025858','FranQM@gmail.com')
	INSERT Cliente (cedula,nombre,apellidos,telefono,correo) VALUES ('402550888', 'Jimena','Corrales Chavez','72021212','jimena@gmail.com')

	INSERT Articulos (precioUnitario,descripcion,producto,idMarca,idCategoria) VALUES ('1000','Atun Vegetales','Atun',1,1)
	INSERT Articulos (precioUnitario,descripcion,producto,idMarca,idCategoria) VALUES ('200','Arroz Balnco','Arroz',3,1)