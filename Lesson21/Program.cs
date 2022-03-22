using System.Text;

FileStream fs = new FileStream(@"C:\html\text1.txt", FileMode.Append/*Open*/);
string mySentence = "hello world";
byte[] myBytes = Encoding.ASCII.GetBytes(mySentence);
fs.Write(myBytes, 0, myBytes.Length);
fs.Close();
