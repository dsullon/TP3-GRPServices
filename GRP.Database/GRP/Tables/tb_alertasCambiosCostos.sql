CREATE TABLE [GRP].[tb_alertasCambiosCostos] (
    [codAlerta]     BIGINT          NOT NULL,
    [tipoVariacion] VARCHAR (20)    NULL,
    [fechaAlerta]   DATETIME        NULL,
    [nuevoCosto]    DECIMAL (10, 2) NULL,
    [estado]        VARCHAR (20)    NULL,
    [codArticulo]   BIGINT          NOT NULL,
    PRIMARY KEY CLUSTERED ([codAlerta] ASC),
    CONSTRAINT [FK_alertaArticulo] FOREIGN KEY ([codArticulo]) REFERENCES [GRP].[tb_articulo] ([codArticulo])
);

