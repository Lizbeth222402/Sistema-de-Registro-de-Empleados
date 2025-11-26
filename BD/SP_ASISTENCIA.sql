USE Sistema_Empleados;
GO

-------LISTAR-------
CREATE OR ALTER PROC SP_LISTAR_ASISTENCIAS
AS
BEGIN
    BEGIN TRY
        SELECT Id_empleado, Fecha , Hora_entrada , Hora_salida, Estado
        FROM Asistencias as PROV
    END TRY
    BEGIN CATCH
        PRINT 'NO SE LISTO LAS ASISTENCIAS , VERIFICA EL ERROR: ' + @@error
    END CATCH
END
GO


-----------------INSERTAR----------------
CREATE OR ALTER PROC SP_INSERTAR_ASISTENCIAS
(
    @Id_empleado INT ,
    @Fecha DATE ,
    @Hora_entrada TIME,
    @Hora_salida TIME,
    @Estado VARCHAR (50)
)
AS
BEGIN
  BEGIN TRY
    BEGIN TRAN
        INSERT INTO Asistencias
        (Id_empleado ,Fecha , Hora_entrada , Hora_salida, Estado ) VALUES
        (@Id_empleado , @Fecha , @Hora_entrada , @Hora_salida, @Estado)
    COMMIT
    PRINT 'Asistencia INSERTADA CORRECTAMENTE'
  END TRY
  BEGIN CATCH
    ROLLBACK
    
    PRINT 'NO SE INSERTO POR EL ERROR, VERIFICA: ' + CAST(ERROR_NUMBER() AS VARCHAR)
  END CATCH    
END
GO

SELECT * FROM Asistencias

EXEC SP_INSERTAR_ASISTENCIAS
    @Id_empleado = 1,             
    @Fecha = '2025-10-17',
    @Hora_entrada = '08:00:00',
    @Hora_salida = '17:00:00',
    @Estado = 'Presente';

-------------EDITAR---------------

CREATE OR ALTER PROC SP_EDITAR_ASISTENCIAS

(
	@Id_asistencia INT ,
    @Id_empleado INT ,
    @Fecha DATE ,
    @Hora_entrada TIME,
    @Hora_salida TIME,
    @Estado VARCHAR(50)
)

AS
BEGIN
    BEGIN TRY
        BEGIN TRAN
        update Asistencias 
        SET Id_empleado = @Id_empleado,
            Fecha = @Fecha,
			Hora_entrada = @Hora_entrada,
			Hora_salida = @Hora_salida,
			Estado = @Estado
            WHERE Id_asistencia = @Id_asistencia
        COMMIT
        PRINT 'LA ASISTENCIAS SE EDITO CORRECTAMENTE'
    END TRY
    BEGIN CATCH
    ROLLBACK
    PRINT 'NO SE EDITO ASISTENCIA POR EL ERROR:' + @@ERROR
    END CATCH
END
GO

EXEC SP_EDITAR_ASISTENCIAS '10', '6', '2025-10-17', '08:30:00', '17:30:00', 'Modificado';  


CREATE OR ALTER PROC SP_ELIMINAR_ASISTENCIAS

(
@Id_asistencias INT
)
AS
BEGIN
    BEGIN TRY
    BEGIN TRAN
    DELETE Asistencias WHERE Id_asistencia = @Id_asistencias
    COMMIT
    PRINT 'LA ASISTENCIA SE ELIMINE CORRECTAMENTE'
    END TRY
    BEGIN CATCH
    ROLLBACK
    PRINT 'NO SE ELIMINO LA ASISTENCIA POR EL ERROR:' + @@ERROR
    END CATCH
END
GO

EXEC SP_ELIMINAR_ASISTENCIAS
    @Id_asistencias = 1;
