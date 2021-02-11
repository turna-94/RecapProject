CREATE TABLE Cars(
	CarId int PRIMARY KEY IDENTITY(1,1),
	BrandId int,
	ColorId int,
	ModelYear varchar(25),
	DailyPrice decimal,
	Descriptions varchar(50),
	FOREIGN KEY (ColorId) REFERENCES Colors(ColorId),
	FOREIGN KEY (BrandId) REFERENCES Brands(BrandId)
);

CREATE TABLE Colors(
	ColorId int PRIMARY KEY IDENTITY(1,1),
	ColorName nvarchar(25)
);

CREATE TABLE Brands(
	BrandId int PRIMARY KEY IDENTITY(1,1),
	BrandName nvarchar(25)
);


INSERT INTO Cars(BrandId,ColorId,ModelYear,DailyPrice,Descriptions)
VALUES
	('1','2','2018','300','Manuel Benzin'),
	('1','3','2014','250','Automatic Dizel'),
	('2','1','2013','170','Automatic Hybrid'),
	('3','3','2015','150','Manuel Dizel');

INSERT INTO Colors(ColorName)
VALUES
	('Black'),
	('Gray'),
	('White');


INSERT INTO Brands(BrandName)
VALUES
	('Audi'),
	('BMW'),
	('Fiat');
