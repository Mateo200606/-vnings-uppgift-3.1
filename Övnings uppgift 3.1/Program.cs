using System; 
namespace övnings_uppgift_3_1
{     
     class program
     { 
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());
            if (ålder > 19)
            {
                Console.WriteLine("Du är för gammal");
            }
            else if (ålder < 16)
            {
                Console.WriteLine("du är för ung");
            }
            else
            {
                Console.WriteLine("Du får delta");
            
            }


    

        }
     }
}