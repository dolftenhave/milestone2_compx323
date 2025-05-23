# Mongo DB

This folder contains all the documents needed to implement zoo.sql in mongodb.

[ER diagram](https://lucid.app/lucidchart/62e459d5-6a2c-4536-8235-2b0af8881b8c/edit?invitationId=inv_ec5c393a-edbf-48fc-a2c2-229d7e7fc4e2&page=0_0#).

### Staff

The top staff is a zookeeper and the bottom staff member is a vet.
```json
{
 "sid":1,
 "fname":"jason",
 "lname":"mamoa",
 "dob": new Date("YYYY-mm-dd"),
 "phoneNumber":"+64234567890",
 "email":"example@email.com",
 "street_num":"23a",
 "street_name":"street",
 "suburb":"sub",
 "city":"cityname",
 "postcode":"0123",
 "sex":"M",
 "overSees":[
    {$lookup: 1},
    {$lookup: 2}
    ]
}
{
 "sid":1,
 "fname":"jason",
 "lname":"mamoa",
 "dob": new Date("YYYY-mm-dd"),
 "phoneNumber":"+64234567890",
 "email":"example@email.com",
 "street_num":"23a",
 "street_name":"street",
 "suburb":"sub",
 "city":"cityname",
 "postcode":"0123",
 "sex":"M",
 "clinic":"this is a vet clinic",
 "care":[
 {$lookup: 1},
 {$looup: 2}]
}
```

### SpeciesGroup

```json
{
   "latin_name": "lName1",
   "common_name":"name1",
   "species":[
        {"latin_name":"lName11",
        "common_name":"name11",
        "requred_biome":"biome",
        "animal":[
            {
            animal ref
            }]
        }]
}
```

### Zone
```json
{
    "name":"e1",
    "Colour":"White",
    "hex_value":"ffffff",
    "enclosure":[
    { "eid":1,
    "biome":"jungle",
    "size":25,
    "animal":[
    {
    animal ref
    }
    ]}
}
```
### Animal

```json
{
    "aid":1,
    "name":"bon",
    "weight":12.90,
    "originCountry":"NLD",
    "dob": new Date("YYYY-mm-dd"),
    "sex":"M",
    "feedin_interval":24 
}
```

### Feed

```json
{
    "dateTime": new Date("YYYY-mm-ddTHH:MM:ss"),
    "care":"recieved",
    "notes":"care_notes",
    "animal":$lookup aid,
    "staff":$lookup sid
}
```

### Care 
```json
{ 
    "dateTime": new Date("YYYY-mm-ddTHH:MM:ss"),
    "food_type": "food",
    "ammount":124.00,
    "animal":$lookup aid,
    "staff":$lookup sid
}
