CREATE TABLE [GMK].[tb_planMarketing] (
    [codPlanMkt]         INT             NOT NULL,
    [nombrePlanMkt]      NVARCHAR (50)   NULL,
    [presupuestoPlanMkt] DECIMAL (10, 5) NULL,
    [fechaRegistro]      DATE            NULL,
    [fechaInicio]        DATE            NULL,
    [fechaFin]           DATE            NULL,
    [fechaInicioReal]    DATE            NULL,
    [fechaFinReal]       DATE            NULL,
    [estadoPlanMkt]      NVARCHAR (50)   NULL,
    CONSTRAINT [PK_tb_planMarketing] PRIMARY KEY CLUSTERED ([codPlanMkt] ASC)
);

