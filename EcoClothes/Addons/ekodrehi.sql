CREATE DATABASE Ekodrehi
go

USE Ekodrehi_2

CREATE TABLE [Fakturi]
( 
	[id_porychka]        integer  NULL ,
	[data_na_dostavka]   datetime  NULL ,
	[nomer_na_faktura]   integer  NOT NULL 
)
go

ALTER TABLE [Fakturi]
	ADD CONSTRAINT [XPKFakturi] PRIMARY KEY  CLUSTERED ([nomer_na_faktura] ASC)
go

CREATE TABLE [Kategorii]
( 
	[id_kategoria]       integer  NOT NULL ,
	[naimenovanie]       nvarchar(50)  NULL 
)
go

ALTER TABLE [Kategorii]
	ADD CONSTRAINT [XPKKategorii] PRIMARY KEY  CLUSTERED ([id_kategoria] ASC)
go

CREATE TABLE [Klienti]
( 
	[id_klient]          integer  NOT NULL ,
	[naimenovanie]       nvarchar(50)  NULL ,
	[adres]              nvarchar(100)  NULL ,
	[telefon]            integer  NULL ,
	[email]              varchar(50)  NULL 
)
go

ALTER TABLE [Klienti]
	ADD CONSTRAINT [XPKKlienti] PRIMARY KEY  CLUSTERED ([id_klient] ASC)
go

CREATE TABLE [Kurieri]
( 
	[id_kurier]          integer  NOT NULL ,
	[naimenovanie]       nvarchar(50)  NULL 
)
go

ALTER TABLE [Kurieri]
	ADD CONSTRAINT [XPKKurieri] PRIMARY KEY  CLUSTERED ([id_kurier] ASC)
go

CREATE TABLE [Materiali]
( 
	[id_material]        integer  NOT NULL ,
	[naimenovanaie]      nvarchar(50)  NULL 
)
go

ALTER TABLE [Materiali]
	ADD CONSTRAINT [XPKMateriali] PRIMARY KEY  CLUSTERED ([id_material] ASC)
go

CREATE TABLE [Materiali_Produkti]
( 
	[id_material]        integer  NOT NULL ,
	[id_produkt]         integer  NOT NULL 
)
go

ALTER TABLE [Materiali_Produkti]
	ADD CONSTRAINT [XPKMateriali_Produkti] PRIMARY KEY  CLUSTERED ([id_material] ASC,[id_produkt] ASC)
go

CREATE TABLE [Porychki]
( 
	[id_slujitel]        integer  NULL ,
	[id_kurier]          integer  NOT NULL ,
	[id_porychka]        integer  NOT NULL ,
	[data_na_porychka]   datetime  NULL ,
	[id_klient]          integer  NOT NULL 
)
go

ALTER TABLE [Porychki]
	ADD CONSTRAINT [XPKPorychki] PRIMARY KEY  CLUSTERED ([id_porychka] ASC)
go

CREATE TABLE [Porychki_Produkti]
( 
	[id_produkt]         integer  NOT NULL ,
	[id_porychka]        integer  NOT NULL ,
	[cena]               float  NULL ,
	[kolichestvo]        integer  NULL 
)
go

ALTER TABLE [Porychki_Produkti]
	ADD CONSTRAINT [XPKPorychki_Produkti] PRIMARY KEY  CLUSTERED ([id_produkt] ASC,[id_porychka] ASC)
go

CREATE TABLE [Produkti]
( 
	[id_sklad]           integer  NOT NULL ,
	[id_kategoria]       integer  NOT NULL ,
	[id_produkt]         integer  NOT NULL ,
	[naimenovanie]       nvarchar(50)  NULL ,
	[nalichnost]         bit  NOT NULL  ,
	[cena]               float  NULL 
)
go

ALTER TABLE [Produkti]
	ADD CONSTRAINT [XPKProdukti] PRIMARY KEY  CLUSTERED ([id_produkt] ASC)
go

CREATE TABLE [Skladove]
( 
	[id_sklad]           integer  NOT NULL ,
	[naimenovanie]       nvarchar(50)  NULL ,
	[adres]              nvarchar(100)  NULL 
)
go

ALTER TABLE [Skladove]
	ADD CONSTRAINT [XPKSkladove] PRIMARY KEY  CLUSTERED ([id_sklad] ASC)
go

CREATE TABLE [Slujiteli]
( 
	[id_slujitel]        integer  NOT NULL ,
	[naimenovanie]       nvarchar(50)  NULL ,
	[egn]                numeric(10)  NULL ,
	[adres]              nvarchar(50)  NULL ,
	[telefon]            integer  NULL ,
	[email]              nvarchar(50)  NULL 
)
go

ALTER TABLE [Slujiteli]
	ADD CONSTRAINT [XPKSlujiteli] PRIMARY KEY  CLUSTERED ([id_slujitel] ASC)
go


ALTER TABLE [Fakturi]
	ADD CONSTRAINT [R_12] FOREIGN KEY ([id_porychka]) REFERENCES [Porychki]([id_porychka])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [Materiali_Produkti]
	ADD CONSTRAINT [R_2] FOREIGN KEY ([id_material]) REFERENCES [Materiali]([id_material])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [Materiali_Produkti]
	ADD CONSTRAINT [R_3] FOREIGN KEY ([id_produkt]) REFERENCES [Produkti]([id_produkt])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [Porychki]
	ADD CONSTRAINT [R_11] FOREIGN KEY ([id_slujitel]) REFERENCES [Slujiteli]([id_slujitel])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [Porychki]
	ADD CONSTRAINT [R_10] FOREIGN KEY ([id_kurier]) REFERENCES [Kurieri]([id_kurier])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [Porychki]
	ADD CONSTRAINT [R_13] FOREIGN KEY ([id_klient]) REFERENCES [Klienti]([id_klient])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [Porychki]
	ADD CONSTRAINT [R_14] FOREIGN KEY ([id_klient]) REFERENCES [Klienti]([id_klient])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [Porychki_Produkti]
	ADD CONSTRAINT [R_8] FOREIGN KEY ([id_produkt]) REFERENCES [Produkti]([id_produkt])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [Porychki_Produkti]
	ADD CONSTRAINT [R_7] FOREIGN KEY ([id_porychka]) REFERENCES [Porychki]([id_porychka])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [Produkti]
	ADD CONSTRAINT [R_5] FOREIGN KEY ([id_sklad]) REFERENCES [Skladove]([id_sklad])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [Produkti]
	ADD CONSTRAINT [R_4] FOREIGN KEY ([id_kategoria]) REFERENCES [Kategorii]([id_kategoria])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


DELETE FROM Skladove;
INSERT INTO Skladove(id_sklad, naimenovanie, adres) VALUES ('01', N'Централен', N'Варна ЦентърПриморски, ул. „Генерал Колев“ No 68, 9000 Варна');


INSERT INTO Kategorii (id_kategoria, naimenovanie) VALUES ('01', N'блуза');
INSERT INTO Kategorii (id_kategoria, naimenovanie) VALUES ('02', N'тениска');
INSERT INTO Kategorii (id_kategoria, naimenovanie) VALUES ('03', N'риза');
INSERT INTO Kategorii (id_kategoria, naimenovanie) VALUES ('04', N'пуловер');
INSERT INTO Kategorii (id_kategoria, naimenovanie) VALUES ('05', N'сако');
INSERT INTO Kategorii (id_kategoria, naimenovanie) VALUES ('06', N'яке');
INSERT INTO Kategorii (id_kategoria, naimenovanie) VALUES ('07', N'палто');
INSERT INTO Kategorii (id_kategoria, naimenovanie) VALUES ('08', N'пончо');
INSERT INTO Kategorii (id_kategoria, naimenovanie) VALUES ('09', N'жилетка');
INSERT INTO Kategorii (id_kategoria, naimenovanie) VALUES ('10', N'панталон');
INSERT INTO Kategorii (id_kategoria, naimenovanie) VALUES ('11', N'пола');
INSERT INTO Kategorii (id_kategoria, naimenovanie) VALUES ('12', N'рокля');
INSERT INTO Kategorii (id_kategoria, naimenovanie) VALUES ('13', N'туника');
INSERT INTO Kategorii (id_kategoria, naimenovanie) VALUES ('14', N'пижама');
INSERT INTO Kategorii (id_kategoria, naimenovanie) VALUES ('15', N'халат');
INSERT INTO Kategorii (id_kategoria, naimenovanie) VALUES ('16', N'вратовръзка');
INSERT INTO Kategorii (id_kategoria, naimenovanie) VALUES ('17', N'папийонка');


DELETE FROM Materiali;
INSERT INTO Materiali (id_material, naimenovanaie) VALUES ('01', N'коноп');
INSERT INTO Materiali (id_material, naimenovanaie) VALUES ('02', N'лен');
INSERT INTO Materiali (id_material, naimenovanaie) VALUES ('03', N'памук');
INSERT INTO Materiali (id_material, naimenovanaie) VALUES ('04', N'коприна');
INSERT INTO Materiali (id_material, naimenovanaie) VALUES ('05', N'вълна');


INSERT INTO Kurieri (id_kurier, naimenovanie) VALUES ('01', N'Speedy');
INSERT INTO Kurieri (id_kurier, naimenovanie) VALUES ('02', N'Еконт');


INSERT INTO Slujiteli (id_slujitel, naimenovanie, egn, adres, telefon, email) VALUES
	('01', N'Александър Иванов', '9311239454', N'Христо Ботев Одесос, ул. „Дрин“, 9000 Варна', '0870622364', 'alexiv_1990@mail.com'),
	('02', N'Милко Трандев', '9908318844', N'ул. "Иван Аксаков" 9000 Варна', '0884444777', 'milkotrandev@mail.com'),
	('03', N'Михаил Русев', '9103229966', N'ул. " Брегалница" 9000 Варна', '0877344111', 'mihailrusev@mail.com'),
	('04', N'Снежина Златева', '9509138877', N'ул. "Генерал Колев" 9000 Варна', '0899656944', 'snejizlateva@mail.com');

DELETE FROM Klienti;
INSERT INTO Klienti (id_klient, naimenovanie, adres, telefon, email) VALUES
	('01', N'Борис Пенчев', N'Христо Ботев Одесос, ул. „Цар Иван Срацимир“ 13А, 9000 Варна', '0877052777', N'b.pen.office@mail.som'),
	('02', N'Иванка Иванова', N'ул. "Генерал Столетов" 56, 6000 Стара Загора', '0888834571', 'i.ivanowa@mail.com'),
	('03', N'Петър Петров', N'ул. "Акве калиде" 8000 Бургас', '0894453721', 'petyr@mail.com'),
	('04', N'Иван Иванов', N'ул. "Трайчо Китанчев" 8800 Сливен', '0897656543', 'i.ivanov44@mail.com'),
	('05', N'Христо Лазаров', N'ул. "Утро" 8800 Сливен', '0896573857', 'hristoivanov@mail.com'),
	('06', N'Ивайла Бакалова', N'ул. "Карлово" 1000 София', '0895641927', 'ivailabak12@mail.com'),
	('07', N'Иван Стоянов', N'ул. "Васил Левски" 1000 София', '0895678912', 'ivanst@mail.com'),
	('08', N'Димитър Заев', N'ул. "Рилска" 1000 София', '0888765432', 'dimi@mail.com'),
	('09', N'Ивон Петрова', N'ул. "Чекърчийска" 2300 Перник', '0899010532', 'ivon94@mail.com'),
	('10', N'Ема Димитрова', N'ул. "3-ти март" 5500 Велико Търново', '0890000998', 'emaema@mail.com'),
	('11', N'Илиана Петканова', N'ул. "Бреза" 6269 Раднево', '0891231231', 'iliana_petkanova@mail.com'),
	('12', N'Петя Станимирова', N'ул. "Сава Силов" 6000 Стара Загора', '0890009876', 'pepi33@mail.com'),
	('13', N'Франк Иванов', N'ул. "Цар Асен" 9000 Варна', '0891234534', 'f18pard@mail.com');
	

DELETE FROM Porychki;
INSERT INTO Porychki (id_slujitel, id_kurier, id_porychka, data_na_porychka, id_klient) VALUES
	('04', '01', '01', '12-07-2024 14:30:15', '10'),
	('02', '02', '02', '12-10-2024 10:10:00', '05'),
    ('01', '01', '03', '01-19-2025 12:23:00', '03'),
	('02', '01', '04', '01-19-2025 11:50:00', '08'),
	('04', '01', '05', '02-13-2025 14:45:00', '04'),
	('01', '01', '06', '02-20-2025 12:45:10', '07'),
	('01', '01', '07', '02-25-2025 16:00:00', '10'),
	('03', '01', '08', '02-26-2025 17:34:00', '05'),
	('04', '01', '09', '03-01-2025 11:30:04', '03'),
	('01', '02', '10', '03-18-2025 13:32:12', '11');

DELETE FROM Produkti;
INSERT INTO Produkti (id_sklad, id_kategoria, id_produkt, naimenovanie, nalichnost, cena) VALUES
	('01', '01', '3', N'Блуза с къдрички', 'TRUE', '51.20'),
	('01', '01', '2', N'Блуза с набори', 'TRUE', '49.20'),
	('01', '01', '1', N'Блуза с пеплум', 'TRUE', '54.00'),
	('01', '02', '6', N'Тениска с джобче отпред', 'TRUE', '29.80'),
	('01', '02', '5', N'Тениска oversize „Nature“', 'TRUE', '30.50'),
	('01', '02', '4', N'Тениска с щампа „Листо“', 'TRUE', '33.90'),
	('01', '03', '9', N'Риза с райе', 'TRUE', '37.60'),
	('01', '03', '8', N'Риза с якичка тип „Питър Пан“', 'TRUE', '43.60'),
	('01', '03', '7', N'Риза с маншети', 'TRUE', '61.40'),
	('01', '04', '12', N'Пуловер с лодка деколте', 'TRUE', '74.50'),
	('01', '04', '11', N'Пуловер с релефна плетка', 'TRUE', '68.40'),
	('01', '04', '10', N'Пуловер с обло деколте', 'TRUE', '79.90'),
	('01', '05', '15', N'Сако тип „блейзър“', 'TRUE', '112.00'),
	('01', '05', '14', N'Сако с подплънки', 'TRUE', '109.00'),
	('01', '05', '13', N'Сако със скрити копчета', 'TRUE', '126.50'),
	('01', '06', '18', N'Яке ветроустойчиво', 'TRUE', '139.00'),
	('01', '06', '17', N'Яке тип „бомбър“', 'TRUE', '97.70'),
	('01', '06', '16', N'Яке есенно с качулка', 'TRUE', '102.20'),
	('01', '07', '21', N'Палто с качулка', 'TRUE', '169.00'),
	('01', '07', '20', N'Палто с двуредово закопчаване', 'TRUE', '159.60'),
	('01', '07', '19', N'Палто тип „тренч“', 'TRUE', '149.99'),
	('01', '08', '24', N'Пончо с пухена яка', 'TRUE', '77.20'),
	('01', '08', '23', N'Пончо с геометрични шарки', 'TRUE', '66.30'),
	('01', '08', '22', N'Пончо със зимни мотиви', 'TRUE', '69.00'),
	('01', '09', '27', N'Жилетка с големи копчета', 'TRUE', '46.70'),
	('01', '09', '26', N'Жилетка тип „болеро“', 'TRUE', '41.20'),
	('01', '09', '25', N'Жилетка асиметрична', 'TRUE', '58.40'),
	('01', '10', '30', N'Панталон с ръб', 'TRUE', '55.90'),
	('01', '10', '29', N'Панталон с висока талия', 'TRUE', '59.40'),
	('01', '10', '28', N'Панталон с широк крачол', 'TRUE', '62.70'),
	('01', '11', '33', N'Пола тип молив', 'TRUE', '52.00'),
	('01', '11', '32', N'Пола плисирана', 'TRUE', '47.80'),
	('01', '11', '31', N'Пола А-силует', 'TRUE', '48.10'),
	('01', '12', '36', N'Рокля плетена с коланче', 'TRUE', '84.10'),
	('01', '12', '35', N'Рокля с колан', 'TRUE', '91.00'),
	('01', '12', '34', N'Рокля с флорални мотиви', 'TRUE', '87.30'),
	('01', '13', '39', N'Туника с етно мотиви', 'TRUE', '49.90'),
	('01', '13', '38', N'Туника с паднали рамене', 'TRUE', '56.10'),
	('01', '13', '37', N'Туника с бродерия', 'TRUE', '53.90'),
	('01', '14', '42', N'Пижама с щампа „звезди“', 'TRUE', '38.80'),
	('01', '14', '41', N'Пижама с дълъг ръкав', 'TRUE', '44.30'),
	('01', '14', '40', N'Пижама с къс ръкав', 'TRUE', '39.90'),
	('01', '15', '45', N'Халат с джобове', 'TRUE', '69.90'),
	('01', '15', '44', N'Халат с шал яка', 'TRUE', '78.90'),
	('01', '15', '43', N'Халат тип кимоно', 'TRUE', '74.00'),
	('01', '16', '48', N'Вратовръзка класическа черна', 'TRUE', '19.90'),
	('01', '16', '47', N'Вратовръзка с винтидж десен', 'TRUE', '23.70'),
	('01', '16', '46', N'Вратовръзка на ситни точки', 'TRUE', '21.00'),
	('01', '17', '50', N'Папийонка с метален клипс', 'TRUE', '16.50'),
	('01', '17', '49', N'Папийонка велюр', 'TRUE', '18.90');


DELETE FROM Porychki_Produkti;
INSERT INTO Porychki_Produkti (id_produkt, id_porychka, cena, kolichestvo) VALUES
	('38', '01', '73.10', '5'),
	('2', '02', '63.20', '4'),
	('4', '02', '34.90', '1'),
	('30', '03', '59.90', '5'),
	('49', '04', '4.90', '1'),
	('30', '04', '44.90', '5'),
	('14', '05', '94.00', '4'),
	('50', '06', '21.50', '5'),
	('27', '06', '33.70', '4'),
	('3', '07', '40.20', '4'),
	('33', '08', '69.00', '5'),
	('10', '08', '92.90', '3'),
	('46', '08', '12.00', '3'),
	('27', '08', '54.70', '2'),
	('24', '09', '82.20', '4'),
	('28', '10', '70.70', '3');

	

DELETE FROM Fakturi;
INSERT INTO Fakturi (id_porychka, data_na_dostavka, nomer_na_faktura) VALUES
	('1', '12-07-2024 13:35:1', '001'),
	('2', '12-10-2024 17:15:12', '002'),
	('2', '12-10-2024 9:37:49', '003'),
	('2', '12-11-2024 15:2:46', '004'),
	('3', '01-19-2025 17:14:42', '005'),
	('4', '01-21-2025 17:13:52', '006'),
	('5', '02-16-2025 11:50:38', '007'),
	('6', '02-22-2025 13:26:1', '008'),
	('6', '02-22-2025 14:9:17', '009'),
	('7', '02-27-2025 18:39:30', '010'),
	('8', '02-26-2025 15:51:4', '011'),
	('8', '02-26-2025 13:35:32', '012'),
	('8', '02-26-2025 15:5:0', '013'),
	('9', '03-04-2025 18:4:41', '014'),
	('9', '03-05-2025 18:30:14', '015'),
	('10', '03-21-2025 16:5:36', '016');
	

	INSERT INTO Materiali_Produkti (id_material, id_produkt) VALUES
	('02', '1'),
	('05', '1'),
	('03', '2'),
	('05', '3'),
	('04', '3'),
	('02', '4'),
	('03', '5'),
	('04', '5'),
	('02', '6'),
	('01', '7'),
	('02', '8'),
	('03', '9'),
	('02', '9'),
	('01', '10'),
	('04', '10'),
	('03', '11'),
	('02', '12'),
	('05', '12'),
	('01', '13'),
	('05', '14'),
	('03', '15'),
	('02', '16'),
	('01', '16'),
	('04', '17'),
	('05', '18'),
	('03', '19'),
	('02', '20'),
	('04', '21'),
	('01', '22'),
	('05', '22'),
	('04', '23'),
	('05', '23'),
	('01', '24'),
	('03', '25'),
	('04', '25'),
	('01', '25'),
	('04', '26'),
	('05', '27'),
	('01', '28'),
	('03', '29'),
	('03', '30'),
	('02', '30'),
	('04', '31'),
	('03', '31'),
	('05', '32'),
	('05', '33'),
	('01', '34'),
	('05', '34'),
	('02', '35'),
	('01', '35'),
	('03', '36'),
	('04', '37'),
	('03', '37'),
	('05', '38'),
	('01', '39'),
	('02', '40'),
	('03', '41'),
	('05', '42'),
	('04', '43'),
	('01', '44'),
	('02', '44'),
	('02', '45'),
	('05', '45'),
	('02', '46'),
	('04', '47'),
	('05', '48'),
	('03', '48'),
	('01', '49'),
	('04', '50');