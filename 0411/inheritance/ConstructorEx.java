package inheritance;
class A{
	public A() {
		System.out.println("클래스 A의 생성자");
	}
}
class B extends A{
	public B() {
		System.out.println("클래스 B의 생성자");
	}
}
class C extends B{
	public C() {
		System.out.println("클래스 C의 생성자");
	}
}
public class ConstructorEx {
	public static void main(String[] args) {
		C c = new C();
		System.out.println(c);
	}
}
