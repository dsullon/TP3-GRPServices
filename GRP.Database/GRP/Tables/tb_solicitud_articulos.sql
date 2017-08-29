CREATE TABLE [GRP].[tb_solicitud_articulos] (
    [codSolicitud]  BIGINT        NOT NULL,
    [descripcion]   VARCHAR (100) NOT NULL,
    [tipoSolicitud] VARCHAR (100) NOT NULL,
    [solicitante]   VARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([codSolicitud] ASC)
);

