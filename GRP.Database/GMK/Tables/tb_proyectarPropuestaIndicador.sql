CREATE TABLE [GMK].[tb_proyectarPropuestaIndicador] (
    [codProyectarPropuestaIndicador] INT  NOT NULL,
    [indicadorConsumo]               INT  NULL,
    [indicadorSabor]                 INT  NULL,
    [indicadorCosto]                 INT  NULL,
    [fechaRegistroIndicador]         DATE NULL,
    [codComboLocal]                  INT  NULL,
    CONSTRAINT [PK_tb_proyectarPropuestaIndicador] PRIMARY KEY CLUSTERED ([codProyectarPropuestaIndicador] ASC)
);

