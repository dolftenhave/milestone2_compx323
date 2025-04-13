- parse an input string that specifies the format the data should be in 
- generate lines of csv data

#### Types of data
- varchar *lenght*
- int 
- date 
- time 

*Note:* the table may need to pull data from a column of another table when using foreign keys

#### tags
- **varshar** \-v *length*
- **int** \-i
- **date** \-d 
- **time** \-t

## classes

### generateTable.java
This is the entry point into the programm. It will call the parse class, parseArgs.java, which will then attempt to parse the class.

### parseArgs.java
This will attempt to parse the arguments passed into generate table into a better readable table that the generator class will use to generate all the lines of csv code. 
