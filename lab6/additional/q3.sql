-- Create a procedure to display 20% discount amount on each order provided order 
-- has at least five items.

set serveroutput on;
CREATE OR REPLACE PROCEDURE apply_discount
AS
BEGIN
    FOR order_rec IN (SELECT order#, COUNT(item#) AS item_count
                     FROM order_items
                     GROUP BY order#
                     HAVING COUNT(item#) >= 5)
    LOOP
        DBMS_OUTPUT.PUT_LINE('Order ' || order_rec.order# || ' is eligible for a 20% discount.');

        DECLARE
            v_order_amount NUMBER;
            v_discount_amount NUMBER;
        BEGIN
            SELECT ordamt INTO v_order_amount
            FROM orders
            WHERE order# = order_rec.order#;

            v_discount_amount := 0.20 * v_order_amount;
            DBMS_OUTPUT.PUT_LINE('Discount Amount: ' || v_discount_amount);
        END;
    END LOOP;
END apply_discount;
/


execute apply_discount;




        

