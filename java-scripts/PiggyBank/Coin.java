
public class Coin 
{ 
    private double value;
    public Coin(double value) 
    { 
        this.value = value;
    } 
    public double getValue() 
    { 
        return this.value; 
    }
}

class Penny extends Coin
{ 
    public Penny() 
    { 
        super(0.01); 
    }
} 
class Nickle  extends Coin
{ 
    public Nickle () 
    { 
        super(0.05); 
    }
}
class Dime extends Coin
{ 
    public Dime() 
    { 
        super(0.10); 
    }
}
class Quarter  extends Coin
{ 
    public Quarter () 
    { 
        super(0.25); 
    }
}
