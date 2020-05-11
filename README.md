# SPToCore, a Stored Procedure Scaffolder for .netcore !!!

This command line utility has been created to simplify the stored procedures management in
new .netcore.

It allows you to scaffold a database to get a new context file with all the store procedures
and their parameters mapping:

In few words it extend current ef context by adding all the stored procedure methods and by mapping
all the parameters: you don't have to worry about passing params by generic object parameter.

## Why you need it ?

If you like me use to deal each day with big enterprise application, written long time ago where even the simple
CRUD operation in basic tables are done with stored procedures, you can undestand how difficulty is to migrate 
the application to .netcore.

This is why I have written a specific scaffolder, just to simplify the migration to .netcore for existing
applications whose strongly use stored procedures.

## From This:
To call a stored procedure in .netcore3 you have to:
1. Define the result class
2. Define the parameters
3. Call the Query or FromSqlRaw Method
4. Get the typed result or modified parameters

## To This:

### Example 1 

Get result list from stored procedure call ( like for a product search )

### Example 2

Call a Stored procedure who initialize and returns the new material id



