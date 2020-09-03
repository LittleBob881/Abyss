Open Abyss.sln file to edit the sloution. 

Abyss.sln location:
GitHub> Abyss > Abyss Abyss.sln
Do not move this flie or unity will create a new one. 

There are 3 parts that creates our code: 
abyss database project
abyss class library project
Asembly-Csharp project (can not join others in solution as unity is a bitch
			and will delete)


refencing database and library with the Asembly-Csharp is a bitch.

So far i have worked out you must take the .dll file from both and put it 
in the unity plugin folder. 
https://www.youtube.com/watch?v=DfRYLwG1Bug  < very good video explaining
dont know if you have to trasnfer .dll

to create scripts create in unity.  

<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>< 
project functions
_________________

 
Asembly-Csharp:
This holds the scrips. 
Create your scripts in the script folder. 
Scrips are the working code.
We should have a script for each scene and in the class model 
they are the contollers




AbyssDatabase:
Holds data 

  


AbyssLibrary:
Create classes here then import this library to the scrips made 
in unity.   