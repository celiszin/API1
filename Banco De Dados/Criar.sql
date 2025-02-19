CREATE DATABASE IF NOT EXISTS yugioh;
USE yugioh;

CREATE TABLE IF NOT EXISTS tipos_cartas (
	tipo_carta_id INT UNSIGNED NOT NULL AUTO_INCREMENT,
    tipo_carta_nome VARCHAR(50) NOT NULL UNIQUE,
    tipo_carta_cor VARCHAR(50),
    PRIMARY KEY(tipo_carta_id)
);

CREATE TABLE IF NOT EXISTS elementos (
	elemento_id INT UNSIGNED NOT NULL AUTO_INCREMENT,
    elemento_nome VARCHAR(50) NOT NULL UNIQUE,
    PRIMARY KEY (elemento_id)
);

CREATE TABLE IF NOT EXISTS niveis (
	nivel_id INT UNSIGNED NOT NULL AUTO_INCREMENT,
    nivel_nome VARCHAR(50) NOT NULL UNIQUE,
    PRIMARY KEY (nivel_id)
);

CREATE TABLE IF NOT EXISTS cartas (
    carta_id INT UNSIGNED NOT NULL AUTO_INCREMENT,
	carta_numero INT UNSIGNED NOT NULL,
    carta_nome VARCHAR(50) NOT NULL UNIQUE,
    carta_descricao VARCHAR(1000),
    carta_imagem VARCHAR(200),
    tipo_carta_id INT NOT NULL,
    elemento_id INT NOT NULL,
    nivel_id INT NOT NULL,
    PRIMARY KEY (carta_id),
    FOREIGN KEY (tipo_carta_id) REFERENCES tipos_cartas(tipo_carta_id),
    FOREIGN KEY (elemento_id) REFERENCES elementos(elemento_id),
    FOREIGN KEY (nivel_id) REFERENCES niveis(nivel_id),
);


 




