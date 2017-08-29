CREATE TABLE [GFR].[tb_usuario] (
    [id]                  INT              IDENTITY (1, 1) NOT NULL,
    [perfilId]            INT              NOT NULL,
    [ctaUsuario]          VARCHAR (25)     NOT NULL,
    [contrasenia]         VARBINARY (8000) NOT NULL,
    [nombres]             VARCHAR (50)     NOT NULL,
    [apellidos]           VARCHAR (50)     NOT NULL,
    [cargo]               VARCHAR (48)     NULL,
    [email]               VARCHAR (255)    NOT NULL,
    [telefono]            VARCHAR (50)     NULL,
    [estado]              TINYINT          NOT NULL,
    [cambiarContrasenia]  BIT              NULL,
    [fechaVencimientoCta] DATETIME         NULL,
    [fechaVencimiento]    DATETIME         NULL,
    [auditoriaUC]         INT              NULL,
    [auditoriaUM]         INT              NULL,
    [auditoriaFC]         DATETIME         NOT NULL,
    [auditoriaFM]         DATETIME         NULL,
    CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED ([id] ASC)
);

