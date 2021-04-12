use master
go

IF EXISTS (SELECT name FROM master.dbo.sysdatabases
WHERE name = 'restaurante')
DROP DATABASE restaurante

CREATE DATABASE restaurante
go
use restaurante
go

create table cidade(
	idCidade int identity not null PRIMARY KEY,
	nmCidade varchar(20)
)

create table bairro(
	idBairro int identity not null PRIMARY KEY,
	nmBairro varchar(30),
	idCidade int not null FOREIGN KEY REFERENCES cidade(idCidade)
)

create table cargo(
	idCargo int identity not null PRIMARY KEY,
	nmCargo VARCHAR(15),
	salario float
)

create table funcionario(
	idFuncionario int identity not null PRIMARY KEY,
	nmFuncionario varchar(40),
	cpf varchar(12),
	sexo char(1) check(upper(sexo)='M' or upper(sexo)='F'),
	dataNasc date,
	telefone varchar(11),
	celular varchar(11), 
	ativo bit,
	login varchar(10),
	senha varchar(15),
	lembrete varchar(8),
	idCargo int not null FOREIGN KEY REFERENCES cargo(idCargo),
)

create table cliente(
	cpf varchar(11) not null PRIMARY KEY,
	nmCliente varchar(30),
	sobNmcliente varchar(30),
	sexo char(1) check(upper(sexo)='M' or upper(sexo)='F'),
	dataNasc date,
	telefone varchar (11),
	celular varchar(11),
	email varchar (30),
	senha varchar(15),
	ativo bit,
)

create table planoReservas(
	idPlanoReservas int identity not null PRIMARY KEY,
	descricao varchar(20),
	dataInicio date,
	dataFim date,
	horaInicio time,
	QmesasDisponiveis int,
	ativo bit
)

create table mesa(
	numeroMesa int identity not null PRIMARY KEY,
	capacidade int,
	ativo binary,
	statusMesa char(1) check(upper(statusMesa)='L' or upper(statusMesa)='O'),/*L=livre, O=Ocupado, R=Reservada*/
)

create table reserva(
	idReserva int identity not null PRIMARY KEY,
	dataReserva date,
	horaReserva date,
	cpf varchar(11) not null FOREIGN KEY REFERENCES cliente(cpf),
	statusReserva char(1) check(upper(statusReserva)='C' or upper(statusReserva)='A' or upper(statusReserva)='F'),/*C=Cancelado, A=em aberto, E=Encerrado*/		
)

create table mesasDisponiveis(
	idMesasDisponiveis int identity not null PRIMARY KEY,
	numeroMesa int not null foreign key references mesa(numeroMesa),
	idPlanoReservas int not null FOREIGN KEY REFERENCES planoReservas(idPlanoReservas),
	idReserva int not null FOREIGN KEY REFERENCES reserva(idReserva)
)




create table venda(
	idVenda int identity not null PRIMARY KEY,
	dataHora datetime,
	numeroMesa int not null FOREIGN KEY REFERENCES mesa(numeroMesa),
	cpf varchar(11) FOREIGN KEY REFERENCES cliente(cpf),
	statusVenda char(1), /* A = Em aberto, C= Cancelado, E = Encerrado*/
	idFuncionario int not null FOREIGN KEY REFERENCES funcionario(idFuncionario)
)

create table fornecedor(
	idFornecedor int identity not null PRIMARY KEY,
	nmComercial varchar(30),
	cnpj varchar(12),
	iscricaoEstadual varchar(12),
	email varchar (30),
	telefone1 varchar(11),
	telefone2 varchar(11),
	urlSite varchar(35),
	tipoLogradouro varchar(10),
	logradouro varchar(20),
	numero varchar(5),
	complemento varchar(15),
	cep varchar(8),
	ativo bit,
	idbairro int not null FOREIGN KEY REFERENCES	bairro(idbairro),
)

create table grupo(
	idGrupo int identity not null PRIMARY KEY,
	nmGrupo varchar(10)
)

create table categoria(
	idCategoria int identity not null PRIMARY KEY,
	nmCategoria varchar(10)
)

create table produto(
	idProduto int identity not null PRIMARY KEY,
	nmProduto varchar(15),
	descricao varchar(50),
	precoUnitario float,
	precoUnitarioCompra float,
	dataFabricacao date,
	dataVencimento date,
	pathImagem varchar(50),
	ativo binary,
	disponivelWeb binary,
	quantidade int,
	idFornecedor int FOREIGN KEY REFERENCES fornecedor(idFornecedor),
	idCategoria int not null FOREIGN KEY REFERENCES categoria(idCategoria),
	idGrupo int not null FOREIGN KEY REFERENCES grupo(idGrupo) 
)

create table detalheVenda(
	idDetalheVenda int identity not null PRIMARY KEY,
	idVenda int not null FOREIGN KEY REFERENCES venda(idVenda),
    idProduto int not null FOREIGN KEY REFERENCES produto(idProduto),
	quantidade float,
	precoUnitario float		
)

create table pedidoFornecedor(
	idPedido int identity not null PRIMARY KEY,
	dataPedido date,
	statusPedido char(1) check(upper(statusPedido)='A' or upper(statusPedido)='F' or upper(statusPedido)='C'),/*A=em aberto, C=Cancelado, E=Encerrado*/
	dataOperacao date,
	numeroNotaFiscal varchar(5)
)

create table detalhePedidoFornecedor(
	idDetalhePedidoFornecedor int identity not null PRIMARY KEY,
	idPedido int not null FOREIGN KEY REFERENCES pedidoFornecedor(idPedido),
	idProduto int not null FOREIGN KEY REFERENCES produto(idProduto),
	quantidade int,
	precoUnitario float	 
)

insert into cargo(nmCargo,salario) values('Gerente',3500.00)
insert into cargo(nmCargo,salario) values('Garçom',1800.50)
insert funcionario (nmFuncionario,cpf,sexo,dataNasc,telefone,celular,ativo,login,senha,lembrete,idCargo) values('Kathia Moteiro','23512817845','f','15/12/1985','114567892','11953564908',1,'admin','admin','ad',1)
insert funcionario (nmFuncionario,cpf,sexo,dataNasc,telefone,celular,ativo,login,senha,lembrete,idCargo) values('Roberto Pires','23564217209','m','08/03/1980','114760091','11993543208',1,'robertop','roberto','rp',2)