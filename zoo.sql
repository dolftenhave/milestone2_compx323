---- Drop tables safely (if they exist)
--BEGIN

--    EXECUTE IMMEDIATE 'DROP TABLE m2s_Feed CASCADE CONSTRAINTS';
--EXCEPTION WHEN OTHERS THEN NULL;
--END;
--/

--BEGIN
--    EXECUTE IMMEDIATE 'DROP TABLE m2s_Care CASCADE CONSTRAINTS';
--EXCEPTION WHEN OTHERS THEN NULL;
--END;
--/

--BEGIN
--    EXECUTE IMMEDIATE 'DROP TABLE m2s_Oversees CASCADE CONSTRAINTS';
--EXCEPTION WHEN OTHERS THEN NULL;
--END;
--/

--BEGIN
--    EXECUTE IMMEDIATE 'DROP TABLE m2s_Animal CASCADE CONSTRAINTS';
--EXCEPTION WHEN OTHERS THEN NULL;
--END;
--/

--BEGIN
--    EXECUTE IMMEDIATE 'DROP TABLE m2s_Species CASCADE CONSTRAINTS';
--EXCEPTION WHEN OTHERS THEN NULL;
--END;
--/

--BEGIN
--    EXECUTE IMMEDIATE 'DROP TABLE m2s_Enclosure CASCADE CONSTRAINTS';
--EXCEPTION WHEN OTHERS THEN NULL;
--END;
--/

--BEGIN
--    EXECUTE IMMEDIATE 'DROP TABLE m2s_Zone CASCADE CONSTRAINTS';
--EXCEPTION WHEN OTHERS THEN NULL;
--END;
--/

--BEGIN
--    EXECUTE IMMEDIATE 'DROP TABLE m2s_SpeciesGroup CASCADE CONSTRAINTS';
--EXCEPTION WHEN OTHERS THEN NULL;
--END;
--/

--BEGIN
--    EXECUTE IMMEDIATE 'DROP TABLE m2s_Staff CASCADE CONSTRAINTS';
--EXCEPTION WHEN OTHERS THEN NULL;
--END;
/

-- Create tables now properly
CREATE TABLE m2s_SpeciesGroup(
    latinName VARCHAR2(30) PRIMARY KEY, 
    commonName VARCHAR2(30) NOT NULL
);

CREATE TABLE m2s_Zone(
    name VARCHAR2(30) PRIMARY KEY,
    colour VARCHAR2(15) NOT NULL,
    hexcode VARCHAR2(6) NOT NULL
);

CREATE TABLE m2s_Enclosure(
    eid INTEGER PRIMARY KEY,
    biome VARCHAR2(15) NOT NULL,
    eSize INTEGER NOT NULL,
    zoneName VARCHAR2(30),
    CONSTRAINT fk_zoneName FOREIGN KEY (zoneName) REFERENCES m2s_Zone(name) ON DELETE SET NULL
);

CREATE TABLE m2s_Species(
    latinName VARCHAR2(30) PRIMARY KEY,
    commonName VARCHAR2(30) NOT NULL,
    requiredBiome VARCHAR2(15) NOT NULL,
    speciesGroup VARCHAR2(30) NOT NULL,
    CONSTRAINT fk_speciesGroup FOREIGN KEY (speciesGroup) REFERENCES m2s_SpeciesGroup(latinName) ON DELETE CASCADE
);

CREATE TABLE m2s_Staff(
    sid INTEGER PRIMARY KEY,
    fName VARCHAR2(20) NOT NULL,
    lName VARCHAR2(20) NOT NULL,
    dob DATE NOT NULL,
    phNumber VARCHAR2(13) NOT NULL,
    email VARCHAR2(320) NOT NULL,
    streetNumber INTEGER NOT NULL,
    streetName VARCHAR2(30) NOT NULL,
    suburb VARCHAR2(30) NOT NULL,
    city VARCHAR2(30) NOT NULL,
    postCode VARCHAR2(4) NOT NULL,
    clinic VARCHAR2(50),
    sex CHAR(1) CHECK (sex IN ('F','M')) NOT NULL,
    CONSTRAINT ck_staff_dob CHECK (dob > TO_DATE('1900-01-01', 'YYYY-MM-DD'))
);

CREATE TABLE m2s_Animal(
    aid INTEGER PRIMARY KEY,
    sex CHAR(1) CHECK (sex IN ('F','M')) NOT NULL,
    feedingInterval INTEGER NOT NULL,
    name VARCHAR2(30) NOT NULL,
    weight DECIMAL(10,2) NOT NULL,
    originCountry CHAR(3) NOT NULL,
    dob DATE NOT NULL,
    enclosureID INTEGER,
    speciesName VARCHAR2(30) NOT NULL,
    CONSTRAINT ck_feedingInterval CHECK (feedingInterval > 0),
    CONSTRAINT ck_weight CHECK (weight > 0),
    CONSTRAINT ck_originCountry CHECK (LENGTH(originCountry) = 3),
    CONSTRAINT fk_enclosureID FOREIGN KEY (enclosureID) REFERENCES m2s_Enclosure(eid) ON DELETE SET NULL,
    CONSTRAINT fk_speciesName FOREIGN KEY (speciesName) REFERENCES m2s_Species(latinName) ON DELETE CASCADE
);

CREATE TABLE m2s_Oversees(
    sGroupName VARCHAR2(30),
    staffID INTEGER,
    PRIMARY KEY (sGroupName, staffID),
    CONSTRAINT fk_sGroupName FOREIGN KEY (sGroupName) REFERENCES m2s_SpeciesGroup(latinName) ON DELETE CASCADE,
    CONSTRAINT fk_staffID_oversees FOREIGN KEY (staffID) REFERENCES m2s_Staff(sid) ON DELETE CASCADE
);

CREATE TABLE m2s_Care(
    staffID INTEGER,
    animalID INTEGER,
    dateTime TIMESTAMP,
    care VARCHAR2(30) NOT NULL,
    notes VARCHAR2(300),
    PRIMARY KEY (staffID, animalID, dateTime),
    CONSTRAINT fk_staffID_care FOREIGN KEY (staffID) REFERENCES m2s_Staff(sid) ON DELETE SET NULL,
    CONSTRAINT fk_animalID_care FOREIGN KEY (animalID) REFERENCES m2s_Animal(aid) ON DELETE CASCADE
);

CREATE TABLE m2s_Feed(
    staffID INTEGER,
    animalID INTEGER,
    dateTime TIMESTAMP,
    amount DECIMAL(5,2) NOT NULL,
    foodType VARCHAR2(15) NOT NULL,
    PRIMARY KEY (staffID, animalID, dateTime),
    CONSTRAINT fk_staffID_feed FOREIGN KEY (staffID) REFERENCES m2s_Staff(sid) ON DELETE SET NULL,
    CONSTRAINT fk_animalID_feed FOREIGN KEY (animalID) REFERENCES m2s_Animal(aid) ON DELETE CASCADE
);

-- Insert into Zone
INSERT INTO m2s_Zone VALUES ('Africa', 'Yellow', 'FFFF00');
INSERT INTO m2s_Zone VALUES ('Native', 'Green', '008000');
INSERT INTO m2s_Zone VALUES ('Australia', 'Red', 'E4002B');

-- Insert into Enclosure
INSERT INTO m2s_Enclosure VALUES (1, 'Savanna', 500, 'Africa');
INSERT INTO m2s_Enclosure VALUES (2, 'Forest', 300, 'Native');
INSERT INTO m2s_Enclosure VALUES (3, 'Woodland', 400, 'Australia');

-- Insert into SpeciesGroup
INSERT INTO m2s_SpeciesGroup VALUES ('Carnivora', 'Carnivores');
INSERT INTO m2s_SpeciesGroup VALUES ('Apterygiformes', 'Kiwis');
INSERT INTO m2s_SpeciesGroup VALUES ('Diprotodontia', 'Marsupials');

-- Insert into Species
INSERT INTO m2s_Species VALUES ('Panthera leo', 'Lion', 'Savanna', 'Carnivora');
INSERT INTO m2s_Species VALUES ('Apteryx haastii', 'Great Spotted Kiwi', 'Forest', 'Apterygiformes');
INSERT INTO m2s_Species VALUES ('Macropus giganteus', 'Eastern Grey Kangaroo', 'Woodland', 'Diprotodontia');

-- Insert into Staff
INSERT INTO m2s_Staff VALUES (1, 'Sam', 'Cotton', TO_DATE('1986-04-01', 'YYYY-MM-DD'), '+64223278952', 'Sam.C@zoo.com', 32, 'Rim Road', 'Claudlands', 'Hamilton', '3216', NULL, 'M');
INSERT INTO m2s_Staff VALUES (2, 'Grace', 'White', TO_DATE('1996-07-24', 'YYYY-MM-DD'), '0246549875', 'GraceWhite547@hotmail.com', 7396, 'SH1', 'Karapiro', 'Waikato', '3472', NULL, 'F');

-- Insert into Animal
INSERT INTO m2s_Animal VALUES (1, 'M', 24, 'Leo', 210000.00, 'TZA', TO_DATE('2017-04-11', 'YYYY-MM-DD'), 1, 'Panthera leo');
INSERT INTO m2s_Animal VALUES (2, 'F', 24, 'Tama', 2000.00, 'NZL', TO_DATE('2015-03-03', 'YYYY-MM-DD'), 2, 'Apteryx haastii');
INSERT INTO m2s_Animal VALUES (3, 'M', 24, 'Skippy', 18000.00, 'AUS', TO_DATE('2018-08-20', 'YYYY-MM-DD'), 3, 'Macropus giganteus');

-- Insert into Oversees
INSERT INTO m2s_Oversees VALUES ('Carnivora', 1);
INSERT INTO m2s_Oversees VALUES ('Apterygiformes', 2);

-- Insert into Care
INSERT INTO m2s_Care VALUES (1, 1, TIMESTAMP '2025-04-25 10:00:00', 'Checkup', NULL);
INSERT INTO m2s_Care VALUES (2, 2, TIMESTAMP '2025-04-26 11:00:00', 'Vaccination', NULL);

-- Insert into Feed
INSERT INTO m2s_Feed VALUES (1, 1, TIMESTAMP '2025-04-25 08:00:00', 300.00, 'Meat');
INSERT INTO m2s_Feed VALUES (2, 2, TIMESTAMP '2025-04-26 08:00:00', 20.00, 'Grubs');
INSERT INTO m2s_Feed VALUES (1, 3, TIMESTAMP '2025-04-27 08:00:00', 100.00, 'Grass');

Select * from m2s_staff
