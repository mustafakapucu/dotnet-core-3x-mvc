# dotnet-core-3x-mvc-generic-respository-unit-of-work

for ef core migrations

# add design package
dotnet add AspNetCore.Presentation/AspNetCore.Presentation.csproj package Microsoft.EntityFrameworkCore.Design

# add migrations
dotnet ef --startup-project AspNetCore.Presentation/AspNetCore.Presentation.csproj migrations add InitialModel -p AspNetCore.Data/AspNetCore.Data.csproj

# database update
dotnet ef --startup-project AspNetCore.Presentation/AspNetCore.Presentation.csproj database update
