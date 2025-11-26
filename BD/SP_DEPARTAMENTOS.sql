USE Sistema_Empleados;
GO

-- TBL_DEPARTAMENTOS

create or alter proc Sp_InsertarDepartamentos
(
@Nombre VARCHAR(50),
@Descripcion VARCHAR(100)
)
as
begin
  begin try
    begin tran
        insert into Departamentos(Nombre, Descripcion) values(@Nombre,@Descripcion)
    commit
    print 'Departamento ingresado corrextamente'
  end try
begin catch
    rollback
    print 'no se puede insertar por el error: ' + @@error
end catch    
end
go


exec Sp_InsertarDepartamentos 'Soporte tecnico', 'Departamento encargado de darle soporte a los equipos'
go



create or alter proc Sp_ListarDepartamentos 
as
begin
    begin try
    select Depar.Id_departamento, Depar.Nombre , Depar.Descripcion from Departamentos as Depar
    end try
    begin catch
            print 'no se pudo listar por el error : ' + @@error
    end catch
end
go


exec [dbo].[Sp_ListarDepartamentos]
go



create or alter proc Sp_EditarDepartamentos
(
@Id_departamento int,
@Nombre VARCHAR(50),
@Descripcion VARCHAR(100)
)
as
begin
    begin try
        begin tran
        update Departamentos 
        set Nombre = @Nombre,
            Descripcion = @Descripcion
            where Id_departamento = @Id_departamento
        commit
        print 'El departamento se edito correctamente'
    end try
    begin catch
    rollback
    print 'no se pudo editar departamentos por el error: ' + @@error
    end catch
end
go

exec Sp_EditarDepartamentos 1,'Recursos humanos','Encargado de todas las gestiones del personal'
go



create or alter proc Sp_EliminarDepartamento
(
@id int
)
as
begin
    begin try
    begin tran
    delete Departamentos where Id_departamento = @id
    commit
    print 'El departamento se elimino correctamente'
    end try
    begin catch
    rollback
    print 'No se pudo eliminar el departamento por el error: ' + @@error
    end catch
end
go


exec Sp_EliminarDepartamento 1007
go
