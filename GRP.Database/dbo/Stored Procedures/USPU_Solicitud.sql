
-- DROP PROCEDURE [dbo].[USPU_Solicitud]
CREATE PROCEDURE [dbo].[USPU_Solicitud]
	@solicitudId	int,
	@estado			int,
	@usuarioId		int,
	@coderr			int OUT,
	@msgerr			varchar(1000) OUT

AS
BEGIN TRAN [tu_solicitud]
BEGIN TRY

	UPDATE Solicitud
	SET Estado = @estado,
		AuditoriaUM = @usuarioId,
		AuditoriaFM = GETDATE()
	WHERE Id = @solicitudId
	
	COMMIT TRAN [tu_solicitud]

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

	ROLLBACK TRAN [tu_solicitud]
	-- RAISERROR(@mensajeError, @codSeveridad, @codStatus)
END CATCH


