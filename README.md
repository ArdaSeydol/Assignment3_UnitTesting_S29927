# Assignment 3 – Unit Testing (C# / .NET 8)

## Overview
This repository contains two independent modules, both tested with NUnit.

1. **ShapesProject** – Calculates area and volume for different geometric shapes.  
   - Classes: Sphere, Cube, Rectangle, Cylinder  
   - Interface: IShape  
   - Tested in ShapesProject.Tests

2. **CalcApp** – A simple calculator performing arithmetic operations.  
   - Methods: Add, Subtract, Multiply, Divide  
   - Tested in CalcApp.Tests  
   - Includes a console demo (Program.cs)

---

## Running Tests
```bash
dotnet test
