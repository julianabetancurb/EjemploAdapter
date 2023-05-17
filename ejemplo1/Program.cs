namespace ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RoundHole hole = new RoundHole(5);
            RoundPeg rpeg = new RoundPeg(5);
            Console.WriteLine(hole.Fits(rpeg)); // true

            SquarePeg smallSqPeg = new SquarePeg(5);
            SquarePeg largeSqPeg = new SquarePeg(10);
            // hole.Fits(smallSqPeg); // Esto no compila (tipos incompatibles)

            SquarePegAdapter smallSqPegAdapter = new SquarePegAdapter(smallSqPeg);
            SquarePegAdapter largeSqPegAdapter = new SquarePegAdapter(largeSqPeg);
            Console.WriteLine(hole.Fits(smallSqPegAdapter)); // true
            Console.WriteLine(hole.Fits(largeSqPegAdapter)); // false
        }
    }
}