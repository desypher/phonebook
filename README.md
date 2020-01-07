# phonebook
Phonebook Application by Brynn Posthumus

Frameworks and Languages: .NET Core (C#), Angular 8, Typescript, Material Angular, SQL (Database), .NET Framework (C#).

Please ensure you have the database set up (you can find my SQL scripts in the 'sql' folder in this directory) and that the application runs on port 5001 as that is the SSL port the application uses.

Also you will need to install Angular 8 as the repo doesn't include the node_modules.

DATABASE NAME USED: phonebook

You can find a backup file of the database under the 'sql' directory.

RELEASE VERSION: https://drive.google.com/file/d/1_Vn1JpndBcc23aOk990JbyunnWEaK7Qq/view?usp=sharing

To run the release version:

1. Unzip the folder called 'publish'.
2. Ensure the SQL database is up and running (Use the backup in 'sql' if needed)
3. Run "phonebook-web.exe" and a cmd window will open
4. Open your browser and type in 
  https://localhost:5001/
5. Check the connection string in app.config which can be found in the 'phonebook-web' directory on the repo or in the main directory of the distributional version to ensure the database details are correct if you are using a different SQL environment.
