using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SquarePegAdapter : RoundPeg
{
    private SquarePeg peg;

    public SquarePegAdapter(SquarePeg peg) : base(0)
    {
        this.peg = peg;
    }

    public override double GetRadius()
    {
        return peg.GetWidth() * Math.Sqrt(2) / 2;
    }
}
