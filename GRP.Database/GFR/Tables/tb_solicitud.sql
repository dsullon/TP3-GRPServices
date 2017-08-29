CREATE TABLE [GFR].[tb_solicitud] (
    [id]                   INT             IDENTITY (1, 1) NOT NULL,
    [numSolicitud]         VARCHAR (15)    NULL,
    [fechaSolicitud]       DATETIME        NULL,
    [ciudadInteres]        VARCHAR (50)    NULL,
    [ubigeoCiudadInteres]  VARCHAR (6)     NULL,
    [montoCapital]         DECIMAL (18, 2) NULL,
    [fuenteFinanciamiento] VARCHAR (50)    NULL,
    [fechaInicioOperacion] DATETIME        NULL,
    [localDisponible]      INT             NULL,
    [condicionLocalId]     INT             NULL,
    [ubigeoLocal]          VARCHAR (6)     NULL,
    [direccionLocal]       VARCHAR (250)   NULL,
    [tipoUbicacionLocalId] INT             NULL,
    [referenciaComercial]  VARCHAR (500)   NULL,
    [referenciaBancaria]   VARCHAR (500)   NULL,
    [estado]               INT             NULL,
    [auditoriaUC]          INT             NOT NULL,
    [auditoriaUM]          INT             NULL,
    [auditoriaFC]          DATETIME        NOT NULL,
    [auditoriaFM]          DATETIME        NULL,
    CONSTRAINT [PK_Solicitud] PRIMARY KEY CLUSTERED ([id] ASC)
);

