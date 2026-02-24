# Simple Snake Game

A classic **Snake** game implemented in **C#**  as a learning/project exercise.  
The snake grows when eating food, moves around a grid, and the game ends on collision with walls or itself.

https://github.com/user-attachments/assets/a5ada03e-0dad-40c8-9d8e-8694a0d85e0d

## Table of Contents
- [Project Overview](#project-overview)
- [Key Features](#key-features)
- [Technologies & Data Structures](#technologies--data-structures)
- [Prerequisites](#prerequisites)
- [Setup Instructions](#setup-instructions)
- [How to Play](#how-to-play)
- [Controls](#controls)
- [Important Notes](#important-notes)


## Project Overview
This is a lightweight, educational implementation of the timeless Snake game.  
Players control a snake that grows longer each time it eats food, while avoiding collisions with walls and its own body.  

The project demonstrates clean usage of fundamental data structures in game logic, efficient rendering techniques, and responsive input handling.

## Key Features
- Smooth snake movement with arrow key controls
- Food spawning at random empty positions
- Score increases with each food eaten
- Game over detection (wall collision OR self-collision)
- Buffered direction changes (prevents instant 180° turns)
- Grid-based rendering using per-cell image controls 
- Visual rotation of snake head based on movement direction

## Technologies & Data Structures

**Core Language & Framework**  
- C#  
- .NET WPF 

**Data Structures Used**

- **2D array** (`int[,]` / `bool[,]` )  
  → Represents the game grid state (where food is, occupied cells, etc.)

- **LinkedList** (`LinkedList<Point>` )  
  → Stores snake body segments in **head → tail order**  
  → Efficient addition at head  and removal from tail when not growing  
  → Used for exact position tracking of each segment

- **LinkedList** (direction buffer)  
  → Queues player direction inputs sequentially  
  → Prevents invalid 180° turns and allows smoother control feel

- **Dictionary**  
  → Maps grid cells → visual elements / images (for fast rendering)  
  → Maps direction → rotation angle (0°, 90°, 180°, 270°) for correct head orientation

- **2D array of  Image controls** 
  → One visual element per grid cell  
  → Enables fast, selective updates instead of redrawing the entire screen

These choices prioritize clarity, performance on small grids, and educational value.

## Prerequisites
- **Operating System**: Windows 10/11 
- **.NET SDK / Runtime**: .NET 6.0 / .NET 7.0 / .NET 8.0   
  → [Download here](https://dotnet.microsoft.com/download)  
- **IDE**:  
  - Visual Studio 2022 
  - JetBrains Rider  

## Setup Instructions

### Option 1: Clone from GitHub 
1. Copy the repository URL
2. In your IDE:  
   - Visual Studio → File → Clone Repository…  
   - Rider → VCS → Get from Version Control…
3. Paste URL and clone

### Option 2: Download ZIP
1. Download ZIP from GitHub
2. Extract to a folder (e.g. `C:\Projects\SimpleSnakeGame`)
3. Open the `.sln` file in Visual Studio / Rider

### Run the Project
1. Open the solution (`.sln`)
2. Right-click the **solution** → **Restore NuGet Packages** 
3. Set the game project as **Startup Project**
4. Press **F5** or click **Run**

The game window should appear immediately.

## How to Play
- Use **arrow keys** to steer the snake
- Eat the red food to grow longer and score points
- Avoid hitting walls or the snake's own body
- Try to achieve the highest score possible!

## Controls
| Key            | Action                  |
|----------------|-------------------------|
| ↑ ↓ ← →        | Change direction        |
|  R             | Restart game            |
|  Esc           | Exit / Pause            |

## Important Notes
- No external dependencies / APIs are used
- Collision detection is grid-based → very reliable
- Direction buffer prevents frustrating instant reversals



AI was **not** used to write the entire game. Core game loop, rendering, and logic were manually designed, implemented, and tested.



---
© Kashvir Sewpersad 2025/2026
