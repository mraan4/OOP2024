package inheritance;

class Person1{
	private int weight;
	int age;
	protected int height;
	public String name;
	public void setWeight(int weight) {
		this.weight = weight;
	}
	public int getWeight() {
		return weight;
	}
	public void printInfo() {
		System.out.println("이름 = " + name + ", 나이 = " + age + ", 키 = " + height + ", 몸무게 = " + weight);
	}
}
class Student1 extends Person1{
	public void set() {
		age = 300;
		name = "홍길동";
		height = 175;
		//weight = 99;
		setWeight(99);
	}
}
public class InheritanceEx {
	public static void main(String[] args) {
		Student1 s1 = new Student1();
		s1.set();
		s1.printInfo();
	}	
}
