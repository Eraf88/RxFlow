create table products(
	id int primary key identity (1,1),
	prod_id varchar(max) not null,
	prod_name varchar(max) not null,
	category varchar(max) not null,
	price float not null,
	stock int not null,
	image varchar(max) null,
	status varchar(max) not null,
	date_insert date not null
)
SELECT * FROM products
INSERT INTO products (prod_id, prod_name, category, price, stock, image, status, date_insert)
                                values(@prodID, @prodName, @prodCat, @price, @stock, @image, @status, @date)