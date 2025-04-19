#!/bin/bash

# @author Dolf ten Have
# This script automates the creation of table files for compx323 milestone 2

java parseArgs v -v 6 -d -t -o 7 9 -I 6 -V 2 -i 500
java MakeCSV $1 v_table.txt out

