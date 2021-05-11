create procedure InsertCPU
@PROCESSOR_NAME nvarchar(100),
@CORES int,
@CLOCK_HZ int,
@L3_CACHE int
as insert into PROCESSORS(PROCESSOR_NAME, CORES, CLOCK_HZ, L3_CACHE)
	values (@PROCESSOR_NAME, @CORES, @CLOCK_HZ, @L3_CACHE)
go