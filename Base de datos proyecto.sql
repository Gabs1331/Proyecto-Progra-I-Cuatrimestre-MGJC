
-- Usar la base de datos creada
USE SistemaReparaciones;
GO

CREATE TABLE Iniciosesion (
    UsuarioID INT PRIMARY KEY,
    Contraseña VARCHAR(100)
);
-- Tabla Usuarios
CREATE TABLE Usuarios (
    UsuarioID INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100),
    CorreoElectronico VARCHAR(100),
    Telefono VARCHAR(20)
);

-- Tabla Equipos
CREATE TABLE Equipos (
    EquipoID INT PRIMARY KEY IDENTITY(1,1),
    TipoEquipo VARCHAR(50),
    Modelo VARCHAR(50),
    UsuarioID INT,
    FOREIGN KEY (UsuarioID) REFERENCES Usuarios(UsuarioID)
);

-- Tabla Reparaciones
CREATE TABLE Reparaciones (
    ReparacionID INT PRIMARY KEY IDENTITY(1,1),
    EquipoID INT,
    FechaSolicitud DATETIME,
    Estado VARCHAR(50),
    FOREIGN KEY (EquipoID) REFERENCES Equipos(EquipoID)
);

-- Tabla DetallesReparacion
CREATE TABLE DetallesReparacion (
    DetalleID INT PRIMARY KEY IDENTITY(1,1),
    ReparacionID INT,
    Descripcion VARCHAR(255),
    FechaInicio DATETIME,
    FechaFin DATETIME,
    FOREIGN KEY (ReparacionID) REFERENCES Reparaciones(ReparacionID)
);

-- Tabla Tecnicos
CREATE TABLE Tecnicos (
    TecnicoID INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100),
    Especialidad VARCHAR(100)
);

-- Tabla Asignaciones
CREATE TABLE Asignaciones (
    AsignacionID INT PRIMARY KEY IDENTITY(1,1),
    ReparacionID INT,
    TecnicoID INT,
    FechaAsignacion DATETIME,
    FOREIGN KEY (ReparacionID) REFERENCES Reparaciones(ReparacionID),
    FOREIGN KEY (TecnicoID) REFERENCES Tecnicos(TecnicoID)
);
GO

INSERT INTO Iniciosesion (UsuarioID, Contraseña)
VALUES (1, 'admin123'); -- UsuarioID: 1, Contraseña: admin123
GO
-- Procedimiento para insertar un nuevo usuario
CREATE PROCEDURE InsertarLogin
    @UsuarioID VARCHAR(50),
    @Contraseña VARCHAR(100)
AS
BEGIN
    INSERT INTO Iniciosesion (UsuarioID, Contraseña)
    VALUES (@UsuarioID, @Contraseña);
END;
GO

-- Procedimiento para consultar todos los logins
CREATE PROCEDURE ConsultarLogins
AS
BEGIN
    SELECT * FROM Iniciosesion;
END;
GO

-- Procedimiento para actualizar contraseña de un usuario
CREATE PROCEDURE ActualizarLogin
    @UsuarioID VARCHAR(50),
    @Contraseña VARCHAR(100)
AS
BEGIN
    UPDATE Iniciosesion
    SET Contraseña = @Contraseña
    WHERE UsuarioID = @UsuarioID;
END;
GO

-- Procedimiento para eliminar un usuario por su UsuarioID
CREATE PROCEDURE EliminarLogin
    @UsuarioID VARCHAR(50)
AS
BEGIN
    DELETE FROM Iniciosesion
    WHERE UsuarioID = @UsuarioID;
END;
GO

-- Procedimiento para validar usuario y contraseña
CREATE PROCEDURE ValidarLogin
    @UsuarioID VARCHAR(50),
    @Contraseña VARCHAR(100)
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM Iniciosesion
        WHERE UsuarioID = @UsuarioID
          AND Contraseña = @Contraseña
    )
        SELECT 'Acceso Concedido' AS Resultado;
    ELSE
        SELECT 'Acceso Denegado' AS Resultado;
END;

GO
-- Insertar usuario
CREATE PROCEDURE InsertarUsuario
    @Nombre VARCHAR(100),
    @CorreoElectronico VARCHAR(100),
    @Telefono VARCHAR(20)
AS
BEGIN
    INSERT INTO Usuarios (Nombre, CorreoElectronico, Telefono)
    VALUES (@Nombre, @CorreoElectronico, @Telefono)
END
GO
-- Consultar usuarios
CREATE PROCEDURE ConsultarUsuarios
AS
BEGIN
    SELECT * FROM Usuarios
END
GO
-- Actualizar usuario
CREATE PROCEDURE ActualizarUsuario
    @UsuarioID INT,
    @Nombre VARCHAR(100),
    @CorreoElectronico VARCHAR(100),
    @Telefono VARCHAR(20)
AS
BEGIN
    UPDATE Usuarios
    SET Nombre = @Nombre,
        CorreoElectronico = @CorreoElectronico,
        Telefono = @Telefono
    WHERE UsuarioID = @UsuarioID
END
GO
-- Eliminar usuario
CREATE PROCEDURE EliminarUsuario
    @UsuarioID INT
AS
BEGIN
    DELETE FROM Usuarios WHERE UsuarioID = @UsuarioID
END
GO

-- Insertar equipo
CREATE PROCEDURE InsertarEquipo
    @TipoEquipo VARCHAR(50),
    @Modelo VARCHAR(50),
    @UsuarioID INT
AS
BEGIN
    INSERT INTO Equipos (TipoEquipo, Modelo, UsuarioID)
    VALUES (@TipoEquipo, @Modelo, @UsuarioID)
END
GO
-- Consultar equipos
CREATE PROCEDURE ConsultarEquipos
AS
BEGIN
    SELECT * FROM Equipos
END
GO
-- Actualizar equipo
CREATE PROCEDURE ActualizarEquipo
    @EquipoID INT,
    @TipoEquipo VARCHAR(50),
    @Modelo VARCHAR(50),
    @UsuarioID INT
AS
BEGIN
    UPDATE Equipos
    SET TipoEquipo = @TipoEquipo,
        Modelo = @Modelo,
        UsuarioID = @UsuarioID
    WHERE EquipoID = @EquipoID
END
GO

-- Eliminar equipo
CREATE PROCEDURE EliminarEquipo
    @EquipoID INT
AS
BEGIN
    DELETE FROM Equipos WHERE EquipoID = @EquipoID
END
GO

-- Insertar reparación
CREATE PROCEDURE InsertarReparacion
    @EquipoID INT,
    @FechaSolicitud DATETIME,
    @Estado VARCHAR(50)
AS
BEGIN
    INSERT INTO Reparaciones (EquipoID, FechaSolicitud, Estado)
    VALUES (@EquipoID, @FechaSolicitud, @Estado)
END
GO

-- Consultar reparaciones
CREATE PROCEDURE ConsultarReparaciones
AS
BEGIN
    SELECT * FROM Reparaciones
END
GO

-- Actualizar reparación
CREATE PROCEDURE ActualizarReparacion
    @ReparacionID INT,
    @EquipoID INT,
    @FechaSolicitud DATETIME,
    @Estado VARCHAR(50)
AS
BEGIN
    UPDATE Reparaciones
    SET EquipoID = @EquipoID,
        FechaSolicitud = @FechaSolicitud,
        Estado = @Estado
    WHERE ReparacionID = @ReparacionID
END
GO

-- Eliminar reparación
CREATE PROCEDURE EliminarReparacion
    @ReparacionID INT
AS
BEGIN
    DELETE FROM Reparaciones WHERE ReparacionID = @ReparacionID
END
GO

-- Insertar detalle de reparación
CREATE PROCEDURE InsertarDetalleReparacion
    @ReparacionID INT,
    @Descripcion VARCHAR(255),
    @FechaInicio DATETIME,
    @FechaFin DATETIME
AS
BEGIN
    INSERT INTO DetallesReparacion (ReparacionID, Descripcion, FechaInicio, FechaFin)
    VALUES (@ReparacionID, @Descripcion, @FechaInicio, @FechaFin)
END
GO

-- Consultar detalles de reparaciones
CREATE PROCEDURE ConsultarDetallesReparacion
AS
BEGIN
    SELECT * FROM DetallesReparacion
END
GO

-- Actualizar detalle de reparación
CREATE PROCEDURE ActualizarDetalleReparacion
    @DetalleID INT,
    @ReparacionID INT,
    @Descripcion VARCHAR(255),
    @FechaInicio DATETIME,
    @FechaFin DATETIME
AS
BEGIN
    UPDATE DetallesReparacion
    SET ReparacionID = @ReparacionID,
        Descripcion = @Descripcion,
        FechaInicio = @FechaInicio,
        FechaFin = @FechaFin
    WHERE DetalleID = @DetalleID
END
GO

-- Eliminar detalle de reparación
CREATE PROCEDURE EliminarDetalleReparacion
    @DetalleID INT
AS
BEGIN
    DELETE FROM DetallesReparacion WHERE DetalleID = @DetalleID
END
GO

-- Insertar técnico
CREATE PROCEDURE InsertarTecnico
    @Nombre VARCHAR(100),
    @Especialidad VARCHAR(100)
AS
BEGIN
    INSERT INTO Tecnicos (Nombre, Especialidad)
    VALUES (@Nombre, @Especialidad)
END
GO

-- Consultar técnicos
CREATE PROCEDURE ConsultarTecnicos
AS
BEGIN
    SELECT * FROM Tecnicos
END
GO

-- Actualizar técnico
CREATE PROCEDURE ActualizarTecnico
    @TecnicoID INT,
    @Nombre VARCHAR(100),
    @Especialidad VARCHAR(100)
AS
BEGIN
    UPDATE Tecnicos
    SET Nombre = @Nombre,
        Especialidad = @Especialidad
    WHERE TecnicoID = @TecnicoID
END
GO

-- Eliminar técnico
CREATE PROCEDURE EliminarTecnico
    @TecnicoID INT
AS
BEGIN
    DELETE FROM Tecnicos WHERE TecnicoID = @TecnicoID
END
GO

-- Insertar asignación
CREATE PROCEDURE InsertarAsignacion
    @ReparacionID INT,
    @TecnicoID INT,
    @FechaAsignacion DATETIME
AS
BEGIN
    INSERT INTO Asignaciones (ReparacionID, TecnicoID, FechaAsignacion)
    VALUES (@ReparacionID, @TecnicoID, @FechaAsignacion)
END
GO

-- Consultar asignaciones
CREATE PROCEDURE ConsultarAsignaciones
AS
BEGIN
    SELECT * FROM Asignaciones
END
GO

-- Actualizar asignación
CREATE PROCEDURE EditarAsignacion
    @AsignacionID INT,
    @ReparacionID INT,
    @TecnicoID INT,
    @FechaAsignacion DATETIME
AS
BEGIN
    UPDATE Asignaciones
    SET ReparacionID = @ReparacionID,
        TecnicoID = @TecnicoID,
        FechaAsignacion = @FechaAsignacion
    WHERE AsignacionID = @AsignacionID
END
GO

-- Eliminar asignación
CREATE PROCEDURE EliminarAsignacion
    @AsignacionID INT
AS
BEGIN
    DELETE FROM Asignaciones WHERE AsignacionID = @AsignacionID
END
GO