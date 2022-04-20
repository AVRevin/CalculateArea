
create table products 
(
	Id int primary key,
	"Name" text 
);

insert into products
values
(1,'Product 1'),
(2,'Product 2'),
(3,'Product 3');


create table categories
(
	Id int primary key,
	"Name" text
)


insert into categories
values
(1,'Category 1'),
(2,'Category 2'),
(3,'Category 3');


create table productcategories
(
	productId int foreign key references products(Id),
	categoryId int foreign key references products(Id),
	primary key (productId,categoryId)
);

insert into productcategories
values
(1,1),
(2,3),
(3,3);



SELECT p."Name", c."Name" FROM products p
LEFT JOIN productCategories pc ON p.Id = pc.productId
LEFT JOIN categories C ON pc.CategoryId = c.Id;