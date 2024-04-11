package inheritance;
class SetterGetter{
	private String name;
	private int age;
	private boolean male;
	public SetterGetter(String name, int age, boolean male) {
		super();
		this.name = name;
		this.age = age;
		this.male = male;
	}
	public SetterGetter() {
		this("홍길동", 300, true);
	}
	public SetterGetter(String name) {
		this.name = name;
		this.age = 300;
		this.male = true;
	}
	
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public int getAge() {
		return age;
	}
	public void setAge(int age) {
		this.age = age;
	}
	public boolean isMale() {
		return male;
	}
	public void setMale(boolean male) {
		this.male = male;
	}
	@Override
	public String toString() {
		return "SetterGetter [name=" + name + ", age=" + age + ", male=" + male + "]";
	}
}

public class SetterGetterTest {
	public static void main(String[] args) {
		SetterGetter human1 = new SetterGetter("홍길동", 10, true);
		human1.setName("이순신");
		System.out.println(human1.toString());
	}
}
