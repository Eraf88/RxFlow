create table transactions (
	id int primary key identity(1,1),
	customer_id int NULL,
	prod_id varchar(max) NULL,
	total_price float ,
	status varchar(max) NULL,
	date_trans date NULL
)

SELECT * FROM transactions

SELECT MAX(id) as getID FROM transactions

CREATE TABLE [dbo].[transactions] (
    [id]          INT           IDENTITY (1, 1) NOT NULL,
    [customer_id] INT           NOT NULL,
    [prod_id]     VARCHAR (MAX) NOT NULL,
    [total_price] FLOAT (53)    NULL,
    [status]      VARCHAR (MAX) NOT NULL,
    [date_trans]  DATE          NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

SELECT * FROM transactions