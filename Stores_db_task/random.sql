ALTER TABLE Prodazba
ADD nacin_naplata INT

CREATE TABLE Nacin_Naplata(
id_nacin INT NOT NULL,
vid_naplata VARCHAR(100)

PRIMARY KEY(id_nacin)
);

ALTER TABLE Nacin_Prodazba
ADD FOREIGN KEY (id_nacin) REFERENCES Prodazba(nacin_naplata);


/*
CREATE TABLE Persons (
    PersonID int,
    LastName varchar(255),
    FirstName varchar(255),
    Address varchar(255),
    City varchar(255)
);
*/