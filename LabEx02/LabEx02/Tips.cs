using static System.Console;

namespace LabEx02
{
    class Tips
    {
        static void Main(string[] args)
        {
            double amount,percentTips,finalAmount;
            Write("Please input the bill >> ");
            amount = double.Parse(ReadLine());

            percentTips = .15 * amount;
            finalAmount = amount + percentTips;
            WriteLine("Tips (15%): ${0:0.###}, Final Amount: ${1:0.###}",percentTips,finalAmount);

            percentTips = .2 * amount;
            finalAmount = amount + percentTips;
            WriteLine("Tips (20%): ${0:0.###}, Final Amount: ${1:0.###}", percentTips, finalAmount);

            ReadKey();
        }
    }
}
