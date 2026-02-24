# simpleSnakeGame

https://github.com/user-attachments/assets/99243598-8b4f-4ed1-9fa7-9bebf6201a3a

### Data structures used 
* 2D arrays are used in Game State class to represent the grid on which the snake and food is generated on 
* Linked lists are used for storing the exact position of the snake and its associated segments, in the order from head to tail.  When food is eaten, a new head position is added. For movements the head moves by one and the tail is reduced by one
* Linked lists are used again for changes of directions; a buffer is incorporated to prevent 180 degree turns and processes inputs sequentially. 
* Dictionaries are used to map the grid cells and images for faster rendering. 
* Dictionaries are used to map direction of rotation angles (0,90,180,270) for rotating the snakes head and thus the snake.
* 2D arrays are used for image control, one per grid cell, which allows for faster per cell image updates 


