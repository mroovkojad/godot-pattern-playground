public partial class PurpleSlime: Character{

	private PurpleSlime()
    {
        Speed = 100.0f;
    }

    public override void _Ready(){
		_controller = new PurpleSlimeAIController(this);
	}
}