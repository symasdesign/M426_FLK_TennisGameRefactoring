namespace TennisGameRefactoring {
    public class TennisGame {
        private int score1 = 0;
        private int score2 = 0;
        private string player1Name;
        private string player2Name;


        public TennisGame(string player1Name, string player2Name) {
            this.player1Name = player1Name;
            this.player2Name = player2Name;
        }

        /**
         * Player 1 wins the point
         */
        public void PlayerOneScores() {
            score1 += 1;
        }

        /**
         * Player 2 wins the point
         */
        public void PlayerTwoScores() {
            score2 += 1;
        }

        /**
         * Returns the current score.
         * 
         * @return score
         */
        public string GetScore() {
            string score = "";
            int tempScore = 0;
            if (score1 == score2) {
                switch (score1) {
                    case 0:
                        score = "Love-All";
                        break;
                    case 1:
                        score = "Fifteen-All";
                        break;
                    case 2:
                        score = "Thirty-All";
                        break;
                    default:
                        score = "Deuce";
                        break;

                }
            } else if (score1 >= 4 || score2 >= 4) {
                int minusResult = score1 - score2;
                if (minusResult == 1) score = "Advantage Player1";
                else if (minusResult == -1) score = "Advantage Player2";
                else if (minusResult >= 2) score = "Player1 wins";
                else score = "Player2 wins";
            } else {
                for (int i = 1; i < 3; i++) {
                    if (i == 1) tempScore = score1;
                    else { score += "-"; tempScore = score2; }
                    switch (tempScore) {
                        case 0:
                            score += "Love";
                            break;
                        case 1:
                            score += "Fifteen";
                            break;
                        case 2:
                            score += "Thirty";
                            break;
                        case 3:
                            score += "Forty";
                            break;
                    }
                }
            }
            return score;
        }
    }
}