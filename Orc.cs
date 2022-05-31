namespace Projeto_2.SRC.Entities
{
    public class Orc: Hero
    {
        public Orc(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;  
            this.HeroType = HeroType;
        }
        public override string Attack(){
            return this.Name + " Defendeu o ataque de Arus";
    }

     public string Attack(int Defesa){

        if (Defesa > 9){
            return this.Name + " Defendeu o ataque de Arus com força de " + Defesa;
        }else{
            return this.Name + " Não defendeu o ataque de Arus, sua força foi de " + Defesa;
        }
}
}
}