using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Darts;

namespace ChallengeSimpleDarts
{
    public class Score
    {
        public static void ScoreDart(Player player, Dart dart)
        {
            int score = 0;

            if (dart.IsTriple) score = dart.Score * 3;
            else if (dart.IsDouble) score = dart.Score * 2;
            else if (dart.IsMiss) score = dart.Score + 0; //added a miss because most likely people are drunk playing this and missing all over the place
            else score = dart.Score;
            //else score = 0; // the IsMiss is not required for the project, but I liked the idea

            if (dart.IsTriple && dart.Score == 0) score = 50;
            else if (dart.Score == 0) score = 25;

            player.Score += score;
        }



        /*
         * (3) In the Web Forms project create a Score class that contains a static method 
                that will calculate the score for a dart throw.  

                Each dart can score from 1 to 20, or the bullseye.
                If the dart lands in the outer band, multiply the dart's score by two.  
                If the dart lands in the inner band, multiply the dart's score by three.  
                If the dart lands in the outer bullseye, it is scored as 25.  
                If the dart lands in the inner bullseye, it is scored as 50.

                Try to keep the classes as short as possible and cohesive.
                Try to keep the methods as short as possible ... no more than 6 lines of code.

                (These are guidelines ... if you can't do that, no worries.)
         */
    }
}