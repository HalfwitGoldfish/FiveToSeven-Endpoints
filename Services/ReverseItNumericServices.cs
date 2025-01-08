namespace FiveToSeven_Endpoints.Services
{
    public class ReverseItNumericServices
    {
        public string ReverseItNum(int num)
        {
            int left = num;
            int reverse = 0;
            while(Convert.ToBoolean(left)){
                int r = left % 10;
                reverse = reverse * 10 + r;
                left = left / 10;
            }
            return $"Your number of '{num}' when reversed is '{reverse}'";
        }
    }
}