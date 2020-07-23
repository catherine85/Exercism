using System;

public class SpaceAge
{
    private int ageSeconds; 
    private const double earthDays = 365.25;
    public SpaceAge(int seconds)
    {
      ageSeconds = seconds;
    }

    public double OnEarth()
    {
        return ageSeconds / 60 / 60 / 24 / earthDays;
    }

    public double OnMercury()
    {
        return FromEarth(0.2408467);
    }

    public double OnVenus()
    {
        return FromEarth(0.61519726);
    }

    public double OnMars()
    {
        return FromEarth(1.8808158);
    }

    public double OnJupiter()
    {
        return FromEarth(11.862615);
    }

    public double OnSaturn()
    {
        return FromEarth(29.447498);
    }

    public double OnUranus()
    {
        return FromEarth(84.016846) ;
    }

    public double OnNeptune()
    {
         return FromEarth(164.79132) ;
    }

    private double FromEarth(double part)
    {
        return OnEarth() / part;
    }
}