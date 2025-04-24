using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditorLibrary
{
    public class TextEditor
    {
        private readonly TextDocument _document = new();
        private readonly Stack<DocumentMemento> _history = new();

        public void Write(string text)
        {
            _history.Push(_document.Save());
            _document.Write(text);
        }

        public void EraseLast(int length)
        {
            _history.Push(_document.Save());
            _document.EraseLast(length);
        }

        public void Undo()
        {
            if (_history.Count > 0)
                _document.Restore(_history.Pop());
        }

        public string GetText() => _document.GetContent();
    }
}
