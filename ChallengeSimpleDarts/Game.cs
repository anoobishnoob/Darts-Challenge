using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Darts; // this part kept tripping me up

namespace ChallengeSimpleDarts
{
    public class Game
    {
        private Player _player1;
        private Player _player2;

        private Random _random;

        public Game(string player1Name, string player2Name)
        {
            _player1 = new Player();
            _player1.Name = player1Name;

            _player2 = new Player();
            _player2.Name = player2Name;

            _random = new Random();
        }

        public string Play()
        {
            while (_player1.Score < 300 && _player2.Score < 300)
            {
                playRound(_player1);
                playRound(_player2);
            }
            return displayResults();
        }

        private string displayResults()
        {
            string result = String.Format("{0}: {1}<br/>{2}: {3}",
                _player1.Name,
                _player1.Score, 
                _player2.Name, 
                _player2.Score);

            return result += "<br/><br />Winner: " + 
                (_player1.Score > _player2.Score ? _player1.Name : _player2.Name);
        }

        private void playRound(Player player)
        {
            for (int i = 0; i < 3; i++)
            {
                Dart dart = new Dart(_random);
                dart.Throw();
                Score.ScoreDart(player, dart);
            }
        }
        /* (2) In the Web Forms project, you will create a Game class that contains the 
            logic for a simple game of darts.  Two players will take turns throwing three
            darts per turn.  Their respective scores accumulate after each turn by adding 
            the score from each dart to the Player's score.  */
    }
}