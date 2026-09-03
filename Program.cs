namespace BackendUke2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(whichGreeting(time));
    }
    static Random rng = new Random();
    static DateTime time = DateTime.Now;
    static string whichGreeting(DateTime time)
    {
        string greeting;
        switch (time.Hour)
        {
            case > 18:
                {
                    greeting = "God kveld";
                    return greeting;
                }
            case > 14:
                {
                    greeting = "God ettermiddag";
                    return greeting;
                }
            case > 10:
                {
                    greeting = "God formiddag";
                    return greeting;
                }
            case > 5:
                {
                    greeting = "God morgen";
                    return greeting;
                }
            default:
                {
                    greeting = "Gjesp";
                    return greeting;
                }
        }
    }

    string[] weatherType = ["sunny", "cloudy", "rainy"];
    Dictionary<string, int> weatherDictionary = new()
    {
        {"sunny", 20},
        {"cloudy", 15},
        {"rainy", 10}
    };
    string[] heatType = ["cold", "normal", "hot"];
    Dictionary<string, int> heatDictionary = new()
    {
        {"cold", -10},
        {"windy", -5},
        {"normal", 5},
        {"hot", 10}
    };
}

/*
string getDay()
    while(true)
        Console.WriteLine($"God{getHilsen} lets check on the weather, which day do you want me to check for?"")
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

void finalOutput()
    ifelse for klesforslag basert på temp ranges
    console: det kommer til å bli en {heatDictionary}, {weatherDictionary} {getDay} og jeg anbefaler {whatClothes}
    */