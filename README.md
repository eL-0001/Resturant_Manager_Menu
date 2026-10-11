# Restaurant Manager Menu

A beginner-friendly C# console application that lets a restaurant manager maintain a simple food menu.

## Features

- Add food items to the menu.
- Remove an item by selecting its number.
- Edit an existing item.
- Display the current menu.
- Validate menu selections and main-menu input.
- Exit the program using a confirmation prompt.

## How to Run

1. Open the project in Visual Studio or another C# environment.
2. Run the program.
3. Choose an option from the displayed menu.
4. Follow the prompts to add, remove, edit, or display food items.

## Example

```text
Restaurant Manager Menu:

What do you want to do?
1. Add a food to the menu
2. Remove a food from the menu
3. Edit food
4. Show Menu
5. Exit
```

After adding items, choosing **Show Menu** displays them with numbers so you can select the item to remove or edit.

## C# Concepts Practiced

- Console input and output
- Variables and strings
- Lists using `List<string>`
- `foreach` loops
- `while` loops
- `if` / `else if` / `else` conditions
- Methods and method parameters
- `int.TryParse()` for input validation
- List indexing and `RemoveAt()`

## Current Limitations

- Menu items are stored in memory, so they are lost when the program closes.
- The program currently manages food names only; it does not store prices or descriptions.
- Input validation for blank food names and repeated exit confirmation can be improved.

## Possible Future Improvements

- Prevent blank food names.
- Repeat the exit confirmation when the response is invalid.
- Display a clear message when the menu is empty.
- Add prices to menu items.
- Save menu items to a file so they remain available after restarting the program.
- Improve the menu layout and user instructions.

## Author

**eL-0001 (also Bokang Malgas)**

This project is part of my early C# learning and practice.
