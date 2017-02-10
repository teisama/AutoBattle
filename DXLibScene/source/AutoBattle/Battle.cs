namespace AutoBattle {
    class Battle {

        public Player player { get; set; }
        public Enemy enemy { get; set; }

        public int PlayerAgile { get; set; } = 0;
        public int EnemyAgile { get; set; } = 0;

        public int PlayerDamage { get; set; } = -1;
        public int EnemyDamage { get; set; } = -1;

        public Battle(Player p, Enemy e) {
            this.player = p;
            this.enemy = e;
        }

        public void Action() {
            this.PlayerAgile += player.Agile;
            this.EnemyAgile += enemy.Agile;
            //プレイヤーの攻撃
            if (this.PlayerAgile >= 100) {
                this.EnemyDamage = player.Attack(enemy);
                this.PlayerAgile = 0;
            }else {
                this.EnemyDamage = -1;
            }

            //敵に攻撃
            if (this.EnemyAgile >=100) {
                enemy.Attack(player);
                this.PlayerDamage = enemy.Attack(player);
                this.EnemyAgile = 0;
            }else {
                this.PlayerDamage = -1;
            }
        }

        public void changeEnemy(Enemy e) {
            this.enemy = e;
        }
    }
}
