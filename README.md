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
(With Visual Studio Installed on your machine)
Navigate to the Master branch of this repository and click Clone or Download button.
  Download as a zip and find this folder and extract all the files to your desired location.
  Inside the extracted folder find the application file and run.
  This will open the game to be played.
  
  If the application file doesn't appear to run, check the version of windows via the help button in Visual Studios navigation bar.
  In order to run the game with Visual Studio 2019 Version 16.3 or later is required (see https://docs.microsoft.com/en-us/dotnet/core/windows-prerequisites?f1url=https%3A%2F%2Fmsdn.microsoft.com%2Fquery%2Fdev15.query%3FappId%3DDev15IDEF1%26l%3DEN-US%26k%3Dk(NETSDK1045)%26rd%3Dtrue&tabs=netcore30 for further details).
  Visual Studio can be updated through the help tab.
  
Without Visual Studio it is possible to run the program through the Console refer: https://docs.microsoft.com/en-us/dotnet/core/tutorials/using-with-xplat-cli for further details.

To view the source code:
  Open Program.cs in preferred text editor or Visual Studio.
