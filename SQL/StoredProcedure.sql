CREATE PROC USP_ModifyPassword
@IDAccount INT, @Password NVARCHAR(1000)
AS
BEGIN
	UPDATE Staff
	SET Password = @Password
	WHERE IDAccount = @IDAccount
END
GO

CREATE PROC USP_GetStatus
@Username NVARCHAR(50), @Password NVARCHAR(50)
AS
BEGIN
	SELECT Status FROM Staff S
	INNER JOIN Account A ON S.IDStaff = A.IDStaff
	WHERE A.Username = N'ngocthinh303' AND A.Password = '1'
END

SELECT * FROM Account
