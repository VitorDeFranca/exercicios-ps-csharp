-- c) Liste as unidades de medida e a quantidade de produtos que existem para cada uma.

SELECT p.UnidadeMedida as 'Unidade de Medida', Count(p.UnidadeMedida) as 'Quantidade' FROM dbo.Produto p
GROUP BY p.UnidadeMedida
ORDER BY Count(p.UnidadeMedida) DESC;

-- INSIRA SEU SQL AQUI ⬆⬆⬆