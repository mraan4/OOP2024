package abstractex;
abstract class Abc{
	int a;
	String name;
	
	void printInfo(){
		System.out.println("Hello");
	}
	abstract void outInfo();
}

class Def extends Abc{
	void outInfo() {
		System.out.println("상속 받은 클래스에서 재정의를 해줌");
	}
}


public class Test {
	public static void main(String[] args) {
		Def def = new Def();
		def.printInfo();
	}
	
}
