# StartSmartStudentManagement
Members: Zander, 

Task: Develop a C# Windows Forms application that manages student records using text files and incorporates Git version control. The application should include the following features:
1. Add New Student: Through a form interface, allow the user to input student details (Student ID, Name, Age, and Course) and save these details to a file called students.txt.
2. View All Students: Display all student records from students.txt in a DataGridView.
3. Update Student Information: Enable the user to search for a student by ID, update their details through a form, and save changes.
4. Delete a Student: Allow the user to select a student from the DataGridView and delete the corresponding record from the file.
5. Generate a Summary Report: Calculate the total number of students and the average age, and display the results on the form, saving this summary to a file named summary.txt.
6. Version Control with Git:
  • Initialize a Git repository for the project.
  • Stage and commit changes after each major modification (add, update, delete, or report generation).
  • Push the repository to GitHub.

## The requirements for the project are as follows:
1. Create a C# Windows Forms Application:
- The application should be designed with an interface that allows users to interact with the Student Management System, including input fields and action buttons.
3. Implement Core Functionalities:
- Add New Student:
  - Use input fields (TextBox controls) for Student ID, Name, Age, and Course.
  - Save new student details to a file called students.txt.
- View All Students:
  - Display the list of students in a DataGridView control on the form.
  - Load student data from students.txt and populate the DataGridView.
- Update Student Information:
  - Allow selection of a student record from the DataGridView, and populate the input fields for editing.
  - Save the updated information back to students.txt.
- Delete a Student:
  - Enable the user to delete a selected student from the DataGridView.
  - Remove the corresponding record from students.txt.
- Generate a Summary Report:
  - Calculate and display the total number of students and average age on the form.
  - Save these details in a file called summary.txt.
4. Implement Version Control Using Git:
- Initialize a Git Repository:
  - In the project directory, initialize a Git repository.
- Commit Changes:
  - After implementing each major feature (Add, Update, Delete, Generate Report), stage and commit the changes.
  - Ensure clear, meaningful commit messages that describe each change.
5. Integrate with GitHub:
- Create a GitHub Repository:
  - Set up a new repository on GitHub and push your local commits to this remote repository.
- Push Changes:
