public class Program
{

const    String idkman = "O2,O2,O2,O2,O2,O2,O2,O2,O2,C5,C5,O2,O2,O2,O2,O2,O2,O2,O2,O2,O2,O2,C5,C5,C5,C5,C5,C5,C5,C5,C5,C5,C5,O1,O1,O1,O1,O1,O1,O2,O2,C5,C5,O1,C2,C4,C4,O1,O2,C3,C3,C3,C5,C5,C5,C5,C5,O1,O1,O2,O2,C5,O1,C2,C2,C2,C4,O2,O1,C3,C3,C3,C3,C5,O1,O1,C5,C5,O1,O2,O2,C5,C2,C2,C2,C2,C4,O2,C3,C3,C3,C3,C3,C5,C5,O1,O1,C5,O1,O2,O2,C5,O3,C2,C2,C4,C4,C3,C3,C3,C3,C3,C3,C3,C5,O1,O1,C5,O1,O2,O2,C5,O3,C2,C2,C3,C3,C3,C3,C3,C3,C3,C3,C3,C5,D1,O1,C5,O1,O2,O2,C5,O3,C2,C5,S1,C3,C3,C3,C5,C3,C3,C3,C3,C3,C5,C5,C5,C5,O2,O2,C5,C5,C5,C5,C3,C3,C3,C3,C3,C3,C3,C3,C3,C3,C3,C3,C3,C5,O2,C5,C5,C5,C3,C3,C3,C3,C3,C3,E4,C3,C3,C3,C3,C3,C3,C3,C5,C5,C5,C5,C5,C3,C3,C4,C4,C4,C4,C3,C3,C3,C3,C3,C3,E8,O1,C3,C4,C4,C5,O2,C5,C3,C3,C4,C4,C4,C2,C3,C1,C3,C3,E3,C3,C1,O1,C3,C5,C4,O2,O2,C5,C3,C3,C4,C4,C4,C2,C3,O1,C3,C3,C3,C3,C3,C3,C3,C5,C4,O2,O2,C5,C3,C3,C4,C4,C3,C3,C3,C3,C3,C3,C3,O1,C3,C3,C3,C5,C4,O2,O2,C5,C3,R1,R1,R1,C3,C3,C3,C3,C3,C3,C3,C3,C3,C3,C3,C5,C5,O2,O2,C5,C5,R1,R1,R1,C3,C3,C3,C3,C3,C3,C3,C3,C3,C3,C3,O1,C5,O2,O2,O1,C5,R1,R1,R1,C3,C3,C3,C3,C3,C3,C3,C3,C3,C3,O1,O1,C5,O2,O2,O1,C5,C5,C5,C5,C5,C5,C5,C5,C5,C5,C5,C5,C5,C3,O1,C5,C5,O2,O2,O1,O1,O1,C5,C5,C5,C3,C3,C5,C5,C3,C3,C3,C5,C5,C5,C5,R1,O2,O2,O2,O2,O2,O2,O2,O2,O2,O2,C5,C5,O2,O2,O2,O2,O2,O2,O2,O2,O2";
    public static void Main()
    {
        Console.WriteLine("jaajjajaa");
        MazeBuffer mz = new MazeBuffer();
        mz.load(idkman);
        mz.print();
    }







}