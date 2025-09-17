    CREATE DATABASE ANUNCIOS;
    GO
    USE ANUNCIOS;
    GO

    -- ==================== TABLAS SIN CLAVES FORÁNEAS ====================


    CREATE TABLE Roles (
        RolId INT PRIMARY KEY IDENTITY(1,1),
        Nombre NVARCHAR(50) NOT NULL,
        Descripcion NVARCHAR(255),
        FechaCreacion DATETIME DEFAULT GETDATE()
    );
    GO


    CREATE TABLE Categorias (
        CategoriaId INT PRIMARY KEY IDENTITY(1,1),
        Nombre NVARCHAR(100) NOT NULL,
        Descripcion NVARCHAR(255),
        FechaCreacion DATETIME DEFAULT GETDATE(),
        Activo BIT DEFAULT 1
    );
    GO


    CREATE TABLE Ubicaciones (
        UbicacionId INT PRIMARY KEY IDENTITY(1,1),
        Nombre NVARCHAR(100) NOT NULL,
        Direccion NVARCHAR(255),
        Ciudad NVARCHAR(100),
        Pais NVARCHAR(100)
    );
    GO


    CREATE TABLE PlanesDePublicacion (
        PlanId INT PRIMARY KEY IDENTITY(1,1),
        Nombre NVARCHAR(100) NOT NULL,
        Precio DECIMAL(10,2) NOT NULL,
        Duracion INT NOT NULL, 
        Descripcion NVARCHAR(255),
        FechaCreacion DATETIME DEFAULT GETDATE(),
        Activo BIT DEFAULT 1
    );
    GO

    -- ==================== TABLAS CON 1 CLAVE FORÁNEA ====================


    CREATE TABLE Usuarios (
        UsuarioId INT PRIMARY KEY IDENTITY(1,1),
        Nombre NVARCHAR(100) NOT NULL,  
        Correo NVARCHAR(150) UNIQUE NOT NULL,
        Contraseña NVARCHAR(255) NOT NULL,
        Telefono NVARCHAR(20),
        FechaRegistro DATETIME NOT NULL DEFAULT GETDATE(),
        
    );
    GO


    CREATE TABLE Subcategorias (
        SubcategoriaId INT PRIMARY KEY IDENTITY(1,1),
        Nombre NVARCHAR(100) NOT NULL,
        Descripcion NVARCHAR(255),
        CategoriaId INT NOT NULL,
        FechaCreacion DATETIME DEFAULT GETDATE(),
        Activo BIT DEFAULT 1,
        FOREIGN KEY (CategoriaId) REFERENCES Categorias(CategoriaId)
    );
    GO

    -- ==================== TABLAS CON 2 CLAVES FORÁNEAS ====================


    CREATE TABLE UsuariosRoles (
        UsuarioId INT,
        RolId INT,
        FechaAsignacion DATETIME NOT NULL DEFAULT GETDATE(),
        AsignadoPor NVARCHAR(100),
        Activo BIT DEFAULT 1,
        PRIMARY KEY (UsuarioId, RolId),
        FOREIGN KEY (UsuarioId) REFERENCES Usuarios(UsuarioId),
        FOREIGN KEY (RolId) REFERENCES Roles(RolId)
    );
    GO


    CREATE TABLE Anuncios (
        AnuncioId INT PRIMARY KEY IDENTITY(1,1),
        Titulo NVARCHAR(200) NOT NULL,
        Descripcion NVARCHAR(MAX),
        Precio DECIMAL(10,2),
        FechaPublicacion DATETIME DEFAULT GETDATE(),
        UsuarioId INT NOT NULL,
        UbicacionId INT NOT NULL,
        Estado BIT DEFAULT 1,
        PlanId INT NULL,
        FOREIGN KEY (UsuarioId) REFERENCES Usuarios(UsuarioId),
        FOREIGN KEY (UbicacionId) REFERENCES Ubicaciones(UbicacionId),
        FOREIGN KEY (PlanId) REFERENCES PlanesDePublicacion(PlanId)
    );
    GO


    CREATE TABLE Comentarios (
        ComentarioId INT PRIMARY KEY IDENTITY(1,1),
        Contenido NVARCHAR(MAX) NOT NULL,
        FechaCreacion DATETIME DEFAULT GETDATE(),
        UsuarioId INT NOT NULL,
        AnuncioId INT NOT NULL,
        ComentarioPadreId INT NULL,
        Activo BIT DEFAULT 1,
        FOREIGN KEY (UsuarioId) REFERENCES Usuarios(UsuarioId),
        FOREIGN KEY (AnuncioId) REFERENCES Anuncios(AnuncioId),
        FOREIGN KEY (ComentarioPadreId) REFERENCES Comentarios(ComentarioId)
    );
    GO

    -- ==================== TABLAS CON 3+ CLAVES FORÁNEAS ====================


    CREATE TABLE ImagenesAnuncios (
        ImagenId INT PRIMARY KEY IDENTITY(1,1),
        Url NVARCHAR(255) NOT NULL,
        AnuncioId INT NOT NULL,
        UsuarioId INT NOT NULL,
        Titulo NVARCHAR(100),
        FechaSubida DATETIME DEFAULT GETDATE(),
        FOREIGN KEY (AnuncioId) REFERENCES Anuncios(AnuncioId),
        FOREIGN KEY (UsuarioId) REFERENCES Usuarios(UsuarioId)
    );
    GO


    CREATE TABLE AnunciosSubcategorias (
        AnuncioId INT, 
        SubcategoriaId INT,
        FechaAsignacion DATETIME DEFAULT GETDATE(),
        AsignadoPor NVARCHAR(100),
        PRIMARY KEY (AnuncioId, SubcategoriaId),
        FOREIGN KEY (AnuncioId) REFERENCES Anuncios(AnuncioId),
        FOREIGN KEY (SubcategoriaId) REFERENCES Subcategorias(SubcategoriaId)
    );
    GO


    CREATE TABLE Favoritos (
        UsuarioId INT,
        AnuncioId INT,
        FechaAgregado DATETIME DEFAULT GETDATE(),
        Notas NVARCHAR(255),
        Activo BIT DEFAULT 1,
        PRIMARY KEY (UsuarioId, AnuncioId),
        FOREIGN KEY (UsuarioId) REFERENCES Usuarios(UsuarioId),
        FOREIGN KEY (AnuncioId) REFERENCES Anuncios(AnuncioId)
    );
    GO


    CREATE TABLE ReportesDeAnuncios (
        ReporteId INT PRIMARY KEY IDENTITY(1,1),
        Motivo NVARCHAR(255) NOT NULL,
        FechaReporte DATETIME DEFAULT GETDATE(),
        UsuarioId INT NOT NULL,
        AnuncioId INT NOT NULL,
        Estado NVARCHAR(50) DEFAULT 'PENDIENTE',
        FOREIGN KEY (UsuarioId) REFERENCES Usuarios(UsuarioId),
        FOREIGN KEY (AnuncioId) REFERENCES Anuncios(AnuncioId)
    );
    GO


    CREATE TABLE Pagos (
        PagoId INT PRIMARY KEY IDENTITY(1,1),
        Monto DECIMAL(10,2) NOT NULL,
        UsuarioId INT NOT NULL,
        PlanId INT NOT NULL,
        AnuncioId INT NULL,
        FechaPago DATETIME DEFAULT GETDATE(),
        MetodoPago NVARCHAR(50),
        Estado NVARCHAR(50) DEFAULT 'PENDIENTE',
        FOREIGN KEY (UsuarioId) REFERENCES Usuarios(UsuarioId),
        FOREIGN KEY (PlanId) REFERENCES PlanesDePublicacion(PlanId),
        FOREIGN KEY (AnuncioId) REFERENCES Anuncios(AnuncioId)
    );
    GO

    CREATE TABLE Notificaciones (
        NotificacionId INT PRIMARY KEY IDENTITY(1,1),
        UsuarioId INT NOT NULL,
        Titulo NVARCHAR(200) NOT NULL,
        Mensaje NVARCHAR(500) NOT NULL,
        FechaCreacion DATETIME DEFAULT GETDATE(),
        Leida BIT DEFAULT 0,
        UrlDestino NVARCHAR(255),
        FOREIGN KEY (UsuarioId) REFERENCES Usuarios(UsuarioId)
    );
    GO

    INSERT INTO Roles (Nombre, Descripcion) VALUES ('Administrador', 'Acceso total al sistema');
INSERT INTO Categorias (Nombre, Descripcion) VALUES ('Electrónica', 'Artículos electrónicos');
INSERT INTO Ubicaciones (Nombre, Direccion, Ciudad, Pais) VALUES ('Centro', 'Av. Principal 123', 'CiudadX', 'PaísY');
INSERT INTO PlanesDePublicacion (Nombre, Precio, Duracion, Descripcion) VALUES ('Plan Básico', 19.99, 30, 'Publicación por 30 días');

INSERT INTO Usuarios (Nombre, Correo, Contraseña, Telefono) VALUES ('Juan Pérez', 'juan@example.com', '1234', '555-1234');
INSERT INTO Subcategorias (Nombre, Descripcion, CategoriaId) VALUES ('Celulares', 'Teléfonos móviles', 1);

INSERT INTO UsuariosRoles (UsuarioId, RolId, AsignadoPor) VALUES (1, 1, 'Admin');
INSERT INTO Anuncios (Titulo, Descripcion, Precio, UsuarioId, UbicacionId, PlanId) VALUES ('iPhone 12', 'En buen estado', 699.99, 1, 1, 1);
INSERT INTO Comentarios (Contenido, UsuarioId, AnuncioId) VALUES ('¿Está disponible?', 1, 1);

INSERT INTO ImagenesAnuncios (Url, AnuncioId, UsuarioId, Titulo) VALUES ('http://imagen.com/iphone.jpg', 1, 1, 'Foto iPhone');
INSERT INTO AnunciosSubcategorias (AnuncioId, SubcategoriaId, AsignadoPor) VALUES (1, 1, 'Admin');
INSERT INTO Favoritos (UsuarioId, AnuncioId, Notas) VALUES (1, 1, 'Me interesa');
INSERT INTO ReportesDeAnuncios (Motivo, UsuarioId, AnuncioId) VALUES ('Contenido inapropiado', 1, 1);
INSERT INTO Pagos (Monto, UsuarioId, PlanId, AnuncioId, MetodoPago) VALUES (19.99, 1, 1, 1, 'Tarjeta');
INSERT INTO Notificaciones (UsuarioId, Titulo, Mensaje, UrlDestino) VALUES (1, 'Nuevo mensaje', 'Tienes un nuevo comentario', 'http://anuncios.com/comentarios');