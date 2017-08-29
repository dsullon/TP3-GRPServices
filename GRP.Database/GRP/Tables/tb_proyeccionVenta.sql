CREATE TABLE [GRP].[tb_proyeccionVenta] (
    [codProducto] BIGINT       NOT NULL,
    [periodo]     VARCHAR (60) NOT NULL,
    [cantidad]    INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([codProducto] ASC, [periodo] ASC),
    CONSTRAINT [FK_producto_proyecVenta] FOREIGN KEY ([codProducto]) REFERENCES [GRP].[tb_producto] ([codProducto])
);

