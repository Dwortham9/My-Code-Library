
public class Pet
{
    String name, birthdate,vacdate;
    
    public Pet(){}
    
    public Pet(String name,String birthdate, String vacdate)
    {
        this.name = name;
        this.birthdate = birthdate;
        this.vacdate = vacdate;
    }
    
    public String getName() 
    {
        return name;
    }
    public void setName(String name) 
    {
        this.name = name;
    }
    
    public String getBirthdate() 
    {
        return birthdate;
    }
    public void setBirthdate(String birthdate) 
    {
        this.birthdate = birthdate;
    }
    
    public String getVacdate() 
    {
        return vacdate;
    }
    public void setVacdate(String vacdate) 
    {
        this.vacdate = vacdate;
    }
    
    void print()
    {
        System.out.println("-----------------------------");
        System.out.println("Pet");
        System.out.println("-----------------------------");
        System.out.print("Name: ");
        System.out.println(name);
        System.out.print("Birth date: ");
        System.out.println(birthdate);
        System.out.print("Vaccination date: ");
        System.out.println(vacdate);
        System.out.println("-----------------------------");
    }
}
