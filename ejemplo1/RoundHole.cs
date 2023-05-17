using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class RoundHole
{
    private double radius;

    public RoundHole(double radius)
    {
        this.radius = radius;
    }

    public double GetRadius()
    {
        return radius;
    }

    public bool Fits(RoundPeg peg)
    {
        return GetRadius() >= peg.GetRadius();
    }
}



