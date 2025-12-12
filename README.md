# PassBox.v2# 

PassBox v2 is a comprehensive password management application developed using C# and Microsoft SQL Server. It provides a secure and organized environment for users to store, manage, and retrieve their credentials efficiently. The system includes advanced features such as Windows Hello biometric authentication, activity logging, and categorized storage.

## Key Features

**Authentication and Access Control**
* **Windows Hello Integration:** Supports secure, password-less login using biometric authentication (Face ID or Fingerprint) and PIN, leveraging Windows security standards.
* **Secure Access:** Ensures that only the authorized user can access the stored credentials.

**Password Management**
* **Secure Storage:** Store passwords along with platform names, usernames, and email addresses.
* **CRUD Operations:** Fully functional interface to add, edit, delete, and view password records.
* **Weak Password Detection:** Automatically identifies and lists passwords that are shorter than 8 characters to ensure better security hygiene.

**Advanced Categorization**
* **Category Management:** Users can create custom categories (e.g., Social Media, Banking, Work) to organize their credentials.
* **Color Coding:** Each category can be assigned a specific color code for better visual organization.
* **Relational Structure:** Passwords are linked to categories, allowing for structured data management.

**Search and Retrieval**
* **Global Search:** Advanced search functionality that filters results by Platform Name, Username, or Email Address simultaneously.
* **Sorting:** Recent records are prioritized for quicker access.

**Security and Auditing**
* **Activity Logging:** The system automatically records every critical action (add, delete, update) in a dedicated security log table.
* **Log Details:** Logs include the operation type, description, and exact timestamp.
* **Automatic Maintenance:** Includes a built-in feature to automatically clean up security logs older than 30 days to optimize database performance.

**Dashboard and Statistics**
* **Statistical Overview:** Displays real-time counts for total passwords, total categories, and total transaction logs.

## Technical Details

* **Programming Language:** C# (.NET)
* **Database:** Microsoft SQL Server
* **Data Access:** ADO.NET (Stored Procedures)
* **Security:** Windows Hello Biometric Framework
* **Architecture:** Layered architecture separating database logic from the user interface.

## Installation

1.  Clone or download the project repository.
2.  Open Microsoft SQL Server Management Studio (SSMS).
3.  Execute the `PassBox.sql` script included in the root directory to generate the database, tables, and stored procedures.
4.  Open the project in Visual Studio.
5.  Update the connection string in `SqlBaglantisi.cs` to match your local SQL Server instance.
6.  Build and run the application.

---
Developed by byBavli
