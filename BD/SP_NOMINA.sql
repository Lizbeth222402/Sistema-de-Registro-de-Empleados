USE Sistema_Empleados;
GO

CREATE OR ALTER PROC SP_LISTAR_NOMINAS
AS
BEGIN
    BEGIN TRY
        SELECT Id_empleado, Fecha_pago , Salario_bruto , Deducciones, Salario_neto
        FROM Nominas as PROV
    END TRY
    BEGIN CATCH
        PRINT 'NO SE LISTO NOMINAS ,VERIFICA EL ERROR: ' + @@error
    END CATCH
END
GO

--------INSERTAR-------

CREATE OR ALTER PROC SP_INSERTAR_NOMINAS
(
	@Id_empleado INT,
    @Fecha_pago DATE ,
    @Salario_bruto DECIMAL(10,2),
    @Deducciones DECIMAL(10,2),
    @Salario_neto DECIMAL(10,2)
)
AS
BEGIN
  BEGIN TRY
    BEGIN TRAN
        INSERT INTO Nominas
        (Id_empleado ,Fecha_pago , Salario_bruto , Deducciones , Salario_neto) VALUES
        (@Id_empleado , @Fecha_pago , @Salario_bruto , @Deducciones , @Salario_neto)
    COMMIT
    PRINT 'NOMINA INSERTADA CORRECTAMENTE'
  END TRY
  BEGIN CATCH
    ROLLBACK
    PRINT 'NO SE INSERTO LA NOMINA POR EL ERROR, VERIFICA: ' + CAST(ERROR_NUMBER() AS VARCHAR)
  END CATCH    
END
GO

EXEC SP_INSERTAR_NOMINAS
    @Id_empleado = 1,
    @Fecha_pago = '2025-10-31',
    @Salario_bruto = 1200.00,
    @Deducciones = 150.00,
    @Salario_neto = 1050.00;


-------------EDITAR-----------------

CREATE OR ALTER PROC SP_EDITAR_NOMINAS
(
	@Id_nomina INT,
	@Id_empleado INT,
    @Fecha_pago DATE ,
    @Salario_bruto DECIMAL(10,2),
    @Deducciones DECIMAL(10,2),
    @Salario_neto DECIMAL(10,2)
)

AS
BEGIN
    BEGIN TRY
        BEGIN TRAN
        update Nominas 
        SET Id_empleado = @Id_empleado,
            Fecha_pago = @Fecha_pago,
			Salario_bruto = @Salario_bruto,
			Deducciones = @Deducciones,
			Salario_neto = @Salario_neto
			
            WHERE Id_nomina = @Id_nomina
        COMMIT
        PRINT 'LA AUSENCIA SE EDITO CORRECTAMENTE'
    END TRY
    BEGIN CATCH
    ROLLBACK
    PRINT 'NO SE EDITO AUSENCIA POR EL ERROR:' + @@ERROR
    END CATCH
END
GO

EXEC SP_EDITAR_NOMINAS
    @Id_nomina = 1,
    @Id_empleado = 1,
    @Fecha_pago = '2025-10-31',
    @Salario_bruto = 1250.00,
    @Deducciones = 180.00,
    @Salario_neto = 1070.00;


--------ELIMINAR-----------------

CREATE OR ALTER PROC SP_ELIMINAR_NOMINAS

(
@Id_nomina INT
)
AS
BEGIN
    BEGIN TRY
    BEGIN TRAN
    DELETE Nominas WHERE Id_nomina = @Id_nomina
    COMMIT
    PRINT 'SE ELIMINO CORRECTAMENTE LA NOMINA'
    END TRY
    BEGIN CATCH
    ROLLBACK
    PRINT 'NO SE ELIMINO LA NOMINA POR EL ERROR:' + @@ERROR
    END CATCH
END
GO

EXEC SP_ELIMINAR_NOMINAS
    @Id_nomina = 2;
