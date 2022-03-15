select —трана, COUNT(язык)
from Ётнический—остав
group by —трана, √од
having COUNT(язык) >= 2


CREATE VIEW vGroupedCountries
AS
select —трана, язык
FROM Ётнический—остав
GROUP BY —трана, язык


SELECT AVG(„исленность)
FROM Ётнический—остав


BEGIN TRAN 
UPDATE Ётнический—остав
SET „исленность = „исленность + 1100 
WHERE —трана IN (select —трана
				FROM vGroupedCountries
				GROUP BY —трана
				HAVING COUNT(язык) >= 2)
COMMIT TRAN
ROLLBACK TRAN


SELECT —трана, язык, √од, „исленность
FROM Ётнический—остав JOIN —траны ON —траны. од = —трана JOIN языки ON языки. од = язык
WHERE языки.Ќазвание = 'украинский' AND —траны.Ќазвание = '–осси€'

INSERT INTO языки ( од, Ќазвание, [языкова€ группа], [¬ид знаковой системы])
VALUES (@@IDENTITY + 1, 'май€', 'май€йские', 'письмо май€')




CREATE PROCEDURE addNewCountry (@name nchar(25), @group nchar(25), @sign_system nchar(25)) 
AS
BEGIN 
DECLARE @last int
SET @last = (SELECT MAX( од)
			FROM языки) + 1

INSERT INTO языки 
VALUES (@last, @name, @group, @sign_system)
END

