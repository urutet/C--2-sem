create database OOP10
ON PRIMARY
  ( NAME='OOP10_Primary',
    FILENAME=
       'D:\BSTU\2 Курс\2 Семестр\ООП 2 сем\LAB10\LAB10.mdf',
    SIZE=4MB,
    MAXSIZE=100MB,
    FILEGROWTH=1MB);

use OOP10;

create table PROCESSORS
(
	ID int identity(1000,1) primary key,
	PROCESSOR_NAME nvarchar(20) not null,
	CORES int check (CORES >= 1 and CORES <=64),
	CLOCK_HZ int check (CLOCK_HZ >= 1000 and CLOCK_HZ <= 6000) not null,
	L3_CACHE int check (L3_CACHE >= 1 AND L3_CACHE <= 64) not null,
)

create table RAMS
(
	ID int identity(2000,1) primary key,
	RAM_NAME nvarchar(20) not null,
	CLOCK_HZ int check (CLOCK_HZ >= 1000 and CLOCK_HZ <= 4000) not null,
	RAM_SIZE int check (RAM_SIZE >= 1 AND RAM_SIZE <= 128) not null
)

create table GPUS
(
	ID int identity (3000, 1) primary key,
	GPU_NAME nvarchar(20) not null,
	GRAM_SIZE int check (GRAM_SIZE >= 1 and GRAM_SIZE <= 32) not null
)

create table COMPUTERS
(
	ID int identity(1,1),
	PC_NAME nvarchar(20) not null,
	PROCESSOR_ID int foreign key references PROCESSORS(ID) not null,
	RAM_ID int foreign key references RAMS(ID),
	GPU_ID int foreign key references GPUS(ID),
	IMG varbinary(max) not null
)

alter table COMPUTERS alter column IMG blob

create table Settings
(
	LOGO varbinary(max) not null
)


--Adding some values to test the program
insert into GPUS(GPU_NAME, GRAM_SIZE)
	values ('Nvidia GeForce GTX 1050', 2),
	('AMD Radeon RX 560', 2),
	('Intel Iris', 2)

insert into PROCESSORS(PROCESSOR_NAME, CORES, CLOCK_HZ, L3_CACHE)
	values ('Intel Core i5', 6, 3200, 16),
			('AMD Ryzen 5', 8, 3400, 16),
			('Intel Core i7', 8, 3400, 16)

insert into RAMS(RAM_NAME, RAM_SIZE, CLOCK_HZ)
	values ('Kingston', 16, 3200),
			('Crucial', 8, 2400),
			('GoodRAM', 16, 1600)

select * from GPUS
select * from RAMS
select * from PROCESSORS

insert into COMPUTERS (PC_NAME, PROCESSOR_ID, RAM_ID, GPU_ID, IMG)
	values ('PC1', 1000, 2000, 3005, (select * 
from openrowset(BULK N'D:\BSTU\2 Курс\2 Семестр\ООП 2 сем\LAB10\DBImg\PC1.jpg', Single_blob) as Image)),
			('PC2', 1001, 2001, 3006, (select *
from openrowset(BULK N'D:\BSTU\2 Курс\2 Семестр\ООП 2 сем\LAB10\DBImg\PC2.png', Single_blob) as Image)),
			('PC3', 1002, 2002, 3008, (select *
from openrowset(BULK N'D:\BSTU\2 Курс\2 Семестр\ООП 2 сем\LAB10\DBImg\PC3.png', Single_blob) as Image))

select * from COMPUTERS

create view PC_VIEW
as select IMG, PC_NAME, PROCESSOR_NAME, RAM_SIZE, GPU_NAME  from COMPUTERS
join RAMS on COMPUTERS.RAM_ID = RAMS.ID
join GPUS on COMPUTERS.GPU_ID = GPUS.ID
join PROCESSORS on COMPUTERS.PROCESSOR_ID = PROCESSORS.ID

drop view PC_VIEW

select * from PC_VIEW