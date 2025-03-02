using System.Xml.Linq;

public partial class GreenSlime: Character{

    public override void _Ready(){
        base._Ready();
        Speed = 100;
		_controller = new GreenSlimeAIController(this);
	}
}