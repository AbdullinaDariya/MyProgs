SELECT product_name, canegory_name
FROM Products p LEFT JOIN Info i
ON p.product_id = i.product_id
LEFT JOIN Categories c
ON i.category_id = c.category_id;