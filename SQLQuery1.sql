select ������, COUNT(����)
from ����������������
group by ������, ���
having COUNT(����) >= 2


CREATE VIEW vGroupedCountries
AS
select ������, ����
FROM ����������������
GROUP BY ������, ����


SELECT AVG(�����������)
FROM ����������������


BEGIN TRAN 
UPDATE ����������������
SET ����������� = ����������� + 1100 
WHERE ������ IN (select ������
				FROM vGroupedCountries
				GROUP BY ������
				HAVING COUNT(����) >= 2)
COMMIT TRAN
ROLLBACK TRAN
SELECT * FROM ����������������





