CREATE TABLE [GMK].[tb_accion] (
    [codAccion]             INT             NOT NULL,
    [nombreAccion]          NVARCHAR (50)   NULL,
    [descripcionAccion]     NVARCHAR (50)   NULL,
    [fechaRegistroAccion]   DATE            NULL,
    [costoAccion]           DECIMAL (10, 5) NULL,
    [fechaInicioAccion]     DATE            NULL,
    [fechaFinAccion]        DATE            NULL,
    [fechaInicioRealAccion] DATE            NULL,
    [fechaFinRealAccion]    DATE            NULL,
    [estadoAccion]          NVARCHAR (50)   NULL,
    CONSTRAINT [PK_tb_accion] PRIMARY KEY CLUSTERED ([codAccion] ASC)
);

