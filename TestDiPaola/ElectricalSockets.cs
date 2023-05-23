using System;

namespace TestDiPaola
{
    public class ElectricalSockets
    {
        public static void NumberScockets()
        {
            var numberTestcases = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numberTestcases; i++)
            {
                var multipleSockets = Console.ReadLine().Split(' ');
                var numberSockets = multipleSockets.Length - 1;
                var totalSockets = 1;

                for (int j = 0; j < numberSockets; j++)
                {
                    var inputSockets = Convert.ToInt32(multipleSockets[j + 1]);
                    totalSockets += inputSockets;
                }

                var resulSocketst = totalSockets - numberSockets;

                Console.WriteLine(resulSocketst);
            }
        }
    }
}