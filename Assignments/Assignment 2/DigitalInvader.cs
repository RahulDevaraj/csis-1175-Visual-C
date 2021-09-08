using System;
using System.Threading.Tasks;
using static System.Console;

namespace CSIS1175Asgn2
{
    class DigitalInvader
    {
        static int canon = 0;                       // an integer, 0-9, to represent a canon
        static string invader = "";                 // a string to presents invaders
        static Random random = new Random(42);      // a Random object generating an invader
       static DateTime now = DateTime.Now;          
        static int s = now.Second;                  // to store current time (second)

        public DigitalInvader()
        {
            // Constructor to initialize the game
            Setup();
        }

        private void PrintCanon()
        {
            // An instance method to print the canon
            Console.SetCursorPosition(0, 0);
            Console.Write(canon);
        }

        private void PrintInvader()
        {
            // An instance method to print the invader
            Console.SetCursorPosition(10, 0);
            Console.Write("{0,10}", invader);
        }


        private void SetKeyListener()
        {
            // An instance method to create the listenr
            // When the key "j" is pressed, the method UpdateCanon() will be called automatically
            // When the key "k" is pressed, the method Shoot() will be called automatically
            ConsoleKey key;
            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    key = Console.ReadKey(true).Key;
                    if (key == ConsoleKey.J)
                    {
                        UpdateCanon();
                    }
                    else if (key == ConsoleKey.K)
                    {
                        Shoot();
                    }
                }
            });
        }

        private void Setup()
        {
            // An instance method to setup the game
            Console.CursorVisible = false;
            Console.Clear();
            SetKeyListener();
            PrintCanon();
        }

        private string GenerateNextInvader()
        {
            // An instance method to generate the next invader
            return (random.Next() % 10).ToString();
        }

        private void UpdateCanon()
        {
            // An instance method to update the Canon
            // After calling SetKeyListener, this method will be automatically called when "j" is pressed
            // The canon will be updated through 0-9 and then back to 0
            canon++;                     //update canon value
            canon = canon % 10;          // to make sure canon cannot be greater than 9
            PrintCanon();



        }

        private void Shoot()
        {
            // An instance method to shoot 
            // After calling SetKeyListener, this method will be automatically called when "k" is pressed
            // When an invader is shot by the canon, the leftmost invader will be removed.
            int index = invader.IndexOf(Convert.ToString(canon));  // to find the index of target
            
            if (index != -1)        //if target exists
            {
                invader = invader.Remove(index, 1);         //new string by deleting the target
            }

        }

        private Boolean eachSecond()                     //function that returns true for each second that passed
        {
            DateTime currentTime = DateTime.Now;
            
            int newNow = currentTime.Second;
            Boolean status = false;
            if (newNow != s)                           // if time updated
            { 
            s = newNow;                                //updated second value stored
                status = true;
             }
            return status;
        }

        public void Play()
        {
            while (true)                  //infinite loop
            { 
                if (eachSecond())         //fn triggers each second
                {
                    invader += GenerateNextInvader(); //new invader generated and added
                    PrintInvader();
                    if (invader.Length == 10)         //if invader length reaches 10 game ends
                        break;
                    
                }


            }
        }

        static void Main(string[] args)
        {
            DigitalInvader invader = new DigitalInvader();
            invader.Play();
            WriteLine("\nThank you for playing Digital Invader!");
            ReadKey();
        }
    }
}
