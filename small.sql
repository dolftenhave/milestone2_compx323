-- Zone
INSERT INTO ZONE values ("Africa", "Yellow", "FFFF00");
INSERT INTO ZONE values ("Native", "Green", "008000");
INSERT INTO ZONE values ("Australia", "Red", "E4002B");

-- Enclosure
INSERT INTO ZONE values (1, "Arrid", 2, "Spider");
INSERT INTO ZONE values (91, "Jungle", 2, "Spider2");
INSERT INTO ZONE values (2, "Savanna", 847, "Great Africa");
INSERT INTO ZONE values (3, "Savanna", 657, "Lion");
INSERT INTO ZONE values (4, "Forest", 42, "Kiwi");
INSERT INTO ZONE values (5, "Forest", 210, "Birds");
INSERT INTO ZONE values (6, "Woodland", 374, "Australia Petting Zoo");
INSERT INTO ZONE values (90, "Forest", 434, "Koala");

--Species Group 
INSERT INTO ZONE values ("Arachnida", "Spider");
INSERT INTO ZONE values ("Carnivora", "Carnivores");
INSERT INTO ZONE values ("Apterygiformes", "Kiwi");
INSERT INTO ZONE values ("Proboscidea", "Elephant");
INSERT INTO ZONE values ("Diprotodontia", "Marsupials");
INSERT INTO ZONE values ("Perissodactyla", "horses, added, zebra");

--Species
INSERT INTO ZONE values ("Latrodectus occidentalis", "Mexican Black Widow Spider", "Jungle", "Arachnida");
INSERT INTO ZONE values ("Aphonopelma chalcodes", "western desert tarantula", "Arrid", "Arachnida");
INSERT INTO ZONE values ("Panthera leo", "Lion", "Savanna", "Carnivora");
INSERT INTO ZONE values ("Apteryx haastii", "Great Spotted Kiwi", "Forest", "Apterygiformes");
INSERT INTO ZONE values ("Loxodonta africana", "African Bush Elephant", "Savanna", "Proboscidea");
INSERT INTO ZONE values ("Macropus giganteus", "Eastern Grey Kangaroo", "Woodland", "Diprotodontia");
INSERT INTO ZONE values ("Notamacropus rufogriseus", "Red-Necked Wallaby", "Woodland", "Diprotodontia");
INSERT INTO ZONE values ("Equus quagga", "Plains Zebra", "Savanna", "Perissodactyla");
INSERT INTO ZONE values ("Diceros bicornis", "Black Rhinoceros", "Savanna", "Perissodactyla");
-- Animal
INSERT INTO ZONE values (1, 0, 12, "Roberto", 1, "MEX", to_date("2023-04-21", "YYYY-MM-DD"), 91, "Latrodectus occidentalis");
INSERT INTO ZONE values (2, 0, 48, "Chika", 150, "USA", to_date("2013-05-30", "YYYY-MM-DD"), 1, "Aphonopelma chalcodes");
INSERT INTO ZONE values (3, 1, 24, "Leo", 212345.0, "TZA", to_date("2017-04-11", "YYYY-MM-DD"), 3, "Panthera leo");
INSERT INTO ZONE values (4, 0, 24, "Sarah", 120334.0, "TZA", to_date("2020-04-19", "YYYY-MM-DD"), 3, "Panthera leo");
INSERT INTO ZONE values (5, 0, 24, "Lily", 140342.0, "TZA", to_date("2019-07-17", "YYYY-MM-DD"), 3, "Panthera leo");
INSERT INTO ZONE values (6, 0, 24, "Stephanie", 60376.0, "TZA", to_date("2024-11-12", "YYYY-MM-DD"), 3, "Panthera leo");
INSERT INTO ZONE values (7, 1, 24, "Tama", 2053.0, "NZL", to_date("1994-01-01", "YYYY-MM-DD"), 4, "Apteryx haastii");
INSERT INTO ZONE values (8, 1, 24, "Richie", 1934.0, "NZL", to_date("1997-12-31", "YYYY-MM-DD"), 4, "Apteryx haastii");
INSERT INTO ZONE values (9, 0, 24, "Grace", 2513.0, "NZL", to_date("2015-03-03", "YYYY-MM-DD"), 4, "Apteryx haastii");
INSERT INTO ZONE values (10, 0, 12, "Tiffany", 6134000.0, "ZAF", to_date("1992-07-19", "YYYY-MM-DD"), 2, "Loxodonta africana");
INSERT INTO ZONE values (11, 1, 12, "Dumbo", 3240000.0, "ZAF", to_date("1989-12-03", "YYYY-MM-DD"), 2, "Loxodonta africana");
INSERT INTO ZONE values (12, 0, 12, "Tigger", 17300.0, "AUS", to_date("2004-11-12", "YYYY-MM-DD"), 6, "Macropus giganteus");
INSERT INTO ZONE values (13, 0, 12, "Zongo", 19200.0, "AUS", to_date("2005-12-13", "YYYY-MM-DD"), 6, "Macropus giganteus");
INSERT INTO ZONE values (14, 0, 12, "Skippy", 17500.0, "AUS", to_date("2013-01-14", "YYYY-MM-DD"), 6, "Macropus giganteus");
INSERT INTO ZONE values (15, 1, 12, "Bazza", 19430.0, "AUS", to_date("2012-05-23", "YYYY-MM-DD"), 6, "Notamacropus rufogriseus");
INSERT INTO ZONE values (16, 1, 12, "Steve", 17800.0, "AUS", to_date("2017-08-06", "YYYY-MM-DD"), 6, "Notamacropus rufogriseus");
INSERT INTO ZONE values (17, 0, 12, "Anette", 13210.0, "AUS", to_date("2015-08-27", "YYYY-MM-DD"), 6, "Notamacropus rufogriseus");
INSERT INTO ZONE values (18, 0, 12, "Coutney", 3325.0, "AUS", to_date("2025-01-17", "YYYY-MM-DD"), 6, "Notamacropus rufogriseus");
INSERT INTO ZONE values (19, 1, 12, "Stripy", 412900.0, "NAM", to_date("1987-01-16", "YYYY-MM-DD"), 2, "Equus quagga");
INSERT INTO ZONE values (20, 0, 12, "Clopper", 390000.0, "NAM", to_date("1996-02-17", "YYYY-MM-DD"), 2, "Equus quagga");
INSERT INTO ZONE values (21, 0, 12, "Jess", 375300.0, "NAM", to_date("1997-04-23", "YYYY-MM-DD"), 2, "Equus quagga");
INSERT INTO ZONE values (22, 0, 12, "Fran", 402300.0, "NAM", to_date("2007-05-28", "YYYY-MM-DD"), 2, "Equus quagga");
INSERT INTO ZONE values (23, 0, 12, "Stella", 401400.0, "NAM", to_date("2017-07-14", "YYYY-MM-DD"), 2, "Equus quagga");
INSERT INTO ZONE values (24, 0, 12, "Bertha", 1450000.0, "ZAF", to_date("1985-04-23", "YYYY-MM-DD"), 2, "Diceros bicornis");

-- Staff

-- Oversees 

-- Care 

-- Feed


