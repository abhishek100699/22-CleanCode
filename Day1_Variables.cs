review 1:
public bool IsShopOpen(string day)
{
    if (string.IsNullOrEmpty(day))
    {
        day = day.ToLower();
        if(day == "friday" || day=="saturday" || day=="sunday"){
            return true
        }
        return false;
    }
    return false;

}

or 

public bool IsShopOpen(string day)
{
    if (string.IsNullOrEmpty(day))
    {
        return false;
    }
    
    public bool IsShopOpen = new[] = {"firday","sat","sun"};
    return openingDays.Any(decimal => d == day.ToLower());

}

------------------------------------------------------------------------------------


  review 3: 

public long Fibonacci(int n)
{
    if(n<50)
    {
        if(n==0 || n==1) return n;
        return Fibonacci(n-1) + Fibonacci(n-2);
    }
    else
    {
        throw new System.Exception("Not supported");
    }

}


-------------------------------------------------------
review 4:

var cities = new[] { "Austin", "New York", "San Francisco" };

for (var i = 0; i < cities.Count(); i++)
{
    var city = cities[i];
    DoStuff();
    DoSomeOtherStuff();

    // ...
    // ...
    // ...
    // Wait, what is `li` for again?
    Dispatch(city);
}


-------------------------------------------------------
  review 5:


const string ADMIN_ROLE = "Admin";
if (userRole == ADMIN_ROLE) // Check if Admin 
{
    
}

---------------------------------------------------

review 6:

public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }

    //...
}

------------------------------------------------
  reiew 7:

  var currentDatTime = DateTime.UtcNow.ToString("MMMM dd, yyyy");

review 9:

public void CreateMicrobrewery(string name =  "Hipster Brew Co.")
{
 
    // ...
}





