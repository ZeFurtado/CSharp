namespace ClasseInterna;

public class Pessoa
{
    void getOlhos()
    {
        Olho olho = new Olho();
    }
    public class Olho
    {
        public static string Iris = "XYZ";
        public Olho()
        {
            Pessoa pessoa = new Pessoa();
        }
    }
}
