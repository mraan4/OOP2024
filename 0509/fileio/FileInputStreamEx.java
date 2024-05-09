package fileio;

import java.io.FileInputStream;
import java.io.IOException;

	public class FileInputStreamEx {
		public static void main(String[] args) {
			byte b[] = new byte [6]; // 비어있는byte 배열
			try {
				FileInputStream fin = new FileInputStream("c:\\Temp\\test.out");
				int n=0, c;
				while((c = fin.read())!= -1) {
					b[n] = (byte)c; 
					n++;
				}
				System.out.println("c:\\Temp\\test.out에서읽은배열을출력합니다.");
				for(int i=0; i<b.length; i++) System.out.print(b[i] + " ");
				System.out.println();
				fin.close();
			} catch(IOException e) {
				System.out.println( "c:\\Temp\\test.out에서읽지못했습니다. 경로명을체크해보세요");
			}
		}
}
