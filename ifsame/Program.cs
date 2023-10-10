namespace ifsame
{
    internal class Program
    {
        struct Student
        {
            public string name;
            public int height;
        }
        static void Main(string[] args)
        {
            //Bemenet
            int count;

            //Kimenet
            bool isSame;

            //Beolvas
            string inputText;
            inputText = Console.ReadLine();
            count = Convert.ToInt32(inputText);

            //Tomb deklaracio
            Student[] students = new Student[count+1];

            //Tomb beolovas (1 sor ket adat)
            for (int i = 1; i <= count; i++)
            {
                inputText = Console.ReadLine();
                string[] row = inputText.Split();
                students[i].name = row[0];
                students[i].height = Convert.ToInt32(row[1]);
            }

            //Feldolgozas
            int j = 1;
            while ( j < count-1 && students[j].height <= students[j + 1].height)
            {
                j++;
            }
            isSame = j > count - 1;

            //kiiras
            if (isSame)
            {
                Console.WriteLine("IGEN");
            }
            else
            {
                Console.WriteLine("NEM");
            }
        }
    }
}