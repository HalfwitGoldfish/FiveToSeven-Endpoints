namespace FiveToSeven_Endpoints.Services
{
    public class MadLibServices
    {
        public string MadLib(string animal, string name, string food, int age)
        {
            return $"I have a {animal} Their name is {name} they like to eat {food} they are {age} year(s) old.";
        }
    }
}