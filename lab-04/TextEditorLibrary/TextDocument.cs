namespace TextEditorLibrary
{
    public class TextDocument
    {
        private string _content = "";

        public void Write(string text)
        {
            _content += text;
        }

        public void EraseLast(int length)
        {
            if (length <= _content.Length)
                _content = _content[..^length];
        }

        public DocumentMemento Save() => new(_content);

        public void Restore(DocumentMemento memento)
        {
            _content = memento.Text;
        }

        public string GetContent() => _content;
    }
}
