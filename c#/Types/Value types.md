# Value types

## Kort fortalt

```c#

int a = 1235;
float b = 123.321;
decimal c = 1235542.5432;
double d = 235656323432.23;

```

### Casting og konvertering

```c#
double a = 8;
int b = (int)a;

// Bedre variant, bruk .NET typens klasse. 
int c = Int32.Parse(a);

// Annet metode, forsøk å parse
int d;
if(Int32.TryParse(a, out d)
{
    // d = a, hvis vellykket
}
```

### Enums

```c#
enum Sertifikattyper
{
    SSL,
    Client,
    CodeSigning,
    RemoteDesktop
}

/* Koble dem til tallverdier, default er int */
enum Maaned
{
	Januar = 1, 
	Februar = 2, 
	Mars = 3, 
	osv...
}

Maaned ValgtMnd = Maaned.Februar;
Console.WriteLine(ValgtMnd.ToString());  // output: Februar
Console.WriteLine( (int) ValgtMnd);  // output: 2

/* For å sette en bestemt type */
enum ErrorCode : ushort
{
    None = 0,
    Unknown = 1,
    ConnectionLost = 100,
    OutlierReading = 200
}

/* Brukes boolean, kan man operere med boolske kombinasjoner, signaliseres med flag */
[Flags]
public enum Days
{
    Ingen     = 0b_0000_0000,  // 0
    Mandag    = 0b_0000_0001,  // 1
    Tirsdag   = 0b_0000_0010,  // 2
    Onsdag    = 0b_0000_0100,  // 4
    Torsdag   = 0b_0000_1000,  // 8
    Fredag    = 0b_0001_0000,  // 16
    Lordag    = 0b_0010_0000,  // 32
    Sondag    = 0b_0100_0000,  // 64
    Helg      = Lordag | Sondag
    Arbeidsdag= Mandag | Tirsdag | Onsdag | Torsdag | Fredag
}


```

### Struct

```c#
public struct Coords
{
    public Coords(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double X { get; }
    public double Y { get; }

    public override string ToString()
    {
    	return $"({X}, {Y})";
    }
}


// Immunable struct, legg merke til nøkkelordet "init", 
// som gjør den skrivbar under initialisjon, i stedet for kun gjennom constructor. 
public readonly struct Coords
{
    public Coords(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double X { get; init; }
    public double Y { get; init; }

    public override string ToString() => $"({X}, {Y})";
}

```

### Nullable types

Spesielt "kjekk å ha" i forbindelse med database. 

```c#
/* Variant 1 */
int? b = 10;
if (b.HasValue)
{
    Console.WriteLine($"b is {b.Value}");
}
else
{
    Console.WriteLine("b does not have a value");
}
// Output:
// b is 10



/* Variant 2 */
int? a = 42;
if (a is int valueOfA)
{
    Console.WriteLine($"a is {valueOfA}");
}
else
{
    Console.WriteLine("a does not have a value");
}
// Output:
// a is 42


/* Konvertering */
int? a = 28;
if(a.HasValue)
{
	b = a.Value;
}
else 
{
	b = 0;
}

/* Kjappere variant */
int? a = 38;
int b = a ?? 0;


```



## Ref: 

[Heltalls typer]([https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types)

[Flytende numeriske typer](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types)

[Innebygget numerisk konvertering](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/numeric-conversions)

[Binære](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool)

[Char](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/char)

[Enums](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum)

[Struct](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/struct)

[Tuple types](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-tuples)

[Nullable type](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/nullable-value-types)







