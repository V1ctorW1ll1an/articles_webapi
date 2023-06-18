#project variable 

PROJECT_NAME ?= GoodBooks

.PHONY: migrations db hello run migrationsRemove

migrations: 
		cd ./ArticlesData && dotnet ef --startup-project ../ArticlesWeb/ migrations add $(mname) && cd ..

db: 
		cd ./ArticlesData && dotnet ef --startup-project ../ArticlesWeb/ database update && cd ..

hello: 
		echo 'Hello word!'
		
run:
		cd ArticlesWeb && dotnet build && dotnet run

migrationsRemove: 
		cd ArticlesData && dotnet ef migrations remove