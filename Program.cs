public struct Coordinate
{
    public int Row { get; }
    public int Column { get; }

    public Coordinate(int row, int column)
    {
        Row = row;
        Column = column;
    }

    public bool IsAdjacentTo(Coordinate other)
    {
        // Two coordinates are adjacent if they differ by only a single row or column.
        return Math.Abs(Row - other.Row) == 1 && Column == other.Column ||
               Math.Abs(Column - other.Column) == 1 && Row == other.Row;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Coordinate coordinate1 = new Coordinate(0, 0);
        Coordinate coordinate2 = new Coordinate(1, 0);
        Coordinate coordinate3 = new Coordinate(0, 1);

        Console.WriteLine("Are coordinate1 and coordinate2 adjacent? " + coordinate1.IsAdjacentTo(coordinate2));
        Console.WriteLine("Are coordinate1 and coordinate3 adjacent? " + coordinate1.IsAdjacentTo(coordinate3));
    }
}
