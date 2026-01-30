public class AdvRect
{
    private double height;
    private double width;
    
    public double getH()
    {
        return this.height;
    }
    public double getW()
    {
        return this.width;
    }
    public void setH(double height)
    {
       this.height = height; 
    }
    public void setW(double width)
    {
       this.width = width; 
    }
    
    public AdvRect(double height, double width)
    {
        this.height = height;
        this.width = width;
    }
    public AdvRect(){}
    
    void print()
    {
        System.out.printf("Rectangle: height=%.2f, width=%.2f\n",this.height, this.width);
    }

}
