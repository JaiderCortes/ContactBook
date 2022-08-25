# :notebook_with_decorative_cover: Contact Book :notebook_with_decorative_cover:

## :package: Welcome to this project :package:
## :grey_question: I would like to tell you about what is this project :grey_question:

This is a project that I created guiding me through a virtual course. So, I learned how to create views with WinForms and how to connect to a database and execute all 
the necesary queries.

## :hammer_and_wrench: How it works? :hammer_and_wrench:

Well, thats easy. This is a basic contacts book, but this is like a desktop app. So, you can execute all the basic database queries with a beautiful and easy way to
use (CRUD).

## :computer: What about the windows? :computer:

You will find a main window where you can see the search input, search and add buttons and the grid or table where you can see all the contacts. When you click on the 
add button it will show a new window with First Name, Last Name, Phone and Address fields to put there the information of the contact that you will add.
To update a contact, you should click on the "Edit" link at the end of the cell of the contact that you want to edit, it will open the same window where you add a
contact and you will be able to modify each field of that contact.
To delete a contact, you should click on the "Delete" link at the end of the cell of the contact that you want to delete, it will delete that one.

## :scroll: What about the database? :scroll:

In this repository you will find a `.sql` file called *ContactBook.sql*, thats the database query file. In this file you will find the query to create the database and 
the table: contact, this all corresponds to the schema. Also, inside this file you have the insert query with all the initial data to insert it and see how 
works the grid, if you don't want to use this data, you can try inserting your own data with the app.

## :electric_plug: And the database connection? :electric_plug:

In this repository you will find also a `.udl` file called *dbConnection*, this file makes the connection with the database. Here you have the instructions to connect 
your own user:
1. Open the file
2. Change the server name, selecting your own server name that you created when you installed SQL Server. If it doesn't appear, click on the **_update_** button
3. Select the checkbox if you want to use Windows autentication or specific autentication (With the user and password that you created when you installed SQL Server).
**Recomended:** Windows NT integrated security
4. Select the database on the dropdown list, it should appear ContactBook.
5. Click on the "Test connection" button. If all was good it should appear a confirmation window.
6. Click on "Ok".
7. Open the file with Notepad or Sublime Text
8. Copy the content of the third line after the **_;_** (semicolon), from *Integrated* to the end of the line. This is the connection line that we use in DataAccessLayer class to establish the connection to the database (Lines 18 and 19). Paste it on the 19 line of the class inside the double quotes.

## :white_check_mark: Let's use the app :white_check_mark:

### :desktop_computer: Software Requirements :desktop_computer:
- .NET, latest version
- Visual Studio
- SQL Server
- Microsoft SQL Server Management Studio 18 (MSSMS)
### :open_book: Instructions :open_book:
1. Clone this repository
2. Open `ContactBook.sln` in Visual Studio
3. Run project!

## :heavy_check_mark: That's all! :heavy_check_mark:

If you want to contribute in this app to give it improvements or fix bugs, you can contact me and tell me through my personal email: jacortessa@gmail.com

## Enjoy it! :blush: :partying_face:

# Created with :heart: by [Jaider](https://github.com/JaiderCortes) in :colombia:
