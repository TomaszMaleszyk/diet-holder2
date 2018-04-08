# **Diet holder**
### **About project**
Diet Holder2 is my second edtion of application to help You to stay (or get) fit.

It’s a mix of necessary tools to reach Your goals, among others calculator of daily calories to eat value, daily statistics of Your diet or motivation and learning corner.<br />
*(Previous version You can find in this [localization](https://github.com/TomaszMaleszyk/diet-holder)).*

This application was created in C# language, .NET framework 4.5.</br>
It’s consist of web application and desktop client. </br>
Web application based on MVC structural pattern is sharing on localhost methods like:
```csharp 
public static double GetTdee(IPerson person)
{
    var bmrValue = CalculatorBmr.GetBmrValue(person);
    var teaValue = GetTeaFactor(bmrValue, person.DailyActivity);
    var tdeeFinalValue = IncludeNeatFactor(teaValue, person.GoalToRealize, person.SomaticType);
  
    return tdeeFinalValue;
}
```
to calculate Your [TDEE](https://www.youtube.com/watch?v=VdPKcsLoQOo) value,
```csharp 
public async Task Post(Products product)
{
    using(var databaseConnection = new DietHolder2Entities())
    { 
        databaseConnection.Products.Add(product);
    
        try
        {
            await databaseConnection.SaveChangesAsync();
        }
        catch(DbUpdateException)
        {
            if(ProductsExists(product.productId))
            {
                throw new Exception("Product existed in database");
            }
            throw;
        }
    }
}
```
to post new product into database using Entity Framework and others, possible to see on this repository.

Desktop application was created in WPF technology </br>
Main menu is looking like that: </br>

![Alt Text](https://media.giphy.com/media/YVEtYDZscnci06giv4/giphy.gif)


### Quick start
There isn't any installator or something like that but it will be created in future. </br>
At this moment if You want to start this application You must download this project and compile it in Your Visual Studio.

### Future plans
- application installator
- widely understood optimalization of application working
- mobile application (Xamarin)
- enlarge the product base
- finish statistic corner implementation

### Summary
⇒ Visual Studio 2015, .NET 4.5, WebApi, MVC, WPF, MVVM, Entity framework, MS SQL Server 2014 management studio
