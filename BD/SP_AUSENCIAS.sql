USE Sistema_Empleados;
GO

-------LISTAR-------
CREATE OR ALTER PROC SP_LISTAR_AUSENCIAS
AS
BEGIN
    BEGIN TRY
        SELECT Id_empleado, Tipo_ausencia , Fecha_inicio , Fecha_fin, Motivo
        FROM Ausencias as PROV
    END TRY
    BEGIN CATCH
        PRINT 'NO SE LISTO LAS AUSENCIAS , VERIFICA EL ERROR: ' + @@error
    END CATCH
END
GO

-----------------INSERTAR----------------
CREATE OR ALTER PROC SP_INSERTAR_AUSENCIAS
(
	@Id_empleado INT,
    @Tipo_ausencia VARCHAR(50),
    @Fecha_inicio DATE,
    @Fecha_fin DATE,
    @Motivo VARCHAR(100)
)
AS
BEGIN
  BEGIN TRY
    BEGIN TRAN
        INSERT INTO Ausencias
        (Id_empleado ,Tipo_ausencia , Fecha_inicio , Fecha_fin, Motivo) VALUES
        (@Id_empleado , @Tipo_ausencia , @Fecha_inicio, @Fecha_fin, @Motivo)
    COMMIT
    PRINT 'AUSENCIAS INSERTADA CORRECTAMENTE'
  END TRY
  BEGIN CATCH
    ROLLBACK
    PRINT 'NO SE INSERTO POR EL ERROR, VERIFICA: ' + CAST(ERROR_NUMBER() AS VARCHAR)
  END CATCH    
END
GO

EXEC SP_INSERTAR_AUSENCIAS
    @Id_empleado = 1,
    @Tipo_ausencia = 'Incapacidad médica',
    @Fecha_inicio = '2025-10-20',
    @Fecha_fin = '2025-10-25',
    @Motivo = 'Reposo por recomendación médica';


-------------EDITAR-----------------

CREATE OR ALTER PROC SP_EDITAR_AUSENCIAS

(
	@Id_ausencia INT ,
   	@Id_empleado INT,
    @Tipo_ausencia VARCHAR(50),
    @Fecha_inicio DATE,
    @Fecha_fin DATE,
    @Motivo VARCHAR(100)
)

AS
BEGIN
    BEGIN TRY
        BEGIN TRAN
        update Ausencias 
        SET Id_empleado = @Id_empleado,
            Tipo_ausencia = @Tipo_ausencia,
			Fecha_inicio = @Fecha_inicio,
			Fecha_Fin = @Fecha_fin,
			Motivo = @Motivo
			
            WHERE Id_ausencia = @Id_ausencia
        COMMIT
        PRINT 'LA AUSENCIA SE EDITO CORRECTAMENTE'
    END TRY
    BEGIN CATCH
    ROLLBACK
    PRINT 'NO SE EDITO AUSENCIA POR EL ERROR:' + @@ERROR
    END CATCH
END
GO

EXEC SP_EDITAR_AUSENCIAS
    @Id_ausencia = 2,
    @Id_empleado = 3,
    @Tipo_ausencia = 'Incapacidad médica',
    @Fecha_inicio = '2025-10-15',
    @Fecha_fin = '2025-10-22',
    @Motivo = 'Reposo médico por cirugía menor';


--------ELIMINAR-----------------

CREATE OR ALTER PROC SP_ELIMINAR_AUSENCIAS

(
@Id_ausencia INT
)
AS
BEGIN
    BEGIN TRY
    BEGIN TRAN
    DELETE Ausencias WHERE Id_ausencia = @Id_ausencia
    COMMIT
    PRINT 'SE ELIMINO CORRECTAMENTE LA AUSENCIA'
    END TRY
    BEGIN CATCH
    ROLLBACK
    PRINT 'NO SE ELIMINO LA AUSENCIA POR EL ERROR:' + @@ERROR
    END CATCH
END
GO

EXEC SP_ELIMINAR_AUSENCIAS
    @Id_ausencia = 1;
