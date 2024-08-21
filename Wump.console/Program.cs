void main() {
    //Create a new GameView
    GameView gv = new GameView();

    //Create a new GameController
    GameController gc = new GameController(gv);

    //Start the game
    gc.Start();
}

main();