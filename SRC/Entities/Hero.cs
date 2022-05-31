namespace Projeto_2.SRC.Entities
{
    public class Hero
    {
        public Hero(string Name, int Level, string HeroType){
          this.Name = Name;
          this.Level = Level;  
          this.HeroType = HeroType;
        } 

        public Hero(){

        }

        public string Name;
        public int Level;
        public string HeroType;


        public override string ToString(){
        return this.Name + " " + this.Level + " " + this.HeroType;
        }

        public virtual string Attack(){
            return this.Name + " Atacou com a sua espada";
        }


         public string Attack(int Ataque){

        if (Ataque > 8){
            return this.Name + " Atacou com força de " + Ataque;
        }else{
            return this.Name + " Atacou com força fraca de " + Ataque;
        }
    }
}
}