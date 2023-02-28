-- Execute como SA

USE BancoTarefas;
GO

CREATE LOGIN [admin] WITH PASSWORD = 'P@adrao!123456';
GO

CREATE USER [admin_tarefas] FOR LOGIN [admin];
GO

EXEC sp_addrolemember 'db_owner', 'admin_tarefas';
GO


