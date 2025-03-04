using Godot;
using System;

#if TOOLS
namespace SimpleNotesPlugin
{
    [Tool]
    public partial class NotesDock : Control
    {
        private TextEdit _notesText;
        private Button _saveButton;
        private Button _clearButton;

        private const string SAVE_PATH = "res://addons/simple_notes/notes_data.txt";

        public override void _Ready()
        {
            _notesText = GetNode<TextEdit>("%NotesText");
            _saveButton = GetNode<Button>("%SaveButton");
            _clearButton = GetNode<Button>("%ClearButton");

            _saveButton.Pressed += OnSaveButtonPressed;
            _clearButton.Pressed += OnClearButtonPressed;
            LoadNotes();
        }

        private void OnSaveButtonPressed()
        {
            using var file = FileAccess.Open(SAVE_PATH, FileAccess.ModeFlags.Write);
            file.StoreString(_notesText.Text);
            GD.Print("Notes saved successfully");
        }

        private void OnClearButtonPressed()
        {
            _notesText.Text = "";
        }

        private void LoadNotes()
        {
            if (FileAccess.FileExists(SAVE_PATH))
            {
                using var file = FileAccess.Open(SAVE_PATH, FileAccess.ModeFlags.Read);
                _notesText.Text = file.GetAsText();
            }
        }
    }
}
#endif
