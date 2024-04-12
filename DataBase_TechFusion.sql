create database DataBase_TechFusion;
use DataBase_TechFusion;

create table produto(
	Cod_prod int primary key auto_increment,
    Nome_prod varchar(70),
    preco_prod float(10,2)
);

create table perfil(
	Cod_perfil int primary key auto_increment,
    cargo varchar(70)
);

create table usuario(
	Cod_usuario int primary key auto_increment,
	Nome_user varchar(70),
    idade_user int,
    foto_user varchar(200),
    data_Registro date,
    horario_Registro time,
    UserName varchar(70),
    senha varchar(90),
    CFK_prod int,
    CFK_perfil int,
    constraint FK_prod foreign key (CFK_prod) references produto(Cod_prod),
    constraint FK_perfil foreign key (CFK_perfil) references perfil(Cod_perfil)
);

create table Historico_pedidos(
	Cod_hist int primary key auto_increment,
    dia_ped date,
    hora_ped time,
    CFK_prod int,
    CFK_User int,
    constraint FK_user foreign key (CFK_User) references usuario(Cod_usuario),
    constraint FK_prods foreign key (CFK_prod)references produto(Cod_prod)
);


insert into perfil(cargo) values("ADM"), ("Gerente"), ("Cliente"),("Revendedor"),("Técnico");

select * from produto;
select * from perfil;
select * from usuario;
-- select * from


