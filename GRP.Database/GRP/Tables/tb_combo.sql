CREATE TABLE [GRP].[tb_combo] (
    [codCombo]          BIGINT          NOT NULL,
    [nombre]            VARCHAR (120)   NULL,
    [descripcion]       VARCHAR (120)   NULL,
    [precio]            DECIMAL (10, 2) NULL,
    [descuento]         DECIMAL (10, 2) NULL,
    [estado]            BIT             NULL,
    [codCategoria]      BIGINT          NOT NULL,
    [fechaCreacion]     DATETIME        NULL,
    [fechaModificacion] DATETIME        NULL,
    PRIMARY KEY CLUSTERED ([codCombo] ASC),
    CONSTRAINT [FK_combo_categoria] FOREIGN KEY ([codCategoria]) REFERENCES [GRP].[tb_categoria] ([codCategoria])
);

