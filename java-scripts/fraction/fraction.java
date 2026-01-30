public class Fraction
{
        int top, bottom;
    
    public double getValue()
    {
        double result = (double) getTop() / (double) getBottom();
        return result;
    }
    public int getTop() 
    {
        return top;
    }
    public void setTop(int top) 
    {
        this.top = top;
    }
    public int getBottom() 
    {
        return bottom;
    }
    public void setBottom(int bottom) 
    {
        this.bottom = bottom;
    }
    
}
