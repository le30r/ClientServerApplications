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