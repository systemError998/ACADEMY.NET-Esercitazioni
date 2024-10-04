CREATE DATABASE CentroFitness_EnergiaPura
USE CentroFitness_EnergiaPura

CREATE TABLE Membro(
	membroID INTEGER PRIMARY KEY IDENTITY,
	nome VARCHAR(250) NOT NULL,
	cogn VARCHAR(250) NOT NULL,
	nasc DATE NOT NULL,
	sess VARCHAR(250),
	mail VARCHAR(50) NOT NULL,
	cell VARCHAR(20) NOT NULL,
	abbo DATE,
)

CREATE TABLE Istruttore(
	istruttoreID INTEGER PRIMARY KEY IDENTITY,
	nome VARCHAR(250) NOT NULL,
	cogn VARCHAR(250) NOT NULL,
	spec VARCHAR(250) NOT NULL,
	orar VARCHAR(250) NOT NULL,
	dayz VARCHAR(250) NOT NULL
)

CREATE TABLE Abbonamenti (
	abbonamentoID INTEGER PRIMARY KEY IDENTITY,
	tipo VARCHAR(250) NOT NULL CHECK (tipo IN ('Mensile', 'Trimestrale', 'Annuale')),
	prez DECIMAL(5,2) NOT NULL CHECK (prez IN (39.90, 99.90, 399.90)),
	membroRIF INTEGER NOT NULL,
	FOREIGN KEY(membroRIF) REFERENCES Membro(membroID) ON DELETE CASCADE
);

CREATE TABLE Classe(
	classeID INTEGER PRIMARY KEY NOT NULL IDENTITY,
	tipo VARCHAR(250) NOT NULL CHECK (tipo IN ('Yoga','Pilates','Spinning','Pesi')),
	nome VARCHAR(250) NOT NULL,
	info TEXT,
	orar VARCHAR(250) NOT NULL,
	dayz VARCHAR(250),
	nmax INTEGER NOT NULL CHECK (nmax <= 20) ,
	istruttoreRIF INTEGER,
	FOREIGN KEY(istruttoreRIF) REFERENCES Istruttore(istruttoreID) ON DELETE SET NULL 
)

CREATE TABLE Prenotazione(
	prenotazioneID INTEGER PRIMARY KEY NOT NULL IDENTITY,
	dataPrenot DATETIME NOT NULL,
	membroRIF INTEGER NOT NULL,
	FOREIGN KEY(membroRIF) REFERENCES Membro(membroID) ON DELETE CASCADE,
	classeRIF INTEGER NOT NULL,
	FOREIGN KEY(classeRIF) REFERENCES Classe(classeID) ON DELETE CASCADE
)

CREATE TABLE Attrezzatura(
	attrezzaturaID INTEGER PRIMARY KEY NOT NULL IDENTITY,
	tipo VARCHAR(250) NOT NULL CHECK (tipo IN ('Tapis Roulant','Bici','Pesi')),
	info TEXT,
	acqu DATE NOT NULL,
	stat VARCHAR(250) NOT NULL CHECK (stat IN ('Disponibile','Fuori servizio','In manutenzione')),
	classeRIF INTEGER,
	FOREIGN KEY(classeRIF) REFERENCES Classe(classeID) ON DELETE SET NULL
)

INSERT INTO Membro (nome, cogn, nasc, sess, mail, cell, abbo) VALUES
('Mario', 'Rossi', '1985-05-23', 'M', 'mario.rossi@gmail.com', '3281234567', '2023-01-01'),
('Giulia', 'Bianchi', '1990-07-19', 'F', 'giulia.bianchi@yahoo.com', '3289876543', '2023-02-01'),
('Luca', 'Verdi', '1992-08-30', 'M', 'luca.verdi@libero.it', '3285678943', '2023-03-01'),
('Francesca', 'Esposito', '1988-02-15', 'F', 'francesca.esposito@hotmail.com', '3291234567', '2023-04-01'),
('Giorgio', 'Russo', '1979-11-11', 'M', 'giorgio.russo@fastwebnet.it', '3201239876', '2023-05-01'),
('Sara', 'Ferrari', '1995-12-03', 'F', 'sara.ferrari@gmail.com', '3288765432', '2023-06-01'),
('Alessandro', 'Costa', '1991-03-22', 'M', 'alessandro.costa@libero.it', '3281236547', '2023-07-01'),
('Elena', 'Conti', '1993-09-09', 'F', 'elena.conti@gmail.com', '3291230987', '2023-08-01'),
('Matteo', 'Greco', '1987-01-10', 'M', 'matteo.greco@hotmail.com', '3209876543', '2023-09-01'),
('Chiara', 'Gallo', '1994-04-18', 'F', 'chiara.gallo@outlook.com', '3282345678', '2023-10-01');

INSERT INTO Membro (nome, cogn, nasc, sess, mail, cell, abbo) VALUES
('Giovanni', 'Pace', '1985-05-23', 'M', 'johnnypax@gmail.com', '33432431221', '2018-01-01'),
('Giulio', 'Cerasoli', '1990-07-19', 'F', 'giulioceras@yahoo.com', '3289876589', '2019-02-01'),
('Anna', 'Panna', '1992-08-30', 'M', 'anna.panna@libero.it', '3295678943', '2020-03-01')

INSERT INTO Istruttore (nome, cogn, spec, dayz, orar) VALUES
('Davide', 'Caruso', 'Yoga', 'Lun-Mer-Ven', '9:00-11:00'),
('Martina', 'Romano', 'Pilates', 'Mar-Gio-Sab', '10:00-12:00'),
('Simone', 'Moretti', 'Spinning', 'Lun-Ven', '17:00-19:00'),
('Federica', 'Sanna', 'Pesi', 'Mer-Ven',' 8:00-10:00'),
('Alessia', 'Leone', 'Yoga', 'Lun-Mer',' 15:00-17:00'),
('Giorgio', 'Rizzo', 'Pilates', 'Mar-Ven',' 18:00-20:00'),
('Sabrina', 'Gatti', 'Spinning', 'Lun-Gio',' 13:00-15:00'),
('Marco', 'De Luca', 'Pesi', 'Mer-Sab',' 16:00-18:00'),
('Carla', 'Pini', 'Yoga', 'Mar-Gio-Sab',' 11:00-13:00'),
('Vincenzo', 'Santoro', 'Pilates', 'Lun-Ven',' 12:00-14:00');

INSERT INTO Abbonamenti (tipo, prez, membroRIF) VALUES
('Mensile', 39.90, 1),
('Trimestrale', 99.90, 2),
('Annuale', 399.90, 3),
('Mensile', 39.90, 4),
('Trimestrale', 99.90, 5),
('Annuale', 399.90, 6),
('Mensile', 39.90, 7),
('Trimestrale', 99.90, 8),
('Annuale', 399.90, 9),
('Mensile', 39.90, 10);

INSERT INTO Classe (tipo, nome, info, orar, dayz, nmax, istruttoreRIF) VALUES
('Yoga', 'Yoga Relax', 'Classe di yoga per principianti', '18:00-19:00', 'Lun-Mer', 15, 1),
('Pilates', 'Pilates Base', 'Pilates per rinforzare i muscoli', '9:00-10:00', 'Mar-Gio', 18, 2),
('Spinning', 'Spinning Intenso', 'Spinning per avanzati', '19:00-20:00', 'Lun-Mer-Ven', 20, 3),
('Pesi', 'Pesi Liberi', 'Allenamento con pesi liberi', '17:00-18:00', 'Mar-Gio', 10, 4),
('Yoga', 'Yoga Avanzato', 'Yoga avanzato per esperti', '10:00-11:00', 'Lun-Ven', 12, 5),
('Pilates', 'Pilates Avanzato', 'Pilates avanzato per esperti', '11:00-12:00', 'Mer-Sab', 15, 6),
('Spinning', 'Spinning Cardio', 'Spinning cardio', '18:00-19:00', 'Mar-Ven', 20, 7),
('Pesi', 'Circuito Pesi', 'Circuito con macchine pesi', '16:00-17:00', 'Lun-Gio', 12, 8),
('Yoga', 'Yoga Meditazione', 'Yoga con meditazione', '8:00-9:00', 'Mar-Gio-Sab', 10, 9),
('Spinning', 'Spinning Beginner', 'Spinning per principianti', '20:00-21:00', 'Lun-Ven', 20, 10);

INSERT INTO Prenotazione (dataPrenot, membroRIF, classeRIF) VALUES
('2024-09-01 10:00:00', 1, 1),
('2024-09-02 11:00:00', 2, 2),
('2024-09-03 12:00:00', 3, 3),
('2024-09-04 13:00:00', 4, 4),
('2024-09-05 14:00:00', 5, 5),
('2024-09-06 15:00:00', 6, 6),
('2024-09-07 16:00:00', 7, 7),
('2024-09-08 17:00:00', 8, 8),
('2024-09-09 18:00:00', 9, 9),
('2024-09-10 19:00:00', 10, 10);

INSERT INTO Prenotazione (dataPrenot, membroRIF, classeRIF) VALUES
('2024-09-10 10:00:00', 1, 5)

INSERT INTO Attrezzatura (tipo, info, acqu, stat, classeRIF) VALUES
('Tapis Roulant', 'Tapis roulant professionale con inclinazione', '2023-01-15', 'Disponibile', 1),
('Bici', 'Bici da spinning per allenamenti intensi', '2022-05-10', 'Fuori servizio', 2),
('Pesi', 'Set di manubri da 5 a 20 kg', '2023-03-20', 'In manutenzione', 3),
('Tapis Roulant', 'Tapis roulant pieghevole per uso domestico', '2021-07-25', 'Disponibile', 4),
('Bici', 'Bici stazionaria con monitoraggio della frequenza cardiaca', '2020-10-12', 'Disponibile', 5),
('Pesi', 'Pesi regolabili fino a 50 kg', '2022-08-05', 'Fuori servizio', 6),
('Tapis Roulant', 'Tapis roulant con programmi di allenamento', '2023-02-28', 'In manutenzione', 7),
('Bici', 'Bici da spinning con resistenza regolabile', '2021-11-15', 'Disponibile', 8),
('Pesi', 'Set di kettlebell da 8 a 24 kg', '2023-05-30', 'Disponibile', 9),
('Tapis Roulant', 'Tapis roulant professionale per palestra', '2020-12-20', 'Disponibile', NULL);



--Recupera tutti i membri registrati nel sistema.
SELECT * FROM Membro

--Recupera il nome e il cognome di tutti i membri che hanno un abbonamento mensile.
SELECT nome,cogn
	FROM Membro 
	JOIN Abbonamenti ON Membro.membroID = Abbonamenti.membroRIF
	WHERE Abbonamenti.tipo = 'Mensile'

--Recupera l'elenco delle classi di yoga offerte dal centro fitness.
SELECT * 
	FROM Classe
	WHERE tipo = 'Yoga'

--Recupera il nome e cognome degli istruttori che insegnano Pilates.
SELECT Istruttore.nome,cogn 
	FROM Istruttore
	JOIN Classe ON Istruttore.istruttoreID = Classe.istruttoreRIF
	WHERE Classe.tipo = 'Pilates'

--Recupera i dettagli delle classi programmate per il lunedì.
SELECT * 
	FROM Classe
	WHERE dayz LIKE '%lun%'

--Recupera l'elenco dei membri che hanno prenotato una classe di spinning.
SELECT *
	FROM Membro
	JOIN Prenotazione ON Membro.membroID = Prenotazione.membroRIF
	JOIN Classe ON Prenotazione.classeRIF = Classe.classeID
	WHERE Classe.tipo = 'Spinning'

--Recupera tutte le attrezzature che sono attualmente fuori servizio.
SELECT * 
	FROM Attrezzatura
	WHERE stat = 'fuori servizio'

--Conta il numero di partecipanti per ciascuna classe programmata per il mercoledì.


--Recupera l'elenco degli istruttori disponibili per tenere una lezione il sabato.
SELECT *		
	FROM Istruttore
	WHERE orar LIKE '%sab%'

--Recupera tutti i membri che hanno un abbonamento attivo dal 2023.
SELECT *
	FROM Membro 
	WHERE abbo LIKE '%2023%'

--Trova il numero massimo di partecipanti per tutte le classi di sollevamento pesi.
SELECT nome,nmax
	FROM Classe
	WHERE tipo = 'pesi'

--Recupera le prenotazioni effettuate da un membro specifico.
SELECT *
	FROM Membro
	JOIN Prenotazione ON Membro.membroID = Prenotazione.membroRIF
	WHERE nome = 'Mario' AND cogn = 'Rossi'

--Recupera l'elenco degli istruttori che conducono più di 5 classi alla settimana.
SELECT *
	FROM Istruttore
	JOIN Classe ON Istruttore.istruttoreID = Classe.istruttoreRIF

--Recupera le classi che hanno ancora posti disponibili per nuove prenotazioni.
--Recupera l'elenco dei membri che hanno annullato una prenotazione negli ultimi 30 giorni.
--Recupera tutte le attrezzature acquistate prima del 2022.
--Recupera l'elenco dei membri che hanno prenotato una classe in cui l'istruttore è "Mario Rossi".
--Calcola il numero totale di prenotazioni per ogni classe per un determinato periodo di tempo.
--Trova tutte le classi associate a un'istruttore specifico e i membri che vi hanno partecipato.
--Recupera tutte le attrezzature in manutenzione e il nome degli istruttori che le utilizzano nelle loro classi.


--Alcune View
--Crea una view che mostra l'elenco completo dei membri con il loro nome, cognome e tipo di abbonamento.
CREATE VIEW ElencoMembriConRelativiAbbonamenti AS
	SELECT Membro.nome, cogn , Abbonamenti.tipo
		FROM Membro
		JOIN Abbonamenti ON Membro.membroID = Abbonamenti.membroRIF
DROP VIEW ElencoMembriConRelativiAbbonamenti

SELECT * FROM ElencoMembriConRelativiAbbonamenti

--Crea una view che elenca tutte le classi disponibili con i rispettivi nomi degli istruttori.
CREATE VIEW ClasseConRelativoIstruttore AS
	SELECT Classe.nome AS 'Nome della classe', tipo, Istruttore.nome, cogn
		FROM Classe
		JOIN Istruttore ON Classe.istruttoreRIF = Istruttore.istruttoreID

SELECT * FROM ClasseConRelativoIstruttore		

--Crea una view che mostra le classi prenotate dai membri insieme al nome della classe e alla data di prenotazione.
CREATE VIEW ClassiPrenotateDaiMembri AS
	SELECT Classe.nome AS 'Nome classe', Prenotazione.dataPrenot AS 'Data Prenotazione', Membro.nome, cogn
		FROM Classe 
		JOIN Prenotazione ON CLasse.classeID = Prenotazione.classeRIF
		JOIN Membro ON Prenotazione.membroRIF = Membro.membroID

SELECT * FROM ClassiPrenotateDaiMembri

--Crea una view che elenca tutte le attrezzature attualmente disponibili, con la descrizione e lo stato.
CREATE VIEW AttrezzatureDisponibili AS
	SELECT tipo, info, stat
		FROM Attrezzatura
		WHERE stat = 'Disponibile'

SELECT * FROM AttrezzatureDisponibili

--Crea una view che mostra i membri che hanno prenotato una classe di spinning negli ultimi 30 giorni.
CREATE VIEW ClasseSpinningUltimi30Giorni
	

--Crea una view che elenca gli istruttori con il numero totale di classi che conducono.
CREATE VIEW NumeroClassiPerIstruttore AS
	SELECT COUNT(*) AS Boh
		FROM Istruttore
		JOIN Classe ON Istruttore.istruttoreID = Classe.istruttoreRIF

SELECT * FROM NumeroClassiPerIstruttore

--Crea una view che mostri il nome delle classi e il numero di partecipanti registrati per ciascuna classe.
CREATE VIEW NumeroPartecipantiPerClasse
	

--Crea una view che elenca i membri che hanno un abbonamento attivo insieme alla data di inizio e la data di scadenza.
--Crea una view che mostra l'elenco degli istruttori che conducono classi il lunedì e il venerdì.
CREATE VIEW IstruttoriLunVen AS
	SELECT Istruttore.nome, cogn AS 'Istruttore', Classe.nome AS 'Nome Classe', Classe.dayz AS 'Giorno della settimana'
		FROM Istruttore
		JOIN Classe ON Istruttore.istruttoreID = Classe.istruttoreRIF
		WHERE ((dayz LIKE '%lun%') AND (dayz LIKE '%ven%'))
DROP VIEW IstruttoriLunVen	

SELECT * FROM IstruttoriLunVen

--Crea una view che elenca tutte le attrezzature acquistate nel 2023 insieme al loro stato attuale.
CREATE VIEW Attrezzature2023ConStato AS
	SELECT tipo,acqu,stat
		FROM Attrezzatura
		WHERE acqu LIKE '%2023%'

SELECT * FROM Attrezzature2023ConStato

--Alcune SP
--Scrivi una stored procedure che permette di inserire un nuovo membro nel sistema con tutti i suoi dettagli, 
--come nome, cognome, data di nascita, tipo di abbonamento, ecc.
--CREATE TABLE Membro(
--	membroID INTEGER PRIMARY KEY IDENTITY,
--	nome VARCHAR(250) NOT NULL,
--	cogn VARCHAR(250) NOT NULL,
--	nasc DATE NOT NULL,
--	sess VARCHAR(250),
--	mail VARCHAR(50) NOT NULL,
--	cell VARCHAR(20) NOT NULL,
--	abbo DATE,
--)
CREATE PROCEDURE InsertNewMember
	@Nome VARCHAR(250),
	@Cogn VARCHAR(250),
	@Nasc DATE,
	@Sess VARCHAR(250),
	@Mail VARCHAR(50),
	@Cell VARCHAR(20),
	@Abbo DATE
AS
BEGIN
	INSERT INTO Membro(nome,cogn,nasc,sess,mail,cell,abbo) VALUES
		(@Nome,@Cogn,@Nasc,@Sess,@Mail,@Cell,@Abbo)
END

EXEC InsertNewMember @Nome = 'Gabriele', @Cogn = 'Percoco', @Nasc = '1993-02-04', @Sess = 'M', @Mail = 'gabryperky@live.it', @Cell = '32112345678', @Abbo = '2024-09-23'
SELECT * FROM Membro

--Scrivi una stored procedure per aggiornare lo stato di un'attrezzatura 
--(ad esempio, disponibile, in manutenzione, fuori servizio).
SELECT * FROM Attrezzatura

CREATE PROCEDURE UpdateStatoAttrezzatura
	@AttrezzoID INT,
	@StatoAttr VARCHAR(250)
AS
BEGIN
	BEGIN TRY
		IF @StatoAttr NOT IN ('Disponibile', 'Fuori servizio', 'In manutenzione')
			PRINT 'Stato non valido, inserire "Non disponibile","Fuori servizio" o "In manutenzione"'

		UPDATE Attrezzatura
			SET stat = @StatoAttr
			WHERE attrezzaturaID = @AttrezzoID

			IF @@ROWCOUNT = 0
				THROW 50001, 'Questa attrezzatura non esiste.',1
	END TRY
	BEGIN CATCH
		PRINT ERROR_MESSAGE()
	END CATCH
END

DROP PROCEDURE UpdateStatoAttrezzatura

SELECT * FROM Attrezzatura
EXEC UpdateStatoAttrezzatura @AttrezzoID = 1, @StatoAttr = 'Fuori servizio'
EXEC UpdateStatoAttrezzatura @AttrezzoID = 1, @StatoAttr = 'Non disponibile' -- genera errore in cui ti dice di specificare il tipo di input  :) 
EXEC UpdateStatoAttrezzatura @AttrezzoID = 111, @StatoAttr = 'fuori servizio' -- genera errore nel caso l'id non esista:) 

--Scrivi una stored procedure che consenta a un membro di prenotare una classe specifica.
--CREATE TABLE Prenotazione(
--	prenotazioneID INTEGER PRIMARY KEY NOT NULL IDENTITY,
--	dataPrenot DATETIME NOT NULL,
--	membroRIF INTEGER NOT NULL,
--	FOREIGN KEY(membroRIF) REFERENCES Membro(membroID) ON DELETE CASCADE,
--	classeRIF INTEGER NOT NULL,
--	FOREIGN KEY(classeRIF) REFERENCES Classe(classeID) ON DELETE CASCADE
--)

CREATE PROCEDURE PrenotaClasse
	@DataPrenotazione
	@Membro
	@Classe

--sql
--Scrivi una stored procedure per permettere ai membri di cancellare una prenotazione esistente.
--Scrivi una stored procedure che restituisce il numero di classi condotte da un istruttore specifico.
