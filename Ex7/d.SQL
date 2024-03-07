-- d) Liste o nome e o estoque de todos os produtos, no dia 31/12/2022 (Dica: Use "LEFT JOIN").

SELECT 
    P.Nome as 'Nome do Produto',
    COALESCE(SUM(CASE WHEN CONVERT(date, T.Data) <= '2022-12-31' THEN T.Quantidade ELSE 0 END), 0) AS 'Estoque'
FROM 
    Produto P
LEFT JOIN 
    Transacao T ON P.IdProduto = T.IdProduto
GROUP BY 
    P.Nome
ORDER BY 
	P.Nome;

-- INSIRA SEU SQL AQUI ⬆⬆⬆