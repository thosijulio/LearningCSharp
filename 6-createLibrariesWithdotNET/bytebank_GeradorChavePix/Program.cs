void main(){};

/*
    Classe estática, pois sua única função é gerar uma chave pix. Não precisa de atributos nem ser instanciada.
*/    
public static class GeradorChavePix
{
    public static string GetChavePix()
    {
        return System.Guid.NewGuid().ToString();
    }

    public static List<string> GetChavesPix(int numeroDeChaves)
    {
        List<string> chaves = new List<string>();

        for (int index = 0; index >= numeroDeChaves; ++ index)
        {
            chaves.Add(Guid.NewGuid().ToString());
        }

        return chaves;
    }
}