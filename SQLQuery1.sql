select Страна, COUNT(Язык)
from ЭтническийСостав
group by Страна, Год
having COUNT(Язык) >= 2


CREATE VIEW vGroupedCountries
AS
select Страна, Язык
FROM ЭтническийСостав
GROUP BY Страна, Язык


SELECT AVG(Численность)
FROM ЭтническийСостав


BEGIN TRAN 
UPDATE ЭтническийСостав
SET Численность = Численность + 1100 
WHERE Страна IN (select Страна
				FROM vGroupedCountries
				GROUP BY Страна
				HAVING COUNT(Язык) >= 2)
COMMIT TRAN
ROLLBACK TRAN


SELECT Страна, Язык, Год, Численность
FROM ЭтническийСостав JOIN Страны ON Страны.Код = Страна JOIN Языки ON Языки.Код = Язык
WHERE Языки.Название = 'украинский' AND Страны.Название = 'Россия'

INSERT INTO Языки (Код, Название, [Языковая группа], [Вид знаковой системы])
VALUES (@@IDENTITY + 1, 'майя', 'майяйские', 'письмо майя')




CREATE PROCEDURE addNewCountry (@name nchar(25), @group nchar(25), @sign_system nchar(25)) 
AS
BEGIN 
DECLARE @last int
SET @last = (SELECT MAX(Код)
			FROM Языки) + 1

INSERT INTO Языки 
VALUES (@last, @name, @group, @sign_system)
END



ALTER PROCEDURE ReducePopulation
AS 
BEGIN
UPDATE Страны
SET [Количество жителей] = [Количество жителей] * 0.97
RETURN @@ROWCOUNT
END

SELECT *
FROM Страны


CREATE PROCEDURE AddCountry (@name nchar(25), @continent nchar(25), @capital nchar(25), @number nchar(25))
AS
BEGIN
DECLARE @id int
SET @id = (SELECT MAX(Код)
			FROM Страны) + 1
INSERT INTO Страны
VALUES (@id, @name, @continent, @capital, @number)
END

ALTER PROCEDURE DeleteEthnical (@country nchar(25), @lang nchar(25))
AS
BEGIN
DECLARE @country_id int, @lang_id int
SELECT @country_id = Код
FROM Страны
WHERE Название = @country
SELECT @lang_id = Код
FROM Языки
WHERE Название = @lang

DELETE FROM ЭтническийСостав
WHERE Страна = @country_id AND Язык = @lang_id
END

select * from ЭтническийСостав

SELECT * FROM Страны
SELECT * FROM Языки

ExEC DeleteEthnical 'Канада', 'Французский'

CREATE PROCEDURE DeleteLanguage (@name nchar(25))
AS
BEGIN
DECLARE @lang_code int
SELECT @lang_code = Код
FROM Языки
WHERE Название = @name
IF EXISTS (SELECT * FROM ЭтническийСостав
			WHERE Язык = @lang_code)
RETURN 1
ELSE 
	DELETE FROM Языки
	WHERE Название = @name
	IF @@ROWCOUNT != 0 RETURN 0
	ELSE RETURN 2
END


DECLARE @ret int 
EXEC @ret = DeleteLanguage 'Русский'
PRINT @ret

select * from Языки