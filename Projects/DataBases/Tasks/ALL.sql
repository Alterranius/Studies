SELECT SUM(фрахты), customer_id, freight_sum
FROM компаний_заказчиков
JOIN стоимость_фрахтов USING(стоимость_фрахтов_id)
WHERE стоимость_фрахта > ALL (SELECT AVG(стоимость_фрахта)
				FROM стоимость_фрахтов
				)
AND
дата_отгрузки BETWEEN '1996-07-15' and '1996-07-31'
GROUP BY customer_id
ORDER BY SUM(фрахты) DESC
LIMIT 6