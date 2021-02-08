Задание: В базе данных MS SQL Server есть продукты и категории.
Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов.
Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». 
Если у продукта нет категорий, то его имя все равно должно выводиться.

--Здесь необходимо создание таблиц--
Допустим, есть 3 таблицы:
Info: product_id,category_id
Products: poduct_id, product_name
Categories: catgory_id, category_name

SELECT product_name, canegory_name
FROM Products p LEFT JOIN Info i
ON p.product_id = i.product_id
LEFT JOIN Categories c
ON i.category_id = c.category_id;
