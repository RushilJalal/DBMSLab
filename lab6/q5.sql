set serveroutput on;

CREATE OR REPLACE PROCEDURE DisplayAccidentInfoByLocation(
    p_location IN VARCHAR2
)
IS
BEGIN
    FOR accident_rec IN (
        SELECT *
        FROM ACCIDENT
        WHERE location = p_location
    )
    LOOP
        DBMS_OUTPUT.PUT_LINE('Accident Report Number: ' || accident_rec.report_number);
        DBMS_OUTPUT.PUT_LINE('Accident Date: ' || TO_CHAR(accident_rec.accd_date, 'YYYY-MM-DD'));
        DBMS_OUTPUT.PUT_LINE('Location: ' || accident_rec.location);
        DBMS_OUTPUT.NEW_LINE;
    END LOOP;
END DisplayAccidentInfoByLocation;
/

   
   
   
execute DisplayAccidentInfoByLocation('Lucknow'); 

