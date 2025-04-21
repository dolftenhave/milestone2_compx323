#!/bin/bash

# @author Dolf ten Have

# Initialization of all the table files
java parseArgs SpeciesGroup -V 10 -v 30
java parseArgs Zone -V 10 -v 15 -h 6
java parseArgs Enclosure -I 0 -v 15 -i 1000 -F Zone.csv 0 
java parseArgs Species -V 20 -v 30 -f Enclosure.csv 2 -F SpeciesGroup.csv 0
java parseArgs Animal -I 0 -b -i 48 -v 10 -o 10 2 -f slim-3.csv 1 -d -F Enclosure.csv 0 -F Species.csv 0
java parseArgs Staff -I 0 -v 6 -v 10 -d -i 99999999 -e -v 15 -v 20
java parseArgs Oversees -F SpeciesGroup.csv 0 -F Staff.csv 0
java parseArgs Care -F Staff.csv 0 -F Animal.csv 0 -T -v 20 -v 200
java parseArgs Feed -F Staff.csv 0 -F Animal.csv 0 -T -o 5 2 -v 5

# Creation of mock data
java MakeCSV 1000 SpeciesGroup_table.txt SpeciesGroup
java MakeCSV 1000 Zone_table.txt Zone
java MakeCSV 3000 Enclosure_table.txt Enclosure
java MakeCSV 3000 Species_table.txt Species
java MakeCSV 5000 Animal_table.txt Animal
java MakeCSV 1000 Staff_table.txt Staff
java MakeCSV 8000 Oversees_table.txt Oversees
java MakeCSV 10000 Care_table.txt Care
java MakeCSV 30000 Feed_table.txt Feed
