# Rent a Car App - Software Engineering & Testing
+ [Installing](#install) &#9989;
    - [Project Setup](#project-setup)
    - [Running Tests](#tests)


## Install 
1. Install [Visual Studio 2022](https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Community&channel=Release&version=VS2022&source=VSLandingPage&cid=2030&passive=false).
2. Install project by clicking ![Code Button](images/code_button.png)
3. Download ZIP
4. Unzip downloaded zip
5. Go into unzipped folder and double click **API.sln**


## Project Setup
1.  Go into the **Solution Explorer** on the right 
![Solution Explorer](images/SolutionExplorer.png)
2. Right-click **Solution 'API' (3 of 3 projects)**
3. Click **Set Startup Projects** towards the middle 
![Right Click Menu](images/Startup.png)
4. Set the checkbox to **Multiple startup projects**
5. Set **API** and **RentalWebApp** to **Start** and leave AppTests as None ![Set Startup Projects](images/startprojects.png)
6. Click OK then click **CTRL + SHIFT + B** to build solution
7. If build is successful, everything **should** work!

## Tests
1. At the top of Visual Studio in the toolbar, you should see **Test**
2. Click **Test** then **Test Explorer**
3. Click the **Left most run button** - Hovering over it should say *Run all Tests in View*
4. Folding out AppTests will provide you with each test ran.
![Tests](images/tests.png)