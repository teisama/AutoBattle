namespace AutoBattle {
    class Player {
        public int Offense { get; set; }
        public int Diffence { get; set; }
        public int Life { get; set; }
        public int Agile { get; set; }

        public Player(int off,int def,int life,int agile){
            this.Offense = off;
            this.Diffence = def;
            this.Life = life;
            this.Agile = agile;
            }

        public int Attack(Enemy enemy) {
            return enemy.Damage(this.Offense);
        }

        public int Damage(int power) {
            int damage = power - this.Diffence;
            this.Life -= damage;
            return damage;
        }
    }
}
