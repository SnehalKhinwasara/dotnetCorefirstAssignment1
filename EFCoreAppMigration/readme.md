Dotnetcore Migrations using Command Line iNterface (CLI) using dotnet.exe

// 1. generating the Migration and snapshot files

dotnet ef migrations add <NAME-OF-THE-MIGRATION> -c <THE-DBCOntext-Class-Namespace-Path>

// 2. Updating database by running migrations

dotnet ef database update -c <THE-DBCOntext-Class-Namespace-Path>

=============================================================================================================================================
Assignment 1: Day 1

Create a database for the Category and Products using Code-First Approach on EF Core 3.x. Make sure that Category Contains Multiple Products.
Create a class using .NET Core 3.1 Console Application having following methods
1. Method should accept Data for list of categories and products in relation and peroform Insert operation for multiple records at once. 
2. Method that will return all products for a specific Category by category Name. The the reusultant collection should show all products with 
the categoryname for each row.
3. Validate the Price for the product that should be greater than or equalto the baseprice of the category where the product will be added.