CREATE DATABASE simulado_saep;

USE simulado_saep;


CREATE TABLE carros (
    id_carro INT AUTO_INCREMENT PRIMARY KEY,
    modelo_carro VARCHAR(100) NOT NULL,
    ano_carro INT NOT NULL,
    avarias TEXT,
    valor_carro DOUBLE NOT NULL,
    cor VARCHAR(50),
    placa VARCHAR(20) UNIQUE,
    chassi VARCHAR(50) UNIQUE,
    tipo_combustivel VARCHAR(30),
    qaunt_portas INT,
    max_velocidade DOUBLE,
    importado BOOLEAN DEFAULT FALSE,
    potencia INT,
    km_rodados DOUBLE
);

select * from carros;