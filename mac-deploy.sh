dotnet publish -c Release

cp dockerfile ./bin/release/netcoreapp2.1/publish

docker build -t sdg-dotnet-1 ./bin/release/netcoreapp2.1/publish

docker tag sdg-dotnet-1 registry.heroku.com/sdg-dotnet-core-1/web

docker push registry.heroku.com/sdg-dotnet-core-1/web

heroku container:release web -a sdg-dotnet-core-1