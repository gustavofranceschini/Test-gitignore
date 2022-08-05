using System;

namespace TestGit
{
    class Git
    {
        public string Name { get; set; }
        public int Idade { get; set; }  
        
        public Git()
        {
        }

        public Git(string name,int idade)
        {
            Name = name;
            Idade = idade;
        }

    }
}
