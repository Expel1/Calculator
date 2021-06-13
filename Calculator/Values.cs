namespace Calculator
{
    public class Values
    {

        //private int _startCost;
        public static int StartCost { get; set; }  

        //private int _handlingCost;
        public int HandlingCost { get; set; }

        //private int _earn; 
        public int Earn { get; set; }

        public static int NoProfit(int startCost, int handlingCost)
        {
            return startCost + handlingCost;
        }

        public static int YesProfit(int startCost, int handlingCost, int earn)
        {
            return startCost + handlingCost + earn;
        }
    }
}   
