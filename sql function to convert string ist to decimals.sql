CREATE FUNCTION [dbo].[fnStringList2TableDecimal]
(
    @List varchar(MAX)
)
RETURNS 
@ParsedList table
(
    item decimal(38,0)
)
AS
BEGIN
    DECLARE @item varchar(800), @Pos int

    SET @List = LTRIM(RTRIM(@List))+ ','
    SET @Pos = CHARINDEX(',', @List, 1)

    WHILE @Pos > 0
    BEGIN
        SET @item = LTRIM(RTRIM(LEFT(@List, @Pos - 1)))
        IF @item <> ''
        BEGIN
            INSERT INTO @ParsedList (item) 
            VALUES (CAST(@item AS decimal(38,0)))
        END
        SET @List = RIGHT(@List, LEN(@List) - @Pos)
        SET @Pos = CHARINDEX(',', @List, 1)
    END

    RETURN
END