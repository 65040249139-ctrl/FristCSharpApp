Console.Clear();
/*
Console.WriteLine("Name : Piyapong Kaeochai");
Console.WriteLine("Course : Advanced Computer Progamming");
Console.WriteLine("Introduction : ผู้นำเชียร์คณะวิทยาศาสตร์ วังแดงเกมส์ ครั้ง 32,33,34");
*/

strLine("-" , 30);
Console.WriteLine("โปรแกรมแนะนำตัวเอง");
Console.WriteLine("โปรดกรอกชื่อของคุณ : ");
string name = Console.ReadLine();
Console.WriteLine("สวัสดี, " + name + "!");
strLine("-" , 30);
Console.WriteLine("THX");

//ทดสอบสร้าง Function
void strLine(string strInput, int n)
{
    string strOutput = "";
    for (int i = 0; i < n; i++)
    {
        strOutput += strInput;
    }
    Console.WriteLine(strOutput+"\n");
}
