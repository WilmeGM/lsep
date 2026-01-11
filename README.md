# lse🅿

**lsep** (List Environment PATH) is a small, fast, and cross-platform command-line utility for inspecting the `PATH` environment variable.

It is designed to help users inspect PATH-related stuff in a simple and readable way.

## Features (v1.0.0.1)

- List PATH entries line by line. 
- Built-in help command.
- Built-in version command.
- Cross-platform support (Windows, Linux, macOS).  

## Installation 

### Windows
1. Check the latest release and download the win-x64 zip file attached (https://github.com/WilmeGM/lsep/releases)
3. Extract lsep.exe
4. Move it to a folder in your PATH (e.g. C:\Tools or whichever)
5. Run: lsep --version

### Linux / macOS
1. Go to the releases page (https://github.com/WilmeGM/lsep/releases) find latest and download the appropriate version for your system attached (linux-x64.zip or osx-x64.tar.gz or osx-arm64.tar.gz)
2. Extract the lsep binary
3. chmod +x lsep
4. sudo mv lsep /usr/local/bin/lsep
5. Run: lsep --version

## Usage
```
lsep [options]
```

### Options

- `--help`, `-h`  
Display help and usage information

- `--version`, `-v`  
Display the current version of lsep

---

## Examples

List PATH entries:

```
lsep
```

Show help:

```
lsep --help
```

Show version:

```
lsep --version
```
---

## Future features

Planned features for upcoming releases:

- Remove duplicate PATH entries  
- Count PATH entries  
- Check PATH entry existence on disk  
- Display PATH statistics  
- Locate executables using PATH resolution  
- JSON output support  
---

## Versioning

This project uses a 4-part numeric versioning scheme:

```
MAJOR.MINOR.BUILD.REVISION
```
- **MAJOR**: incompatible changes  
- **MINOR**: new features  
- **BUILD**: improvements  
- **REVISION**: fixes 
---

## Contributing

Contributions, suggestions, and feedback are welcome.

Steps to contribute:

1. Fork the repository  
2. Create a feature branch  
3. Commit your changes  
4. Open a pull request  
---

## License

This project is open source and available under the MIT License.

## Author

Created by **Wilme GM**
