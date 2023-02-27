



-- Execute como SA

USE BancoTarefas;
GO

create table dbo.Status
(
    Id          int          not null
        constraint Status_pk
            primary key,
    Description varchar(255) not null
)
go

create table dbo.Usuario
(
    Id       int          not null
        constraint Usuario_pk
            primary key,
    Username varchar(255) not null,
    Password varchar(255) not null
)
go

create table dbo.Tarefa
(
    Id        int           not null
        constraint Tarefa_pk
            primary key,
    Descricao varchar(1000) not null,
    UsuarioId int           not null
        constraint Tarefa_Usuario_Id_fk
            references dbo.Usuario
            on update cascade on delete cascade,
    StatusId  int           not null
        constraint Tarefa_Status_Id_fk
            references dbo.Status
)
go



CREATE LOGIN [admin] WITH PASSWORD = 'P@adrao!123456';
GO

CREATE USER [admin_tarefas] FOR LOGIN [admin];
GO

EXEC sp_addrolemember 'db_owner', 'admin_tarefas';
GO


