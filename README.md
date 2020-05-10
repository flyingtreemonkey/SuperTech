FINAL SUBMISSION USEAGE INSTRUCTIONS

In order to have this work locally, the user needs to have a repository set up locally to query against for the login information.

This would necessitate changing several lines that relate to file operations and the string for establishing the SQL connection

 return "Host = localhost; Username = postgres; Database = supertech; password =sophie";
 would need to be changed
 
 the output file would also need to be changed
 
 this.application_information = new StreamWriter("C:\\Users\\Sophie\\Desktop\\application" + todays_date + ".txt");
 
 Please consult the data_base_statements.txt to establish the create table statements locally
 
 INSERT INTO Managers (manager_id, manager_password) VALUES ('abcde', 'abcde'); 
 
 Would replicate the necessary manager login information to start using the application
 
 LOG-IN
 
 To log into the application as a manager, provide an appropriate manager ID and password then click "Manager Log-in".
 
 To log into the application as an employee, provide an appropriate employee ID and password then click "Employee Log-in".
 
 MANAGERS
 
 To create a new menu, click the "Add Menu" button and provide an appropriate name (e.g. Lunch, Dinner, etc.). This will create a new button which can subsequently be clicked to access the menu. 
 
 IF the menu is empty, click the "Add Food Item" and provide an appropriate name for the food item. When the new food item button is clicked, you can modify what ingredients will be used to create the food item. Managers may still add food items to the menu even if there are already food item buttons listed.
 
 DO NOT FORGET to click the button "Commit To Database" to save the food item(s), and their ingredients to the menu.
 
 EMPLOYEES
 
 TO ADD ITEMS TO AN ORDER, click the menu button and select the table number (on the right side of the GUI) and then click on the appropriate food item. You can add notes to the order after the button has been clicked, and once submitted will be recorded to a text file.
 
 
 Please reach out to Scott Walters at scott_walters@wsu.edu to obtain more assistance
 
 



Team Name: SZMMKR - SuperTech
# Project Title: Restaurant Automation for Small-Medium Sized Businesses
# Project Repository: https://github.com/flyingtreemonkey/SuperTech

Team Members: 

  Scott Walters : EECS - swalters
  
  Zach Gherman : EECS - zgherman
  
  Matt Molitor : EECS - mmolitor
  
  Kevin Hermanson : EECS - khermans
  
  Riley Hunter : EECS - rhunter
  
  Mathew Nishimoto : EECS - mnishimo
  











*Last Updated by Zach Gherman*
