package classEx;

public class Book {
	String title;
	String author;
	public Book() {
		this("","");
	}
	public Book(String title) {
		super();
		this.title = title;
		author = "작가미상";
	}
	public Book(String title, String author) {
		super();
		this.title = title;
		this.author = author;
	}
	
	public static void main(String[] args) {
		Book littlePrince = new Book("어린왕자", "생떼쥐베리");
		Book loveStory = new Book("춘향전");
		
		System.out.println(littlePrince.title + " " + littlePrince.author);
		System.out.println(loveStory.title + " " + loveStory.author);
	}
}
