CREATE TABLE [GFR].[tb_local] (
    [id]            INT          IDENTITY (1, 1) NOT NULL,
    [nombre]        VARCHAR (50) NOT NULL,
    [fechaApertura] DATETIME     NOT NULL,
    [responsable]   VARCHAR (50) NOT NULL,
    [distrito]      VARCHAR (50) NOT NULL,
    [direccion]     VARCHAR (50) NOT NULL,
    [latitud]       VARCHAR (50) NOT NULL,
    [longitud]      VARCHAR (50) NOT NULL,
    [auditoriaFM]   DATETIME     NULL,
    CONSTRAINT [PK_Local] PRIMARY KEY CLUSTERED ([id] ASC)
);

