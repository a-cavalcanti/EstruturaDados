
public class Pessoa
{

    private String nome;
    private String sexo;
    private int idade;

    public Pessoa(String nome1, String sexo1, int idade1)
    {
        this.nome = nome1;
        this.sexo = sexo1;
        this.idade = idade1;
    }

    public Pessoa()
    {

    }


    public String getNome()
    {
        return nome;
    }
    public void setNome(String nome)
    {
        this.nome = nome;
    }
    public String getSexo()
    {
        return sexo;
    }
    public void setSexo(String sexo)
    {
        this.sexo = sexo;
    }
    public int getIdade()
    {
        return idade;
    }
    public void setIdade(int idade)
    {
        this.idade = idade;
    }
}
