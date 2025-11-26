CREATE DATABASE Sistema_Empleados;
GO

USE Sistema_Empleados;
GO

CREATE TABLE Departamentos /*listo LISTADO..*/
(
    Id_departamento INT PRIMARY KEY IDENTITY (1,1),
    Nombre VARCHAR(50),
    Descripcion VARCHAR(100)
);
GO

CREATE TABLE Puestos /*listo LISTADO..*/
(
    Id_puesto INT PRIMARY KEY IDENTITY (1,1),
    Nombre_puesto VARCHAR(100),
    Descripcion VARCHAR(100),
    Salario_base DECIMAL(10,2) 
);
GO

CREATE TABLE Empleados /*listo LISTADO..*/
(
    Id_empleado INT PRIMARY KEY IDENTITY (1,1),
    Nombres VARCHAR(50),
    Apellidos VARCHAR(50),
    Fecha_nacimiento DATE,
    Direccion VARCHAR(100),
    Telefono VARCHAR(20),
    Email VARCHAR(100),
    Fecha_ingreso DATE,
    Id_departamento INT,
    Id_puesto INT,
    FOREIGN KEY (Id_departamento) REFERENCES Departamentos(Id_departamento),
    FOREIGN KEY (Id_puesto) REFERENCES Puestos(Id_puesto)
);
GO

SELECT * FROM Empleados

CREATE TABLE Contratos  /*listo LISTADO..*/
(
    Id_contrato INT PRIMARY KEY IDENTITY (1,1),
    Id_empleado INT ,
    Tipo_contrato VARCHAR(50),
    Fecha_inicio DATE,
    Fecha_fin DATE,
    Salario DECIMAL(10,2),
    FOREIGN KEY (Id_empleado) REFERENCES Empleados(Id_empleado)
);
GO

CREATE TABLE Asistencias /*listo LISTADO..*/
(
    Id_asistencia INT PRIMARY KEY IDENTITY (1,1),
    Id_empleado INT NOT NULL,
    Fecha DATE NOT NULL,
    Hora_entrada TIME,
    Hora_salida TIME,
    Estado VARCHAR(50),
    FOREIGN KEY (Id_empleado) REFERENCES Empleados(Id_empleado)
);
GO

CREATE TABLE Ausencias /*listo LISTADO..*/
(
    Id_ausencia INT PRIMARY KEY IDENTITY (1,1),
    Id_empleado INT ,
    Tipo_ausencia VARCHAR(50),
    Fecha_inicio DATE,
    Fecha_fin DATE,
    Motivo VARCHAR(100),
    FOREIGN KEY (Id_empleado) REFERENCES Empleados(Id_empleado)
);
GO

CREATE TABLE Nominas  /*listo LISTADO..*/
(
    Id_nomina INT PRIMARY KEY IDENTITY (1,1),
    Id_empleado INT ,
    Fecha_pago DATE ,
    Salario_bruto DECIMAL(10,2),
    Deducciones DECIMAL(10,2),
    Salario_neto DECIMAL(10,2),
    FOREIGN KEY (Id_empleado) REFERENCES Empleados(Id_empleado)
);
GO

----EN LA DOCUMENTACION SE ESPECIFICA QUE NADA MAS EL DE RRHH TENDRA ACCESO AL SISTEMA DE REGISTRO--------

CREATE TABLE TBL_USUARIOS  /*listo LISTADO..*/
(
	ID_USUARIO INT PRIMARY KEY IDENTITY (1,1),
	NOMBRE_USUARIO VARCHAR (100) NOT NULL,
	CONTRASEÑA VARCHAR (100) NOT NULL,
	ACTIVO BIT NOT NULL
);

SELECT * FROM TBL_USUARIOS