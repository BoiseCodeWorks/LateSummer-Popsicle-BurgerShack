CREATE TABLE IF NOT EXISTS burgers(
    id int NOT NULL AUTO_INCREMENT,
    name VARCHAR(255) NOT NULL,
    description VARCHAR(255),
    price decimal(6,2),
    PRIMARY KEY(id) 
);

