# STUDENT MANAGEMENT SOFTWARE

Your project is a software designed for life management, comprising functions such as add, delete, and edit.

## Tech stack

- Visual Basic .NET
- [DevExpress][DevExpress]
- SQL Server

## SOLUTION DESIGN

The software is designed with a main form and a student management form.

### 1. Main form

The main form displays a dropdown menu button as shown in the image:
![alt text](images/mainform.png)

- If the user clicks on the menu button, a list will appear as shown in the image:
  ![alt text](images/list.png)

- When the user clicks on the "Student list" button, the student management form will appear.

### 2. Student management form

The student management form includes functional buttons for adding, deleting, and editing, as well as a table displaying the list of students.

![alt text](images/studentform.png)

- The "Add" button is used to add new data. When the user clicks on this button, a form will appear for the user to enter information.This form has two functional buttons, including the "Save" button for saving data to the database and the "Reset" button to help users quickly clear information.
  ![alt text](images/addform.png)

- The "Delete" button is used to remove data. This button helps users delete data from the currently selected row with a mouse click.

- The "Export file" button is used to export the student list to a PDF file format.

- In addition, users can directly add or update information on the student list table.

  [DevExpress]: https://www.devexpress.com/
