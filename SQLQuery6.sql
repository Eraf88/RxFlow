create table transactionss (
	id int primary key identity(1,1),
	customer_id int NULL,
	prod_id varchar(max) NULL,
	total_price float ,
	status varchar(max) NULL,
	date_trans date NULL
)

SELECT * FROM transactionss

SELECT MAX(id) as getID FROM transactionss

SELECT sum(total_price) as todaysRevenue FROM transactionss 