package inheritance;

class Person{
	String name;
	String id;
	public Person() {
		name = "홍길동";
		id = "123456";
	}
	public Person(String name) {
		super();
		this.name = name;
	}
	public Person(String name, String id) {
		this.id = id;
		this.name = name;
	}
	public String toString() {
		return "name = " + name + ", id = " + id;
	}
}

class Student extends Person{
	String grade;
	String department;
	public Student() {
		this("홍길동", "123456", "A+", "컴퓨터 정보");
	}
	public Student(String name) {
		super(name);
		id = "123456";
		grade = "A";
		department = "소프트웨어";
	}
	public Student(String name, String id, String grade, String department) {
		super(name, id);
		this.grade = grade;
		this.department = department;
	}
	public String toString(){
		return "name = " + name +" , id = " + id + " grade = " + grade + ", department = " + department;
	}
}
public class UpcastingEx {
	public static void main(String[] args) {
		Person p; 
		Student s = new Student("홍길동");
		s.grade = "A+";
		s.department = "컴퓨터";		
		System.out.println(s);
		
		p = s;
		System.out.println(p.name);
		System.out.println(p.id);
		
		Student s1;
		s1 = (Student)p;
		s1.name = "이순신";
		s1.id = "0987655";
		s1.grade = "A+";
		s1.department = "장군";
		System.out.println(s1);
	}
}
