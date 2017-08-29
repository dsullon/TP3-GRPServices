CREATE TABLE [GRP].[tb_infnutricional] (
    [codArticulo]   BIGINT          NOT NULL,
    [calorias]      DECIMAL (20, 2) NULL,
    [grasas]        DECIMAL (20, 2) NULL,
    [proteinas]     DECIMAL (20, 2) NULL,
    [carbohidratos] DECIMAL (20, 2) NULL,
    PRIMARY KEY CLUSTERED ([codArticulo] ASC)
);

