package overriding;

class Weapon{
	protected int fire() {
		return 1;
	}
}
class Cannon extends Weapon{
	protected int fire() {
		return 10;
	}
}

public class MethodOverridingEx {
	public static void main(String[] args) {
		Weapon weapon = new Weapon();
		System.out.println(weapon.fire());
		Cannon cannon = new Cannon();
		System.out.println(cannon.fire());
		weapon = cannon;
		System.out.println(weapon.fire());
	}
}
