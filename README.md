# 📚 Library Management System

A console-based Library Management System developed in C#, designed to facilitate user registration, authentication, and book management operations such as adding, searching, and deleting books.

---

## 🚀 Features

- **User Roles**: Supports Admin, Librarian, and Patron roles with distinct permissions.
- **User Management**: Register new users, login authentication, and user data persistence.
- **Book Management**: Add, search (by title, author, ISBN, genre), list, and delete books.
- **Data Persistence**: User data stored in `users.txt`; book data serialized in `books.dat`.
- **Reporting**: Generate reports on the number of books, users, and books currently on loan.

---

## 🛠️ Getting Started

### Prerequisites

- .NET 6.0 SDK or later
- Visual Studio 2022 or any compatible IDE

### Installation

1. **Clone the repository**:

   ```bash
   git clone https://github.com/NoorTantawi/LibrarySystem.git
   ```

2. **Navigate to the project directory**:

   ```bash
   cd LibrarySystem
   ```

3. **Open the project in Visual Studio**:

   - Open `UML_Project.csproj`

4. **Build and run the application**:

   - Press `Ctrl + F5` to build and run without debugging.

---

## 📂 Project Structure

```
LibrarySystem/
├── Admin.cs
├── Book.cs
├── Catalog.cs
├── GenerateISBN_code.cs
├── Librarian.cs
├── LibrarySystem.cs
├── Patron.cs
├── User.cs
├── main.cs
├── UML_Project.csproj
├── users.txt
├── books.dat
├── .gitignore
└── README.md
```

---

## 📄 Usage

Upon running the application:

1. **Main Menu**: Choose to register or login.
2. **Registration**: Provide name, username, password, and contact information.
3. **Login**: Enter username and password to access the system.
4. **Post-Login**:
   - **Admin**: Manage users and view reports.
   - **Librarian**: Manage book inventory.
   - **Patron**: Search and view books.

---

## 📝 Notes

- **Data Files**:
  - `users.txt`: Stores user information. Ensure this file is present in the project's root directory.
  - `books.dat`: Binary file storing serialized book data. Automatically created upon adding books.

- **File Paths**: The application reads and writes to `users.txt` and `books.dat` located in the same directory as the executable.

---

## 🤝 Contributing

Contributions are welcome! Please fork the repository and submit a pull request for any enhancements or bug fixes.

---

## 🙋‍♂️ Author

**Noor-Aldeen Tayseer Tantawi**  
[LinkedIn](https://www.linkedin.com/in/nooraldeen-tantawi-3bb899237/)  
[GitHub](https://github.com/NoorTantawi)

---

## 📄 License

This project is licensed under the [MIT License](LICENSE).
