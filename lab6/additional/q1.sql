CREATE OR REPLACE FUNCTION withdraw_money(
    p_account_number IN VARCHAR2,
    p_withdrawal_amount IN NUMBER
) RETURN NUMBER
IS
    v_current_balance NUMBER;
    v_new_balance NUMBER;
BEGIN
    SELECT balance INTO v_current_balance
    FROM bank_account
    WHERE account_number = p_account_number;

    IF v_current_balance >= p_withdrawal_amount THEN
        v_new_balance := v_current_balance - p_withdrawal_amount;

        UPDATE bank_account
        SET balance = v_new_balance
        WHERE account_number = p_account_number;

        RETURN v_new_balance;
    ELSE
        RETURN -1;
    END IF;
END withdraw_money;
/

-- DECLARE
--     v_new_balance NUMBER;
-- BEGIN
--     v_new_balance := withdraw_money('123456789', 100);

--     IF v_new_balance >= 0 THEN
--         DBMS_OUTPUT.PUT_LINE('Withdrawal successful. New balance: ' || v_new_balance);
--     ELSE
--         DBMS_OUTPUT.PUT_LINE('Insufficient funds or account not found.');
--     END IF;
-- END;
-- /

