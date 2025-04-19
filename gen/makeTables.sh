#!/bin/bash

# @author Dolf ten Have
# This script automates the creation of table files for compx323 milestone 2

java parseArgs v -v -d -t -o 9000
java MakeCSV 2000 v_table.txt out

