using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_MidTermTest_Shivani_301100045
{
    /**
    * <summary>
    * This class is a subclass of the LottoGame abstract superclass
    * </summary>
    * 
    * @class LottoMax
    */
    public class LottoMax : LottoGame, IGenerateLottoNumbers
    {
        /**
         * <summary>
         * This constructor does not take any parameters but satisfies the
         * base constructor requirements by send the elementNumber and setSize
         * </summary>
         * 
         * @constructor
         */
        public LottoMax()
            : base(7, 49)
        {

        }

        // CREATE the public GenerateLottoNumbers method here ----------------
        /**
         * <summary>
         * This method display lottery numbers for 7 tickets
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