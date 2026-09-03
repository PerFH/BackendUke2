namespace BackendUke2;

class Program
{
    static DateTime time = DateTime.Now;
    static void Main(string[] args)
    {
    getDay();
    //lookupWeatherTemp(whatWeather());
    todayTemp(
        lookupWeatherTemp(whatWeather()), 
        lookupHeatTemp(whatHeat()));
    }
    static Random rng = new Random();
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

    static string[] weatherType = ["sunny", "cloudy", "rainy"];
    static Dictionary<string, int> weatherDictionary = new()
    {
        {"sunny", 20},
        {"cloudy", 15},
        {"rainy", 10}
    };
    static string[] heatType = ["cold", "windy", "normal", "hot"];
    static Dictionary<string, int> heatDictionary = new()
    {
        {"cold", -10},
        {"windy", -5},
        {"normal", 5},
        {"hot", 10}
    };

static string getDay()
    {
        
    while(true)
        {
        Console.WriteLine($"{whichGreeting(time)}! la oss sjekke været, hvilken dag vil du sjekke for?");
        string? input = Console.ReadLine();
        return input;
        }
    }
static int whatWeather()
    {
       int i = rng.Next(0,2);
    return i;
    }
static int whatHeat()
    {
        
       int i = rng.Next(0,3);
    return i;
    }

static string lookupWeatherTemp(int whatWeather)
    {
        Console.WriteLine(weatherType[whatWeather]);
    return weatherType[whatWeather];
    }
    


static string lookupHeatTemp(int whatHeat)
    {
        Console.WriteLine(heatType[whatHeat]);
        return heatType[whatHeat];
    }


static int todayTemp(string lookupWeatherTemp, string lookupHeatTemp)
    {
    int mathTemp = weatherDictionary[lookupWeatherTemp] + heatDictionary[lookupHeatTemp];
    Console.WriteLine(mathTemp);
    return mathTemp; 
    }

/*
string whatClothes(int todayTemp())
    if (todayTemp x>y)
        return clothes

void finalOutput()
    ifelse for klesforslag basert på temp ranges
    console: det kommer til å bli en {heatDictionary}, {weatherDictionary} {getDay} og jeg anbefaler {whatClothes}
    */
}