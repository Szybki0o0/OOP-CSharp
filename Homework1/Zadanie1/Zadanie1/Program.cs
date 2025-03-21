namespace Zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConflictSide conflictSide = new ConflictSide(1,2);
            conflictSide.FactionStatistic();
            Console.WriteLine();

            AlliedPowers alliedPower = new AlliedPowers(3,4,true);
            alliedPower.AlliesStatistics();
            alliedPower.FactionStatistic();
            Console.WriteLine();

            CentralPowers centerPowers = new CentralPowers(5, 6, "Wilhelm");
            centerPowers.CenterPowersStatistics();
            centerPowers.FactionStatistic();
            Console.WriteLine();

            France france = new France(7,8,true,7);
            france.FactionStatistic();
            france.AlliesStatistics();
            france.FranceStatistics();
            Console.WriteLine();

            UnitedKingdom unitedKingdom = new UnitedKingdom(9,10,true,9);
            unitedKingdom.FactionStatistic();
            unitedKingdom.AlliesStatistics();
            unitedKingdom.UnitedKingdomStatistics();
            Console.WriteLine();

            UnitedStates unitedStates = new UnitedStates(11, 12, true, 11);
            unitedStates.FactionStatistic();
            unitedStates.AlliesStatistics();
            unitedStates.UnitedStatesStatistics();
            Console.WriteLine();

            Germany germany = new Germany(13, 14, "Hohenzolern", 13);
            germany.FactionStatistic();
            germany.CenterPowersStatistics();
            germany.GermanyStatistics();
            Console.WriteLine();
        }
    }
}
