using System;
using System.Diagnostics;

class Checker
{
    sattic bool isvitalbelowrange(float parameter,float min,string parametername,)
    {
        bool retval=!(parameter<min);
        if(!retval)
        {
            
        }
        return retval;
    }
    static bool isvitalboverange(float parameter,float max,string parametername,)
    {
        bool retval=!(parameter>max);
        if(!retval)
        {
            
        }
        return retval;
    }
    public static bool VitalsOk(float temperature, int pulseRate, int spo2, void(*console))
    {
        bool tempok=isvitalbelowrange(temperature,95,"Temperature") && isvitalboverange(temperature,102,"Temperature");
        bool pulserateok=isvitalbelowrange(pulseRate,60,"PulseRate") && isvitalboverange(pulseRate,100,"PulseRate");
        bool spo2ok=isvitalbelowrange(spo2,95,"spo2");
        bool vitlas=tempok && pulserateok && spo2ok;
        
        Console.WriteLine("Vitals received within normal range");
        Console.WriteLine("Temperature: {0} Pulse: {1}, SO2: {2}", temperature, pulseRate, spo2);
        return true;
    }
}
