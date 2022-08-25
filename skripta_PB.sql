CREATE DATABASE Fitnes
-- Ter za uporabo baze uporabimo USE: 
USE Fitnes;

-- Ustvarjanje prej zadanih tabel
CREATE TABLE Uporabnik
(
uporabnik_id int primary key NOT NULL,
ime nvarchar(20) NOT NULL,
priimek nvarchar(20) NOT NULL,
telefeon nvarchar(15) NOT NULL,
naslov nvarchar(50) NOT NULL,
email nvarchar(50) NOT NULL,
spol char(1) NOT NULL,
starost int NOT NULL,
je_trener bit
)

CREATE TABLE Tip_clanstva
(
tip_id int primary key NOT NULL,
ime nvarchar(20) NOT NULL,
Znesek nvarchar(50) NOT NULL,
Trajanje nvarchar(50) NOT NULL,
Provizija nvarchar(3) NOT NULL
)

CREATE TABLE Clan
(
clan_id int primary key NOT NULL,
pridruzitev date NOT NULL,
potek_clanstva date NOT NULL,
uporabnik_id int NOT NULL, 
tip_id int NOT NULL,
FOREIGN KEY (uporabnik_id) REFERENCES Uporabnik(uporabnik_id),
FOREIGN KEY (tip_id) REFERENCES Tip_clanstva(tip_id)
)

CREATE TABLE Trening
(
trening_id int primary key NOT NULL,
ime nvarchar(20) NOT NULL,
Opis nvarchar(255) NOT NULL
)

CREATE TABLE Plan_treningov
(
plan_id int primary key NOT NULL,
clan_id int NOT NULL,
trener_id int NOT NULL,
trening_id int NOT NULL,
dnevi_treningov nvarchar(50) NOT NULL,
FOREIGN KEY (clan_id) REFERENCES Clan(clan_id),
FOREIGN KEY (trener_id) REFERENCES Uporabnik(uporabnik_id),
FOREIGN KEY (trening_id) REFERENCES Trening(trening_id)
)


-- Ustvarjanje indeksov:
CREATE INDEX Uporabniki_indeks ON Uporabnik(uporabnik_id);
CREATE INDEX Clan_indeks ON Clan(clan_id);
CREATE INDEX Plan_treningov_indeks ON Plan_treningov(plan_id);
CREATE INDEX Tip_clanstva_indeks ON Tip_clanstva(tip_id);
CREATE INDEX Trening_indeks ON Trening(trening_id);



-- Vstavljanje podatkov v tabele:
BEGIN TRANSACTION;
INSERT INTO Uporabnik(uporabnik_id, ime, priimek, telefeon, naslov, email, spol, starost, je_trener) 
VALUES
(1,'Luka', 'Slapnik', '051772959', 'Gubèeva ulica 8, Slovenske Konjice', 'lukec.slapnik@gmail.com', 'M', 18, 1),
(2,'Maj', 'Kotnik', '034123222', 'Zreška ulica 12, Zreèe', 'maj.kotnik@gmail.com', 'M', 18, 0),
(3,'Tim', 'Puhic', '32132323', 'Žauska ulica 1, Žalec', 'tim@gmail.com', 'M', 18, 1),
(4,'Nejc', 'Nekdo', '32131333', 'Nejska ulica 11, Loèe', 'nejc@gmail.com', 'M', 22, 1),
(5,'Blaž', 'Knaflc', '323213123', 'Zièe ulica 11, Zièe', 'blaž@gmail.com', 'M', 18, 1),
(6,'Blaž', 'Zikding', '2323231', 'Zièe ulica 11, Zièe', '1111@gmail.com', 'M', 18, 0),
(7,'Jana', 'Janko', '2323231', 'Zièe ulica 11, Zièe', 'jana@gmail.com', 'Ž', 18, 0),
(8,'Maj', 'Matnik', '32312323', 'Zièe ulica 11, Zièe', 'jan@gmail.com', 'M', 18, 0),
(9,'Nik', 'Kmetec', '232312', 'Zièe ulica 11, Zièe', 'maj@gmail.com', 'M', 18, 0),
(10,'Luka', 'Obner', '3232131', 'Zièe ulica 11, Zièe', 'nik@gmail.com', 'M', 18, 0),
(11,'Nika', 'Opri', '3354545', 'Zièe ulica 11, Zièe', 'klar@gmail.com', 'Ž', 18, 0),
(12,'Marko', 'King', '5454343', 'Zièe ulica 11, Zièe', 'marko@gmail.com', 'M', 18, 0),
(13,'Andraz', 'Golcer', '3423342', 'Zièe ulica 11, Zièe', 'andarz@gmail.com', 'M', 18, 0),
(14,'Miha', 'Novak', '12312255', 'Zièe ulica 11, Zièe', 'miha@gmail.com', 'M', 18, 0),
(15,'Špela', 'Skok', '75345344', 'Zièe ulica 11, Zièe', 'Spela@gmail.com', 'Ž', 18, 0),
(16,'Blaž', 'Krivc', '23656743', 'Zièe ulica 11, Zièe', 'blaž1@gmail.com', 'M', 18, 0),
(17,'Blaž', 'Janko', '54354674', 'Zièe ulica 11, Zièe', 'blaž2@gmail.com', 'M', 18, 0);

COMMIT TRANSACTION;

BEGIN TRAN 
DELETE FROM Uporabnik WHERE uporabnik_id = 14;
ROLLBACK TRAN 

BEGIN TRANSACTION;
INSERT INTO Tip_clanstva(tip_id, ime, Znesek, Trajanje, Provizija) 
VALUES
(1, 'Tedensko', '20€', '7 dni', '5%'),
(2, 'Meseèno', '50€', '30 dni', '5%'),
(3, 'Tri meseèno', '100€', '90 dni', '5%'),
(4, 'Šest meseèno', '200€', '180 dni','5%'),
(5, 'Letno', '500€', '365 dni', '5%'),
(6, 'Life time', '2000€', 'Za vedno', '5%');

INSERT INTO Clan(clan_id, pridruzitev, potek_clanstva, tip_id, uporabnik_id) 
VALUES
(1, '2022-04-25', '2022-05-25', 2, 1),
(2, '2022-03-11', '2022-10-11', 1, 6),
(3, '2022-02-12', '2022-08-12', 4, 7),
(4, '2022-01-13', '2100-01-13', 6, 8),
(5, '2022-02-14', '2022-06-14', 3, 9),
(6, '2022-03-15', '2022-06-15', 3, 10),
(7, '2022-04-16', '2022-10-16', 6, 11),
(8, '2022-05-1', '2022-12-1', 1, 12),
(9, '2022-01-12', '2023-01-12', 5, 13),
(10, '2022-02-2', '2023-02-2', 5, 14),
(11, '2022-03-3', '2023-03-3', 5, 15),
(12, '2022-04-1', '2023-04-1', 5, 16);

COMMIT TRANSACTION;

INSERT INTO Trening(trening_id, ime, opis) 
VALUES
(1, 'Push 1', 'Trening z vajami pri katerih potiskamo za dan 1.'),
(2, 'Push 2', 'Trening z vajami pri katerih potiskamo za dan 2.'),
(3, 'Pull 1', 'Trening z vajami pri katerih vleèemo za dan 1.'),
(4, 'Pull 2', 'Trening z vajami pri katerih vleèemo za dan 2.'),
(5, 'Legs 1', 'Trening z vajamie, ki vkljuèujejo noge za dan 1.'),
(6, 'Legs 2', 'Trening z vajamie, ki vkljuèujejo noge za dan 2.'),
(7, 'Upper 1', 'Trening z vajamie, ki vkljuèujejo zgorni del teslesa za dan 1.'),
(8, 'Upper 2', 'Trening z vajamie, ki vkljuèujejo zgorni del teslesa za dan 2.'),
(9, 'Lower 1', 'Trening z vajamie, ki vkljuèujejo spodni del teslesa za dan 2.'),
(10, 'Lower 2', 'Trening z vajamie, ki vkljuèujejo spodni del teslesa za dan 2.');

BEGIN TRANSACTION;
INSERT INTO Plan_treningov(plan_id, clan_id, trener_id, trening_id, dnevi_treningov) 
VALUES
(1, 2, 1, 1, 'Ponedeljek'),
(2, 3, 1, 2, 'Torek'),
(3, 4, 1, 3, 'Sreda'),
(4, 5, 3, 4, 'Èetrtek'),
(5, 6, 3, 5, 'Petek'),
(6, 7, 4, 6, 'Sobota'),
(7, 8, 4, 7, 'Nedeleja'),
(8, 9, 4, 8, 'Torek'),
(9, 10, 5, 9, 'Èetrtek'),
(10, 11, 5, 10, 'Petek');

COMMIT TRANSACTION;


SELECT * FROM Uporabnik
SELECT * FROM Clan
SELECT * FROM Plan_treningov
SELECT * FROM Trening
SELECT * FROM Tip_clanstva


-- Poizvedbe

-- Izpiše vse plane treningov, ki imajo trening na torek in èetrtega trenerja
SELECT * FROM Plan_treningov WHERE (dnevi_treningov = 'Torek' AND trener_id=4); 

-- Izpiše povprešèno starost uporabnikov fitnesa, prav tako najmanjšo starost uporabnikov ter najveèjo starost 
SELECT AVG(starost) AS 'Povpreèna starost', MIN(starost) AS 'Najnižja starost', MAX(starost) AS 'Najvišja plaèa' FROM Uporabnik;

-- Izpiše vse uporabnike fitnesa
SELECT COUNT(uporabnik_id) AS 'Koliko uporabnikom ima fitnes'  FROM Uporabnik;

-- Izpiše imena uporabnikov in potek njhoviga èlanstva za vse, ki so moški
SELECT ime, potek_clanstva 
FROM Uporabnik, Clan
Where Uporabnik.uporabnik_id = clan.clan_id
AND spol='M'

-- Izpišemo vse podatke o trenigih ter na kateri dan so 
SELECT P.dnevi_treningov, T.*
FROM Plan_treningov P JOIN Trening T ON P.trening_id = T.trening_id
ORDER BY P.dnevi_treningov, T.ime;

-- Izpišemo 
SELECT U.ime, P.clan_id
FROM Uporabnik U JOIN Plan_treningov P ON U.uporabnik_id = P.trener_id
ORDER BY U.ime, P.clan_id;

-- Izpiši vse ženske, ki so uporabnice ter so starejše od 15 let
SELECT * FROM Uporabnik WHERE spol = 'Ž' AND starost > 15;

-- Izpiše vse èalne, ki so se pridružili v letu 2022 ter jih èlanstvo poteka dlje ko samo do konca leta. 
SELECT * FROM Clan WHERE pridruzitev < '2021-12-31'
UNION
SELECT * FROM Clan WHERE potek_clanstva > '2022-12-31'

-- Izpiše vse treninge, ki imajo v imenu uppper ter v opisu številko 1 nekej v stringu
SELECT * FROM Trening WHERE ime LIKE '%Upper%'
INTERSECT
SELECT * FROM Trening WHERE opis LIKE '%1%'

-- Izpiše vse uporabnike, ki so iz žiè ter njighovo pridružitev v fitnes
SELECT u.*, c.pridruzitev FROM Uporabnik u INNER JOIN Clan c
ON u.uporabnik_id = c.clan_id
WHERE u.naslov LIKE '%Zièe'
ORDER BY c.pridruzitev


-- Pogledi

-- Izpiši vse plane trenigov ter imena trenigov
 GO
 CREATE VIEW [Plani_treningi] AS
 SELECT p.*, t.ime
 FROM Plan_treningov p INNER JOIN Trening t
 ON p.trening_id = t.trening_id 


-- Pogled vrst treningov
 GO
 CREATE VIEW Pogled_trenigov AS
 SELECT ime as 'Ime', Opis as 'Opis'
 FROM Trening

 -- Pogled vseh info o èlanih 
 GO
 CREATE VIEW Clan_pogled AS
 SELECT U.ime as 'Ime', U.priimek as 'Priimek', C.pridruzitev as 'Datum pridruzitve'
 FROM Uporabnik U JOIN Clan C ON U.uporabnik_id = C.clan_id


-- Pogled tipov èlanstva 
 GO
 CREATE VIEW Pogled_tipov_èlanstva AS
 SELECT ime as 'Ime', Znesek as 'Znesek v Euro', Trajanje as 'Trajanje v dneh'
 FROM Tip_clanstva

-- Pogled za uporabnike
 GO
 CREATE VIEW Pogled_uporabnik AS
 SELECT ime as 'Ime', priimek as 'Priimek', telefeon as 'Telefon', email as 'Email' 
 FROM Uporabnik

-- Izpiše vse trenige, ki so zastavljeni za prvi dan
 GO
 CREATE VIEW [Treningi] AS
 SELECT * 
 FROM Trening 
 WHERE ime LIKE '%1%';
 
 -- Izpiše kateri uporabniki imajo kater tip naroènine
 GO
 CREATE VIEW Pogled_tipov_in_clanov AS
 SELECT C.ime as 'Ime clana', T.uporabnik_id as 'Števlika uporabnika'
 FROM Tip_clanstva C JOIN Clan T ON C.tip_id = T.tip_id ;
 Go

-- Ustvarimo procedure 
CREATE OR ALTER PROCEDURE Uporabniki_po_uporabnik_id @uporabnik_id int AS
SELECT * FROM Uporabnik U WHERE U.uporabnik_id = @uporabnik_id;
GO

CREATE OR ALTER PROCEDURE Clanih_po_clan_id @clan_id int AS
SELECT * FROM Clan C WHERE C.clan_id = @clan_id;
GO

CREATE OR ALTER PROCEDURE Plan_treningov_po_plan_id @plan_id int AS
SELECT * FROM Plan_treningov P WHERE P.plan_id = @plan_id;
GO

CREATE OR ALTER PROCEDURE Tipi_clanstva_po_tip_id @tip_id int AS
SELECT * FROM Tip_clanstva T WHERE T.tip_id= @tip_id;
GO

CREATE OR ALTER PROCEDURE Treningi_po_trening_id @trening_id int AS
SELECT * FROM Trening t WHERE T.trening_id = @trening_id;
GO


-- Ustvarimo prožilce za dodajanje, brisanje ter posodabljanje

BEGIN TRANSACTION;
GO
CREATE OR ALTER TRIGGER Uporabnik_insert_trigger
ON Uporabnik AFTER INSERT AS
PRINT 'Nov uporabnik je bil dodan.';
GO

CREATE OR ALTER TRIGGER Clan_insert_trigger
ON Clan AFTER INSERT AS
PRINT 'Nov èlan je bil dodan.'
GO

CREATE OR ALTER TRIGGER Plan_treningov_insert_trigger
ON Plan_treningov AFTER INSERT AS
PRINT 'Dodan je bil nov plan treningov.';
GO

CREATE OR ALTER TRIGGER Tip_clanstva_insert_trigger
ON Tip_clanstva AFTER INSERT AS
PRINT 'Dodan je bil nov tip clanstva.'
GO

CREATE OR ALTER TRIGGER Trening_insert_trigger
ON Trening AFTER INSERT AS
PRINT 'Dodan je bil nov trening.'
GO

COMMIT TRANSACTION;
GO

CREATE OR ALTER TRIGGER Uporabnik_delete_trigger
ON Uporabnik AFTER DELETE AS
PRINT 'Uporabnik je bil izbrisan.';
GO

CREATE OR ALTER TRIGGER Clan_delete_trigger
ON Clan AFTER DELETE AS
PRINT 'Èlan je bil izbrisan.'
GO

CREATE OR ALTER TRIGGER Plan_treningov_delete_trigger
ON Plan_treningov AFTER DELETE AS
PRINT 'Plan trenigov je bil izbrisan.';
GO

CREATE OR ALTER TRIGGER Tip_clanstva_delete_trigger
ON Tip_clanstva AFTER DELETE AS
PRINT 'Tip èlasntva je bil izbrisan.'
GO

CREATE OR ALTER TRIGGER Trening_delete_trigger
ON Trening AFTER DELETE AS
PRINT 'Trening je bil izbrisan.'
GO

CREATE OR ALTER TRIGGER Uporabnik_update_trigger
ON Uporabnik AFTER UPDATE AS
PRINT 'Uporabnik je bil posodobljen.';
GO

CREATE OR ALTER TRIGGER Clan_update_trigger
ON Clan AFTER UPDATE AS
PRINT 'Èlan je bil posodobljen.'
GO

CREATE OR ALTER TRIGGER Plan_treningov_update_trigger
ON Plan_treningov AFTER UPDATE AS
PRINT 'Plan trenigov je bil posodboljen.';
GO

CREATE OR ALTER TRIGGER Tip_clanstva_update_trigger
ON Tip_clanstva AFTER UPDATE AS
PRINT 'Tip èlastva je bil posodboljen.'
GO

CREATE OR ALTER TRIGGER Trening_update_trigger
ON Trening AFTER UPDATE AS
PRINT 'Trening je bil posodobljen.'
GO



