public partial class GreenSlime: Character{

	private GreenSlime()
    {
        Speed = 40.0f;
    }

    public override void _Ready(){
		_controller = new GreenSlimeAIController(this);
	}
}