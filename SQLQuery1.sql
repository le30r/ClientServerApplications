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
SELECT * FROM Ётнический—остав





