namespace FiveToSeven_Endpoints.Services
{
    public class OddOrEvenServices
    {
        public string OddOrEven(string num)
        {
            int parsedNum;
            bool numeric = int.TryParse(num, out parsedNum);
            if(numeric == true){
                if(parsedNum % 2 == 0){
                    return $"{parsedNum} is an even number";
                }else{
                    return $"{parsedNum} in an odd number";
                }
            }else{
                return $"error '{num}' is not a valid integer";
            }
        }
    }
}