using TextEditorLibrary;

var editor = new TextEditor();

editor.Write("Hello, ");
editor.Write("world!");
Console.WriteLine(editor.GetText());  

editor.Undo();
Console.WriteLine(editor.GetText());   

editor.Write("C# Dev");
Console.WriteLine(editor.GetText());  

editor.Undo();
Console.WriteLine(editor.GetText());  