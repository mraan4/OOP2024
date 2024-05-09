package collection;

class MyClass<T>{
	T val;
	
	void set(T a) {
		val = a;
	}
	
	T get() {
		return val;
	}
}

public class GenericEx {
	public static void main(String[] args) {
		MyClass<Integer> mc = new MyClass<Integer>();
		MyClass<Double> dc = new MyClass<Double>();
		mc.val = 1;
		System.out.println(mc.get());
		dc.val = 1.0;
		System.out.println(dc.get());
	}
}
