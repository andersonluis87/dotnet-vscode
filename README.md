# Developing dotnet using VS Code

## Examples
1. Creating a solution:
    ``` 
    dotnet new sln -n "VsCodeSolution"
    ``` 
2. Creating a Console Application:
    ``` 
    dotnet new console -n "IntroUI"
    ``` 
3. Creating a Class Library Application:
    ``` 
    dotnet new classlib -n "IntroLibrary"
    ``` 
4. Referencing all projects to the solution:
    ``` 
    dotnet sln VsCodeSolution.sln add **/*.csproj
    ``` 
    > *Bash commands makes it easier to add the projects at once to the sln file. If you use command prompt (windows), you will need to add the projects one by one*

5. Creating a reference between projects:
    ``` 
    dotnet add IntroUI/IntroUI.csproj reference IntroLibrary/IntroLibrary.csproj
    ``` 
6. Adding a Nuget Package to your project:
    
    Navigate to your project and run the following commnad:
    ```
    dotnet add package Dapper
    ```
