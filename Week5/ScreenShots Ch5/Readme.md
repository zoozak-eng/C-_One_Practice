SCREENSHOTS.

1-Create File Concept in C#
This program uses StreamWriter method and File.CreateText() to create a new text file and write data into it.
StreamWriter:is class Writes data into a text file.
File.CreateText(): Creates a new text file.
WriteLine(): Writes text into the file.
Close(): Closes the file after writing.
MessageBox.Show(): Displays a success message when the file is created.

2-Append File Concept in C#
This program uses StreamWriter and File.AppendText() to add new text to an existing text file without deleting the previous content.
StreamWriter:is class Writes data into a text file.
File.AppendText(): Adds new text to an existing file.
WriteLine(): Writes a new line of text.
Close(): Closes the file after writing.
MessageBox.Show(): Displays a success message.

3-Read File Concept in C#
This program uses StreamReader and File.OpenText() to read an existing text file and display its contents in a ListBox.
StreamReader:is class Reads data from a text file.
File.OpenText(): Opens an existing text file for reading.
ReadLine(): Reads one line at a time.
EndOfStream: Checks whether the end of the file has been reached.
While Loop: Repeats reading until all lines are read.
ListBox: Displays all text from the file.
Close(): Closes the file after reading.

4-Save File using static path
StreamWriter:is class Writes data into a file.
SaveFileDialog: Allows the user to choose where to save the file.
File.CreateText(): Creates a new text file.
WriteLine(): Writes text into the file.
Close(): Closes the file after writing.

5-Read File
StreamReader:is class Reads data from a file.
OpenFileDialog: Allows the user to select an existing file.
File.OpenText(): Opens the selected file for reading.
EndOfStream: Checks the end of the file.
ReadLine(): Reads text line by line.
ListBox: Displays the file contents.
Close(): Closes the file after reading.

6-Save File Dynamic Way
This program uses StreamWriter and SaveFileDialog to create and save a text file.
StreamWriter: Writes data into a text file.
DialogResult: Checks whether the user clicked OK or Cancel.
ShowDialog(): Opens the Save File dialog window.
File.CreateText(): Creates a new text file.
WriteLine(): Writes text into the file.
Close(): Closes the file after writing.
MessageBox: Displays a message if the user cancels the operation.

7-Reading Process Step-by-Step in C#
This program uses StreamReadir and OpenFileDialog to create and save a text file.
Declare StreamReader:Creates a `StreamReader` variable to read the text file.
OpenFileDialog:Displays a file selection window so the user can choose a file.
Check DialogResult: Checks whether the user clicked OK or Cancel.
Open File:`File.OpenText()` opens the selected text file for reading.
Check EndOfStream: The `while` loop checks whether the end of the file has been reached.
ReadLine():Reads the file one line at a time.
Display Data:`listBox1.Items.Add(lines)` displays each line inside the ListBox.
Close File:`Reads.Close()` closes the file after all lines have been read.
Cancel Operation:If the user clicks Cancel, a MessageBox displays "Not found the file".

