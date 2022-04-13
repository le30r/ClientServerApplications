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

ALTER PROCEDURE DeleteEthnical (@country nchar(25), @lang nchar(25))
AS
BEGIN
DECLARE @country_id int, @lang_id int
SELECT @country_id = ���
FROM ������
WHERE �������� = @country
SELECT @lang_id = ���
FROM �����
WHERE �������� = @lang

DELETE FROM ����������������
WHERE ������ = @country_id AND ���� = @lang_id
END

select * from ����������������

SELECT * FROM ������
SELECT * FROM �����

ExEC DeleteEthnical '������', '�����������'

CREATE PROCEDURE DeleteLanguage (@name nchar(25))
AS
BEGIN
DECLARE @lang_code int
SELECT @lang_code = ���
FROM �����
WHERE �������� = @name
IF EXISTS (SELECT * FROM ����������������
			WHERE ���� = @lang_code)
RETURN 1
ELSE 
	DELETE FROM �����
	WHERE �������� = @name
	IF @@ROWCOUNT != 0 RETURN 0
	ELSE RETURN 2
END


DECLARE @ret int 
EXEC @ret = DeleteLanguage '�������'
PRINT @ret

select * from �����