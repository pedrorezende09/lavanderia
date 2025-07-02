CREATE DATABASE LavanderiaDB;
USE LavanderiaDB;

CREATE TABLE Servicos (
    id INT AUTO_INCREMENT,
    nome_cliente VARCHAR(100) NOT NULL,
    cpf_cliente VARCHAR(14) NOT NULL UNIQUE,
    tipo_servico VARCHAR(50) NOT NULL,
    peso_roupa_kg DECIMAL(5,2) NOT NULL,
    valor_total DECIMAL(7,2) NOT NULL,
    PRIMARY KEY (id)
);

CREATE USER 'lavanderia_user'@'localhost' IDENTIFIED BY '123';
GRANT SELECT, INSERT, UPDATE, DELETE ON LavanderiaDB.Servicos TO 'lavanderia_user'@'localhost';

SELECT * FROM Servicos;

