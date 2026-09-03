# Backend Uke 2, oppgave
I denne oppgaven skal dere designe og implementere et program som returnerer en tilpasset melding (hilsen) tilbake til brukeren, basert på ett eller flere parametere.

Dere bestemmer selv hvilke parametere programmet skal ta hensyn til, men her er noen tips til hva dere kan utforske:

    Bruk av DateTime:
    DateTime.Now gir deg tidspunktet akkurat nå. Kan du bruke deler av dette objektet – for eksempel Hour, DayOfWeek eller Month – til å bestemme hvilken hilsen brukeren får?
    (Se gjerne dokumentasjonen i System-namespace for flere muligheter.)

    Brukerinput:
    Trenger programmet å tolke (parse) input fra brukeren? Kanskje dere kan la brukeren oppgi navn eller alder, og kombinere det med tidspunktet?
    Her kan det være nyttig å se på metoder i System.Console for å lese inn tekst.

    Oppslagstabell:
    Hva om dere lagde en liten "lookup table" ved hjelp av et Dictionary<string, string>? Da kan bestemte inputverdier gi bestemte hilsener – uten at dere trenger mange if/else-blokker.

    Andre verktøy:
    Kanskje det kan være nyttig å utforske System.Globalization for dato- og tidsformatering, eller System.Text for mer avansert behandling av strenger?

Et konkret forslag er å skrive et program som returnerer en custom hilsen basert på:

    tidspunktet på maskinen (morgen, ettermiddag, kveld)

    og/eller navnet brukeren skriver inn.

Arbeidsmåte

    Start med å tegne flytdiagrammet. Flyten bør begynne med at brukeren gir input.

    Skriv pseudokode som beskriver hvordan programmet skal gå fra input til ferdig hilsen.

    Implementer deretter programmet i C#.

Målet er å lage noe som fungerer – men prøv gjerne å utvide ideen med flere parametere og mer dynamiske valg, slik at programmet føles mer “intelligent”.

Nøkkelfunksjoner å fokusere på: tid/dato, dictionary, arrays


# Flow
lage rng
hent dato/tid
array med vær
dictionary med vær og hvilke base temperatur som hører til hver temp
array med vær modifier
dictionary med temp modifiers basert på variant
plukk random plass fra array 1 og array 2, sjekk dictionary hva det betyr for temp, regn ut dagens temp

modifiser temperatur basert på tiden på dagen
1. god(tid på dagen) bruker, 
    - custom hilsen basert på navn (forbokstav)? (dictionary)
    - og anbefaling på hvor godt man burde kle seg

# Pseudocode
Datetime dato = DateTime.Now;

string[] weatherType = [sunny, cloudy, rainy]
Dictionary<string><int> weatherDictionary = new Dictionary()
    {
        {"sunny", 20}
        {"cloudy", 15}
        {"rainy", 10}
    }
string[] heatType = [cold, normal, hot]
Dictionary<string><int> heatDictionary = new Dictionary()
    {
        {"cold", -10}
        {"windy", -5}
        {"normal", 5}
        {"hot", 10}
    }

string getDay()
    while(true)
        Console: Hello,(time of day) lets check on the weather, which day do you want me to check for?
        readline(input)
    return input;

string whatWeather()
    rng.weatherType(0-2)
    return weatherType;

int lookupWeatherTemp(string whatWeather)
    sjekk hva temp som hører til værtypen i weather dictionary
    return weatherType.weatherDictionary;

string whatHeat()
    rng.heatType(0-2)
    return heatType;

int lookupHeatTemp(string whatHeat)
    sjekk dictionary hva for varmetype det blir
    return heatType.Heatdictionary


int todayTemp(int lookupWeatherTemp, int lookupHeatTemp())
    mathTemp = lookupWeatherTemp + lookupHeatTemp
    return mathTemp    

string whatClothes(int todayTemp())
    if (todayTemp x>y)
        return clothes

string finalOutput()
    ifelse for klesforslag basert på temp ranges
    console: It is going to be a {heatDictionary}, {weatherDictionary} {getDay} and i advise you to wear {whatClothes}

