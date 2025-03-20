# ToyRobotSimulator
Toy Robot Simulator

Overview

The Toy Robot Simulator is a console-based simulation where a toy robot moves on a 5x5 tabletop. The robot follows a set of commands to navigate the grid while ensuring it does not fall off the table.

How to Run the Program

Prerequisites

.NET SDK (Download from dotnet.microsoft.com)

Visual Studio (Optional but recommended)

Steps to Run

Clone the Repository

Build the Project

Run the Application

Commands

Command

Description

PLACE X,Y,F

Places the robot at (X, Y) facing NORTH, SOUTH, EAST, or WEST.

MOVE

Moves the robot one unit forward in its current direction.

LEFT

Rotates the robot 90° left without moving.

RIGHT

Rotates the robot 90° right without moving.

REPORT

Displays the current position and direction of the robot.

EXIT

Stops the simulator.

Example

Input:

Output:

Running Unit Tests

This project includes xUnit tests for validating robot movements.

Steps to Run Tests

Navigate to the test project:

Run tests using .NET CLI:

