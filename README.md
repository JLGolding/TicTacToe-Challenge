# TicTacToe-Challenge
Tic Tac Toe 
written in C#
Complied using Visual Sudio 2019
Version 16.3.6 (please note there may be some compatibilitiy issues with older versions)

Assumptions for the game and brief project description:
This is a game to be played on the local terminal window.
Player wins by having 3 of their symbols (X or O) in a row (horizontal, vertical and diagonal).

The board is a 3x3 grid initial displayed as ".", Players choose their location by entering a number from 1 to 9,
1 being top left  and 9 being bottom right of the board/grid.
⁭If a player enters a non-valid selection they will be given a message/prompt and are able to choose again. 

If the board gets filled (after 9 turns) and no one has 3 in a row then the game is a draw.

Players can "give up"/quit by submitting q or Q as their selection and this will close the console.

After each game ending situation the players can choose to play again or quit.  
If they choose to play again the parameters are reset and board cleared of Xs and Os.

Player 1 always goes first and is always X.
The game will check after 4 turns to see if there is a winner and every turn after that until someone wins or there is a draw.

For running on your local machine:
Navigate to the branch of this repository... tbc
