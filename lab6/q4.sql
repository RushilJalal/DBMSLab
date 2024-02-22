set serveroutput on;
CREATE OR REPLACE PROCEDURE DisplayTotalDamageByDriverAndYear(
    p_driver_id IN VARCHAR2,
    p_year IN INT
)
IS
    total_damage INT;
BEGIN
    SELECT SUM(damage_amount) INTO total_damage
    FROM PARTICIPATED p
    WHERE p.driver_id# = p_driver_id
      AND EXTRACT(YEAR FROM (SELECT accd_date FROM ACCIDENT a WHERE a.report_number = p.report_number)) = p_year;

    DBMS_OUTPUT.PUT_LINE('Total Damage for Driver ' || p_driver_id || ' in ' || p_year || ': ' || total_damage);
END DisplayTotalDamageByDriverAndYear;
/

-- BEGIN
--     DisplayTotalDamageByDriverAndYear('2', 2024);
-- END;
-- /