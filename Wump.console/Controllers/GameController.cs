namespace Wump.console.Controllers;

/**
 * GameController.cs -- Class to control the game logic.
 */
public class GameController {
    //View for the game
    private GameView gameView;

    /**
     * Main constructor for the GameController class.
     */
    public GameController(GameView gv) {
        this.gameView = gv;
    }

    /**
     * Method to start the game.
     */
    public void Start() {
        //Output the game title
        (this.gameView).OutputGameText("Wumpus Maze", true);
    }
}
