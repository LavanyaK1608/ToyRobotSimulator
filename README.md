# Toy Robot Simulator

## Overview
The **Toy Robot Simulator** is a console-based simulation where a toy robot moves on a **5x5 tabletop**. The robot follows a set of commands to navigate the grid while ensuring it does not fall off the table.

## How to Run the Program
### Prerequisites
- **.NET SDK** (Download from [dotnet.microsoft.com](https://dotnet.microsoft.com/))
- **Visual Studio** (Optional but recommended)

### Steps to Run
1. **Clone the Repository**
   ```sh
   git clone <your-repo-url>
   cd ToyRobotSimulator
   ```
2. **Build the Project**
   ```sh
   dotnet build
   ```
3. **Run the Application**
   ```sh
   dotnet run
   ```

## Commands
| Command          | Description |
|-----------------|-------------|
| `PLACE X,Y,F`   | Places the robot at (X, Y) facing `NORTH`, `SOUTH`, `EAST`, or `WEST`. |
| `MOVE`          | Moves the robot **one unit forward** in its current direction. |
| `LEFT`          | Rotates the robot **90° left** without moving. |
| `RIGHT`         | Rotates the robot **90° right** without moving. |
| `REPORT`        | Displays the current position and direction of the robot. |
| `EXIT`          | Stops the simulator. |

### Example
#### **Input:**
```
PLACE 0,0,NORTH
MOVE
REPORT
```
#### **Output:**
```
0,1,NORTH
```

## Running Unit Tests
This project includes **xUnit tests** for validating robot movements.

### Steps to Run Tests
1. Navigate to the **test project**:
   ```sh
   cd ToyRobotSimulator.Tests
   ```
2. Run tests using **.NET CLI**:
   ```sh
   dotnet test
   ```

## Project Structure
```
ToyRobotSimulator/
│── ToyRobotSimulator.sln         # Solution file
│── src/
│   ├── Program.cs                # Main entry point
│   ├── Models/
│   │   ├── Robot.cs               # Robot model
│   │   ├── Tabletop.cs            # Table constraints
│   ├── Services/
│   │   ├── CommandProcessor.cs    # Handles commands
│── Tests/
│   ├── RobotTests.cs              # Unit tests
│── README.md                      # Documentation
```

## Contributing
- Fork the repository.
- Create a feature branch.
- Submit a **Pull Request**.

## License
This project is licensed under the **MIT License**.

