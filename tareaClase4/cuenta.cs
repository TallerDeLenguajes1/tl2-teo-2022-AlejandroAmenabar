public enum TipoDeExtraccion
{
    CajeroHumano=1,
    CajeroAutomatico=2
}
public class Cuenta
{
    public virtual void insercion(int monto){

    }
    public virtual void extraccion(int monto, TipoDeExtraccion tipo){
        
    }

}

public class CuentaCorrientePesos : Cuenta
{
    public float fondos;
    public override void insercion(int monto) 
    {
        // Do something else.
    }
    public override void extraccion(int monto, TipoDeExtraccion tipo)
    {
        if (tipo==TipoDeExtraccion.CajeroAutomatico)
        {
            if (monto<20000 && monto-fondos<-5000)
            {
                System.Console.WriteLine("todo ok");
            }else{
                //podria hacer un mecanismo de excepciones aqui
                System.Console.WriteLine("todo mal");
            }
        }
    }
}
public class CuentaCorrienteDolares : Cuenta
{
    public override void insercion(int monto) 
    {
        // Do something else.
    }
    public override void extraccion(int monto, TipoDeExtraccion tipo)
    {
        //pepe
    }
}

public class cajaAhorroPesos : Cuenta
{
    public override void insercion(int monto) 
    {
        // Do something else.
    }
    public override void extraccion(int monto, TipoDeExtraccion tipo)
    {
        //pepe
    }
}

