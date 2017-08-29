
-- DROP PROCEDURE [dbo].[USPS_ResultadoEvaluacion]
CREATE PROCEDURE [dbo].[USPS_ResultadoEvaluacion]
	@solicitudId	int,
	@coderr			int OUT,
	@msgerr			varchar(1000) OUT

AS
BEGIN TRY

	SELECT	RE.Id as ReporteEvalId,
			S.Id as SolicitudId,
			S.NumSolicitud,
			S.MontoCapital,
			S.FechaSolicitud,
			S.Estado as EstadoId,
			E.Nombre as Estado,
			SL.ApellidoMaterno,
			SL.ApellidoPaterno,
			SL.Nombres,
			RE.FechaReporte,
			RE.ResultadoEjercicio,
			RE.ErroresEncontrados
	FROM Solicitud S
	inner join Solicitante SL on S.id = SL.SolicitudId
	inner join ReporteEvaluacion RE on S.Id = Re.SolicitudId
	inner join Parametro E on S.Estado = E.Codigo and E.CodigoGrupo = 3
	WHERE S.Id = @solicitudId
	order by 1
	
	Set @coderr = 0
	Set @msgerr = 'OK'

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

	-- RAISERROR(@mensajeError, @codSeveridad, @codStatus)
END CATCH


