package q;

import p.B;

public class A extends B {
	void f() {
		A a = new A();
		a.n = 3;
		a.g();
	}
}
