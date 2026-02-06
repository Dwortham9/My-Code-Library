class Rectangle 
{
    public int height, width;
    public int GetArea() 
    {
        int result = this.height * this.width;
        return result;
    }
}
class area_rect 
{
    static void Main(string[] args) 
    {
        Rectangle rect1 = new Rectangle();
        rect1.height = 10;
        rect1.width = 20;
        int area = rect1.GetArea();
        Console.WriteLine("Area of rectangle is " + area);
    }
}