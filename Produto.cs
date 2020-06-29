using System.IO;

namespace Aula27DadosExcel
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float  Preco { get; set; }

        private const string PATH = "DataBase/Produto.csv";
        

        public Produto(){
            //DESAFIO:
            string pasta = PATH.Split("/")[0];
            if(!Directory.Exists(pasta)){
                Directory.CreateDirectory(pasta);
            }
            //Quer saber se ele não existe
            if(!File.Exists(PATH)){
                File.Create(PATH).Close();
            }
        }
        
        public void Cadastrar(Produto prod){
              
            //Acrescenta todas as linhas
            var linha = new string[]{PrepararLinha(prod)};
            
            File.AppendAllLines(PATH,linha);
        }

        //1;Celular;600

        private string PrepararLinha(Produto p){
            return $"Código = {p.Codigo}; Nome = {p.Nome}; Preço = {p.Preco}";
        }
    }

}