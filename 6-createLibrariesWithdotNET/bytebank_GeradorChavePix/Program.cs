void main(){};
/*
    Separar o código entre projetos e reutilizar em outras soluções, conseguimos diminuir a complexidade de um software e fazer com que cada componente
    entregue uma funcionalidade separada, facilitando a manutenção, leitura e reaproveitamento do código.

    Classe estática, pois sua única função é gerar uma chave pix. Não precisa de atributos nem ser instanciada.
*/    

namespace bytebank_GeradorChavePix
{
    /// <summary>
    /// Class that generate PIX keys using GUID format.
    /// </summary>
    public static class GeradorChavePix
    {
        /// <summary>
        /// Method that returns a PIX key.
        /// </summary>
        /// <returns>Return a PIX key in string format.</returns>
        public static string GetChavePix()
        {
            return System.Guid.NewGuid().ToString();
        }

        /// <summary>
        /// Method that returns a list with PIX keys with Length according to the parameter.
        /// </summary>
        /// <param name="numeroDeChaves">Length of the pix keys List</param>
        /// <returns>Return a List with PIX keys in string format.</returns>
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

}