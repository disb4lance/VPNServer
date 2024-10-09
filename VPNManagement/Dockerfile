# Укажите образ .NET SDK
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Копируем csproj и восстанавливаем зависимости
COPY VPNManagement/VPNManagement/VPNManagement.csproj ./  # Копируем .csproj в /app
RUN dotnet restore                              # Восстанавливаем зависимости

# Копируем все файлы и собираем приложение
COPY VPNManagement/. ./                          # Копируем все файлы из VPNManagement в /app
RUN dotnet publish -c Release -o out             # Публикуем приложение

# Создаем образ для запуска
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .                     # Копируем собранное приложение

ENTRYPOINT ["dotnet", "VPNManagement.dll"]       # Указываем точку входа
