CREATE TABLE [GMK].[tb_caracteristicaComboVenta] (
    [codCaracteristicaComboVenta] INT             NOT NULL,
    [nombreCaractComboVenta]      NVARCHAR (50)   NULL,
    [pesoCaractComboVenta]        DECIMAL (10, 5) NULL,
    [codResultadoEncuesta]        INT             NULL,
    [codSugerirComboPromocionar]  INT             NULL,
    CONSTRAINT [PK_tb_caracteristicaComboVenta] PRIMARY KEY CLUSTERED ([codCaracteristicaComboVenta] ASC)
);

