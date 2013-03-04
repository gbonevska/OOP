public struct Point3D
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }
    private static readonly Point3D zeroPoint = new Point3D(0, 0, 0);

    public static Point3D ZeroPoint
    {
        get { return Point3D.zeroPoint; }
    } 

    public Point3D(int x, int y, int z)
        : this()
    {
        this.X = x;
        this.Y = y;
        this.Z = z;
    }

    public override string ToString()
    {
        string result;
        result = string.Format( "Point3D(x,y,z) = ({0},{1},{2})", this.X, this.Y, this.Z);
        return result;
    }
}