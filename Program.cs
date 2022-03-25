namespace C__Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int page = 0;
            string input;
            while(true)
            {
                switch(page)
                {
                    case 0:
                        System.Console.Clear();
                        System.Console.WriteLine("PAGE 0");

                        System.Console.WriteLine("Enter action: ");
                        input = System.Console.ReadLine();

                        if(input == "next"){
                            page = 1;
                            input = "";
                        }
                        break;
                    
                    case 1:
                        System.Console.Clear();
                        System.Console.WriteLine("Page 1");

                        System.Console.WriteLine("Enter action: ");
                        input = System.Console.ReadLine();

                        if(input == "next")
                        {
                            page = 2;
                            input = "";
                        } else if (input == "back")
                        {
                            page = 0;
                            input = "";
                        }
                            
                        
                        break;

                    case 2:
                        System.Console.Clear();
                        System.Console.WriteLine("Page 2");

                        System.Console.WriteLine("Enter action: ");
                        input = System.Console.ReadLine();

                        if(input == "next")
                        {
                            page = 2;
                            input = "";
                        } else if (input == "back")
                        {
                            page = 1;
                            input = "";
                        }
                        break;
                    
                }
            }
        }
    }
}
