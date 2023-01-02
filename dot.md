1. create folder Ecommerce

	make folder Ecommerce and the open cmd 
		-----> then cd Ecommerce

2.  	====== To create SOLUTION file

	----> dotnet new sln

3.	======== To Create Test console Appln ======
	
	---->dotnet new console -o Test

4. 	======== To Create Classlibraries ========

	-----> dotnet new classlib -o projectname

5.	======= Add Console Appln to Solution ====

	-----> dotnet sln add Test\Test.csproj


6.	====== Add Projects to Solution ===========

	-----> dotnet sln add ProjectName\ProjectName.csproj

7. go to test directory

	cd Test

8.	====== add references ===============

	-----> dotnet add reference ..\ProjectName\ProjectName.csproj


