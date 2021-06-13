# Awesome_Meal_App_Musab_Bekir_181510_Murat_Useini_191546

Visual programming project by students of FINKI-SEIS 2021

Awesome Meal! - Restaurant management application

![Homepage](https://user-images.githubusercontent.com/63672103/121812950-3dc74000-cc6a-11eb-9ea0-1ea6242ae783.png)

Requirements for the application;
- MySQL
- Visual Studio (for editing)/Windows

The application will have different functionalities for staff and customers.

Main purpose of the application is food ordering.

After the initiation of the application, the customer will be directed to home page by default. Basic functionalities for customers are;
- They will be displayed home page product (which can be changed by staff/ordered by customers!);
- [homepage product](https://user-images.githubusercontent.com/63672103/121812998-7404bf80-cc6a-11eb-8a06-2292639b9fe4.png)
- Visit social media links from the list which is located on top of the application;
- ![social media links](https://user-images.githubusercontent.com/63672103/121813026-972f6f00-cc6a-11eb-8933-e9060af6d26c.png)

- They can go through the list of products by going to "Products" section which is located at the right panel. A list of all products will be displayed to customers from which they can choose the meal they want to have;
  The products' data will be gathered from database (FoodDatabase.mdf) and all products will be listed ready to be ordered.
- ![food database](https://user-images.githubusercontent.com/63672103/121813080-d493fc80-cc6a-11eb-97d4-3521f41e8ded.png)

- They can also go to "About" page by clicking the About button from the right panel;
- ![about us](https://user-images.githubusercontent.com/63672103/121813160-102ec680-cc6b-11eb-837c-d13759332300.png)
- There will be "Employee Login" button available but they have to create an employee account (which will be stored at local database LoginDatabase.mdf) in order to log in

*Staff* members (workers) of the restaurant will be able to create accounts and log in in order to change the home-page product or change the FoodDatabase.mdf data.
- Other than the functionalities for regular customers, staff members will be able to Register (new)/Log-In (to their) account from "Employee Log-In" button.
- While the current existing staff/employees of the restaurant can log in by using their username-password, new staff/employees will have to be registered firstly.
- ![login form](https://user-images.githubusercontent.com/63672103/121813188-394f5700-cc6b-11eb-9f46-bfe87b4b17f3.png)
- Registration form can be accessed after clicking "Employee Log In > Register".
- New employee will be asked to input their
1. Username
2. Password (with confirmation)
3. Name
4. Surname
5. Restaurant management password (which is for security reasons. By default it is set to "finkiVPproject").
- After a successful Registration, new employee's data will be sent and stored on LoginDatabase.mdf so that it can be accessed for Log in after.
- ![image](https://user-images.githubusercontent.com/63672103/121813228-6865c880-cc6b-11eb-971d-786934d1969c.png)
- ![staff database](https://user-images.githubusercontent.com/63672103/121813368-09ed1a00-cc6c-11eb-9abc-dab23fe76893.png)
Logged In *Employees*
- Their username will be written below "Log Out" button.
- Logged in employees will be able to edit the database "FoodDatabase.mdf". After an employee logs in, 
1. Edit Home Page Product button;
-[EditHomePageProd](https://user-images.githubusercontent.com/63672103/121819981-6feb9880-cc90-11eb-84f5-6e9a90fb746f.PNG)
2. Edit Product List button;
3. Log-out button;
will appear on the bottom right of the application.
- Logged in employee can edit the home page product by clicking the "Edit Home Page Product" button. They will be redirected to a new form where they can edit the home page product.
- At the form employee will have to input Price, Title, Category and Picture of the product. After writing the necessary data, they will be able to click "Edit" button.

"Edit Product List"
- Logged in employee will be able to edit the current database by clicking Edit Product List button which will appear on bottom right after a successful log in.!
- After clicking the button, employee will be displayed a database of current products and textboxes for being able to add new product.
"Log Out"
- Log out button can be clicked by an employee so that they can log out from the system.

Musab Bekiri - 181510
Murat Useini - 191546
