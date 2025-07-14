CREATE TABLE orders (
	id int primary key identity(1,1),
	customer_id int not null,
	prod_id varchar(max) not null,
	prod_name varchar(max) not null,
	category varchar(max) not null,
	regular_price float not null,
	quantity int not null,
	status varchar(max) not null,
	date_order date not null
)

SELECT * FROM orders

CREATE TABLE [dbo].[orders] (
    [id]            INT           IDENTITY (1, 1) NOT NULL,
    [customer_id]   INT           NOT NULL,
    [prod_id]       VARCHAR (MAX) NOT NULL,
    [prod_name]     VARCHAR (MAX) NOT NULL,
    [category]      VARCHAR (MAX) NOT NULL,
    [regular_price] FLOAT (53)    NOT NULL,
    [quantity]      INT           NOT NULL,
    [status]        VARCHAR (MAX) NOT NULL,
    [date_order]    DATE          NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

SELECT * FROM orders