---Создание таблицы
CREATE TABLE Persons (
     Id INT IDENTITY(1,1) NOT NULL CONSTRAINT Person_Id PRIMARY KEY,
     Name Nvarchar(50) NOT NULL,
     MobilePhone varchar(50) NOT NULL,
     JobTitle Nvarchar(50) NOT NULL,
     BirthDate  Date NOT NULL
   );

--Добавление строк в таблицу
   INSERT INTO Persons(Name, MobilePhone, JobTitle, BirthDate)
	VALUES ('Jessie Adamson', '+124-698-7514', 'Accountant', '1998-10-16'),
	('Freddy Smith', '+375-(89)-148-65-7', 'Developer', '1990-01-08'),
	('Jenny Gilbert', '+7-78-777-88', 'HR', '2000-12-21'),
	('Danny Davies', '123-456-789', 'Manager', '1996-07-23'),
	('Annie Parson', '4-78-589', 'Marketeer', '1983-03-03')