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


SELECT ������, ����, ���, �����������
FROM ���������������� JOIN ������ ON ������.��� = ������ JOIN ����� ON �����.��� = ����
WHERE �����.�������� = '����������' AND ������.�������� = '������'

INSERT INTO ����� (���, ��������, [�������� ������], [��� �������� �������])
VALUES (@@IDENTITY + 1, '����', '���������', '������ ����')




CREATE PROCEDURE addNewCountry (@name nchar(25), @group nchar(25), @sign_system nchar(25)) 
AS
BEGIN 
DECLARE @last int
SET @last = (SELECT MAX(���)
			FROM �����) + 1

INSERT INTO ����� 
VALUES (@last, @name, @group, @sign_system)
END



ALTER PROCEDURE ReducePopulation
AS 
BEGIN
UPDATE ������
SET [���������� �������] = [���������� �������] * 0.97
RETURN @@ROWCOUNT
END

SELECT *
FROM ������


CREATE PROCEDURE AddCountry (@name nchar(25), @continent nchar(25), @capital nchar(25), @number nchar(25))
AS
BEGIN
DECLARE @id int
SET @id = (SELECT MAX(���)
			FROM ������) + 1
INSERT INTO ������
VALUES (@id, @name, @continent, @capital, @number)
END