# Chapter 5: Files and File Dialogs

## Contents

| Section | Topic |
| 5.1 | Using files for data storage |
| 5.2 | The `OpenFileDialog` and `SaveFileDialog` controls |

## 5.1 Using files for data storage

A program saves data for later use by writing it to a **file**. Working with a file always takes three steps:

1. **Open** the file: create a connection between the file and the program.
2. **Process** the file: write to it or read from it.
3. **Close** the file: disconnect the file and the program.

There are two kinds of files:

- **Text file**: data encoded as text (for example Unicode). You can open it in a text editor.
- **Binary file**: data that has not been converted to text. A text editor cannot display it.

This chapter uses text files only. Add `using System.IO;` to use the classes below.

.NET provides two classes for text files:

| Class | Purpose |
| `StreamWriter` | write data to a text file |
| `StreamReader` | read data from a text file |

### Writing to a file


StreamWriter outputFile;
outputFile = File.CreateText("courses.txt");
outputFile.WriteLine("Introduction to Computer Science");
outputFile.WriteLine("English Composition");
outputFile.WriteLine("Calculus I");
outputFile.Close();
```

| Method | What it does |
|---|---|
| `File.CreateText(name)` | creates the file; if it already exists its contents are **erased** |
| `File.AppendText(name)` | opens the file and adds to the **end**; existing contents are kept |
| `Write(item)` | writes the item with **no** newline |
| `WriteLine(item)` | writes the item followed by a newline |

### Specifying the location of a file

Give a path instead of just a name. Prefix the string with `@` so the backslashes are not treated as escape characters.

StreamWriter outputFile = File.AppendText(@"C:\Data\Names.txt");
```

### Reading from a file


StreamReader inputFile;
inputFile = File.OpenText("students.txt");
string line = inputFile.ReadLine();
inputFile.Close();
```

| Method | What it does |
|---|---|
| `File.OpenText(name)` | opens an existing file for reading |
| `ReadLine()` | reads one line and returns it as a `string` |
| `Read()` | reads the next character (returns an `int`, `-1` at the end) |
| `ReadToEnd()` | reads the rest of the file as one `string` |
| `File.ReadAllText(name)` | opens, reads everything, and closes in one call |

### Reading a file with a loop

`StreamReader` has a Boolean property, `EndOfStream`, that is true once the end of the file has been reached.

```csharp
while (!inputFile.EndOfStream)        // same as: inputFile.EndOfStream == false
{
    string line = inputFile.ReadLine();
}
```

## 5.2 The OpenFileDialog and SaveFileDialog controls

These controls show the standard Windows **Open** and **Save As** dialog boxes. They are **invisible controls**: when you add one to a form it appears in the *component tray* below the form, not on the form itself.

Display a dialog by calling `ShowDialog`:

openFileDialog1.ShowDialog();
```

### Detecting which button the user clicked

`ShowDialog` returns a `DialogResult`:

| Value | Meaning |
|---|---|
| `DialogResult.OK` | the user clicked **Open** (or **Save**) |
| `DialogResult.Cancel` | the user clicked **Cancel** |

DialogResult result = openFileDialog1.ShowDialog();

if (result == DialogResult.OK)
{
    // use openFileDialog1.FileName
}
else if (result == DialogResult.Cancel)
{
    // the user cancelled
}
### FileName and InitialDirectory

- `FileName`: the full path of the file the user selected.
- `InitialDirectory`: the folder the dialog shows first.

openFileDialog1.InitialDirectory = @"C:\Data";

if (openFileDialog1.ShowDialog() == DialogResult.OK)
{
    inputFile = File.OpenText(openFileDialog1.FileName);
}
### SaveFileDialog

Works the same way, but you create the file instead of opening it:
if (saveFileDialog1.ShowDialog() == DialogResult.OK)
{
    outputFile = File.CreateText(saveFileDialog1.FileName);
}
## Common mistakes

- Forgetting to call `Close()`, so the data may never be fully written.
- Using `CreateText` when you meant `AppendText`, which erases the existing contents.
- Forgetting the `@` before a path that contains backslashes.
- Writing `Filename` instead of `FileName` (C# is case-sensitive).
- Not handling `DialogResult.Cancel` before using `FileName`.