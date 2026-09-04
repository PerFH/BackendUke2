namespace BackendUke2;

class Program
{
    static DateTime time = DateTime.Now;
    static void Main(string[] args)
    {
        Console.Clear();
    finalOutput(
        whatClothes(
            todayTemp(
                lookupWeatherTemp(
                    whatWeather()
                    ), 
                    lookupHeatTemp(
                        whatHeat()
                    )
                )
            )
        );
    static void finalOutput(string whatClothes)
        {
        Console.WriteLine($"{getDay()} kommer til å bli {weatherType[whatWeather()]} og {heatType[whatHeat()]}" + 
        $", og jeg anbefaler {whatClothes}.");
        }
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

    static string[] weatherType = ["sol", "overskyet", "regnvær"];
    static Dictionary<string, int> weatherDictionary = new()
    {
        {"sol", 20},
        {"overskyet", 15},
        {"regnvær", 10}
    };
    static string[] heatType = ["kaldt", "vindfullt", "normalt", "varmt"];
    static Dictionary<string, int> heatDictionary = new()
    {
        {"kaldt", -10},
        {"vindfullt", -5},
        {"normalt", 5},
        {"varmt", 10}
    };

static string getDay()
    {
        {
        Console.WriteLine($"{whichGreeting(time)}! la oss sjekke været, hvilken dag vil du sjekke for?");
        string? input = Console.ReadLine();
        string formattedInput = char.ToUpper(input[0]) + input.Substring(1);
        return formattedInput;
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
        //Console.WriteLine(weatherType[whatWeather]);
    return weatherType[whatWeather];
    }
    


static string lookupHeatTemp(int whatHeat)
    {
        //Console.WriteLine(heatType[whatHeat]);
        return heatType[whatHeat];
    }


static int todayTemp(string lookupWeatherTemp, string lookupHeatTemp)
    {
    int mathTemp = weatherDictionary[lookupWeatherTemp] + heatDictionary[lookupHeatTemp];
    //Console.WriteLine(mathTemp);
    return mathTemp; 
    }

static string whatClothes(int todayTemp)
    {      
    switch (todayTemp)
        {
        case >=30: return "sommer klær";
        case >=20: return "normale klær";
        case >=10: return "varme klær";
        default: return "vinter klær";
        }
    }

}