CREATE PROC USP_ModifyPassword
@IDAccount INT, @Password NVARCHAR(1000)
AS
BEGIN
	UPDATE Staff
	SET Password = @Password
	WHERE IDAccount = @IDAccount
END
GO