# HW4
## Devlog

1. The control side of the game is the player class and the view side of the game are the game controller class that regulates the score, sound, and the UI.
2. Events are initiated by the player, three specifically: Jump, Score, and Die. When each event are received, the game controller will do play sound for each occasion and when dying stops the spawning of the pipe. The pipes also stop when receive the die signal.
Because the player needs to call events to be in action, the singleton will have to include the player so that all the game controller and the pipe need to do is Locator.Instance.Player.event name += the method in the pipe or the game controller

## Open-Source Assets
If you added any other assets, list them here!
- [Brackey's Platformer Bundle](https://brackeysgames.itch.io/brackeys-platformer-bundle) - sound effects
- [2D pixel art seagull sprites](https://elthen.itch.io/2d-pixel-art-seagull-sprites) - seagull sprites
