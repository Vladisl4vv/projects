# File Organizer

A simple Windows Forms application written in **C#** that automatically organizes files inside a selected folder into categorized subfolders based on file extensions.

---

## Features

* Select any folder using a GUI
* Automatically sorts files into folders such as:

  * Photos
  * Videos
  * Documents
  * Audio
  * Archives
  * Code
  * Executables
  * Logs
  * Other
* Supports many common file extensions
* Simple and beginner-friendly code structure
* Prevents window resizing for cleaner UI
* Displays success/error messages using MessageBox

---

## How It Works

The program:

1. Lets the user choose a directory
2. Scans all files inside that directory
3. Detects each file's extension
4. Moves the file into a matching category folder
5. Creates missing folders automatically

### Example

Before:

```text
Desktop/
├── image.png
├── song.mp3
├── project.cs
├── notes.txt
```

After:

```text
Desktop/
├── Photos/
│   └── image.png
├── Audio/
│   └── song.mp3
├── Code/
│   └── project.cs
├── Documents/
│   └── notes.txt
```

---

## Technologies Used

* C#
* Windows Forms (.NET)
* System.IO
* Visual Studio

---

## Supported File Categories

| Folder      | Extensions                                          |
| ----------- | --------------------------------------------------- |
| Photos      | png, jpg, jpeg, gif, bmp, tiff, webp                |
| Videos      | mp4, mov, avi, mkv, wmv, flv, webm                  |
| Documents   | pdf, doc, docx, txt, rtf, xls, xlsx, ppt, pptx      |
| Audio       | mp3, wav, flac, aac, ogg, m4a                       |
| Archives    | zip, rar, 7z, tar, gz                               |
| Code        | cs, cpp, c, py, js, html, css, java, php, json, xml |
| Executables | exe, msi, bat, cmd                                  |
| Logs        | log                                                 |
| Other       | Unknown extensions                                  |

---

## Running The Project

### Requirements

* Visual Studio
* .NET Windows Forms support

### Steps

1. Clone/download the project
2. Open the `.sln` file in Visual Studio
3. Run the project using:

   * `F5` for Debug
   * `Ctrl + F5` without debugger

---

## Executable

The executable version of the program is already included inside the net8.0-windows folder inside the main project folder on GitHub

You can run it directly without opening Visual Studio.

---

## Important Notes

* The program currently organizes only files in the selected folder (not subdirectories).
* Files are copied into target folders and then deleted from the original location.
* Unknown file types are moved into the `Other` folder.

---

## Possible Future Improvements

* Recursive folder scanning
* Drag & drop support
* Custom categories
* Duplicate file handling
* Progress bar
* Undo feature
* Dark mode UI
* Multithreading for large folders

---

## Author

Made by Vlad as a C# Windows Forms practice project.
