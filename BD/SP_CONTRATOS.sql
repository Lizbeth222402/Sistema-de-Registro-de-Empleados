USE Sistema_Empleados;
GO

-- TBL_CONTRATOS

create or alter proc Sp_InsertarContratos
(
    @Id_empleado INT,
    @Tipo_contrato VARCHAR(50),
    @Fecha_inicio DATE,
    @Fecha_fin DATE,
    @Salario DECIMAL(10,2)
)
as
begin
  begin try
    begin tran
        insert into Contratos (Id_empleado, Tipo_contrato, Fecha_inicio, Fecha_fin, Salario)
        values (@Id_empleado, @Tipo_contrato, @Fecha_inicio, @Fecha_fin, @Salario)
    commit
    print 'Contrato ingresado correctamente'
  end try
  begin catch
    rollback
    print 'No se puede insertar el contrato por el error: ' + @@error
  end catch    
end
go



create or alter proc Sp_ListarContratos
as
begin
    begin try
        select 
            c.Id_contrato,
            c.Id_empleado,
            e.Nombres + ' ' + e.Apellidos as Empleado,
            c.Tipo_contrato,
            c.Fecha_inicio,
            c.Fecha_fin,
            c.Salario
        from Contratos c
        inner join Empleados e on c.Id_empleado = e.Id_empleado
    end try
    begin catch
        print 'No se pudo listar los contratos por el error: ' + @@error
    end catch
end
go



create or alter proc Sp_EditarContratos
(
    @Id_contrato int,
    @Id_empleado INT,
    @Tipo_contrato VARCHAR(50),
    @Fecha_inicio DATE,
    @Fecha_fin DATE,
    @Salario DECIMAL(10,2)
)
as
begin
    begin try
        begin tran
            update Contratos
            set Id_empleado = @Id_empleado,
                Tipo_contrato = @Tipo_contrato,
                Fecha_inicio = @Fecha_inicio,
                Fecha_fin = @Fecha_fin,
                Salario = @Salario
            where Id_contrato = @Id_contrato
        commit
        print 'El contrato se editó correctamente'
    end try
    begin catch
        rollback
        print 'No se pudo editar el contrato por el error: ' + @@error
    end catch
end
go



create or alter proc Sp_EliminarContrato
(
    @Id_contrato int
)
as
begin
    begin try
        begin tran
            delete Contratos where Id_contrato = @Id_contrato
        commit
        print 'El contrato se eliminó correctamente'
    end try
    begin catch
        rollback
        print 'No se pudo eliminar el contrato por el error: ' + @@error
    end catch
end
go

