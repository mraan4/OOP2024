package report2;

import java.util.Scanner;

abstract class Shape {
	private Shape next;
	
	public Shape() {next = null;}
	
	public void setNext(Shape obj) {next=obj;}
	
	public Shape getNext() {return next;}
	
	public abstract void draw();
}

class Line extends Shape {
	@Override
	public void draw() {
		System.out.println("Line");
	}
}
class Rect extends Shape {
	@Override
	public void draw() {
		System.out.println("Rect");
	}
}
class Circle extends Shape {
	@Override
	public void draw() {
		System.out.println("Circle");
	}
}

class GraphicEditor {
	private String name;
	Scanner sc = new Scanner(System.in);
	private Shape head = null, tail = null;
	
	public GraphicEditor(String name) {
		this.name = name;
	}
	
	public void run() {
		System.out.println("그래픽 에디터 "+name+"을(를) 실행합니다.");
		while(true) {
			System.out.println("1.삽입 2.삭제 3.모두 보기 4.종료 >> ");
			int num = sc.nextInt();
			switch(num) {
			case 1:
				System.out.println("1.Line 2.Rect 3.Circle >> ");
				int spNum = sc.nextInt();
				insert(spNum);
				break;
			case 2:
				System.out.println("삭제할 도형의 위치 >> ");
				int delNum = sc.nextInt();
				delete(delNum);
				break;
			case 3:
				print(); break;
			case 4:
				System.out.println(name+"을(를) 종료합니다.");
				return;
			default:
				System.out.println("잘못 입력하셨습니다.");
			}
		}
	}
	
	public void insert(int spNum) {
		Shape shape;
		switch(spNum) {
		case 1:
			shape = new Line();
			break;
		case 2:
			shape = new Rect();
			break;
		case 3:
			shape = new Circle();
			break;
		default:
			System.out.println("잘못 입력하셨습니다.");
			return;
		}
		if(head==null) {
			head = shape;
			tail = head;
		}
		else {
			tail.setNext(shape);
			tail = shape;
		}
	}
	
	public void delete(int delNum) {
		Shape current = head;
		Shape a = head;
		int i;
		if(delNum==1) {
			if(head==tail) {
				head = null;
				tail = null;
				return;
			}
			else {
				head = head.getNext();
				return;
			}
		}
		for(i=1; i<delNum; i++) {
			a = current;
			current = current.getNext();
			if(current == null) {
				System.out.println("삭제할 수 없습니다.");
				return;
			}
		}
		if(i==delNum) {
			a.setNext(current.getNext());
			tail = a;
		}
		else {
			a.setNext(current.getNext());
		}
	}
	public void print() {
		Shape shape = head;
		while(shape != null) {
			shape.draw();
			shape = shape.getNext();
		}
	}
}

public class Ex5_12 {
	public static void main(String[] args) {
		GraphicEditor ge = new GraphicEditor("happy");
		ge.run();
	}
}