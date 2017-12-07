using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts //First create a re-usable library called Darts that could be used for
                //other dart games in the future.
{
    public class Dart
    {
        public int Score { get; set; }
        public bool IsDouble { get; set; }
        public bool IsTriple { get; set; }
        public bool IsMiss { get; set; }
        /* for the above
         The dart has an equal chance of scoring one through twenty,
            or the bullseye (0).  For numbers 1 through 20, the dart has a five percent chance 
            of landing in the outer band that represents a double score, and a five percent 
            chance of landing in the inner band that represents a triple score. 
         
          
          
         * */
        private Random _random;
        
        public Dart(Random random)  /*  It will contain a single class named Dart.  When
                                        creating a new instance of Dart, you will pass it an 
                                        instance of the System.Random
                                        class to ensure you get a true random number 
                                        across the lifetime of the web page's 
                                        lifecycle.*/
        {
            _random = random;
        }

        public void Throw() //When you call the Throw() method it will simulate the act of throwing a 
                            //dart at a dart board.

        {
            Score = _random.Next(0, 21); //what this does is makes it 0-20. 

            int multiplier = _random.Next(1, 101);//same as before 0-100
            if (multiplier > 95) IsTriple = true;
            else if (multiplier > 90) IsDouble = true;
            else if (multiplier > 99) IsMiss= true;
        }
    }
}
