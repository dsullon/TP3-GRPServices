CREATE TABLE [GRP].[tb_carta] (
    [codCarta]          BIGINT   NOT NULL,
    [fechaCreacion]     DATETIME NULL,
    [fechaModificacion] DATETIME NULL,
    [estado]            BIT      NOT NULL,
    PRIMARY KEY CLUSTERED ([codCarta] ASC)
);

