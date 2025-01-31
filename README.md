# LimsLibraryUtils
Dedicated library that contains all the utilities used in Lims Project

Steps to deploy for use :
    1 - Implement your utility class
        NB : Make sure there is not an error in your code
    2 - Build it and export it as dll by running
        shell : "dotnet build --configuration Release"
        NB : The dll will be normally located inside ./bin/Release/net8.0/ApiService.dll
    3 - Now go to your other project where you want to use this lib
    4 - Create a directory named /lib
        Your project directory achitecture shall be like this :
            /MyProject
                /lib
                    ApiService.dll
                /MyProject.csproj
                /Program.cs
    5 - Change your .csproj and add this inside "<ItemGroup>" with the other nuget or other packages
        "
            <Reference Include="ApiService">
                <HintPath>.\lib\ApiService.dll</HintPath>
            </Reference>
        "
    6 - Run : "dotnet restore" in the project to reload it
    7 - Now enjoy using, do not forget to import the package that contains your class in the library