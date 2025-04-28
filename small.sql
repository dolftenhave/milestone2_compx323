-- Zone
INSERT INTO m2s_Zone VALUES ("Africa", "Yellow", "FFFF00");
INSERT INTO m2s_Zone VALUES ("Native", "Green", "008000");
INSERT INTO m2s_Zone VALUES ("Australia", "Red", "E4002B");

-- Enclosure
INSERT INTO m2s_Enclosure VALUES (1, "Arrid", 2, "Spider");
INSERT INTO m2s_Enclosure VALUES (91, "Jungle", 2, "Spider2");
INSERT INTO m2s_Enclosure VALUES (2, "Savanna", 847, "Great Africa");
INSERT INTO m2s_Enclosure VALUES (3, "Savanna", 657, "Lion");
INSERT INTO m2s_Enclosure VALUES (4, "Forest", 42, "Kiwi");
INSERT INTO m2s_Enclosure VALUES (5, "Forest", 210, "Birds");
INSERT INTO m2s_Enclosure VALUES (6, "Woodland", 374, "Australia Petting Zoo");
INSERT INTO m2s_Enclosure VALUES (90, "Forest", 434, "Koala");

--Species Group 
INSERT INTO m2s_SpeciesGroup VALUES ("Arachnida", "Spider");
INSERT INTO m2s_SpeciesGroup VALUES ("Carnivora", "Carnivores");
INSERT INTO m2s_SpeciesGroup VALUES ("Apterygiformes", "Kiwi");
INSERT INTO m2s_SpeciesGroup VALUES ("Proboscidea", "Elephant");
INSERT INTO m2s_SpeciesGroup VALUES ("Diprotodontia", "Marsupials");
INSERT INTO m2s_SpeciesGroup VALUES ("Perissodactyla", "horses, added, zebra");

--Species
INSERT INTO m2s_Species VALUES ("Latrodectus occidentalis", "Mexican Black Widow Spider", "Jungle", "Arachnida");
INSERT INTO m2s_Species VALUES ("Aphonopelma chalcodes", "western desert tarantula", "Arrid", "Arachnida");
INSERT INTO m2s_Species VALUES ("Panthera leo", "Lion", "Savanna", "Carnivora");
INSERT INTO m2s_Species VALUES ("Apteryx haastii", "Great Spotted Kiwi", "Forest", "Apterygiformes");
INSERT INTO m2s_Species VALUES ("Loxodonta africana", "African Bush Elephant", "Savanna", "Proboscidea");
INSERT INTO m2s_Species VALUES ("Macropus giganteus", "Eastern Grey Kangaroo", "Woodland", "Diprotodontia");
INSERT INTO m2s_Species VALUES ("Notamacropus rufogriseus", "Red-Necked Wallaby", "Woodland", "Diprotodontia");
INSERT INTO m2s_Species VALUES ("Equus quagga", "Plains Zebra", "Savanna", "Perissodactyla");
INSERT INTO m2s_Species VALUES ("Diceros bicornis", "Black Rhinoceros", "Savanna", "Perissodactyla");
-- Animal
INSERT INTO m2s_Animal VALUES (1, 0, 12, "Roberto", 1, "MEX", to_date("2023-04-21", "YYYY-MM-DD"), 91, "Latrodectus occidentalis");
INSERT INTO m2s_Animal VALUES (2, 0, 48, "Chika", 150, "USA", to_date("2013-05-30", "YYYY-MM-DD"), 1, "Aphonopelma chalcodes");
INSERT INTO m2s_Animal VALUES (3, 1, 24, "Leo", 212345.0, "TZA", to_date("2017-04-11", "YYYY-MM-DD"), 3, "Panthera leo");
INSERT INTO m2s_Animal VALUES (4, 0, 24, "Sarah", 120334.0, "TZA", to_date("2020-04-19", "YYYY-MM-DD"), 3, "Panthera leo");
INSERT INTO m2s_Animal VALUES (5, 0, 24, "Lily", 140342.0, "TZA", to_date("2019-07-17", "YYYY-MM-DD"), 3, "Panthera leo");
INSERT INTO m2s_Animal VALUES (6, 0, 24, "Stephanie", 60376.0, "TZA", to_date("2024-11-12", "YYYY-MM-DD"), 3, "Panthera leo");
INSERT INTO m2s_Animal VALUES (7, 1, 24, "Tama", 2053.0, "NZL", to_date("1994-01-01", "YYYY-MM-DD"), 4, "Apteryx haastii");
INSERT INTO m2s_Animal VALUES (8, 1, 24, "Richie", 1934.0, "NZL", to_date("1997-12-31", "YYYY-MM-DD"), 4, "Apteryx haastii");
INSERT INTO m2s_Animal VALUES (9, 0, 24, "Grace", 2513.0, "NZL", to_date("2015-03-03", "YYYY-MM-DD"), 4, "Apteryx haastii");
INSERT INTO m2s_Animal VALUES (10, 0, 12, "Tiffany", 6134000.0, "ZAF", to_date("1992-07-19", "YYYY-MM-DD"), 2, "Loxodonta africana");
INSERT INTO m2s_Animal VALUES (11, 1, 12, "Dumbo", 3240000.0, "ZAF", to_date("1989-12-03", "YYYY-MM-DD"), 2, "Loxodonta africana");
INSERT INTO m2s_Animal VALUES (12, 0, 12, "Tigger", 17300.0, "AUS", to_date("2004-11-12", "YYYY-MM-DD"), 6, "Macropus giganteus");
INSERT INTO m2s_Animal VALUES (13, 0, 12, "Zongo", 19200.0, "AUS", to_date("2005-12-13", "YYYY-MM-DD"), 6, "Macropus giganteus");
INSERT INTO m2s_Animal VALUES (14, 0, 12, "Skippy", 17500.0, "AUS", to_date("2013-01-14", "YYYY-MM-DD"), 6, "Macropus giganteus");
INSERT INTO m2s_Animal VALUES (15, 1, 12, "Bazza", 19430.0, "AUS", to_date("2012-05-23", "YYYY-MM-DD"), 6, "Notamacropus rufogriseus");
INSERT INTO m2s_Animal VALUES (16, 1, 12, "Steve", 17800.0, "AUS", to_date("2017-08-06", "YYYY-MM-DD"), 6, "Notamacropus rufogriseus");
INSERT INTO m2s_Animal VALUES (17, 0, 12, "Anette", 13210.0, "AUS", to_date("2015-08-27", "YYYY-MM-DD"), 6, "Notamacropus rufogriseus");
INSERT INTO m2s_Animal VALUES (18, 0, 12, "Coutney", 3325.0, "AUS", to_date("2025-01-17", "YYYY-MM-DD"), 6, "Notamacropus rufogriseus");
INSERT INTO m2s_Animal VALUES (19, 1, 12, "Stripy", 412900.0, "NAM", to_date("1987-01-16", "YYYY-MM-DD"), 2, "Equus quagga");
INSERT INTO m2s_Animal VALUES (20, 0, 12, "Clopper", 390000.0, "NAM", to_date("1996-02-17", "YYYY-MM-DD"), 2, "Equus quagga");
INSERT INTO m2s_Animal VALUES (21, 0, 12, "Jess", 375300.0, "NAM", to_date("1997-04-23", "YYYY-MM-DD"), 2, "Equus quagga");
INSERT INTO m2s_Animal VALUES (22, 0, 12, "Fran", 402300.0, "NAM", to_date("2007-05-28", "YYYY-MM-DD"), 2, "Equus quagga");
INSERT INTO m2s_Animal VALUES (23, 0, 12, "Stella", 401400.0, "NAM", to_date("2017-07-14", "YYYY-MM-DD"), 2, "Equus quagga");
INSERT INTO m2s_Animal VALUES (24, 0, 12, "Bertha", 1450000.0, "ZAF", to_date("1985-04-23", "YYYY-MM-DD"), 2, "Diceros bicornis");

-- Staff
INSERT INTO m2s_Staff VALUES ( 1, "Sam", "Cotton", to_date("1986-04-01", "YYYY-MM-DD"), "+64223278952","Sam.C@zoo.com",32, "Rim Road", "Claudlands", "Hamilton", "3216", NULL);
INSERT INTO m2s_Staff VALUES ( 2, "Grace", "White", to_date("1996-07-24", "YYYY-MM-DD"), "0246549875","GraceWhite547@hotmail.com",7396, "SH1", "Karapiro", "Waikato", "3472","Karapiro Vets");
INSERT INTO m2s_Staff VALUES ( 3, "Bruce", "Batton", to_date("1975-07-13", "YYYY-MM-DD"), "0225768945","BrucieTheBest@gmail.com",32, "Masters Ave", "Silverdale", "Hamilton", "3216", NULL);
INSERT INTO m2s_Staff VALUES ( 4, "Bryce", "Trainer", to_date("1998-17-24", "YYYY-MM-DD"), "0224519736","BryceTrainsALot@outlook.com", 54, "Hillcrest rd", "Hillcrest", "Hamilton", "3216","Newstead Vets");
INSERT INTO m2s_Staff VALUES ( 5, "Kendal", "Tanner", to_date("2001-01-16", "YYYY-MM-DD"), "0219843275","kt175@notReal.students.waikato.ac.nz",03, "Paul Close", "Hillcrest", "Hamilton", "3216",NULL);

-- Oversees 
INSERT INTO m2s_Oversees VALUES ("Arachnida", 1);
INSERT INTO m2s_Oversees VALUES ("Carnivora", 1);
INSERT INTO m2s_Oversees VALUES ("Apterygiformes", 1);
INSERT INTO m2s_Oversees VALUES ("Arachnida", 3);
INSERT INTO m2s_Oversees VALUES ("Carnivora", 3);
INSERT INTO m2s_Oversees VALUES ("Apterygiformes", 3);
INSERT INTO m2s_Oversees VALUES ("Apterygiformes", 5);
INSERT INTO m2s_Oversees VALUES ("Diprotodontia", 5);
INSERT INTO m2s_Oversees VALUES ("Proboscidea", 3);
INSERT INTO m2s_Oversees VALUES ("Proboscidea", 1);
INSERT INTO m2s_Oversees VALUES ("Diprotodontia", 1);
INSERT INTO m2s_Oversees VALUES ("Perissodactyla", 1);
INSERT INTO m2s_Oversees VALUES ("Perissodactyla", 3);

-- Care 
INSERT INTO m2s_Care VALUES (2, 19, TIMESTAMP "2025-04-03 10:30:00", "Trimmed Hoofs", NULL);
INSERT INTO m2s_Care VALUES (2, 20, TIMESTAMP "2025-04-03 10:40:00", "Trimmed Hoofs", NULL );
INSERT INTO m2s_Care VALUES (2, 21, TIMESTAMP "2025-04-03 10:50:00", "Trimmed Hoofs", NULL );
INSERT INTO m2s_Care VALUES (2, 22, TIMESTAMP "2025-04-03 11:00:00", "Trimmed Hoofs", NULL );
INSERT INTO m2s_Care VALUES (2, 23, TIMESTAMP "2025-04-03 11:10:00", "Trimmed Hoofs", NULL );
INSERT INTO m2s_Care VALUES (4, 8, TIMESTAMP "2025-01-06 11:10:00", "Trouble Breathing", "The kiwi seemed to have trouble breathing. Coming back in 2 days for further Chechup.");
INSERT INTO m2s_Care VALUES (4, 8, TIMESTAMP "2025-01-08 12:10:00", "Trouble Breathing", "Medicine seemed to have worked. No further care needed");

-- Feed

--Thank god for VIM visual block 

-- Black Widow Spider
INSERT INTO m2s_Feed VALUES (1, 1, TIMESTAMP "2025-04-03 10:30:00", 0.2, "Meal Worm");
INSERT INTO m2s_Feed VALUES (1, 1, TIMESTAMP "2025-04-02 10:30:00", 0.2, "Meal Worm");
INSERT INTO m2s_Feed VALUES (1, 1, TIMESTAMP "2025-04-04 10:30:00", 0.2, "Meal Worm");
INSERT INTO m2s_Feed VALUES (1, 1, TIMESTAMP "2025-04-05 10:30:00", 0.2, "Meal Worm");
INSERT INTO m2s_Feed VALUES (2, 1, TIMESTAMP "2025-04-03 22:40:00", 0.2, "Meal Worm");
INSERT INTO m2s_Feed VALUES (2, 1, TIMESTAMP "2025-04-02 22:30:00", 0.2, "Meal Worm");
INSERT INTO m2s_Feed VALUES (2, 1, TIMESTAMP "2025-04-04 22:30:00", 0.2, "Meal Worm");
INSERT INTO m2s_Feed VALUES (2, 1, TIMESTAMP "2025-04-05 22:30:00", 0.2, "Meal Worm");

-- Terantual
INSERT INTO m2s_Feed VALUES (1, 2, TIMESTAMP "2025-04-03 12:30:00", 20,"Meat");
INSERT INTO m2s_Feed VALUES (1, 2, TIMESTAMP "2025-04-01 12:30:00", 20,"Meat");
INSERT INTO m2s_Feed VALUES (1, 2, TIMESTAMP "2025-04-07 12:30:00", 20,"Meat");
INSERT INTO m2s_Feed VALUES (1, 2, TIMESTAMP "2025-04-09 12:30:00", 20,"Meat");
INSERT INTO m2s_Feed VALUES (1, 2, TIMESTAMP "2025-04-11 12:30:00", 20,"Meat");
INSERT INTO m2s_Feed VALUES (1, 2, TIMESTAMP "2025-04-13 12:30:00", 20,"Meat");
INSERT INTO m2s_Feed VALUES (1, 2, TIMESTAMP "2025-04-15 12:30:00", 20,"Meat");

-- Lion Enclosure
INSERT INTO m2s_Feed VALUES (3, 3,TIMESTAMP "2025-04-15 12:30:00",3000,"Meat");
INSERT INTO m2s_Feed VALUES (3, 4,TIMESTAMP "2025-04-15 12:30:00",3000,"Meat");
INSERT INTO m2s_Feed VALUES (3, 5,TIMESTAMP "2025-04-15 12:30:00",3000,"Meat");
INSERT INTO m2s_Feed VALUES (3, 6,TIMESTAMP "2025-04-15 12:30:00",3000,"Meat");
INSERT INTO m2s_Feed VALUES (3, 3,TIMESTAMP "2025-04-13 12:30:00",3000,"Meat");
INSERT INTO m2s_Feed VALUES (3, 4,TIMESTAMP "2025-04-13 12:30:00",3000,"Meat");
INSERT INTO m2s_Feed VALUES (3, 5,TIMESTAMP "2025-04-13 12:30:00",3000,"Meat");
INSERT INTO m2s_Feed VALUES (3, 6,TIMESTAMP "2025-04-13 12:30:00",3000,"Meat");
INSERT INTO m2s_Feed VALUES (1, 3,TIMESTAMP "2025-04-11 12:30:00",3000,"Meat");
INSERT INTO m2s_Feed VALUES (1, 4,TIMESTAMP "2025-04-11 12:30:00",3000,"Meat");
INSERT INTO m2s_Feed VALUES (1, 5,TIMESTAMP "2025-04-11 12:30:00",3000,"Meat");
INSERT INTO m2s_Feed VALUES (1, 6,TIMESTAMP "2025-04-11 12:30:00",3000,"Meat");
INSERT INTO m2s_Feed VALUES (3, 3,TIMESTAMP "2025-04-17 12:30:00",3000,"Meat");
INSERT INTO m2s_Feed VALUES (3, 4,TIMESTAMP "2025-04-17 12:30:00",3000,"Meat");
INSERT INTO m2s_Feed VALUES (3, 5,TIMESTAMP "2025-04-17 12:30:00",3000,"Meat");
INSERT INTO m2s_Feed VALUES (3, 6,TIMESTAMP "2025-04-17 12:30:00",3000,"Meat");

-- Kiwi Enclosure
INSERT INTO m2s_Feed VALUES (5, 7,TIMESTAMP "2025-04-11 12:30:00",20,"Grubs");
INSERT INTO m2s_Feed VALUES (5, 8,TIMESTAMP "2025-04-11 12:30:00",20,"Grubs");
INSERT INTO m2s_Feed VALUES (5, 9,TIMESTAMP "2025-04-11 12:30:00",20,"Grubs");

INSERT INTO m2s_Feed VALUES (5, 7,TIMESTAMP "2025-04-13 12:30:00",20,"Grubs");
INSERT INTO m2s_Feed VALUES (5, 8,TIMESTAMP "2025-04-13 12:30:00",20,"Grubs");
INSERT INTO m2s_Feed VALUES (5, 9,TIMESTAMP "2025-04-13 12:30:00",20,"Grubs");

INSERT INTO m2s_Feed VALUES (5, 7,TIMESTAMP "2025-04-14 12:30:00",20,"Grubs");
INSERT INTO m2s_Feed VALUES (5, 8,TIMESTAMP "2025-04-14 12:30:00",20,"Grubs");
INSERT INTO m2s_Feed VALUES (5, 9,TIMESTAMP "2025-04-14 12:30:00",20,"Grubs");

INSERT INTO m2s_Feed VALUES (5, 7,TIMESTAMP "2025-04-15 12:30:00",20,"Grubs");
INSERT INTO m2s_Feed VALUES (5, 8,TIMESTAMP "2025-04-15 12:30:00",20,"Grubs");
INSERT INTO m2s_Feed VALUES (5, 9,TIMESTAMP "2025-04-15 12:30:00",20,"Grubs");

-- Africa Enclusure
INSERT INTO m2s_Feed VALUES (3, 10,TIMESTAMP "2025-04-15 15:30:00",20000,"Hay & Fruits");
INSERT INTO m2s_Feed VALUES (3, 11,TIMESTAMP "2025-04-15 15:30:00",20000,"Hay & Fruits");
INSERT INTO m2s_Feed VALUES (3, 19,TIMESTAMP "2025-04-15 15:30:00",2000,"Hay & Fruits");
INSERT INTO m2s_Feed VALUES (3, 20,TIMESTAMP "2025-04-15 15:30:00",2000,"Hay & Fruits");
INSERT INTO m2s_Feed VALUES (3, 21,TIMESTAMP "2025-04-15 15:30:00",2000,"Hay & Fruits");
INSERT INTO m2s_Feed VALUES (3, 22,TIMESTAMP "2025-04-15 15:30:00",2000,"Hay & Fruits");
INSERT INTO m2s_Feed VALUES (3, 21,TIMESTAMP "2025-04-15 15:30:00",2000,"Hay & Fruits");
INSERT INTO m2s_Feed VALUES (3, 22,TIMESTAMP "2025-04-15 15:30:00",2000,"Hay & Fruits");
INSERT INTO m2s_Feed VALUES (3, 23,TIMESTAMP "2025-04-15 15:30:00",2000,"Hay & Fruits");
INSERT INTO m2s_Feed VALUES (3, 24,TIMESTAMP "2025-04-15 15:30:00",8000,"Hay & Fruits");

INSERT INTO m2s_Feed VALUES (3, 10,TIMESTAMP "2025-04-14 15:30:00",20000,"Hay & Fruits");
INSERT INTO m2s_Feed VALUES (3, 11,TIMESTAMP "2025-04-14 15:30:00",20000,"Hay & Fruits");
INSERT INTO m2s_Feed VALUES (3, 19,TIMESTAMP "2025-04-14 15:30:00",2000,"Hay & Fruits");
INSERT INTO m2s_Feed VALUES (3, 20,TIMESTAMP "2025-04-14 15:30:00",2000,"Hay & Fruits");
INSERT INTO m2s_Feed VALUES (3, 21,TIMESTAMP "2025-04-14 15:30:00",2000,"Hay & Fruits");
INSERT INTO m2s_Feed VALUES (3, 22,TIMESTAMP "2025-04-14 15:30:00",2000,"Hay & Fruits");
INSERT INTO m2s_Feed VALUES (3, 21,TIMESTAMP "2025-04-14 15:30:00",2000,"Hay & Fruits");
INSERT INTO m2s_Feed VALUES (3, 22,TIMESTAMP "2025-04-14 15:30:00",2000,"Hay & Fruits");
INSERT INTO m2s_Feed VALUES (3, 23,TIMESTAMP "2025-04-14 15:30:00",2000,"Hay & Fruits");
INSERT INTO m2s_Feed VALUES (3, 24,TIMESTAMP "2025-04-14 15:30:00",8000,"Hay & Fruits");

INSERT INTO m2s_Feed VALUES (3, 10,TIMESTAMP "2025-04-13 15:30:00",20000,"Hay & Fruits");
INSERT INTO m2s_Feed VALUES (3, 11,TIMESTAMP "2025-04-13 15:30:00",20000,"Hay & Fruits");
INSERT INTO m2s_Feed VALUES (3, 19,TIMESTAMP "2025-04-13 15:30:00",2000,"Hay & Fruits");
INSERT INTO m2s_Feed VALUES (3, 20,TIMESTAMP "2025-04-13 15:30:00",2000,"Hay & Fruits");
INSERT INTO m2s_Feed VALUES (3, 21,TIMESTAMP "2025-04-13 15:30:00",2000,"Hay & Fruits");
INSERT INTO m2s_Feed VALUES (3, 22,TIMESTAMP "2025-04-13 15:30:00",2000,"Hay & Fruits");
INSERT INTO m2s_Feed VALUES (3, 21,TIMESTAMP "2025-04-13 15:30:00",2000,"Hay & Fruits");
INSERT INTO m2s_Feed VALUES (3, 22,TIMESTAMP "2025-04-13 15:30:00",2000,"Hay & Fruits");
INSERT INTO m2s_Feed VALUES (3, 23,TIMESTAMP "2025-04-13 15:30:00",2000,"Hay & Fruits");
INSERT INTO m2s_Feed VALUES (3, 24,TIMESTAMP "2025-04-13 15:30:00",8000,"Hay & Fruits");

INSERT INTO m2s_Feed VALUES (1, 10,TIMESTAMP "2025-04-12 15:30:00",20000,"Hay & Fruits");
INSERT INTO m2s_Feed VALUES (1, 11,TIMESTAMP "2025-04-12 15:30:00",20000,"Hay & Fruits");
INSERT INTO m2s_Feed VALUES (1, 19,TIMESTAMP "2025-04-12 15:30:00",2000,"Hay & Fruits");
INSERT INTO m2s_Feed VALUES (1, 20,TIMESTAMP "2025-04-12 15:30:00",2000,"Hay & Fruits");
INSERT INTO m2s_Feed VALUES (1, 21,TIMESTAMP "2025-04-12 15:30:00",2000,"Hay & Fruits");
INSERT INTO m2s_Feed VALUES (1, 22,TIMESTAMP "2025-04-12 15:30:00",2000,"Hay & Fruits");
INSERT INTO m2s_Feed VALUES (1, 21,TIMESTAMP "2025-04-12 15:30:00",2000,"Hay & Fruits");
INSERT INTO m2s_Feed VALUES (1, 22,TIMESTAMP "2025-04-12 15:30:00",2000,"Hay & Fruits");
INSERT INTO m2s_Feed VALUES (1, 23,TIMESTAMP "2025-04-12 15:30:00",2000,"Hay & Fruits");
INSERT INTO m2s_Feed VALUES (1, 24,TIMESTAMP "2025-04-12 15:30:00",8000,"Hay & Fruits");

INSERT INTO m2s_Feed VALUES (1, 10,TIMESTAMP "2025-04-11 15:30:00",20000,"Hay & Fruits");
INSERT INTO m2s_Feed VALUES (1, 11,TIMESTAMP "2025-04-11 15:30:00",20000,"Hay & Fruits");
INSERT INTO m2s_Feed VALUES (1, 19,TIMESTAMP "2025-04-11 15:30:00",2000,"Hay & Fruits");
INSERT INTO m2s_Feed VALUES (1, 20,TIMESTAMP "2025-04-11 15:30:00",2000,"Hay & Fruits");
INSERT INTO m2s_Feed VALUES (1, 21,TIMESTAMP "2025-04-11 15:30:00",2000,"Hay & Fruits");
INSERT INTO m2s_Feed VALUES (1, 22,TIMESTAMP "2025-04-11 15:30:00",2000,"Hay & Fruits");
INSERT INTO m2s_Feed VALUES (1, 21,TIMESTAMP "2025-04-11 15:30:00",2000,"Hay & Fruits");
INSERT INTO m2s_Feed VALUES (1, 22,TIMESTAMP "2025-04-11 15:30:00",2000,"Hay & Fruits");
INSERT INTO m2s_Feed VALUES (1, 23,TIMESTAMP "2025-04-11 15:30:00",2000,"Hay & Fruits");
INSERT INTO m2s_Feed VALUES (1, 24,TIMESTAMP "2025-04-11 15:30:00",8000,"Hay & Fruits");

-- Aus enclosure
INSERT INTO m2s_Feed VALUES (3,12,TIMESTAMP "2025-04-11 15:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (3,13,TIMESTAMP "2025-04-11 15:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (3,14,TIMESTAMP "2025-04-11 15:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (3,15,TIMESTAMP "2025-04-11 15:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (3,16,TIMESTAMP "2025-04-11 15:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (3,17,TIMESTAMP "2025-04-11 15:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (3,18,TIMESTAMP "2025-04-11 15:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (5,12,TIMESTAMP "2025-04-11 09:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (5,13,TIMESTAMP "2025-04-11 09:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (5,14,TIMESTAMP "2025-04-11 09:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (5,15,TIMESTAMP "2025-04-11 09:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (5,16,TIMESTAMP "2025-04-11 09:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (5,17,TIMESTAMP "2025-04-11 09:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (5,18,TIMESTAMP "2025-04-11 09:30:00",1000.0,"Cornmeal & Protien");

INSERT INTO m2s_Feed VALUES (3,12,TIMESTAMP "2025-04-12 15:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (3,13,TIMESTAMP "2025-04-12 15:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (3,14,TIMESTAMP "2025-04-12 15:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (3,15,TIMESTAMP "2025-04-12 15:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (3,16,TIMESTAMP "2025-04-12 15:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (3,17,TIMESTAMP "2025-04-12 15:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (3,18,TIMESTAMP "2025-04-12 15:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (5,12,TIMESTAMP "2025-04-12 09:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (5,13,TIMESTAMP "2025-04-12 09:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (5,14,TIMESTAMP "2025-04-12 09:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (5,15,TIMESTAMP "2025-04-12 09:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (5,16,TIMESTAMP "2025-04-12 09:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (5,17,TIMESTAMP "2025-04-12 09:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (5,18,TIMESTAMP "2025-04-12 09:30:00",1000.0,"Cornmeal & Protien");

INSERT INTO m2s_Feed VALUES (3,12,TIMESTAMP "2025-04-13 15:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (3,13,TIMESTAMP "2025-04-13 15:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (3,14,TIMESTAMP "2025-04-13 15:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (3,15,TIMESTAMP "2025-04-13 15:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (3,16,TIMESTAMP "2025-04-13 15:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (3,17,TIMESTAMP "2025-04-13 15:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (3,18,TIMESTAMP "2025-04-13 15:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (5,12,TIMESTAMP "2025-04-13 09:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (5,13,TIMESTAMP "2025-04-13 09:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (5,14,TIMESTAMP "2025-04-13 09:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (5,15,TIMESTAMP "2025-04-13 09:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (5,16,TIMESTAMP "2025-04-13 09:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (5,17,TIMESTAMP "2025-04-13 09:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (5,18,TIMESTAMP "2025-04-13 09:30:00",1000.0,"Cornmeal & Protien");

INSERT INTO m2s_Feed VALUES (3,12,TIMESTAMP "2025-04-14 15:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (3,13,TIMESTAMP "2025-04-14 15:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (3,14,TIMESTAMP "2025-04-14 15:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (3,15,TIMESTAMP "2025-04-14 15:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (3,16,TIMESTAMP "2025-04-14 15:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (3,17,TIMESTAMP "2025-04-14 15:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (3,18,TIMESTAMP "2025-04-14 15:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (5,12,TIMESTAMP "2025-04-14 09:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (5,13,TIMESTAMP "2025-04-14 09:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (5,14,TIMESTAMP "2025-04-14 09:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (5,15,TIMESTAMP "2025-04-14 09:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (5,16,TIMESTAMP "2025-04-14 09:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (5,17,TIMESTAMP "2025-04-14 09:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (5,18,TIMESTAMP "2025-04-14 09:30:00",1000.0,"Cornmeal & Protien");

INSERT INTO m2s_Feed VALUES (3,12,TIMESTAMP "2025-04-15 15:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (3,13,TIMESTAMP "2025-04-15 15:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (3,14,TIMESTAMP "2025-04-15 15:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (3,15,TIMESTAMP "2025-04-15 15:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (3,16,TIMESTAMP "2025-04-15 15:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (3,17,TIMESTAMP "2025-04-15 15:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (3,18,TIMESTAMP "2025-04-15 15:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (5,12,TIMESTAMP "2025-04-15 09:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (5,13,TIMESTAMP "2025-04-15 09:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (5,14,TIMESTAMP "2025-04-15 09:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (5,15,TIMESTAMP "2025-04-15 09:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (5,16,TIMESTAMP "2025-04-15 09:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (5,17,TIMESTAMP "2025-04-15 09:30:00",1000.0,"Cornmeal & Protien");
INSERT INTO m2s_Feed VALUES (5,18,TIMESTAMP "2025-04-15 09:30:00",1000.0,"Cornmeal & Protien");

-- INSERT INTO m2s_Feed VALUES (3,,TIMESTAMP " ",,"");
