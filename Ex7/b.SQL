-- b) Liste o nome e a unidade de medida de todos os produtos, cuja unidade de medida é em gramas ou em unidades.

SELECT p.Nome as 'Nome do Produto', p.UnidadeMedida as 'Unidade de Medida' FROM dbo.Produto p
WHERE p.UnidadeMedida = 'g' or p.UnidadeMedida = 'un';

-- INSIRA SEU SQL AQUI ⬆⬆⬆