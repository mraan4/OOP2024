package abstractex;

public class InterfaceEx {
	public static void main(String[] args) {
		SamsungPhone phone1 = new SamsungPhone();
		phone1.printLogo();
		phone1.sendCall();
		phone1.receiveCall();
		phone1.flash();
	}
}
