create database TinhTongHaiSo
use TinhTongHaiSo

create table calc (
	a int,
	b int,
	result int
)

CREATE PROCEDURE GetSum
    @a INT,
    @b INT
AS
BEGIN
    SELECT @a + @b
END

select *from calc
