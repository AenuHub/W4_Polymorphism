## W4_Polymorphism

### Overview
This project implements geometric shape classes (`Square`, `Rectangle`, `RightTriangle`) that inherit from a base class `BaseGeoShape`. The goal is to demonstrate how polymorphism can be used to calculate the area of different geometric shapes in a flexible and maintainable way.

### Class Structure

#### 1. BaseGeoShape
**Properties:**
- `Width` (double): The width of the shape.
- `Height` (double): The height of the shape.

**Methods:**
- `Area()`: A method that calculates and returns the area of a shape. This method is defined in the base class and overridden in the derived classes as needed.

#### 2. Square (Inherits from `BaseGeoShape`)
The `Square` class represents a square, where the area is calculated as:
- `Area = Width x Height`

**Methods:**
- `Area()`: No need to override method as calculation is the same.

#### 3. Rectangle (Inherits from `BaseGeoShape`)
The `Rectangle` class represents a rectangle, where the area is calculated as:
- `Area = Width x Height`

**Methods:**
- `Area()`: No need to override method as calculation is the same.

#### 4. RightTriangle (Inherits from `BaseGeoShape`)
The `RightTriangle` class represents a right-angled triangle, where the area is calculated as:
- `Area = (Width x Height) / 2`

**Methods:**
- `Area()`: This method overrides the base class method and calculates the area as `(Width x Height) / 2`.

### Polymorphism
Polymorphism is applied through the `Area()` method. Each shape class implements its own logic for calculating the area by overriding the method from the base class `BaseGeoShape`. This allows the same method to behave differently based on the object's type (square, rectangle, or triangle).

### How It Works
- The `BaseGeoShape` class provides the foundational properties (`Width` and `Height`) and the method `Area()`.
- The `Square`, `Rectangle`, and `RightTriangle` classes inherit from `BaseGeoShape` and implement their own logic for area calculation by overriding the `Area()` method.
- Polymorphism ensures that when you call the `Area()` method on a shape object, it executes the version defined in the specific class (either `Square`, `Rectangle`, or `RightTriangle`).
