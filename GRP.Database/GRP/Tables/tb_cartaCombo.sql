CREATE TABLE [GRP].[tb_cartaCombo] (
    [codCarta] BIGINT NOT NULL,
    [codCombo] BIGINT NOT NULL,
    PRIMARY KEY CLUSTERED ([codCarta] ASC, [codCombo] ASC),
    CONSTRAINT [FK_carta] FOREIGN KEY ([codCarta]) REFERENCES [GRP].[tb_carta] ([codCarta]),
    CONSTRAINT [FK_combo] FOREIGN KEY ([codCombo]) REFERENCES [GRP].[tb_combo] ([codCombo])
);

