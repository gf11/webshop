## EF Commands

#Install Tools
dotnet tool install --global dotnet-ef

#Initial Migration
dotnet ef migrations add --project ch.gibz.m151.demo.data --startup-project ch.gibz.m151.demo.api Initial

#Update Database
dotnet ef database update
dotnet ef database update --project ch.gibz.m151.demo.data --startup-project ch.gibz.m151.demo.api

#Remove Migration
dotnet ef migrations remove --project ch.gibz.m151.demo.data --startup-project ch.gibz.m151.demo.api Privileges