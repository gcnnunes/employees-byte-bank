using System;
using ByteBank.Funcionarios;

//uma interface é parecida com uma classe abstrata, a diferença é que a interface não pode ter nenhuma implementação de metodo. é como se fosse um layout que todas as classes que herdarem dela vai ter que seguir.

namespace ByteBank.Sistemas
{
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
}
