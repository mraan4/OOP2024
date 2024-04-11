package abstractex;

public class GoodCalc extends Calculator {
	@Override
	public int add(int a, int b) {
		// TODO Auto-generated method stub
		return a+b;
	}
	@Override
	public int subtract(int a, int b) {
		// TODO Auto-generated method stub
		return a-b;
	}
	@Override
	public int multiply(int a, int b) {
		// TODO Auto-generated method stub
		return a*b;
	}
	@Override
	public double divide(int a, int b) {
		// TODO Auto-generated method stub
		return (double)a/b;
	}
	public static void main(String[] args) {
		GoodCalc calc = new GoodCalc();
		System.out.println(calc.add(1,2));
		System.out.println(calc.subtract(1,2));
		System.out.println(calc.multiply(1,2));
		System.out.println(calc.divide(1,2));
	}
}
