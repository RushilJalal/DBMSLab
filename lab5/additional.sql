SELECT cname
FROM CUSTOMER
WHERE cust# NOT IN (SELECT cust# FROM ORDERS);




SELECT cname
FROM CUSTOMER
WHERE cust# = (SELECT cust# FROM ORDERS GROUP BY cust# ORDER BY SUM(ordamt) DESC FETCH FIRST 1 ROW ONLY);



SELECT *
FROM ORDERS
WHERE order# NOT IN (SELECT order# FROM SHIPMENT);



SELECT item#
FROM ITEM
WHERE item# NOT IN (SELECT item# FROM ORDER_ITEMS);



SELECT item#
FROM ORDER_ITEMS
GROUP BY item#
ORDER BY COUNT(DISTINCT cust#) DESC FETCH FIRST 1 ROW ONLY;



SELECT *
FROM ORDERS
WHERE order# NOT IN (SELECT order# FROM SHIPMENT WHERE shipdate = TO_DATE('YourDate', 'YYYY-MM-DD')); -- Replace 'YourDate' with the desired date



SELECT cname
FROM CUSTOMER
WHERE cust# IN (
    SELECT s1.cust#
    FROM SHIPMENT s1
    WHERE shipdate = TO_DATE('YourDate1', 'YYYY-MM-DD') -- Replace 'YourDate1' with the first specified date
    INTERSECT
    SELECT s2.cust#
    FROM SHIPMENT s2
    WHERE shipdate = TO_DATE('YourDate2', 'YYYY-MM-DD') -- Replace 'YourDate2' with the second specified date
);



SELECT cname
FROM CUSTOMER
WHERE cust# IN (
    SELECT s.cust#
    FROM SHIPMENT s
    GROUP BY s.cust#
    HAVING COUNT(DISTINCT warehouse#) = 1
);




SELECT cname
FROM CUSTOMER
WHERE cust# IN (
    SELECT cust#
    FROM ORDERS
    GROUP BY cust#
    ORDER BY COUNT(order#) DESC FETCH FIRST 1 ROW ONLY
);
