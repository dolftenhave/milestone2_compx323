# Data Generation App

This application is designed to generate large amounts of csv data.

## parseArgs

This program generates a pre defined table that will be used by MakeCSV to generate a bunch of random csv data

#### Usage

`parseArgs <table name> <arguments>`

There are several different type of arguments used to greate the data

- **varchar** `-v <length>` legnth 1 to n.
- **integer** `-i <length>` lengtth 0 will auto increment starting form 1. A fixed lenth will generate a random number with that many digits *e.g. 2 will generate a number 10-99*
- **date** `-d` will generate a random date in the format DD/MM/YYYY
- **time** `-t` will generate a random time
- **file** `-f <path to file> <column to choose the data from>` will take data from a specified column of another csv file and insert it into this column. This is used in instances of foreign keys.
- **double** `-o <length> <delimiter position>` will generate a dounle with the length and position of the delimiter.

## MakeCSV
