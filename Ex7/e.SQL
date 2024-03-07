-- e) Liste o nome, o estoque mínimo e o estoque atual de todos os produtos, cujo estoque atual está abaixo do estoque mínimo (Dica: Use "HAVING").

SELECT 
    p.Nome AS 'Nome do Produto',
    p.EstoqueMinimo AS 'Estoque Mínimo',
    COALESCE(SUM(t.Quantidade), 0) AS 'Estoque Atual'
FROM 
    dbo.Produto p
LEFT JOIN 
    Transacao t ON p.IdProduto = t.IdProduto
GROUP BY 
    p.Nome, p.EstoqueMinimo
HAVING 
    COALESCE(SUM(t.Quantidade), 0) < P.EstoqueMinimo
ORDER BY [Estoque Atual] DESC;


-- INSIRA SEU SQL AQUI ⬆⬆⬆