/*
DROP TABLE m2s_Ate;
DROP TABLE m2s_Care;
DROP TABLE m2s_Oversees;
DROP TABLE m2s_Staff;
DROP TABLE m2s_Animal;
DROP TABLE m2s_Species;
DROP TABLE m2s_Enclosure;
DROP TABLE m2s_Zone;
DROP TABLE m2s_SpeciesGroup;
*/

CREATE TABLE m2s_SpeciesGroup(
    latinName VARCHAR(30) PRIMARY KEY, 
    commonName VARCHAR(30) NOT NULL
;

CREATE TABLE m2s_Zone(
    name VARCHAR(30) PRIMARY KEY,
    colour VARCHAR(15) NOT NULL,
    hexcode VARCHAR(6) NOT NULL
);

CREATE TABLE m2s_Enclosure(
    eid INTEGER PRIMARY KEY,
    biome VARCHAR(15) NOT NULL,
    eSize INTEGER NOT NULL,
    zoneName VARCHAR(30) NOT NULL,
    CONSTRAINT zoneCheck
        FOREIGN KEY (zoneName) REFERENCES m2s_Zone(name)
        ON DELETE SET NULL
);

CREATE TABLE m2s_Species(
    latinName VARCHAR(30) PRIMARY KEY,
    commonName VARCHAR(30) NOT NULL,
    requiredBiome VARCHAR(15) NOT NULL,
    speciesGroup VARCHAR(30) NOT NULL,
    CONSTRAINT speciesGroupCheck
        FOREIGN KEY (speciesGroup) REFERENCES m2s_SpeciesGroup(latinName)
        ON DELETE CASCADE
);

CREATE TABLE m2s_Animal(
    aid INTEGER PRIMARY KEY,
    -- F for female, T for male
    sex BOOLEAN NOT NULL,
    feedingInterval INTEGER NOT NULL,
    name VARCHAR(30) NOT NULL,
    -- Heaviest land animal: elephant (can be 10t!)
    -- Measured in g, to 2dp because of exceptionally light animals
    weight DECIMAL(10,2) NOT NULL,
    -- Follows standardised three letter codes for each country
    -- https://en.wikipedia.org/wiki/ISO_3166-1_alpha-3
    -- For unknown origin, use code 'XXX'
    originCountry CHAR(3) NOT NULL,
    dob DATE NOT NULL,
    enclosureID INTEGER NOT NULL,
    speciesName VARCHAR(30) NOT NULL,

    CONSTRAINT feedingIntervalCheck
        CHECK (feedingInterval > 0),

    CONSTRAINT weightCheck
        CHECK (weight > 0),

    CONSTRAINT countryCodeLengthCheck
        CHECK (length(originCountry) = 3),

    CONSTRAINT animalEnclosureCheck
        FOREIGN KEY (enclosureID) REFERENCES m2s_Enclosure(eid)
        ON DELETE SET NULL,

    CONSTRAINT speciesNameCheck
        FOREIGN KEY (speciesName) REFERENCES m2s_Species(latinName)
        ON DELETE CASCADE
);

CREATE TABLE m2s_Staff(
    sid INTEGER PRIMARY KEY,
    fName VARCHAR(20) NOT NULL,
    lName VARCHAR(20) NOT NULL,
    dob DATE NOT NULL,
    -- Phone number is vharchar because of the posibility of '+' or leading 0's 
	-- In new zealand the maxum length of a phone number is 0+10 digits. In the case of a leading international number th e0 is replaced with +64 to indicate New Zealand. Hence the length of 13.
    phNumber VARCHAR(13) NOT NULL,
    email VARCHAR(320) NOT NULL,

	-- Normalised address
	streetNumber INT NOT NULL,
	streetName VARCHAR(30) NOT NULL,
	suburb VARCHAR(30) NOT NULL,
	city VARCHAR(30) NOT NULL,
	postCode VARCHAR (4) NOT NULL,

    clinic VARCHAR (50),

    CONSTRAINT reasonableStaffDateOB
        CHECK (dob > TO_DATE('1900.01.01', 'YYYY.MM.DD'))
);

CREATE TABLE m2s_Oversees(
    sGroupName VARCHAR(30),
    staffID INTEGER,
    PRIMARY KEY (sGroupName, staffID),
    CONSTRAINT checkValidSGroup
        FOREIGN KEY (sGroupName) REFERENCES m2s_SpeciesGroup(latinName)
        ON DELETE CASCADE,
    CONSTRAINT checkValidStaffID
        FOREIGN KEY (staffID) REFERENCES m2s_Zookeeper(sid)
        ON DELETE CASCADE
);

CREATE TABLE m2s_Care(
    staffID INTEGER,
    animalID INTEGER,
    dateTime TIMESTAMP,
    care VARCHAR(30) NOT NULL,
    notes VARCHAR(300),
    PRIMARY KEY (staffID, animalID, dateTime),
    CONSTRAINT checkValidStaffID2
        FOREIGN KEY (staffID) REFERENCES m2s_Vet(sid)
        -- Unsure about if this is valid (staffID part of primary key)
        ON DELETE SET NULL,
    CONSTRAINT checkValidAnimalID
        FOREIGN KEY (animalID) REFERENCES m2s_Animal(aid)
        ON DELETE CASCADE
);

CREATE TABLE m2s_Feed(
    staffID INTEGER,
    animalID INTEGER,
    dateTime TIMESTAMP,
    -- Amount in grams
    amount DECIMAL(5,2) NOT NULL,
    foodType VARCHAR(15) NOT NULL,
    PRIMARY KEY (staffID, animalID, dateTime),
    CONSTRAINT checkValidStaffID3
        FOREIGN KEY (staffID) REFERENCES m2s_Zookeeper(sid)
        -- Unsure about if this is valid (staffID part of primary key)
        ON DELETE SET NULL,
    CONSTRAINT checkValidAnimalID2
        FOREIGN KEY (animalID) REFERENCES m2s_Animal(aid)
        ON DELETE CASCADE
);

--------------------------------------------------
-- Tables for large dataset
-------------------------------------------------
/*
DROP TABLE m2l_Ate;
DROP TABLE m2l_Care;
DROP TABLE m2l_Oversees;
DROP TABLE m2l_Staff;
DROP TABLE m2l_Animal;
DROP TABLE m2l_Species;
DROP TABLE m2l_Enclosure;
DROP TABLE m2l_Zone;
DROP TABLE m2l_SpeciesGroup;
*/

CREATE TABLE m2l_SpeciesGroup(
    latinName VARCHAR(30) PRIMARY KEY, 
    commonName VARCHAR(30) NOT NULL
;

CREATE TABLE m2l_Zone(
    name VARCHAR(30) PRIMARY KEY,
    colour VARCHAR(15) NOT NULL,
    hexcode VARCHAR(6) NOT NULL
);

CREATE TABLE m2l_Enclosure(
    eid INTEGER PRIMARY KEY,
    biome VARCHAR(15) NOT NULL,
    eSize INTEGER NOT NULL,
    zoneName VARCHAR(30) NOT NULL,
    CONSTRAINT zoneCheck
        FOREIGN KEY (zoneName) REFERENCES m2l_Zone(name)
        ON DELETE SET NULL
);

CREATE TABLE m2l_Species(
    latinName VARCHAR(30) PRIMARY KEY,
    commonName VARCHAR(30) NOT NULL,
    requiredBiome VARCHAR(15) NOT NULL,
    speciesGroup VARCHAR(30) NOT NULL,
    CONSTRAINT speciesGroupCheck
        FOREIGN KEY (speciesGroup) REFERENCES m2l_SpeciesGroup(latinName)
        ON DELETE CASCADE
);

CREATE TABLE m2l_Animal(
    aid INTEGER PRIMARY KEY,
    -- F for female, T for male
    sex BOOLEAN NOT NULL,
    feedingInterval INTEGER NOT NULL,
    name VARCHAR(30) NOT NULL,
    -- Heaviest land animal: elephant (can be 10t!)
    -- Measured in g, to 2dp because of exceptionally light animals
    weight DECIMAL(10,2) NOT NULL,
    -- Follows standardised three letter codes for each country
    -- https://en.wikipedia.org/wiki/ISO_3166-1_alpha-3
    -- For unknown origin, use code 'XXX'
    originCountry CHAR(3) NOT NULL,
    dob DATE NOT NULL,
    enclosureID INTEGER NOT NULL,
    speciesName VARCHAR(30) NOT NULL,

    CONSTRAINT feedingIntervalCheck
        CHECK (feedingInterval > 0),

    CONSTRAINT weightCheck
        CHECK (weight > 0),

    CONSTRAINT countryCodeLengthCheck
        CHECK (length(originCountry) = 3),

    CONSTRAINT animalEnclosureCheck
        FOREIGN KEY (enclosureID) REFERENCES m2l_Enclosure(eid)
        ON DELETE SET NULL,

    CONSTRAINT speciesNameCheck
        FOREIGN KEY (speciesName) REFERENCES m2l_Species(latinName)
        ON DELETE CASCADE
);

CREATE TABLE m2l_Staff(
    sid INTEGER PRIMARY KEY,
    fName VARCHAR(20) NOT NULL,
    lName VARCHAR(20) NOT NULL,
    dob DATE NOT NULL,
    -- Phone number is vharchar because of the posibility of '+' or leading 0's 
	-- In new zealand the maxum length of a phone number is 0+10 digits. In the case of a leading international number th e0 is replaced with +64 to indicate New Zealand. Hence the length of 13.
    phNumber VARCHAR(13) NOT NULL,
    email VARCHAR(320) NOT NULL,

	-- Normalised address
	streetNumber INT NOT NULL,
	streetName VARCHAR(30) NOT NULL,
	suburb VARCHAR(30) NOT NULL,
	city VARCHAR(30) NOT NULL,
	postCode VARCHAR (4) NOT NULL,

    clinic VARCHAR (50),

    CONSTRAINT reasonableStaffDateOB
        CHECK (dob > TO_DATE('1900.01.01', 'YYYY.MM.DD'))
);

CREATE TABLE m2l_Oversees(
    sGroupName VARCHAR(30),
    staffID INTEGER,
    PRIMARY KEY (sGroupName, staffID),
    CONSTRAINT checkValidSGroup
        FOREIGN KEY (sGroupName) REFERENCES m2l_SpeciesGroup(latinName)
        ON DELETE CASCADE,
    CONSTRAINT checkValidStaffID
        FOREIGN KEY (staffID) REFERENCES m2l_Zookeeper(sid)
        ON DELETE CASCADE
);

CREATE TABLE m2l_Care(
    staffID INTEGER,
    animalID INTEGER,
    dateTime TIMESTAMP,
    care VARCHAR(30) NOT NULL,
    notes VARCHAR(300),
    PRIMARY KEY (staffID, animalID, dateTime),
    CONSTRAINT checkValidStaffID2
        FOREIGN KEY (staffID) REFERENCES m2l_Vet(sid)
        -- Unsure about if this is valid (staffID part of primary key)
        ON DELETE SET NULL,
    CONSTRAINT checkValidAnimalID
        FOREIGN KEY (animalID) REFERENCES m2l_Animal(aid)
        ON DELETE CASCADE
);

CREATE TABLE m2l_Feed(
    staffID INTEGER,
    animalID INTEGER,
    dateTime TIMESTAMP,
    -- Amount in grams
    amount DECIMAL(5,2) NOT NULL,
    foodType VARCHAR(15) NOT NULL,
    PRIMARY KEY (staffID, animalID, dateTime),
    CONSTRAINT checkValidStaffID3
        FOREIGN KEY (staffID) REFERENCES m2l_Zookeeper(sid)
        -- Unsure about if this is valid (staffID part of primary key)
        ON DELETE SET NULL,
    CONSTRAINT checkValidAnimalID2
        FOREIGN KEY (animalID) REFERENCES m2l_Animal(aid)
        ON DELETE CASCADE
);
