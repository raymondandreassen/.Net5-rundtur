# Introduksjon til .NET

.NET er gratis, open-souce utviklingsplattform for å bygge: 

* Web applikasjoner, web API og microtjenester
* Serverless funksjoner i skyen
* Apper som er "Cloud native"
* Apper for mobil
* Windows desktop apps
  * Windows WPF
  * Windows Forms
  * Universial Windows Platform (UWP)
* Spill
* IoT
* Maskinlæring
* Console apps
* Windows Services
* Og mye mer

## Cross plattform

.NET apper kan være for (nov 2020)

- Windows
- macOS
- Linux
- Android
- iOS
- tvOS
- watchOS

Processor arkitektur (nov 2020):

- x64
- x86
- ARM32
- ARM64

.NET kan ha plattformspesifikke funksjoner, f.eks. API mot OS og funksjoner man kun finner på mobiltelefoner. 

## Open source

.NET er open source. (MIT and Apache 2)
.NET er et prosjekt organisert av .NET Foundation

## Plattform støtte

.NET kjører på Windows, macOS, and Linux. 
Det opppdateres for sikkerhet hver andre tirsdag hver måned. 

.NET binary distribueres fra Microsoft. Microsoft tar også ansvaret for å bygge og teste dem. Distribusjonen følger Microsoft sine rutiner og metoder. 
Red Hat støtter .NET på RHEL. Red Hat og Microsoft samarbeidet for å sikret at .NET fungerer godt på RHEL.
Tizen støtter .NET på Tizen plattform. 

### Programmeringsspråk 

.NET støtter 3 programmeringsspråk:

* C#
* F#
* Visual Basic

### IDEs

For å kode .NET så finnes blant annet:

- [Visual Studio](https://visualstudio.microsoft.com/vs/) 
- [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/)
- [Visual Studio Code](https://code.visualstudio.com/) 
- [GitHub Codespaces](https://github.com/features/codespaces) - Nytt online verktøy, pr nov 2020 i beta. 

## Deployment modeller

.NET kan leveres etter to modeller:

- Publisert som en "self-contained". Da inneholder pakken alt den trenger for å kjøre. 
- Publisert som "framework-dependent". Da er koden avhengig at det er satt hvor det skal kjøre. 

Men kan installere så mange versjoner av runtime, versjoner av pakker og frameworks som man vil. 
Microsoft har som kjent meget god erfaring fra dll-hell, så dette kan de alt om. 