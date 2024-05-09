package fileio;

import java.io.FileReader;
import java.io.IOException;

public class FileReaderEx {
public static void main(String[] args) {
	FileReader fin = null;
	try {
		fin = new FileReader("c:\\windows\\system.ini"); 
		int c;
		while ((c = fin.read()) != -1) { // 한문자씩파일끝까지읽기
			System.out.print((char)c);
		}
		fin.close();
	}catch (IOException e) {
			System.out.println("입출력오류");
		}
	}
}
