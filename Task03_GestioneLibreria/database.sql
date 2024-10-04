CREATE DATABASE task03_biblioteca
USE task03_biblioteca

CREATE TABLE Utente(
	utenteID INT PRIMARY KEY IDENTITY,
	codice VARCHAR(250) DEFAULT NEWID(),
	nome VARCHAR(250) NOT NULL, 
	cognome VARCHAR(250) NOT NULL,
	email VARCHAR(250) NOT NULL,
)

CREATE TABLE Libro(
	libroID INT PRIMARY KEY IDENTITY,
	codice VARCHAR(250) DEFAULT NEWID(),
	titolo VARCHAR(250) NOT NULL, 
	autore VARCHAR(250) NOT NULL,
	anno INT NOT NULL CHECK(anno <= YEAR(GETDATE())),
	disponibile BIT DEFAULT 1
)

CREATE TABLE Prestito(
	prestitoID INT PRIMARY KEY IDENTITY,
	codice VARCHAR(250) DEFAULT NEWID(),
	data_prestito DATE NOT NULL DEFAULT GETDATE(), 
	data_ritorno DATE DEFAULT NULL,
	utenteRIF INT NOT NULL,
	FOREIGN KEY(utenteRIF) REFERENCES Utente(utenteID),
	libroRIF INT NOT NULL,
	FOREIGN KEY(libroRIF) REFERENCES Libro(libroID)
)

INSERT INTO Utente (nome, cognome, email) VALUES ('Mario', 'Rossi', 'mario.rossi@example.com');
INSERT INTO Utente (nome, cognome, email) VALUES ('Luigi', 'Verdi', 'luigi.verdi@example.com');
INSERT INTO Utente (nome, cognome, email) VALUES ('Francesca', 'Bianchi', 'francesca.bianchi@example.com');
INSERT INTO Utente (nome, cognome, email) VALUES ('Giulia', 'Neri', 'giulia.neri@example.com');
INSERT INTO Utente (nome, cognome, email) VALUES ('Alessandro', 'Romano', 'alessandro.romano@example.com');
INSERT INTO Utente (nome, cognome, email) VALUES ('Laura', 'Ricci', 'laura.ricci@example.com');
INSERT INTO Utente (nome, cognome, email) VALUES ('Federico', 'Esposito', 'federico.esposito@example.com');
INSERT INTO Utente (nome, cognome, email) VALUES ('Martina', 'Greco', 'martina.greco@example.com');
INSERT INTO Utente (nome, cognome, email) VALUES ('Davide', 'Ferri', 'davide.ferri@example.com');
INSERT INTO Utente (nome, cognome, email) VALUES ('Chiara', 'Moretti', 'chiara.moretti@example.com');
INSERT INTO Utente (nome, cognome, email) VALUES ('Sara', 'Conti', 'sara.conti@example.com');
INSERT INTO Utente (nome, cognome, email) VALUES ('Marco', 'Leone', 'marco.leone@example.com');
INSERT INTO Utente (nome, cognome, email) VALUES ('Simone', 'Marini', 'simone.marini@example.com');
INSERT INTO Utente (nome, cognome, email) VALUES ('Elisa', 'Lombardi', 'elisa.lombardi@example.com');
INSERT INTO Utente (nome, cognome, email) VALUES ('Valentina', 'Ferrari', 'valentina.ferrari@example.com');
INSERT INTO Utente (nome, cognome, email) VALUES ('Giovanni', 'Gallo', 'giovanni.gallo@example.com');
INSERT INTO Utente (nome, cognome, email) VALUES ('Roberta', 'Costa', 'roberta.costa@example.com');
INSERT INTO Utente (nome, cognome, email) VALUES ('Andrea', 'Santoro', 'andrea.santoro@example.com');
INSERT INTO Utente (nome, cognome, email) VALUES ('Stefano', 'D\''Angelo', 'stefano.dangelo@example.com');
INSERT INTO Utente (nome, cognome, email) VALUES ('Eleonora', 'Villa', 'eleonora.villa@example.com');

INSERT INTO Libro (titolo, autore, anno) VALUES ('Sapiens: A Brief History of Humankind', 'Yuval Noah Harari', 2011);
INSERT INTO Libro (titolo, autore, anno) VALUES ('The Hitchhiker\''s Guide to the Galaxy', 'Douglas Adams', 1979);
INSERT INTO Libro (titolo, autore, anno) VALUES ('1984', 'George Orwell', 1949);
INSERT INTO Libro (titolo, autore, anno) VALUES ('Brave New World', 'Aldous Huxley', 1932);
INSERT INTO Libro (titolo, autore, anno) VALUES ('The Lord of the Rings', 'J.R.R. Tolkien', 1954);
INSERT INTO Libro (titolo, autore, anno) VALUES ('To Kill a Mockingbird', 'Harper Lee', 1960);
INSERT INTO Libro (titolo, autore, anno) VALUES ('Harry Potter and the Philosopher\''s Stone', 'J.K. Rowling', 1997);
INSERT INTO Libro (titolo, autore, anno) VALUES ('The Great Gatsby', 'F. Scott Fitzgerald', 1925);
INSERT INTO Libro (titolo, autore, anno) VALUES ('The Catcher in the Rye', 'J.D. Salinger', 1951);
INSERT INTO Libro (titolo, autore, anno) VALUES ('Dune', 'Frank Herbert', 1965);
INSERT INTO Libro (titolo, autore, anno) VALUES ('Fahrenheit 451', 'Ray Bradbury', 1953);
INSERT INTO Libro (titolo, autore, anno) VALUES ('The Road', 'Cormac McCarthy', 2006);
INSERT INTO Libro (titolo, autore, anno) VALUES ('Moby Dick', 'Herman Melville', 1851);
INSERT INTO Libro (titolo, autore, anno) VALUES ('The Alchemist', 'Paulo Coelho', 1988);
INSERT INTO Libro (titolo, autore, anno) VALUES ('The Handmaid\''s Tale', 'Margaret Atwood', 1985);
INSERT INTO Libro (titolo, autore, anno) VALUES ('Slaughterhouse-Five', 'Kurt Vonnegut', 1969);
INSERT INTO Libro (titolo, autore, anno) VALUES ('Crime and Punishment', 'Fyodor Dostoevsky', 1866);
INSERT INTO Libro (titolo, autore, anno) VALUES ('The Picture of Dorian Gray', 'Oscar Wilde', 1890);
INSERT INTO Libro (titolo, autore, anno) VALUES ('The Shining', 'Stephen King', 1977);
INSERT INTO Libro (titolo, autore, anno) VALUES ('The Name of the Wind', 'Patrick Rothfuss', 2007);

INSERT INTO Prestito (data_prestito, data_ritorno, utenteRIF, libroRIF) VALUES ('2024-01-01', '2024-01-15', 1, 1);
INSERT INTO Prestito (data_prestito, data_ritorno, utenteRIF, libroRIF) VALUES ('2024-01-03', NULL, 2, 2);
INSERT INTO Prestito (data_prestito, data_ritorno, utenteRIF, libroRIF) VALUES ('2024-01-05', NULL, 3, 3);
INSERT INTO Prestito (data_prestito, data_ritorno, utenteRIF, libroRIF) VALUES ('2024-01-07', '2024-01-21', 4, 4);
INSERT INTO Prestito (data_prestito, data_ritorno, utenteRIF, libroRIF) VALUES ('2024-01-10', '2024-01-20', 5, 5);
INSERT INTO Prestito (data_prestito, data_ritorno, utenteRIF, libroRIF) VALUES ('2024-01-12', NULL, 6, 6);
INSERT INTO Prestito (data_prestito, data_ritorno, utenteRIF, libroRIF) VALUES ('2024-01-14', '2024-01-28', 7, 7);
INSERT INTO Prestito (data_prestito, data_ritorno, utenteRIF, libroRIF) VALUES ('2024-01-17', '2024-01-31', 8, 8);
INSERT INTO Prestito (data_prestito, data_ritorno, utenteRIF, libroRIF) VALUES ('2024-01-19', NULL, 9, 9);
INSERT INTO Prestito (data_prestito, data_ritorno, utenteRIF, libroRIF) VALUES ('2024-01-21', '2024-02-04', 10, 10);
INSERT INTO Prestito (data_prestito, data_ritorno, utenteRIF, libroRIF) VALUES ('2024-01-23', NULL, 11, 11);
INSERT INTO Prestito (data_prestito, data_ritorno, utenteRIF, libroRIF) VALUES ('2024-01-25', '2024-02-08', 12, 12);
INSERT INTO Prestito (data_prestito, data_ritorno, utenteRIF, libroRIF) VALUES ('2024-01-27', NULL, 13, 13);
INSERT INTO Prestito (data_prestito, data_ritorno, utenteRIF, libroRIF) VALUES ('2024-01-29', '2024-02-12', 14, 14);
INSERT INTO Prestito (data_prestito, data_ritorno, utenteRIF, libroRIF) VALUES ('2024-01-31', NULL, 15, 15);
INSERT INTO Prestito (data_prestito, data_ritorno, utenteRIF, libroRIF) VALUES ('2024-02-02', '2024-02-16', 16, 16);
INSERT INTO Prestito (data_prestito, data_ritorno, utenteRIF, libroRIF) VALUES ('2024-02-04', NULL, 17, 17);
INSERT INTO Prestito (data_prestito, data_ritorno, utenteRIF, libroRIF) VALUES ('2024-02-06', '2024-02-20', 18, 18);
INSERT INTO Prestito (data_prestito, data_ritorno, utenteRIF, libroRIF) VALUES ('2024-02-08', NULL, 19, 19);
INSERT INTO Prestito (data_prestito, data_ritorno, utenteRIF, libroRIF) VALUES ('2024-02-10', '2024-02-24', 20, 20);

SELECT * FROM Libro
SELECT * FROM Utente
SELECT * FROM Prestito


