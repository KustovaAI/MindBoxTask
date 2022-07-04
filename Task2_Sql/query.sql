-- Так как в задании это не указано, рассмотрим два случая строения таблиц.

-- Первый случай: таблица продуктов содержит 3 колонки: id, product_name, category_id (id категории, соответствующей данному продукту).
-- А таблица с категориями содержит 2 колонки: id и category_name.

-- Второй случай: таблица продуктов содержит 2 колонки: product_name, category_name (имя категории, соответствующей данному продукту).
-- Таблица с категориями содержит 1 колонку: category_name.

-- Случай, когда в таблицах продуктов и их категорий присутствуют их уникальные идентификаторы

SELECT 
    p.product_name product, c.category_name category 
        FROM products p
    LEFT JOIN categories c ON p.category_id = c.id

-- Второй случай, когда в таблицах продуктов и их категорий нет уникальных идентификаторов

SELECT 
    p.product_name product, c.category_name category 
        FROM products p
    LEFT JOIN categories c ON p.category_name = c.category_name