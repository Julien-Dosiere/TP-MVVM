
CREATE DATABASE EmailsDB;

USE EmailsDB;

CREATE TABLE Services (
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Nom VARCHAR(100),
)





CREATE TABLE Salaries (
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Matricule VARCHAR(100),
	Nom VARCHAR(100),
	Prenom VARCHAR(100),
	DateNaissance DATETIME,
	Adresse VARCHAR(200),
	TypeContrat VARCHAR(100),
	Photo VARCHAR(max),
	Email VARCHAR(100),
	password VARCHAR(100),
	Responsable BIT,
	IdService INT FOREIGN KEY REFERENCES Services(Id),

)

CREATE TABLE Demandes (
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Motif VARCHAR(100),
	Statut VARCHAR(100),
	Info VARCHAR(100),
	Email VARCHAR(100),
	IdSalarie INT FOREIGN KEY REFERENCES Salaries(Id),


)


INSERT INTO Services VALUES ('Comptabilité');
INSERT INTO Services VALUES ('Logistique');

INSERT INTO Salaries (	
		Matricule,
		Nom,
		Prenom,
		DateNaissance,
		Adresse,
		TypeContrat,
		Photo,
		Email,
		password,
		Responsable,
		IdService) 
	VALUES(
		'SD2345',
		'Michel',
		'LeBlanc',
		'01/01/1960',
		'34 rue des Coquelicots',
		'Cadre',
		'lien photo',
		'email',
		'password',
		1,
		1
	);


	INSERT INTO Salaries (	
		Matricule,
		Nom,
		Prenom,
		DateNaissance,
		Adresse,
		TypeContrat,
		Photo,
		Email,
		password,
		Responsable,
		IdService) 
	VALUES(
		'SD2346',
		'Marie',
		'Dupont',
		'01/01/1970',
		'34 rue des Acacias',
		'Employé',
		'lien photo',
		'email',
		'password',
		0,
		2
	);