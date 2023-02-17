Product was assigned for Assignment on 2 Feb, 2023.
Then i took some days to think about  my product 

Start Project on 2023-02-16    1430
At first I create a project named with my assigned product that is Lamps by
selecting Individual Accounts.

then create a repository on githib and clone my repository.

After creating project I test my project . It was perfect till this time

In the next step I add HelloWorldController.cs  inside  Controllers/HelloWorldController.cs.
The do coding in HelloWorldController.cs.
After that I test by code by IIS Express . It is running till this time      1530
After that test again on localhost by /HelloWorld/Welcome .   


Then I added Index.cshtml insise Views Folder and replace some code in Index.cshtml.
After that make some changes in _Layout.cshtml   and   add @DateTime.Now.ToString("2023")  for real time and date.

In next step i changed the heading with My Lamps List.

Uffff ***Finally Reached on main part Models

Create a Lamp.cs file and update the code.
Then Install NuGet Packages and then run command in the PMC Install-Package Microsoft.EntityFrameworkCore.SqlServer

After that Create database context class inside Data and 
register the databse context using statements Lamps.Data;
using Microsoft.EntityFrameworkCore;

Then I reached on Scaffold Page 
oooooohh shitttt got an error  
something like download microsoft.visualstudio.web.codegenerator      2116

****To solve this error i modify something in my Visual Studio Installer 
Then try to scaffold again,   huuuuuu luckily successful this time .      2200 ****

Use the EF Core Migrations feature to create the database

In the PMC, enter the following commands:

Add-Migration InitialCreate             1030
Update-Database

***Took Break for some time ****

then create as class named as SeedData.cs in the Models folder .
Update the code of SeedData.cs file with adding Lamps information .


After that Update my Program.cs file .

Yeaahhh! Finally Test my data .   Hurraaah! successfuly got my Lamps properties.          0133

thats it for today . Rest part will continue next morning.    Pause Project  0135

******Start Project   Again at 1314   *****

Add navigation bar named as Abous us and Lamps inside _Layout.cshtml  

change the font style and add bpdy color on home page.
