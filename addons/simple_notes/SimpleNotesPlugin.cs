// SimpleNotesPlugin.cs - Main plugin script
using Godot;
using System;

#if TOOLS
namespace SimpleNotesPlugin
{
    [Tool]
    public partial class SimpleNotesPlugin : EditorPlugin
    {
        private Control _dockInstance;

        public override void _EnterTree()
        {
            // Initialization of the plugin
            var dockScene = GD.Load<PackedScene>("res://addons/simple_notes/NotesDock.tscn");
            _dockInstance = dockScene.Instantiate<Control>();

            // Add the dock to the editor
            AddControlToDock(DockSlot.RightUl, _dockInstance);
            GD.Print("Simple Notes Plugin Enabled");
        }

        public override void _ExitTree()
        {
            // Clean-up of the plugin
            // Remove the dock from the editor
            RemoveControlFromDocks(_dockInstance);
            _dockInstance.QueueFree();
            GD.Print("Simple Notes Plugin Disabled");
        }

        public override bool _HasMainScreen() => false;
    }
}
#endif