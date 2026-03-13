OUT=ghosts.exe

build:
	dotnet publish -r win-x64

clean:
	dotnet clean
	rm -rf bin obj

format:
	dotnet format

run:
	wine ./bin/Release/net10.0-windows/win-x64/${OUT} 2>/dev/null
