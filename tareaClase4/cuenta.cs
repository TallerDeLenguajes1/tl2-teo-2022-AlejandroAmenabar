public enum TipoDeExtraccion
{
    CajeroHumano=1,
    CajeroAutomatico=2
}
public class Cuenta
{
    public float fondos;
    protected Cuenta()
    {
        fondos=0;
    }
    protected Cuenta(float x)
    {
        fondos = x;
    }
    public virtual void insercion(int monto)
    {
        fondos = fondos + monto;
    }
    public virtual void extraccion(int monto, TipoDeExtraccion tipo){}

}

public class CuentaCorrientePesos : Cuenta
{
    public CuentaCorrientePesos(){}
    public CuentaCorrientePesos(float x) :base(x) {}
    public override void extraccion(int monto, TipoDeExtraccion tipo)
    {
        if (tipo==TipoDeExtraccion.CajeroAutomatico)
        {
            if (monto<20000 && (fondos-monto)>(-5000))
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
    public override void extraccion(int monto, TipoDeExtraccion tipo)
    {
        //pepe
    }
}

public class cajaAhorroPesos : Cuenta
{
    public override void extraccion(int monto, TipoDeExtraccion tipo)
    {
        //pepe
    }
}

