CREATE TABLE Vendors (
    Vend_id CHAR(5) PRIMARY KEY,  -- Vendor ID (must be unique)
    Vend_name CHAR(20) NOT NULL,  -- Vendor Name (cannot be blank)
    Vend_address CHAR(20),  -- Address of the vendor
    Vend_city CHAR(20),  -- City
    Vend_state CHAR(2),  -- State (2 letters)
    Vend_zip CHAR(5),  -- ZIP Code
    Vend_commission DECIMAL(7,2),  -- Commission (dollars and cents)
    Vend_bonus DECIMAL(6,2)  -- Bonus (not used yet)
);

