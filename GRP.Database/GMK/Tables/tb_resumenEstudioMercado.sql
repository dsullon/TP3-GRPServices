CREATE TABLE [GMK].[tb_resumenEstudioMercado] (
    [codResumenEstudio]          INT           NOT NULL,
    [fechaEstudio]               DATE          NULL,
    [descripClientelaPotencial]  NVARCHAR (50) NULL,
    [descripAnalisisCompetencia] NVARCHAR (50) NULL,
    [descripLimitaciones]        NVARCHAR (50) NULL,
    [fechaRegistro]              DATE          NULL,
    [codPlanMkt]                 INT           NULL,
    CONSTRAINT [PK_tb_resumenEstudioMercado] PRIMARY KEY CLUSTERED ([codResumenEstudio] ASC),
    CONSTRAINT [FK_tb_resumenEstudioMercado_tb_planMarketing] FOREIGN KEY ([codPlanMkt]) REFERENCES [GMK].[tb_planMarketing] ([codPlanMkt])
);

