CREATE TABLE [GMK].[tb_comboLocal] (
    [codComboLocal]        INT  NOT NULL,
    [cantidadVendidaCombo] INT  NULL,
    [fechaVenta]           DATE NULL,
    [codLocal]             INT  NULL,
    CONSTRAINT [PK_tb_comboLocal] PRIMARY KEY CLUSTERED ([codComboLocal] ASC)
);

