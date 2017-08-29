CREATE TABLE [GRP].[tb_detalleVenta] (
    [codVenta]        BIGINT          NOT NULL,
    [codDetalleVenta] BIGINT          NOT NULL,
    [codCombo]        BIGINT          NOT NULL,
    [cantidad]        INT             NOT NULL,
    [precio]          DECIMAL (10, 2) NOT NULL,
    [descuento]       DECIMAL (10, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([codVenta] ASC, [codDetalleVenta] ASC),
    CONSTRAINT [FK_DetaVenta_Combo] FOREIGN KEY ([codCombo]) REFERENCES [GRP].[tb_combo] ([codCombo]),
    CONSTRAINT [FK_DetaVenta_venta] FOREIGN KEY ([codVenta]) REFERENCES [GRP].[tb_venta] ([codventa])
);

