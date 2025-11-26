USE Sistema_Empleados;
GO

INSERT INTO Departamentos (Nombre, Descripcion) VALUES
('Recursos Humanos', 'Encargado de la gestión del personal'),
('Finanzas', 'Departamento encargado de la contabilidad y presupuestos'),
('Tecnología', 'Departamento de soporte técnico y desarrollo de sistemas'),
('Ventas', 'Área encargada de la comercialización de productos'),
('Logística', 'Gestión del transporte y almacenamiento');
GO




INSERT INTO Puestos (Nombre_puesto, Descripcion, Salario_base) VALUES
('Gerente de RRHH', 'Responsable del área de Recursos Humanos', 1500.00),
('Contador General', 'Encargado de las finanzas y reportes contables', 1200.00),
('Desarrollador de Software', 'Diseño y programación de sistemas', 1000.00),
('Ejecutivo de Ventas', 'Atiende a clientes y gestiona ventas', 900.00),
('Chofer de Reparto', 'Encargado de entregas y transporte', 800.00);
GO


INSERT INTO Empleados (Nombres, Apellidos, Fecha_nacimiento, Direccion, Telefono, Email, Fecha_ingreso, Id_departamento, Id_puesto) VALUES
('Carlos', 'Martínez', '1985-04-10', 'Av. Central 123', '8888-1234', 'cmartinez@empresa.com', '2020-01-15', 1, 1),
('Ana', 'López', '1990-07-25', 'Colonia Esperanza #45', '8888-5678', 'alopez@empresa.com', '2021-03-10', 2, 2),
('Josué', 'Mairena', '1998-11-30', 'Barrio Universitario', '8888-4321', 'jmairena@empresa.com', '2022-06-05', 3, 3),
('María', 'Gómez', '1992-08-12', 'Reparto Los Laureles', '8888-8765', 'mgomez@empresa.com', '2023-02-01', 4, 4),
('Luis', 'Pérez', '1988-12-03', 'Km 8 Carretera Norte', '8888-6543', 'lperez@empresa.com', '2019-09-20', 5, 5);
GO


INSERT INTO Contratos (Id_empleado, Tipo_contrato, Fecha_inicio, Fecha_fin, Salario) VALUES
(1, 'Indefinido', '2020-01-15', '2040-01-15', 1500.00),
(2, 'Indefinido', '2021-03-10', '2040-03-10', 1200.00),
(3, 'Por proyecto', '2022-06-05', '2025-06-05', 1000.00),
(4, 'Temporal', '2023-02-01', '2025-02-01', 900.00),
(5, 'Indefinido', '2019-09-20', '2040-09-20', 800.00);
GO


INSERT INTO Asistencias (Id_empleado, Fecha, Hora_entrada, Hora_salida, Estado) VALUES
(1, '2025-10-17', '08:00', '17:00', 'Presente'),
(2, '2025-10-17', '08:10', '17:05', 'Presente'),
(3, '2025-10-17', '08:05', '17:10', 'Presente'),
(4, '2025-10-17', '00:00', '00:00', 'Ausente'),
(5, '2025-10-17', '07:50', '16:30', 'Presente'); 
GO

Select * from Asistencias

INSERT INTO Ausencias (Id_empleado, Tipo_ausencia, Fecha_inicio, Fecha_fin, Motivo) VALUES
(4, 'Permiso médico', '2025-10-17', '2025-10-18', 'Gripe'),
(2, 'Vacaciones', '2025-09-01', '2025-09-15', 'Descanso anual');
GO


INSERT INTO Nominas (Id_empleado, Fecha_pago, Salario_bruto, Deducciones, Salario_neto) VALUES
(1, '2025-10-15', 1500.00, 150.00, 1350.00),
(2, '2025-10-15', 1200.00, 120.00, 1080.00),
(3, '2025-10-15', 1000.00, 100.00, 900.00),
(4, '2025-10-15', 900.00, 90.00, 810.00),
(5, '2025-10-15', 800.00, 80.00, 720.00);
GO


INSERT INTO TBL_USUARIOS (NOMBRE_USUARIO , CONTRASEÑA , ACTIVO)
VALUES
('NP', '7887' , 1),
('JG', '5648' , 0);


SELECT * FROM  TBL_USUARIOS