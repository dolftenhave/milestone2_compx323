/*
DROP TABLE m2_Ate;
DROP TABLE m2_Care;
DROP TABLE m2_Oversees;
DROP TABLE m2_Staff;
DROP TABLE m2_Animal;
DROP TABLE m2_Species;
DROP TABLE m2_Enclosure;
DROP TABLE m2_Zone;
DROP TABLE m2_SpeciesGroup;
*/

CREATE TABLE m2_SpeciesGroup(
    latinName VARCHAR(30) PRIMARY KEY, 
    commonName VARCHAR(30) NOT NULL
);

CREATE TABLE m2_Zone(
    name VARCHAR(30) PRIMARY KEY,
    colour VARCHAR(15) NOT NULL,
    hexcode VARCHAR(6) NOT NULL
);

CREATE TABLE m2_Enclosure(
    eid INTEGER PRIMARY KEY,
    biome VARCHAR(15) NOT NULL,
    eSize INTEGER NOT NULL,
    zoneName VARCHAR(30) NOT NULL,
    CONSTRAINT zoneCheck
        FOREIGN KEY (zoneName) REFERENCES m2_Zone(name)
        ON DELETE SET NULL
);

CREATE TABLE m2_Species(
    latinName VARCHAR(30) PRIMARY KEY,
    commonName VARCHAR(30) NOT NULL,
    requiredBiome VARCHAR(15) NOT NULL,
    speciesGroup VARCHAR(30) NOT NULL,
    CONSTRAINT speciesGroupCheck
        FOREIGN KEY (speciesGroup) REFERENCES m2_SpeciesGroup(latinName)
        ON DELETE CASCADE
);

CREATE TABLE m2_Animal(
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
        FOREIGN KEY (enclosureID) REFERENCES m2_Enclosure(eid)
        ON DELETE SET NULL,

    CONSTRAINT speciesNameCheck
        FOREIGN KEY (speciesName) REFERENCES m2_Species(latinName)
        ON DELETE CASCADE
);

CREATE TABLE m2_Staff(
    sid INTEGER PRIMARY KEY,
    fName VARCHAR(20) NOT NULL,
    lName VARCHAR(20) NOT NULL,
    dob DATE NOT NULL,
    -- Phone number is vharchar because of the posibility of '+' or leading 0's 
	-- In new zealand the maxum length of a phone number is 0+10 digits. In the case of a leading international number th e0 is replaced with +64 to indicate New Zealand. Hence the length of 13.
    phNumber VARCHAR(13) NOT NULL,
    email VARCHAR(320),
    address VARCHAR(100) NOT NULL,
    clinic VARCHAR (50),

    CONSTRAINT reasonableStaffDateOB
        CHECK (dob > TO_DATE('1900.01.01', 'YYYY.MM.DD'))
);

CREATE TABLE m2_Oversees(
    sGroupName VARCHAR(30),
    staffID INTEGER,
    PRIMARY KEY (sGroupName, staffID),
    CONSTRAINT checkValidSGroup
        FOREIGN KEY (sGroupName) REFERENCES m2_SpeciesGroup(latinName)
        ON DELETE CASCADE,
    CONSTRAINT checkValidStaffID
        FOREIGN KEY (staffID) REFERENCES m2_Zookeeper(sid)
        ON DELETE CASCADE
);

CREATE TABLE m2_Care(
    staffID INTEGER,
    animalID INTEGER,
    dateTime TIMESTAMP,
    care VARCHAR(30) NOT NULL,
    notes VARCHAR(300),
    PRIMARY KEY (staffID, animalID, dateTime),
    CONSTRAINT checkValidStaffID2
        FOREIGN KEY (staffID) REFERENCES m2_Vet(sid)
        -- Unsure about if this is valid (staffID part of primary key)
        ON DELETE SET NULL,
    CONSTRAINT checkValidAnimalID
        FOREIGN KEY (animalID) REFERENCES m2_Animal(aid)
        ON DELETE CASCADE
);

CREATE TABLE m2_Feed(
    staffID INTEGER,
    animalID INTEGER,
    dateTime TIMESTAMP,
    -- Amount in grams
    amount DECIMAL(5,2) NOT NULL,
    foodType VARCHAR(15) NOT NULL,
    PRIMARY KEY (staffID, animalID, dateTime),
    CONSTRAINT checkValidStaffID3
        FOREIGN KEY (staffID) REFERENCES m2_Zookeeper(sid)
        -- Unsure about if this is valid (staffID part of primary key)
        ON DELETE SET NULL,
    CONSTRAINT checkValidAnimalID2
        FOREIGN KEY (animalID) REFERENCES m2_Animal(aid)
        ON DELETE CASCADE
);
