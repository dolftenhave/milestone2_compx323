#!/bin/bash

# @author Dolf ten Have

# Initialization of all the table files
java parseArgs SpeciesGroup -V 10 -v 30
java parseArgs Zone -V 10 -v 15 -h 6
java parseArgs Enclosure -I 1 -v 15 -i 4 -F "csv/Zone.csv" 0 
java parseArgs Species -V 20 -v 30 -f "csv/Enclosure.csv" 2 -F "csv/SpeciesGroup.csv" 0
java parseArgs Staff -I 1 -v 6 -v 10 -d -p -e -i 3 -v 6 -v 7 -v 8 -i 4 -v 0 -s
java parseArgs Animal -I 1 -s -i 2 -v 8 -o 10 2 -f "csv/slim-3.csv" 1 -d -F "csv/Enclosure.csv" 0 -F "csv/Species.csv" 0
java parseArgs Oversees -F "csv/SpeciesGroup.csv" 0 -F "csv/Staff.csv" 0
java parseArgs Care -F "csv/Staff.csv" 0 -F "csv/Animal.csv" 0 -T -F "csv/care.csv" -v 200
java parseArgs Feed -F "csv/Staff.csv" 0 -F "csv/Animal.csv" 0 -T -o 5 2 -F "csv/food.csv" 0

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
