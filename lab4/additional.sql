--a)
SELECT DISTINCT c.cname
FROM
    CUSTOMER c
    JOIN ORDERS o ON c.cust# = o.cust#
    JOIN ORDER_ITEMS oi ON o.order# = oi.order#
    JOIN ITEM i ON oi.item# = i.item#
WHERE
    o.odate = TO_DATE('2015-09-05', 'YYYY-MM-DD');

--b)
SELECT
    o.order#,
    COUNT(oi.item#) AS "Total Items"
FROM
    ORDERS o
    JOIN ORDER_ITEMS oi ON o.order# = oi.order#
GROUP BY
    o.order#;

--c)
SELECT
    o.order#,
    COUNT(oi.item#) AS "Total Items"
FROM
    ORDERS o
    JOIN ORDER_ITEMS oi ON o.order# = oi.order#
GROUP BY
    o.order#
ORDER BY
    COUNT(oi.item#) DESC
FETCH FIRST 1 ROW ONLY;

--d)
SELECT
    s.shipdate
FROM
    SHIPMENT s
GROUP BY
    s.shipdate
ORDER BY
    COUNT(s.order#) DESC
FETCH FIRST 1 ROW ONLY;


--f)
SELECT DISTINCT o.order#
FROM
    ORDERS o
    JOIN SHIPMENT s ON o.order# = s.order#
    JOIN WAREHOUSE w ON s.warehouse# = w.warehouse#
WHERE
    w.city = 'YourCity'; -- Replace 'YourCity' with the desired city

--g)

SELECT c.cname
FROM
    CUSTOMER c
WHERE
    SUBSTR(c.cname, INSTR(c.cname, ' ') + 1) = 'YourSurname'; -- Replace 'YourSurname' with the desired surname

--h)
SELECT
    c.cname,
    SUM(o.ordamt) AS "Total Order Amount"
FROM
    CUSTOMER c
    JOIN ORDERS o ON c.cust# = o.cust#
GROUP BY
    c.cname
ORDER BY
    "Total Order Amount" DESC;

--i)
SELECT DISTINCT c.cname
FROM
    CUSTOMER c
    JOIN ORDERS o ON c.cust# = o.cust#
    JOIN SHIPMENT s ON o.order# = s.order#
WHERE
    o.odate = TO_DATE('YourDate', 'YYYY-MM-DD') -- Replace 'YourDate' with the desired date
GROUP BY
    c.cname
HAVING
    COUNT(DISTINCT o.order#) >= 3;
