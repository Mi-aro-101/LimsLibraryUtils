# LimsLibraryUtils
<h3>Dedicated library that contains all the utilities used in Lims Project</h3>

Steps to deploy for use : <br />
    <ol>
        <li>
            Implement your utility class <br />
            NB : Make sure there is no error in your code
        </li>
        <li>
            <p>Build it and export it as dll by running <br />
            shell : `dotnet build --configuration Release` <br />
            NB : The dll will be normally located inside ./bin/Release/net8.0/ApiService.dll </p>
        </li>
        <li>
           <p> Now go to your other project where you want to use this lib</p>
        </li>
        <li>
            Create a directory named "/lib" in the root of your project <br />
            Your project directory achitecture shall be like this :
            `MyProject ├── lib │ └── ApiService.dll ├── MyProject.csproj └── Program.cs`
        </li>
        <li>
            Change your .csproj and add this inside `<ItemGroup>` section with the other nuget or other packages : <br />
            <div>`<Reference Include="ApiService">`</div>
                <div style="text-indent: 25px;">`<HintPath>.\lib\ApiService.dll</HintPath>`</div>
            <div>`</Reference>`</div
        </li>
        <li>
           <p> Run : `dotnet restore` to reload</p>
        </li>
        <li>
            Now enjoy using, do not forget to import the package that contains your class from the library
        </li>
    </ol>