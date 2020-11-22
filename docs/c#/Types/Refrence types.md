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

| Declared accessibility                                       | Meaning                                                      |
| :----------------------------------------------------------- | :----------------------------------------------------------- |
| [`public`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/public) | Access is not restricted.<br />                              |
| [`protected`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/protected) | Access is limited to the containing class or <br />types derived from the containing class. |
| [`internal`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/internal) | Access is limited to the current assembly.<br />             |
| [`protected internal`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/protected-internal) | Access is limited to the current assembly or <br />types derived from the containing class. |
| [`private`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/private) | Access is limited to the containing type.<br />              |
| [`private protected`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/private-protected) | Access is limited to the containing class or <br />types derived from the containing class within the current assembly. |

### Class

```C#
public class Bruker
{
      string brukernavn;

        // Vanlig Constructor
        public Bruker()
        { }

        // Constructor med innhold
        public Bruker(string brukernavn)
        {   // Kanskje ikke helt innafor å ha like navn på property og parameter
            this.brukernavn = brukernavn;
        }

        // Property som settes under init, slik
        // new Bruker()
        // {
        // 		BrukerId = 12345;
        // }

    	// Med init, så gjør vi den read-only. 
    	// Trenger ikke å sette gjennom constructor
        public int BrukerId { get; init; }

        // Vanlig 
        public string Brukernavn1
        {
            get { return brukernavn; }
            set
            { 
                brukernavn = value; }
            }
    
        // Forenklet
        public string Brukernavn2 { get; set; }

        // void metode
        public void DoSomething()
        {

        }

        // metode som returnerer
        public string DoSomethingElse()
        {
            return ".....";
        }  
}
```



### Class arv

```c#
public class Student : Bruker
{
    public Student() : base()
    {	// Constructor, som kaller base constructor og en base metode
    }
    
    public void DoSomethingStudent()
    {	// Vanlig kall av base
    	base.DoSomethingBase();
    }
}
```



### Class arv, bruker expression body

Alt etter => er et gyldig kodeuttrykk. 

```c#
public class Ansatt : Bruker
{
    string ansattkode;
	string avdeling;

   public string Ansattkode(string kode) => ansattkode = kode;

   public string Avdeling
   {
      get => avdeling;
      set => avdeling = value;
   }
}
```



### Finalizer

```c#
public class Something
{
    ~Destroyer() => Console.WriteLine($"The {ToString()} destructor is executing.");
}
```



### Delegates

Delegates er referanser til metoder, med en bestemt parameterliste og retur type. Delegates brukes for å sende metoder som argumenter til andre metoder. Event handler er ingenting mer enn metoder som er kalt av delegates. 

Setter opp en delegate, som jeg kaller på de forskjellige måtene ettersom c# har utviklet seg. 

```c#
class Test
{
    delegate void TestDelegate(string s);
    static void M(string s)
    {
        Console.WriteLine(s);
    }

    static void Main(string[] args)
    {
        // Koble delegate til metoder, alt på sin egen "metode"
        TestDelegate testDelA = new TestDelegate(M);							// c# v1
        TestDelegate testDelB = delegate(string s) { Console.WriteLine(s); };	// c# v2
        TestDelegate testDelC = (x) => { Console.WriteLine(x); };				// c# v3

        // Invoke
        testDelA("Hei, dette var slik man gjorde det i v1.");
        testDelB("Versjon 2 kom med anonyme funksjoner.");
        testDelC("Versjon 3 kom med lamda uttrykk.");
    }
}
/* Output:
    Hei, dette var slik man gjorde det i v1.
    Versjon 2 kom med anonyme funksjoner.
    Versjon 3 kom med lamda uttrykk.
*/
```



### Event handlers

#### Simpleste form

```c#
class SkalSendeEvent
{
    //Sette opp eventhandleren til å bruke delegate
    public event MyEventHandler SomethingHappened;

    // eventen
    SomethingHappened("bar");
}

class SkalMottaEvent
{
    // delegate som er referanse til metoden, og kan bli sendt rundt som en verdi
    public delegate void MyEventHandler(string foo);
    
    void Main()
    {
        SkalSendeEvent myObj = new SkalSendeEvent();
        
        // Og pekeren (subscribe) til metoden som skal aktiveres når "det skjer"
		myObj.SomethingHappened += new MyEventHandler(HandleSomethingHappened);
    }
   
    // Håndtere eventen når det kalles
    void HandleSomethingHappened(string foo)
    {
    }
}
```



#### Vanlig pattern



```c#
public class NoeData
{
    public event MyEventNoeData NoeDataRapporterer;
    public int BukerID { get; set;}
    
    public void NoeDataSenderEvent()
    {
        NoeDataRapporterer(this);
    }
}


public class HolderAvMasseData
{
    public void Main()
    {
        List<NoeData> brukerliste = new;
        for(int i; i<=10; i++)
        {
            NoeData obj = new { BrukerID = i; }
            obj.
        }
        
        
        
        
        
        
        
    }
}



```









#### Med parametere

Delegate

```c#
public delegate void ItHappend(object sender, OnSomeThingHappenedEventArgs e);
```

En klasse som har behov for å varsle. 

```c#
class ClassWithEvent
{
    public event EventHandler SomeThingHappened;
    protected virtual void OnSomeThingHappened(EventArgs e)
    {
        EventHandler handler = SomeThingHappened;
        handler?.Invoke(this, e);
    }

    // Resten av implementasjonen av klassen
}
```

Siden jeg ønsker å sende noe mer enn litt, trenger vi en klasse for å sende inn som argument. 
Klassen arver EventArgs som forventes av "OnSomeThingHappened"

```c#
public class OnSomeThingHappenedEventArgs : EventArgs
{	
    public int EtTall { get; set; }
    public string EnString { get; set; }
}
```

Selve "kjørekoden"

```c#
// "Motta"
static void c_ThresholdReached(object sender, EventArgs e)
{
	Console.WriteLine("Event handler ble kalt.");
}

```





### Ref

[Constructor](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/constructors)

[Delegates](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/)