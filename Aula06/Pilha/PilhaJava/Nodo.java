
public class Nodo
{
    private String nome;
    private Nodo proximo;


    public Nodo(String nome1)
    {
        this.nome = nome1;
        this.proximo = null;

    }

    public Nodo()
    {

    }

    public String getNome()
    {
        return nome;
    }

    public void setNome(String nome1)
    {
        this.nome = nome1;
    }

    public Nodo getProximo()
    {
        return proximo;
    }

    public void setProximo(Nodo proximo)
    {
        this.proximo = proximo;
    }

}
