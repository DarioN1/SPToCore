# SPToCore, a Stored Procedure Scaffolder for .netcore 

This command line utility has been created to simplify the stored procedures management in
new .netcore.

It allows you to scaffold a Microsoft SqlServer database and get a new context file with all the stored procedures methods.

In few words it extends the current EF Context by adding all the stored procedure methods and by mapping
all the parameters: you don't have to worry about passing params by generic object parameter.

## Installation

Just download "dist\SPToCore.exe" file.

## Usage

Here you can find and example of a real case:

```
SPToCore.exe scan -cnn "Data Source=DN1;Initial Catalog=myDB;Persist Security Info=True;User ID=myUser;Password=password;" -sch * -nsp SPToCoreTest -ctx EMGERPContext -sf Model -pf C:\Users\dario\Documents\github\SPToCore\SPToCoreTest\Model\ -f SPToCoreContext.cs
```
If you have properly set the parameters to write the output file to dest solution you are ready to go, otherwise
you can always write the file to a temp folder and add it manually to dest solution.

## Implementation

### Example 1 

Get result list from stored procedure call ( like for a products search )

```c#
public void Test1(){
  using (SPToCoreContext db = new SPToCoreContext()) {

      int? idUser = 1;
      int? includeNotClassified = 1;
      int? idMaterialDestination = 12345;
      int? flStock = 1;

      var res = db.Material_SEARCHAsync(idUser, includeNotClassified, idMaterialDestination, flStock);                

      foreach (var r in res.Result) {
          Console.WriteLine(r.Code);
      }
  }
}
```            

### Example 2

Call a Stored procedure who initializes a new Material and get the new material id.
In the example I will use a transaction, it works well also with them:

```c#
public void Test2(){
  using (SPToCoreContext db = new SPToCoreContext())
  {
    using (var transaction = db.Database.BeginTransaction())
    {
        for (int i = 0; i < 10; i++)
        {

            int idUser = 1;
            string code = $"TESTCODE{i}";
            string material = $"My test material {i}";
            int idMaterialClass = 1;
            int idUnitSelling = 1;
            int? idMaterial = 0;

            db.Material_INITIALIZE(idUser, code, material, idMaterialClass, idUnitSelling, ref idMaterial);
            Console.WriteLine($"The new idMaterial is {idMaterial}");
        }

        transaction.Rollback();
    }
  }
}
```   
## Params

All the parameters are mandatory, you have to specify each one of them:


| Parameter| ShortName | Description |
| --- | --- | ---|
| `connection` | `cnn` | SqlServer ConnectionString |
| `schema` | `sch` | SqlServer Schema to filter Stored Procedure ( leave * if you don't want to filter )  |
| `namespace` | `nsp` | Namespace name of the solution where the output file will be added |
| `context` | `ctx` | Entity Framework dbContext from where the SPToCoreContext inherits |
| `sfolder` | `sf` | Relative Solution folder where the output file will be added (like "Model")|
| `pfolder` | `pf` | Physical destination folder where the output file will be written |
| `filename` | `f` | Output file name |

## Compatibility

* SQL Server 2012 ( All versions )
* SQL Server 2014 ( All versions )
* SQL Server 2017 ( All versions )
* SQL Server 2019 ( All versions )

## Special Thanks

Special thanks to:

* Valecass
* Mobius_One93
* Kasuken

and all the Kasuken Discord Community for the support!

## Note

This is my first shared project on GitHub, I coded it during COVID-19 lockdown working from home with my fiancee and my two years old son, you can figure out... 

That's not the best environment for coding so please, be kind when you test and review the code. ;-)

I have tested the scanner with 4 big databases with 122, 250, 320 and 335 stored procedures, allone of the sp has been imported but
this utility must be tested a little bit more.

## License

MIT

