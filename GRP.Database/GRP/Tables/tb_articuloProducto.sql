CREATE TABLE [GRP].[tb_articuloProducto] (
    [codArticulo] BIGINT          NOT NULL,
    [codProducto] BIGINT          NOT NULL,
    [costo]       DECIMAL (10, 2) NULL,
    [cantidad]    DECIMAL (10, 3) NULL,
    [rendimiento] DECIMAL(10, 3) NULL, 
    PRIMARY KEY CLUSTERED ([codArticulo] ASC, [codProducto] ASC),
    CONSTRAINT [FK_ARTICULO_DETALLE] FOREIGN KEY ([codArticulo]) REFERENCES [GRP].[tb_articulo] ([codArticulo]),
    CONSTRAINT [FK_PRODUCTO__DETALLE] FOREIGN KEY ([codProducto]) REFERENCES [GRP].[tb_producto] ([codProducto])
);

