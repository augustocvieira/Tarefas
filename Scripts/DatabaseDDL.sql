use BancoTarefas

create table dbo.Status
(
    Id          int          not null
        constraint Status_pk
            primary key,
    Descricao varchar(255) not null
)
    go

create table dbo.Usuario
(
    Id int identity(1,1) primary key,
    Login varchar(255) not null,
    Senha varchar(255) not null
)
    go

create table dbo.Tarefa
(
    Id int identity(1,1) primary key,
    Descricao varchar(1000) not null,
    UsuarioId int           not null
        constraint Tarefa_Usuario_Id_fk
            references dbo.Usuario
            on update cascade on delete cascade,
    StatusId  int           not null
        constraint Tarefa_Status_Id_fk
            references dbo.Status
) go

insert into dbo.Status (Id, Descricao)
values (1, 'A Fazer'),
(2, 'Completa');