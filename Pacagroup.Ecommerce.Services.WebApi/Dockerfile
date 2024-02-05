 # Esta linea indica desde que sdk se va a compitar, con la version y se crea un alias a la imagen (build-env).
FROM mcr.microsoft.com/dotnet/core/sdk:3.0  AS build-env
# Se establece directorio de trabajo, se crea el directorio src dentro del sistema de archivos de la imagen.
WORKDIR /src
# Indica que se copie todo el contenido del diretorio actual del dockerhost hacia el directorio src de la imagen.
# En este caso se copia desde el origen .
COPY . . 
# 
WORKDIR /src/Pacagroup.Ecommerce.Services.WebApi
# Restaura los paquetes que utiliza la aplicaion desde nuget
RUN dotnet restore
# Se idica que se realice la publicacion del proyecto en release y el resultado se almacena en el directorio out.
RUN dotnet publish -c Release -o out
# imagen base defnitiva sobre la cual se va a agregar los componentes del proyecto.
FROM mcr.microsoft.com/dotnet/core/aspnet:3.0
# El directorio de trabajo en la imagen definitiva
WORKDIR /App
# Se copian los arhivos del directorio out al directorio App de la imagen definitiva
COPY --from=build-env /src/Pacagroup.Ecommerce.Services.WebApi/out ./
# Permite ejecutar un ejecutable en el contenedor al momento del arranque.
ENTRYPOINT [ "dotnet",  "Pacagroup.Ecommerce.Services.WebApi.dll"]