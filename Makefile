update:
	dotnet ef database update

add:
	dotnet ef migrations add $(NAME)
