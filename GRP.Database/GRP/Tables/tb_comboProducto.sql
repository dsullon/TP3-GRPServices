CREATE TABLE [GRP].[tb_comboProducto] (
    [codCombo]    BIGINT NOT NULL,
    [codProducto] BIGINT NOT NULL,
    PRIMARY KEY CLUSTERED ([codCombo] ASC, [codProducto] ASC),
    CONSTRAINT [FK_combo_producto] FOREIGN KEY ([codCombo]) REFERENCES [GRP].[tb_combo] ([codCombo]),
    CONSTRAINT [FK_producto] FOREIGN KEY ([codProducto]) REFERENCES [GRP].[tb_producto] ([codProducto]),
    CONSTRAINT [FK_producto_combo] FOREIGN KEY ([codProducto]) REFERENCES [GRP].[tb_producto] ([codProducto])
);

