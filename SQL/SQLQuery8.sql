/****** Script do comando SelectTopNRows de SSMS  ******/
--Create
insert into Produto
(
	Nome
	,Descrição
)
VALUES
(
	'Celular'
	,'Motorola Tijolão'
);

--Read
SELECT
*
FROM Produto;


--Update
UPDATE Produto
	SET
		Descrição = 'De Camurça'
		
	WHERE Descrição = 'De Pelo';-- sempre lembrar do WHERE por segurança

--Delete
	DELETE FROM Produto --Sozinho deleta tudo
	WHERE ID = 1; --Deleta um em especifico