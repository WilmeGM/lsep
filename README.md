# lse🅿

**lsep** (List Environment PATH) is a small, fast, and cross-platform command-line utility for inspecting the `PATH` environment variable.

It is designed to help users inspect PATH-related stuff in a simple and readable way.

## Features (v1.0.0.1)

- List PATH entries line by line. 
- Built-in help command.
- Built-in version command.
- Cross-platform support (Windows, Linux, macOS).  

## Installation

### 🖥️ Windows

1. **Download:** Go to the [Latest Releases](https://github.com/WilmeGM/lsep/releases) and download the `win-x64.zip` file.
2. **Extract:** Extract the contents to locate the `lsep.exe` executable.
3. **Move to PATH:** Move `lsep.exe` to a folder currently in your System PATH (e.g., `C:\Tools` or `C:\Windows`). 
    * *Tip: If you create a new folder, remember to add that folder to your Environment Variables.*
4. **Verify:** Open a terminal (PowerShell or CMD) and run:
   ```powershell
   lsep --version

**🍎 macOS / 🐧 Linux**

1. **Download:** Visit the [Latest Releases](https://github.com/WilmeGM/lsep/releases) and download the archive for your system:
   * **Linux:** linux-x64.zip
   * **macOS (Intel):** osx-x64.tar.gz
   * **macOS (Apple Silicon/M-Series):** osx-arm64.tar.gz
2. **Extract & Prepare:** Open your terminal and run the following:
   ```bash
   tar -xzf osx-arm64.tar.gz  
   chmod +x lsep
4. **Install Globally:** Move the binary to /usr/local/bin:
   ```bash
   sudo mv lsep /usr/local/bin/lsep
6. **Verify:** Run the following to ensure success:
   ```bash
   lsep --version

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
