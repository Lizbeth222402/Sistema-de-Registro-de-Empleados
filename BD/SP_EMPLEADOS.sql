USE Sistema_Empleados;
GO

-- TBL_EMPLEADOS

create or alter proc Sp_InsertarEmpleados
(
    @Nombres VARCHAR(50),
    @Apellidos VARCHAR(50),
    @Fecha_nacimiento DATE,
    @Direccion VARCHAR(100),
    @Telefono VARCHAR(20),
    @Email VARCHAR(100),
    @Fecha_ingreso DATE,
    @Id_departamento INT,
    @Id_puesto INT
)
as
begin
  begin try
    begin tran
        insert into Empleados 
        (Nombres, Apellidos, Fecha_nacimiento, Direccion, Telefono, Email, Fecha_ingreso, Id_departamento, Id_puesto)
        values 
        (@Nombres, @Apellidos, @Fecha_nacimiento, @Direccion, @Telefono, @Email, @Fecha_ingreso, @Id_departamento, @Id_puesto)
    commit
    print 'Empleado ingresado correctamente'
  end try
  begin catch
    rollback
    print 'No se puede insertar el empleado por el error: ' + @@error
  end catch    
end
go



create or alter proc Sp_ListarEmpleados
as
begin
    begin try
        select 
            e.Id_empleado,
            e.Nombres,
            e.Apellidos,
            e.Fecha_nacimiento,
            e.Direccion,
            e.Telefono,
            e.Email,
            e.Fecha_ingreso,
            d.Nombre as Departamento,
            p.Nombre_puesto as Puesto
        from Empleados e
        inner join Departamentos d on e.Id_departamento = d.Id_departamento
        inner join Puestos p on e.Id_puesto = p.Id_puesto
    end try
    begin catch
        print 'No se pudo listar los empleados por el error: ' + @@error
    end catch
end
go



create or alter proc Sp_EditarEmpleados
(
    @Id_empleado int,
    @Nombres VARCHAR(50),
    @Apellidos VARCHAR(50),
    @Fecha_nacimiento DATE,
    @Direccion VARCHAR(100),
    @Telefono VARCHAR(20),
    @Email VARCHAR(100),
    @Fecha_ingreso DATE,
    @Id_departamento INT,
    @Id_puesto INT
)
as
begin
    begin try
        begin tran
            update Empleados
            set Nombres = @Nombres,
                Apellidos = @Apellidos,
                Fecha_nacimiento = @Fecha_nacimiento,
                Direccion = @Direccion,
                Telefono = @Telefono,
                Email = @Email,
                Fecha_ingreso = @Fecha_ingreso,
                Id_departamento = @Id_departamento,
                Id_puesto = @Id_puesto
            where Id_empleado = @Id_empleado
        commit
        print 'El empleado se editó correctamente'
    end try
    begin catch
        rollback
        print 'No se pudo editar el empleado por el error: ' + @@error
    end catch
end
go



create or alter proc Sp_EliminarEmpleado
(
    @Id_empleado int
)
as
begin
    begin try
        begin tran
            delete Empleados where Id_empleado = @Id_empleado
        commit
        print 'El empleado se eliminó correctamente'
    end try
    begin catch
        rollback
        print 'No se pudo eliminar el empleado por el error: ' + @@error
    end catch
end
go