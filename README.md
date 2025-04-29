# JSON Deserialization and Inheritance in C# using .NET and Newtonsoft.Json

This project demonstrates working with JSON data in a .NET Console Application using C# and the `Newtonsoft.Json` package. It covers basic deserialization, object-oriented inheritance, and handling different user types from JSON.

---

##  Task Overview

###  **Task 1: Manual JSON File Creation and Basic Deserialization**
- Created a `user.json` file with `Name`, `Age`, and `City`.
- Deserialized JSON into a `User` object.
- Displayed user info on the console.

###  **Task 2: Add New Entries to JSON**
- Converted `user.json` into an array of users.
- Added multiple users.
- Deserialized into `List<User>` using a loop.

###  **Task 3: Inheritance and User Types**
- Extended `User` into:
  - `AdminUser` with `AdminLevel`
  - `RegularUser` with `SubscriptionType`
- Created `user_types.json` with mixed user types.
- Used conditional logic to deserialize into correct type.

###  **Task 4: Final Deserialization and Output**
- Printed all properties using a loop.
- Reused Task 3’s logic and output.

---

##  Files Included

- `Program.cs` – Main console program
- `User.cs` – Contains `User`, `AdminUser`, and `RegularUser` classes
- `user.json` – Basic user data
- `user_types.json` – Extended user types data

---

##  Tools & Libraries

- **Language**: C#
- **Framework**: .NET Core
- **Package**: [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/)

---

##  Author

- **Student:** Mehedi Hasan
- **GitHub Repository:** [16Mehedi/JsonExample](https://github.com/16Mehedi/JsonExample)

