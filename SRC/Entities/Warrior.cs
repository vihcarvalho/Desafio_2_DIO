namespace Projeto_2.SRC.Entities
{
    public class Warrior : Hero
    {
        public Warrior(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;  
            this.HeroType = HeroType;
        }
        public override string Attack(){
            return this.Name + " Defendeu o ataque";
    }

     public string Attack(int Defesa){

        if (Defesa > 5){
            return this.Name + " Defendeu o ataque com força de " + Defesa;
        }else{
            return this.Name + " Não defendeu o ataque, sua força foi de " + Defesa;
        }
}
}
}