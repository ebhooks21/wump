namespace Wump.console.Models;

/**
 * Player.cs -- Class to represent the player in the game.
 */
public class Player {
    //Name of the player
    private string name; 

    /**
     * Main constructor for the player class.
     */
    public Player(string name) {
        this.name = name;
    }

    /**
     * Propery to get or set the name of the player.
     */
     public string Name {
        get {
            return name;
        }

        set {
            name = value;
        }
     }
}
