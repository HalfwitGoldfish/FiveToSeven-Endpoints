namespace FiveToSeven_Endpoints.Services
{
    public class OddOrEvenServices
    {
        public string OddOrEven(int num)
        {
            if(num % 2 == 0){
                return $"{num} is an even number";
            }else{
                return $"{num} in an odd number";
            }
        }
    }
}