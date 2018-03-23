using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    interface IPaint
    {
    }
    /// <summary>
    /// la clase paint que depende de las otras tres clases (Lienzo,Toolbar y Output), 
    /// tendra un metodo para añadir nueva figura.
    /// </summary>
    public class Paint : IPaint
    {
        public Lienzo Lienzo { get; set; }
        public Toolbar Toolbar { get; set; }
        public Output Output { get; set; }

        public void NuevaFigura
        {

        }
    }
    interface IToolbar
    {
        public Figura Figura { get; set; }

    }
    /// <summary>
    /// llamamos a un metodo para selecionar una figura de la lista de figuras, y 
    /// otro metodo para seleccionar el color deseado.
    /// </summary>
    public class Toolbar : IToolbar
    {
        IList<Type> _figuras;


        public void SeleccionarFiguras(string figuras)
        {
        }
        public void SeleccionarColor(string color)
        {
        }
    }
    public interface ILienzo
    {
    }
    /// <summary>
    /// actuara como controlador, llamamos a un metodo que muestra las figuras seleccionadas, 
    /// otro metodo que muestra el color selecionado, y por ultimo un metodo que seleciona la opcion salida o exit.
    /// </summary>
    public class Lienzo : ILienzo
    {
        IList<Type> _figuras;

        public List<Figura> Figuras { get; }

        new List<figuras> {get;}
    /// <summary>
    /// desde el constructor nunca se debe ejecutar nada 
    /// </summary>
    /// <param name="figura"></param>


    public void ShowFigura(string figura)
    {
        this.Figuras.Add(figura);
    }

    public void ShowColor(string color)
    {

    }
    public void exit(string exit)
    {

    }
}
interface IOutput
{
}
/// <summary>
/// utilizando la interfaz IOutput llamamos a un metodo para escribir y otro para leer la consola.
/// </summary>
public class Output : IOutput

{

    public void Escribir(string s)
    {
        Console.WriteLine(s);
    }
    public string Leer()
    {
        return Console.ReadLine();
    }
}

public class view

{
    Action<string> write { get; set; }
    Func<string> Read { get; set; }
}
public class view : Iview
{
    public view(Action<string> write, Func<string> read)
    {

        write = write;
        read = read;

    }


    interface IFigura
    {
        public List<Figura> Figuras { get; }
    }
    /// <summary>utilizando la interfaz Ifigura, implementamos un metodo encargado de selecionar la figura
    /// 
    /// </summary>
    public class Figura : IFigura
    {
        public List<Figura> Figuras => throw new NotImplementedException();

        public void seleccionarfigura(string figura)
        {

        }
    }
    public interface IContainer1
    {
    }
    /// <summary>
    /// contiene la lista de figuras 
    /// </summary>
    public class Container1 : IContainer1


        readonly IList<Type> _figuras;
    public Container1(IList<Type> figuras)
    {
        if (null == figuras)
        {
            throw new ArgumentNullException("figuras");
        }
    }
    interface IContainer2
    {
    }
    public class Container2 : IContainer2
    {
        public void seleccionarcolor(string color)
        {

        }
    }
}

class estrella : Figura
{
    public override string ToString()
    {
        return "soy estrella";
    }
}
class corazon : Figura
{
    public override string ToString()
    {
        return "soy corazon";
    }
    class rayo : Figura
    {
        public override string ToString()
        {
            return "soy rayo";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }

    }
}
}