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
---

## Additional Test Cases

To improve test coverage and demonstrate more scenarios, **six extra unique unit tests** were added:

### ShapesProject.Tests (3 new tests)
- **Sphere** → Radius = 0 should return area = 0.
- **Cube** → Side = 0 should return volume = 0.
- **Cylinder** → Radius = 2, Height = 10 must produce correct surface area (≈ 150.796).

### CalcApp.Tests (3 new tests)
- Addition with negative numbers (e.g. -5 + 3 = -2).
- Multiplication by zero should always return 0.
- Division should return a precise double result (e.g. 1 / 2 = 0.5).

All additional test cases successfully pass when running:

```bash
dotnet test
