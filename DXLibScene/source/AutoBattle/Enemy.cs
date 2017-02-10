namespace AutoBattle {
    class Enemy {
        
        public string Image { get; set; }
        public int Offense { get; set; }
        public int Diffence { get; set; }
        public int Life { get; set; }
        public int Agile { get; set; }

        public Enemy(string image,int off, int def, int life, int agile) {
            this.Image = image;
            this.Offense = off;
            this.Diffence = def;
            this.Life = life;
            this.Agile = agile;
        }

        public int Attack(Player player) {
            return player.Damage(this.Offense);
        }

        public int Damage(int power) {
            int damage = power - this.Diffence;
            this.Life -= damage;
            return damage;
        }

        public static Enemy getNewEnemy() {
            System.Random r = new System.Random();
            int ran = r.Next(3);
            if (ran == 0) {
                AutoBattle.Enemy e = new AutoBattle.Enemy(" ∧,,∧ \n( `･ω･)\n/ ∽ |\nしー-Ｊ\n", 8, 4, 60, 3);
                return e;
            }

            if (ran == 1) {
                AutoBattle.Enemy e = new AutoBattle.Enemy("ヘ(・ω･　）あちょ！ \n   ヽν |\n    <  < ", 12, 3, 90, 10);
                return e;
            }

            if(ran == 2) {
                AutoBattle.Enemy e = new AutoBattle.Enemy("∧_＿∧ \n(´･ω･,)\n(つ旦Ｏ\n(＿＿＿)", 6, 2, 100, 7);
                return e;
            }
            return null;
        }
    }
}
