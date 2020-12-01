using Microsoft.VisualStudio.TestTools.UnitTesting;
using atividade_3_polimorfismo;
namespace unitTesteIdade
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void testeMaiorIdade()
        {

            int idade = 18;
            
            bool resultado = Helper.verificaIdade(idade);

            Assert.IsTrue(resultado);

        }

        [TestMethod]
        public void testeMenorIdade()
        {
            int idade = 12;

            bool resultado = Helper.verificaIdade(idade);

            Assert.IsTrue(resultado);
        }
    }
}
