namespace Wump.console.Views;

/**
 * GameView.cs -- Class to control the game view.
 */
public class GameView {
    /**
     * Main constructor for the GameView class.
     */
     public GameView() {
        
     }

     /**
      * Method to display a line of text.
      */
      public void OutputGameText(string text, bool newLine) {
        // Print the given text to the console.
        Console.WriteLine(text);

        if(newLine) {
            Console.WriteLine("\r\n");
        }
      }
}
