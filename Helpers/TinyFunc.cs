using System;

namespace prof_sofware.Helpers
{
    public class TinyFunc
    {
        public int getAge(DateTime bdate){
            return DateTime.Now.Year - bdate.Year;
        }

        public int Sum(int x, int y){
            return x + y;
        }
    }
}