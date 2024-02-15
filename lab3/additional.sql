CREATE TABLE CUSTOMER (
    cust# INT PRIMARY KEY,
    cname VARCHAR(50),
    city VARCHAR(30)
);

CREATE TABLE ORDERS (
    order# INT PRIMARY KEY,
    odate DATE,
    cust# INT,
    ordamt INT,
    FOREIGN KEY (cust#) REFERENCES CUSTOMER(cust#)
);

CREATE TABLE ITEM (
    item# INT PRIMARY KEY,
    unitprice INT
);

CREATE TABLE ORDER_ITEMS (
    order# INT,
    qty INT,
    item# INT,
    PRIMARY KEY (order#, item#),
    FOREIGN KEY (order#) REFERENCES ORDERS(order#),
    FOREIGN KEY (item#) REFERENCES ITEM(item#)
);

CREATE TABLE SHIPMENT (
    order# INT,
    warehouse# INT,
    shipdate DATE,
    PRIMARY KEY (order#),
    FOREIGN KEY (order#) REFERENCES ORDERS(order#)
);

CREATE TABLE WAREHOUSE (
    warehouse# INT PRIMARY KEY,
    city VARCHAR(30)
);


