
public class IP
{
    private int[] segments = new int[4];

    public int this[int idx]
    {
        get {return segments[idx];}

        set {segments[idx] = value;}

    }

    /* An indexer lets an object behave like an array. */

    public IP(int segment1, int segment2, int segment3, int segment4)
    {
        segments[0] = segment1;
        segments[1] = segment2;
        segments[2] = segment3;
        segments[3] = segment4;  
    }
   
    public string Address =>  String.Join(".", segments);
    
}


class   Program
{

    static void Main()
    {
        var ip = new IP(123, 127, 1, 27);
        
        System.Console.WriteLine(ip.Address);

        System.Console.WriteLine(ip[0]);
        System.Console.WriteLine(ip[1]);
        System.Console.WriteLine(ip[2]);
        System.Console.WriteLine(ip[3]);

        ip[0] = 1337;

        System.Console.WriteLine(ip[0]);
        
    }
    
}
