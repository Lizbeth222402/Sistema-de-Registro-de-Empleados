USE Sistema_Empleados;
GO

-- TBL_PUESTOS

create or alter proc Sp_InsertarPuestos
(
@Nombre_puesto VARCHAR(100),
@Descripcion VARCHAR(100),
@Salario_base DECIMAL(10,2)
)
as
begin
  begin try
    begin tran
        insert into Puestos (Nombre_puesto, Descripcion, Salario_base)
        values (@Nombre_puesto, @Descripcion, @Salario_base)
    commit
    print 'Puesto ingresado correctamente'
  end try
  begin catch
    rollback
    print 'No se puede insertar el puesto por el error: ' + @@error
  end catch    
end
go



create or alter proc Sp_ListarPuestos
as
begin
    begin try
        select Id_puesto, Nombre_puesto, Descripcion, Salario_base
        from Puestos
    end try
    begin catch
        print 'No se pudo listar los puestos por el error: ' + @@error
    end catch
end
go



create or alter proc Sp_EditarPuestos
(
    @Id_puesto int,
    @Nombre_puesto VARCHAR(100),
    @Descripcion VARCHAR(100),
    @Salario_base DECIMAL(10,2)
)
as
begin
    begin try
        begin tran
            update Puestos
            set Nombre_puesto = @Nombre_puesto,
                Descripcion = @Descripcion,
                Salario_base = @Salario_base
            where Id_puesto = @Id_puesto
        commit
        print 'El puesto se editó correctamente'
    end try
    begin catch
        rollback
        print 'No se pudo editar el puesto por el error: ' + @@error
    end catch
end
go



create or alter proc Sp_EliminarPuesto
(
@Id_puesto int
)
as
begin
    begin try
        begin tran
            delete Puestos where Id_puesto = @Id_puesto
        commit
        print 'El puesto se eliminó correctamente'
    end try
    begin catch
        rollback
        print 'No se pudo eliminar el puesto por el error: ' + @@error
    end catch
end
go