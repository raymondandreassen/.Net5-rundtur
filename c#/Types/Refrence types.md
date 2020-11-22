# Refrence types



### Class

#### Arv og Interface

Ingen arv 

```
class Klassen
{}
```

Singel arv

```
class Klassen : Arveklassen 
{}
```

Implementerer to interface

```
class Klassen : Interface1, Interface2 
{}
```

Arv og interface

```
class Klassen : Arveklassen, Interface1 
{}
```



#### Access modifiers

| [`public`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/public) |                                                              |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| [`protected`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/protected) | Access is limited to the containing class or types derived from the containing class. |
| [`internal`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/internal) | Access is limited to the current assembly.                   |
| [`protected internal`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/protected-internal) | Access is limited to the current assembly or types derived from the containing class. |
| [`private`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/private) | Access is limited to the containing type.                    |
| [`private protected`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/private-protected) | Access is limited to the containing class or types derived from the containing class within the current assembly. Available since C# 7.2. |



#### "Alt i ett demo". 

```C#
public class Bruker
{
    int brukerId;
    string brukernavn;
    string visningsnavn;
    
    public Bruker()
    {
        // Constructor
    }
    
    public BrukerId { get; init; }
    
    public Brukernavn
    {
        get { return brukernavn; }
        set { brukernavn = value; }
    }
    
    public Brukernavn { get; set; }
    
    public DoSomething()
    {
       	
    }
}

public class Student : Bruker
{
    public Bruker()
    {	// Constructor, som kaller base constructor og en base metode
        base.
        base.DoSomething();
    }
}
```

