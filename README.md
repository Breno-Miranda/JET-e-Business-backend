# JET e-Business (DOTNET 2.2)

![JET e-Business](https://media-exp1.licdn.com/dms/image/C4D0BAQF5iiNwyoa2bw/company-logo_200_200/0/1543317822795?e=2159024400&v=beta&t=ZR3A_pya3b11HpUGONQAdRJUVtbCo1hJ94nDX1rgkE8)

Projeto simples (um scope de ecommerce) feito com todo amor e carinho.

- Tecnologias utilizadas:

  - Dotnet 2.2
  - MySqlContext -> modelBuilder

# Principais pontos

1. Arquitetura do projeto

-A camada de front-end da loja pode ser realizada utilizando Asp.net MVC 5 ou Angular. (fique a
vontade para utilizar bootstrap)
O front deve se comunicar com o repositório de dados utilizando api rest que precisam ser
criadas utilizando .net Core 2.2 ou superior.
Para a camada de repositório de dados pode-se utilizar dados estáticos (in memory) ou algum
banco de dados relacional (ex. MySql, PostgreSql, SqlServer ) ou bancos nosql como MongoDB,
Cassandra e Redis.

### Installation

Blue modas requer [Dotnet 2.2](https://docs.microsoft.com) to run.

Só precisa de alguns passo:

```sh
$ wget https://packages.microsoft.com/config/ubuntu/20.10/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
```
Proximo passo (dotnet sdk):

```sh
$ sudo apt-get update; \
$ sudo apt-get install -y apt-transport-https && \
$ sudo apt-get update && \
$ sudo apt-get install -y dotnet-sdk-3.1
```
Proximo passo (runtime):

```sh
$ sudo apt-get update; \
$ sudo apt-get install -y apt-transport-https && \
$ sudo apt-get update && \
$ sudo apt-get install -y aspnetcore-runtime-3.1
$ sudo apt-get install -y dotnet-runtime-3.1
```
Para rodar o projeto ...

```sh
$ dotnet build
```

```sh
$ dotnet run 
```

#### MYSQL (SCRIPT)


```sh
create database jetecommerce;

use jetecommerce;

CREATE TABLE IF NOT EXISTS users (
  id int(11) NOT NULL AUTO_INCREMENT primary key,
  email varchar(50) NOT NULL DEFAULT '0',
  salt varchar(36) NOT NULL DEFAULT '0',
  password varchar(128) NOT NULL DEFAULT '0',
  role varchar(20) NOT NULL DEFAULT '0'
) ;


CREATE TABLE IF NOT EXISTS  categorys(
	id int not null auto_increment primary key,
    title varchar(255) not null,
    description longtext not null,
    discount decimal(10, 2) null,
    stock int not null default 0,
    url_image varchar(255) not null,
    date_time timestamp not null,
    is_promotion boolean not null default false,
    is_activate boolean not null default false
);

CREATE TABLE IF NOT EXISTS  products(
	id int not null auto_increment primary key,
    category_id int not null,
    title varchar(255) not null,
    description longtext not null,
    price decimal(10, 2) not null,
    discount decimal(10, 2) null,
    stock int not null default 0,
    url_image varchar(255) not null,
    date_time timestamp not null,
    is_promotion boolean not null default false,
    is_activate boolean not null default false
);

```


### Plugins

Os Plugins utilizados foram:

| Plugin |
| ------ | 
| dotnet |
| mysql | 

