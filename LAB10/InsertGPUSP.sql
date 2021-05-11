create procedure InsertGPU
@GPU_NAME nvarchar(100),
@GRAM_SIZE int
as insert into GPUS(GPU_NAME, GRAM_SIZE)
	values (@GPU_NAME, @GRAM_SIZE)
go
