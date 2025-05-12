# 📝 ASP.NET Core Razor To-Do List App

This is a simple and clean to-do list web application built with ASP.NET Core Razor Pages. It lets users add tasks, mark them as complete, delete individual tasks, and clear the entire list.

## 🌟 Features

- ✅ Add new tasks
- ☑ Mark tasks as done or not done
- 🗑 Delete individual tasks
- 🩹 Clear all tasks at once
- 📂 Stores data using SQL Server (MSQL Express)

## 🚀 Technologies Used

- ASP.NET Core Razor Pages
- Entity Framework Core
- Microsoft SQL Server Express
- Bootstrap 5 for styling

## 💠 How to Run the Project

1. Clone or download this repository:
   ```bash
   git clone https://github.com/yourusername/todo-razor-app.git
   cd todo-razor-app
   ```

2. Make sure you have installed:
   - .NET 6 SDK or later
   - Visual Studio or VS Code

3. Check your connection string in `appsettings.json`:
   Example:
   ```json
   "ConnectionStrings": {
     "TodoDb": "Server=(localdb)\\MSSQLLocalDB;Database=TodoListDb;Trusted_Connection=True;"
   }
   ```

4. Run these commands in the Package Manager Console or terminal:
   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

5. Run the project:
   ```bash
   dotnet run
   ```

6. Open in browser:
   ```
   https://localhost:5001
   ```

## 📁 Project Structure

- `Pages/`
  - `Todo.cshtml` (UI)
  - `Todo.cshtml.cs` (logic)
- `Models/`
  - `TodoItem.cs`
- `Data/`
  - `ApplicationDbContext.cs`

## 📌 Notes

- This is a beginner-friendly project made for learning Razor Pages, C#, and EF Core.
- All data is stored locally using SQL Server LocalDB or SQL Server Express.
