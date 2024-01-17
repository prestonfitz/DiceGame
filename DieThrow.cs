using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    // Dic throwing class
    public class DieThrow
    {
        // pull in random function
        Random rnd = new Random();

        // Do the work
        public int[] DiceThrow(int throws) {

            // make the array
            int[] results = [0,0,0,0,0,0,0,0,0,0,0];

            // use the user specified amount
            for (int i = 0; i < throws; i++)
            {
                int Die1 = rnd.Next(1, 7);
                int Die2 = rnd.Next(1, 7);
                int result = Die1 + Die2;

                // store results to array
                results[result - 2] = results[result - 2] + 1;
            }

            //return array
            return results;

        }
    }
}
