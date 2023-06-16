using Software2KnowledgeCheck1;

class Program
{
    public static void Main()
    {
        CityBuilder citybuilder = new CityBuilder();
        var city = new City();
        var apartment = new Apartment();
        var highRise = new HighRise();
        var building = new Building();
        

        citybuilder.CreateBuilding<Apartment>(apartment, city);

        citybuilder.CreateBuilding(highRise, city);
        
        citybuilder.CreateBuilding(building, city);

        foreach(Building cityBuilding in city.Buildings)
        {
            Console.Out.WriteLine(cityBuilding);
        }
    }
}