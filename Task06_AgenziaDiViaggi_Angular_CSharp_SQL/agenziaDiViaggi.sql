CREATE DATABASE Agenzia_Viaggi_La_Perla_Nera
USE Agenzia_Viaggi_La_Perla_Nera

CREATE TABLE Destinazione(
	destinazioneID INT PRIMARY KEY IDENTITY,
	destinazioneCod CHAR(36) NOT NULL DEFAULT NEWID(),
	nome VARCHAR(255) NOT NULL,
	descrizione TEXT,
	paese VARCHAR(255) NOT NULL, 
	copertina VARCHAR(255)
)

CREATE TABLE Pacchetto_Vacanza(
	pacchettoID INT PRIMARY KEY IDENTITY,
	pacchettoCOD CHAR(36) NOT NULL DEFAULT NEWID(),
	nome VARCHAR(255) NOT NULL,
	prezzo INT NOT NULL,
	CONSTRAINT Chk_Prezzo CHECK(prezzo > 0),
	durata INT NOT NULL,
	CONSTRAINT Chk_Durata CHECK(durata > 0),
	data_inizio DATE NOT NULL,
	data_fine DATE NOT NULL,
	CONSTRAINT Chk_Data CHECK (data_fine >= data_inizio)
)

CREATE TABLE Destinazione_Pacchetto_Vacanza(
	Destinazione_Pacchetto_VacanzaID INT PRIMARY KEY IDENTITY,
	destinazioneRIF INT,
	FOREIGN KEY (destinazioneRIF) REFERENCES Destinazione(destinazioneID) ON DELETE CASCADE,
	pacchetto_vacanzaRIF INT,
	FOREIGN KEY (Pacchetto_VacanzaRIF) REFERENCES Pacchetto_Vacanza(pacchettoID) ON DELETE CASCADE,
)

CREATE TABLE Recensione(
	recensioneID INT PRIMARY KEY IDENTITY,
	recensioneCod CHAR(36) NOT NULL DEFAULT NEWID(),
	nomeUtente VARCHAR(255) NOT NULL,
	voto INT,
	CHECK (voto >= 1 AND voto <= 5),
	commento TEXT,
	data_recensione DATETIME NOT NULL DEFAULT GETDATE(), -- || DATE NOT NULL DEFAULT CAST(GETDATE() AS DATE) => solo la data
	pacchetto_vacanzaRIF INT,
	FOREIGN KEY (pacchetto_vacanzaRIF) REFERENCES Pacchetto_Vacanza(pacchettoID) ON DELETE CASCADE
)

INSERT INTO Destinazione (nome, descrizione, paese, copertina)
VALUES
('Roma', 'La capitale italiana, famosa per il Colosseo e il Vaticano.', 'Italia', 'https://tourismmedia.italia.it/is/image/mitur/20220127150143-colosseo-roma-lazio-shutterstock-756032350?wid=1600&hei=900&fit=constrain,1&fmt=webp'),
('Parigi', 'La città delle luci, famosa per la Torre Eiffel.', 'Francia', 'https://www.aviontourism.com/images/1260-1260-fix/0c4d1ff2-dc66-49ce-a15e-cbe6e19b9b5e'),
('New York', 'La città che non dorme mai, con la Statua della Libertà.', 'Stati Uniti', 'https://elefanteviaggi.com/wp-content/uploads/2023/10/One-day-in-New-York-USA-NYC-day-trip-itinerary.jpg'),
('Tokyo', 'Una città tecnologica con tradizioni antiche.', 'Giappone', 'https://citygame.com/wp-content/blogs.dir/1/files/sites/37/2023/02/City-Game-Tokyo-e1677225958158-1920x1080.jpg'),
('Londra', 'Famosa per il Big Ben e la cultura britannica.', 'Regno Unito', 'https://media.cdn.facile.it/traveleasy/contenuti/577/1-600.jpg'),
('Sydney', 'Casa dell’Opera di Sydney e delle bellissime spiagge.', 'Australia', 'https://media.tatler.com/photos/6141d37b9ce9874a3e40107d/16:9/w_2560%2Cc_limit/social_crop_sydney_opera_house_gettyimages-869714270.jpg'),
('Rio de Janeiro', 'Famosa per il Carnevale e la statua del Cristo Redentore.', 'Brasile', 'https://www.bioedilprogetti.com/wp-content/uploads/2019/04/rio-de-janeiro-capitale-architettura-unesco.jpg'),
('Barcellona', 'Famosa per le opere di Gaudì come la Sagrada Familia.', 'Spagna', 'https://siviaggia.it/wp-content/uploads/sites/2/2023/07/tour-barcellona.jpg'),
('Berlino', 'Città storica con monumenti della seconda guerra mondiale.', 'Germania', 'https://images.musement.com/cover/0001/06/berlin_header-5512.jpeg'),
('Dubai', 'Famosa per i grattacieli futuristici e i centri commerciali di lusso.', 'Emirati Arabi Uniti', 'https://www.dubai.it/wp-content/uploads/sites/32/dubai-marina-hd.jpg');

INSERT INTO Pacchetto_Vacanza (nome, prezzo, durata, data_inizio, data_fine)
VALUES
('Roma Antica', 500, 7, '2024-06-01', '2024-06-08'),
('Parigi Romantica', 700, 5, '2024-07-10', '2024-07-15'),
('New York Avventura', 1000, 10, '2024-09-01', '2024-09-11'),
('Tokyo Esplorazione', 900, 8, '2024-04-01', '2024-04-09'),
('Londra Classica', 800, 6, '2024-05-15', '2024-05-21'),
('Sydney Mare e Cultura', 1200, 10, '2024-08-10', '2024-08-20'),
('Rio Festa', 600, 7, '2024-03-01', '2024-03-08'),
('Barcellona Arte e Architettura', 750, 5, '2024-10-05', '2024-10-10'),
('Berlino Storica', 650, 6, '2024-11-01', '2024-11-07'),
('Dubai Lusso', 1500, 5, '2024-12-01', '2024-12-06');

INSERT INTO Recensione (nomeUtente, voto, commento, data_recensione, pacchetto_vacanzaRIF)
VALUES
('Mario Rossi', 5, 'Roma è sempre magnifica! Ogni angolo una sorpresa. Consiglio vivamente.', 2024-06-09, 1)


INSERT INTO Recensione (nomeUtente, voto, commento, data_recensione, pacchetto_vacanzaRIF)
VALUES
('Giulia Bianchi', 4, 'Parigi era incantevole, ma la guida sembrava volerci portare ovunque tranne che alla Torre Eiffel. Che fortuna!', 2024-07-16, 2),
('Luca Verdi', 5, 'New York non ha deluso! La Statua della Libertà è più piccola dal vivo, ma lo skyline è impressionante.', 2024-09-12, 3),
('Alessandra Neri', 4, 'Tokyo è straordinaria! Il mio unico rimpianto è che non mi sono trasformata in un personaggio anime.', 2024-04-10, 4),
('Carlo Blu', 5, 'Londra è stata un sogno. Pioggia? Certo, ma fa parte del pacchetto, no?', 2024-05-22, 5),
('Francesca Gialli', 2, 'Sydney era bellissima, peccato che l’Opera House fosse “in manutenzione”. Esattamente come nel mio ultimo viaggio lì. Sarà un caso?', 2024-08-21, 6),
('Paolo Grigio', 1, 'Rio durante il Carnevale? Troppo rumore, troppa gente. Perché mai pensavo che sarebbe stato tranquillo?!', 2024-03-09, 7),
('Sofia Viola', 2, 'Barcellona è magnifica, ma la guida sembrava confondere Gaudí con Picasso. Avrei potuto fare di meglio con Google.', 2024-10-11, 8),
('Andrea Arancio', 3, 'Berlino è affascinante. Però il tour incentrato sulle "meraviglie della pioggia incessante" potevano risparmiarselo.', 2024-11-08, 9),
('Elena Rosa', 1, 'Dubai? Lusso ovunque! Peccato che nel mio hotel l’aria condizionata funzionasse solo a temperature “desertiche”. Esperienza autentica, immagino.', 2024-12-07, 10);

INSERT INTO Destinazione_Pacchetto_Vacanza (destinazioneRIF, pacchetto_vacanzaRIF)
VALUES
(1, 1), -- Roma Antica -> Roma
(2, 2), -- Parigi Romantica -> Parigi
(3, 3), -- New York Avventura -> New York
(4, 4), -- Tokyo Esplorazione -> Tokyo
(5, 5), -- Londra Classica -> Londra
(6, 6), -- Sydney Mare e Cultura -> Sydney
(7, 7), -- Rio Festa -> Rio de Janeiro
(8, 8), -- Barcellona Arte e Architettura -> Barcellona
(9, 9), -- Berlino Storica -> Berlino
(10, 10); -- Dubai Lusso -> Dubai


SELECT * FROM Destinazione
SELECT * FROM Pacchetto_Vacanza
SELECT * FROM Recensione


CREATE VIEW VistaCompleta AS
	SELECT 
		Destinazione.nome AS Nome_destinazione, descrizione,paese,copertina, 
		Pacchetto_Vacanza.nome AS Nome_pacchetto, prezzo,durata,data_inizio,data_fine,destinazioneRIF,
		Recensione.nomeUtente AS Utente_recensione, voto, commento, data_recensione, pacchetto_vacanzaRIF
			FROM Destinazione
			JOIN Pacchetto_Vacanza ON Destinazione.destinazioneID = Pacchetto_Vacanza.destinazioneRIF
			JOIN Recensione ON Pacchetto_Vacanza.pacchettoID = Recensione.pacchetto_vacanzaRIF

SELECT * FROM VistaCompleta


-- ALTER TABLE Recensione ADD CONSTRAINT Chk_Data_Recensione CHECK (data_recensione > Pacchetto_Vacanza.data_fine) 
-- :C NUN SE PO FA 

--CREATE TRIGGER trg_CheckDataRecensione
--ON Recensione
--FOR INSERT, UPDATE
--AS
--BEGIN
--    IF EXISTS (
--        SELECT 1
--        FROM inserted i
--        JOIN Pacchetto_Vacanza pv
--        ON i.id_pacchetto_vacanza = pv.id_pacchetto_vacanza  -- Assumendo una chiave esterna che collega le due tabelle
--        WHERE i.data_recensione <= pv.data_fine
--    )
--    BEGIN
--        -- Se la condizione è violata, viene generato un errore e l'operazione è annullata
--        RAISERROR ('La data della recensione deve essere successiva alla data di fine del pacchetto vacanza.', 16, 1);
--        ROLLBACK TRANSACTION;
--    END
--END;