public partial class EnemySlime: Character{

    public override void _Ready(){
		_controller = new SlimeAIController(this);
	}
}