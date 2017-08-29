
-- DROP PROCEDURE [dbo].[USPI_ResultadoEvaluacion]
CREATE PROCEDURE [dbo].[USPI_ResultadoEvaluacion]
	@solicitudId	int,
	@resultado		varchar(250),
	@errores		varchar(400),
	@usuarioId		int,
	@idResultadoEva	int OUT,
	@coderr			int OUT,
	@msgerr			varchar(1000) OUT

AS
BEGIN TRAN [ti_ResultadoE]
BEGIN TRY

	insert into ReporteEvaluacion(  SolicitudId, 
									FechaReporte, 
									ResultadoEjercicio, 
									ErroresEncontrados, 
									AuditoriaUC, 
									AuditoriaFC)
	Values (@solicitudId, GETDATE(),
		@resultado, @errores, @usuarioId, GETDATE());
	
	Select @idResultadoEva = SCOPE_IDENTITY();

	Set @coderr = 0
	Set @msgerr = 'OK'

	COMMIT TRAN [ti_ResultadoE]

END TRY
BEGIN CATCH
	DECLARE @mensajeError as varchar(4000)
	DECLARE @codSeveridad as int
	DECLARE @codStatus as int

	Select @mensajeError = ERROR_MESSAGE(),
		   @codSeveridad = ERROR_SEVERITY(),
		   @codStatus = ERROR_STATE()
	
	set @coderr = 1
	set @msgerr = @mensajeError

	ROLLBACK TRAN [ti_ResultadoE]
	-- RAISERROR(@mensajeError, @codSeveridad, @codStatus)
END CATCH


