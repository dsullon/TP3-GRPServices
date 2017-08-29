CREATE TABLE [GMK].[tb_Objetivo] (
    [codObjetivo]    INT           NOT NULL,
    [nombreObjetivo] NVARCHAR (50) NULL,
    [estadoObjetivo] NVARCHAR (50) NULL,
    [idPlanMkt]      INT           NULL,
    CONSTRAINT [PK_tb_Objetivo] PRIMARY KEY CLUSTERED ([codObjetivo] ASC),
    CONSTRAINT [FK_tb_Objetivo_tb_planMarketing] FOREIGN KEY ([idPlanMkt]) REFERENCES [GMK].[tb_planMarketing] ([codPlanMkt])
);

