using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_MidTermTest_Shivani_301100045
{
    /**
     * <summary>
     * This class is a subclass of the LottoGame abstract superclass
     * </summary>
     * 
     * @class Lotto649
     */
    public class Lotto649 : LottoGame, IGenerateLottoNumbers
    {
        // CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This constructor does not take any parameters but satisfies the
         * base constructor requirements by send the elementNumber and setSize
         * </summary>
         * 
         * @constructor
         */
        public Lotto649()
            : base(6, 49)
        {

        }

        // CREATE the public GenerateLottoNumbers method here ----------------
        /**
         * <summary>
         * This method display lottery numbers for 6 tickets
         * </summary>
         * 
         * @method GenerateLottoNumbers
         * @returns {void}
         */
        public void GenerateLottoNumbers()
        {
            // Loop through generate and display tickets
            for (int i = 1; i <= ElementNumber; i++)
            {
                // Generate the elements
                PickElements();

                // Display the elements
                Console.WriteLine("Ticket  " + i + ":  " + base.ToString());
            }
        }
    }
}
