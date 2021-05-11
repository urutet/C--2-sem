create procedure InsertRAM
@RAM_NAME nvarchar(100),
@CLOCK_HZ int,
@RAM_SIZE int
as insert into RAMS(RAM_NAME, CLOCK_HZ, RAM_SIZE)
	values (@RAM_NAME, @CLOCK_HZ, @RAM_SIZE)
go