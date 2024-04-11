package inheritance;

public class DownCastingEx {
	public static void main(String[] args) {
		Person p = new Student("홍길동");
		Student s;
		
		s = (Student)p;
		
		System.out.println(s.name);
		s.grade = "A+";
		System.out.println(s.grade);
	}
}
