public class Angle
{
     private double rise;
     private double run;
    
    public Angle(){}
    
    public Angle(double rise, double run)
    {
        this.rise = rise;
        this.run = run;
    }
    
    public Angle copy()
    {
        Angle newangle = new Angle(this.rise, this.run);
        return newangle;
    }
    double getAngleInDegrees()
    {
        double slope = this.rise/ this.run;
        double angle = Math.atan(slope);
        angle = Math.toDegrees(angle); 
        return angle;
    }
    double getHypotenuse()
    {
        double hypo = Math.sqrt(rise*rise + run*run);
        return hypo;
    }

    void print()
    {
       System.out.printf("The angle in degrees is %.2f\n",getAngleInDegrees());
       System.out.printf("The hypotenuse is %.2f\n",getHypotenuse());
    }
}
