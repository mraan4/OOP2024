package inheritance;

class AA{
	public AA() {
		System.out.println("클래스 A의 기본 생성자 입니다.");
	}
	public AA(int x) {
		System.out.println("클래스 A의 int 형 인자 하나 갖는 생성자");
	}
}
class BB extends AA{
	public BB() {
		System.out.println("클래스 B의 기본 생성자입니다.");
	}
	public BB(int x) {
		super(x);
		System.out.println("클래스 B의 int 형 인자 하나 갖는 생성자");
	}
}
public class ConstructorEx01 {
	public static void main(String[] args) {
		BB b1 = new BB();
		BB b2 = new BB(1);	
	}
}
