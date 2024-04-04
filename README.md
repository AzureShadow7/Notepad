# Recipe Finder
This is my first C# .NET project which is done in Visual Studio.
The concept of this project is to have a recipe finder where the user is able to:
* type out what ingredient they have at home
* filter out results based on preparation time and cooking time
* filter between vegetarian and non-vegetarian options
* add their own original recipes to the recipe finder

The project does not display a step by step process of how the meal is prepared but rather has the user input their main ingredient and sort through the existing recipes in the recipe finder to give the user an idea of what meal they can make within the parameters they set.

## Development
I started off the project by deciding the aims for the recipe finder which is stated in the bullet points above. 
The next step was to design and create the layout and UI of the recipe finder in a way that clearly shows the user what they need to input into the program. The layout and the project itself was made in Visual Studios forms template.
![image](https://github.com/AzureShadow7/Recipe-Finder/assets/106389001/069bc2f8-da9e-4d55-a51c-2ac540eee4fa)

The image above shows the current layout of the forms page.

1. Beneath the text "What's in your kitchen?" is a text box, this is going to be the space where the users inputs the main ingredient of the meal that they have at home, like a hero ingredient in a meal such as rice in egg fried rice etc.
2. Next is the specifications for cooking time and preparation time, these are combo boxes that are intended to contain the cooking time and preparation time that will be inputted from the database.
3. The next element is a check box for further filtering of the data into vegetarian and non-vegetarian options.
4. Below that is a simple button that when clicked should run the parameters to be displayed on the next element which is
5. The Data grid viewer, this is meant to display the table from the database after the filtering has been appplied


After the layout and design was finalised it was left to create the database that would store the meal and the parameters for the user to filter through, the database management system used was Microsoft SQL Server Management Studio.
This program allowed me to create a server for the database and create a table containing a meal id, meal name, main ingredient, secondary ingredient, vegetarian, cook time and prep time. 
![image](https://github.com/AzureShadow7/Recipe-Finder/assets/106389001/55fb1bbf-4d5a-449d-95aa-222f59429b2e)

Once the table was created with the right parameters it was filled with sample data that would be used for testing.

I later connected the server containing the database to the visual studio project allowing the project to acces the database. Once that was done, the next step was to start programming. The first thing I did was what I proposed was the easiest step which was to have the button clicked and the data displayed on the datagridviewer. After that step was completed the next step was to filter out the data using the main ingredient. The text box was used for this section. The text box as previously mentioned was to allow the user to type in the main ingredient, upon typing the main ingredient and then clicking the search button, the data grid viewer was to show only the data in the table that had the ingredients inputted as their main ingredient.
This step allowed a more limited choice of meal but another thing to consider was the time of the user, does the user have the time to make the meals that have been listed and assuming the data in the table was much bigger there would be an overwhelming amount of data to sift through trying to find the recipe the user wants so the need for further filtration was found. Using the data from cooking and prep time, the numbers where added to the drop list of elements contained in the comboboxes.
