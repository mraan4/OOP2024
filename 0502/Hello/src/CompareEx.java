
public class CompareEx {
	public static void main(String[] args) {
		String s1 = "1234";
		String s2 = "1233";
		
		int res = s1.compareTo(s2);
		
		if(res == 0)
			System.out.println("두 문자열은 같습니다.");
		else if(res < 0)
			System.out.println(s1 + " 문자열이 " + s2 + " 보다 더 작습니다.");
		else
			System.out.println(s1 + " 문자열이 " + s2 + " 보다 더 큽니다.");
	}
}
