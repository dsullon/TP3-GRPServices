CREATE TABLE [GRP].[tb_solicitudRetiro] (
    [codSolicitudRetiro] BIGINT        NOT NULL,
    [fechaEnvio]         DATETIME      NULL,
    [comentario]         VARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([codSolicitudRetiro] ASC)
);

