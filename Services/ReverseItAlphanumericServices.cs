using Microsoft.Extensions.ObjectPool;

namespace FiveToSeven_Endpoints.Services
{
    public class ReverseItAlphanumericServices
    {
        public string ReverseItAlpha(string input)
        {
            string reverse = "";
            for(int i = input.Length - 1; i >= 0; i--){
                    reverse += input[i];
            }
            return new string($"Your input of '{input}' when reversed comes out as '{reverse}'");
        }
    }
}