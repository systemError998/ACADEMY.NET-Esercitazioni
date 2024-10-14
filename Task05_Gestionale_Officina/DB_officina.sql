CREATE DATABASE Task05_GestionaleOfficina
USE Task05_GestionaleOfficina

CREATE TABLE Cliente(
	clienteID INT PRIMARY KEY IDENTITY,
	codice CHAR(36) NOT NULL DEFAULT NEWID() UNIQUE,
	nome VARCHAR(250) NOT NULL,
	cognome VARCHAR(250) NOT NULL,
	indirizzo VARCHAR(250),
	telefono VARCHAR(250),
	email VARCHAR(250)
)

CREATE TABLE Veicolo(
	veicoloID INT PRIMARY KEY IDENTITY,
	codice CHAR(36) NOT NULL DEFAULT NEWID() UNIQUE,
	targa CHAR(7) NOT NULL,
	modello VARCHAR(250) NOT NULL,
	marca VARCHAR(50) NOT NULL,
	annoImmatricolazione INT,
	prezzoIntervento DECIMAL(10,2),
	statoIntervento VARCHAR(250) CHECK (statoIntervento IN ('In corso','Completato','Da fare')),
	dataIngresso DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
	clienteRIF INTEGER,
	FOREIGN KEY(clienteRIF) REFERENCES Cliente(clienteID) ON DELETE CASCADE /*NON DIMENTICARE MAI*/
)

INSERT INTO Cliente (nome, cognome, indirizzo, telefono, email)
VALUES
('Mario', 'Rossi', 'Via Roma 1, Milano', '3331234567', 'mario.rossi@email.com'),
('Luca', 'Bianchi', 'Via Milano 45, Torino', '3339876543', 'luca.bianchi@email.com'),
('Giulia', 'Verdi', 'Via Napoli 12, Roma', '3335432167', 'giulia.verdi@email.com'),
('Marco', 'Neri', 'Via Firenze 78, Firenze', '3331122334', 'marco.neri@email.com'),
('Sara', 'Gialli', 'Via Venezia 22, Genova', '3335566778', 'sara.gialli@email.com'),
('Anna', 'Rossi', 'Via Torino 90, Milano', '3339988776', 'anna.rossi@email.com'),
('Davide', 'Bianchi', 'Via Palermo 30, Napoli', '3336655442', 'davide.bianchi@email.com'),
('Chiara', 'Esposito', 'Via Trieste 5, Bari', '3337755332', 'chiara.esposito@email.com'),
('Paolo', 'Martini', 'Via Siena 19, Bologna', '3333322111', 'paolo.martini@email.com'),
('Laura', 'Guerra', 'Via Pisa 88, Verona', '3332233445', 'laura.guerra@email.com');

INSERT INTO Veicolo (targa, modello, marca, annoImmatricolazione, prezzoIntervento, statoIntervento, clienteRIF)
VALUES
('AB123CD', 'Fiesta', 'Ford', 2015, 300.00, 'In corso', 1),
('EF456GH', 'Golf', 'Volkswagen', 2017, 450.00, 'Completato', 2),
('IJ789KL', 'Civic', 'Honda', 2016, 500.00, 'In corso', 3),
('MN012OP', 'Clio', 'Renault', 2018, 250.00, 'Da fare', 4),
('QR345ST', 'Astra', 'Opel', 2019, 600.00, 'Completato', 5),
('UV678WX', 'Panda', 'Fiat', 2020, 150.00, 'Da fare', 6),
('YZ901AB', 'C3', 'Citroen', 2018, 350.00, 'In corso', 7),
('CD234EF', 'Serie 1', 'BMW', 2017, 700.00, 'Completato', 8),
('GH567IJ', 'Focus', 'Ford', 2016, 400.00, 'Da fare', 9),
('KL890MN', 'A4', 'Audi', 2015, 800.00, 'In corso', 10),
('OP123QR', 'Qashqai', 'Nissan', 2021, 550.00, 'Completato', 1),
('ST456UV', '500', 'Fiat', 2022, 300.00, 'In corso', 2),
('WX789YZ', 'Leon', 'Seat', 2019, 450.00, 'Completato', 3),
('AB012CD', 'Yaris', 'Toyota', 2018, 500.00, 'Da fare', 4),
('EF345GH', 'Octavia', 'Skoda', 2020, 600.00, 'In corso', 5);

SELECT *
	FROM Cliente 
	JOIN Veicolo ON Cliente.clienteID = Veicolo.clienteRIF