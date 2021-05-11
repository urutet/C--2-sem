create procedure InsertComputer
@PC_NAME nvarchar(100),
@PROCESSOR_ID int,
@RAM_ID int,
@GPU_ID int
as insert into COMPUTERS(PC_NAME, PROCESSOR_ID, RAM_ID, GPU_ID)
	values (@PC_NAME, @PROCESSOR_ID, @RAM_ID, @GPU_ID)
go