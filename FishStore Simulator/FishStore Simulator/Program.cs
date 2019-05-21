using System;

namespace FishStore_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int storevalue = 15000;
            int fishinvent = 120;
            int currFishA = 50;
            int currFishB = 40;
            int currFishC = 30;
            int fishACost = 5;
            int fishBCost = 6;
            int fishCCost = 7;
            int customers;
            int totalFishA;
            int totalFishB;
            int totalFishC;
           //int totalfishSold;
            int fishSoldA;
            int fishSoldB;
            int fishSoldC;
            int totalFishLeft;
            int fishProfit;
          
            

            //string specialorder;

            Console.WriteLine("Enter the number of blue fish you want?");
            int fishA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of red fish you want?");
            int fishb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of yellow fish you want?");
            int fishc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need to special order");
            string input = Console.ReadLine();
            int number = 45;
            if(Int32.TryParse(input, out number))
            {
                Console.WriteLine("Customer wants to special order");
               
            }
            else
            {
                Console.WriteLine("Customer does not want a special order");
            }
            Console.WriteLine(" Did you do weekly cleaning/maintance");
            string clean = Console.ReadLine();
            int number2 = 10;
            if(Int32.TryParse(clean,out number2))
            {
                Console.WriteLine("Your fish are nice and healthy good job");

            }
            else
            {
                Console.WriteLine("Your tank is dirty and high risk of sick fish bad job");
            }
            for(customers = 0; customers <= 50; customers++ )
            {
                totalFishA = fishinvent -currFishA;
                Console.WriteLine("Total Fish A:" + totalFishA);
                totalFishB = fishinvent - currFishB;
                Console.WriteLine("Total Fish B:" + totalFishB);
                totalFishC = fishinvent - currFishC;
                Console.WriteLine("Total Fish C:" + totalFishC);

                

                totalFishLeft = totalFishA + totalFishB + totalFishC;
                Console.WriteLine("Total Fish Left unsold" + totalFishLeft);

                fishSoldA = (fishA * fishACost);
                Console.WriteLine("Total Blue fish Sold" + fishSoldA);

                fishSoldB = (fishb * fishBCost);
                Console.WriteLine("Total Red fish Sold" + fishSoldB);
                fishSoldC = (fishc * fishCCost);
                Console.WriteLine("Total Red fish Sold" + fishSoldC);

                fishProfit = storevalue + (fishSoldA + fishSoldB + fishSoldC);
                Console.WriteLine(" Total profit gained from fish and please remember to reorder", fishProfit);


                if( fishProfit <= 15000)
                {
                    Console.WriteLine("Number of {0} you are losing money", fishProfit);

                }
                else
                {
                    Console.WriteLine( "Number of {0} you are gaining money cool beans",fishProfit);
                }


                //if (totalFishA <= 10)
                //{
                //    Console.WriteLine("Number of {0}  blue fish is less than 10,please reorder", totalFishA);
                //}
                //else
                //{
                //    Console.WriteLine("Number of {0} blue fish is fine dont reorder", totalFishA);
                //}
                //if (totalFishB <= 10)
                //{
                //    Console.WriteLine("Number of {0}  red fish is less than 10,please reorder", totalFishB);
                //}
                //else
                //{
                //    Console.WriteLine("Number of { 0} red fish is less than 10,please reorder", totalFishB);
                //}
                //if (totalFishC <= 10)
                //{
                //    Console.WriteLine("Number of {0}  yellow fish is less than 10,please reorder", totalFishC);
                //}
                //else
                //{
                //    Console.WriteLine("Number of { 0} yellow fish is less than 10,please reorder", totalFishC);
                //}



            }

        





        }
    }
}
