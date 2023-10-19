

 use aaaaaaa

 --creo la base de datos de productos
 create database datashopbiz;

 use datashopbiz;

	--public int codigo { get; set; }
	--public string Nombre { get; set; }
	--public string imagen { get; set; }
	--public string precio { get; set; }
	--public int moneda { get; set; }
	--public String DescMoneda { get; set; }
 create table Producto(
	Codigo int,
	Nombre varchar(50),
	Imagen varbinary(max) NULL,
	Precio float,
	Moneda int,
	DescMoneda varchar(20)
 );

 select * from producto;