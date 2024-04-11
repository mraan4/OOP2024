package abstractex;

public class SamsungPhone implements PhoneInterface {

	@Override
	public void sendCall() {
		System.out.println("띠리리링");
	}
	@Override
	public void receiveCall() {
		System.out.println("전화 왔어요!!");	
	}
	public void flash() {
		System.out.println("전화기에 불이 켜졌습니다.");
	}
}
