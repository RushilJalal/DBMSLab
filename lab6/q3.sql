set serveroutput on;

CREATE OR REPLACE FUNCTION GetTotalAccidentsByYear(
    p_year IN INT
) RETURN INT
IS
    total_accidents INT;
BEGIN
    SELECT COUNT(*) INTO total_accidents
    FROM ACCIDENT
    WHERE EXTRACT(YEAR FROM accd_date) = p_year;

    RETURN total_accidents;
END GetTotalAccidentsByYear;
/


DECLARE
    accidents_count INT;
BEGIN
    accidents_count := GetTotalAccidentsByYear(2008);
    DBMS_OUTPUT.PUT_LINE('Total Accidents in 2008: ' || accidents_count);
END;
/