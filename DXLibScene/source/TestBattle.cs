using static DxLibDLL.DX;
using AutoBattle;
using System.Collections.Generic;
using System;

namespace DXLibScene.source {
    class Battle : Scene {
        AutoBattle.Battle battle;
        List<String> log = new List<String>();
        
        public Battle(AutoBattle.Battle autoBattle) {
            log.Capacity = 5;
            this.battle = autoBattle;
        }

        public void Draw() {
            DrawString(0, 0, "敵情報", GetColor(255, 255, 255));
            DrawString(0, 20, "体力::" + battle.enemy.Life, GetColor(255, 255, 255));
            DrawString(0, 40, "攻撃力::" + battle.enemy.Offense, GetColor(255, 255, 255));
            DrawString(0, 60, "防御力::" + battle.enemy.Diffence, GetColor(255, 255, 255));
            DrawString(0, 80, "素早さ::" + battle.enemy.Agile, GetColor(255, 255, 255));
            DrawString(0, 100, "素早さゲージ::" + battle.EnemyAgile, GetColor(255, 255, 255));

            DrawString(300, 50, battle.enemy.Image, GetColor(255, 255, 255));


            DrawString(0, 520, "プレイヤー情報", GetColor(255, 255, 255));
            DrawString(0, 540, "体力::" + battle.player.Life, GetColor(255, 255, 255));
            DrawString(0, 560, "攻撃力::" + battle.player.Offense, GetColor(255, 255, 255));
            DrawString(0, 580, "防御力::" + battle.player.Diffence, GetColor(255, 255, 255));
            DrawString(0, 600, "素早さ::" + battle.player.Agile, GetColor(255, 255, 255));
            DrawString(0, 620, "素早さ::" + battle.PlayerAgile, GetColor(255, 255, 255));

            DrawString(0, 620, "素早さ::" + battle.PlayerAgile, GetColor(255, 255, 255));

            if (battle.PlayerDamage != -1) {
                log.Add("敵の攻撃、プレイヤーは" + battle.PlayerDamage + "のダメージ!");
                if(log.Count >= 6) {
                    log.RemoveAt(0);
                }
            }
            if(battle.EnemyDamage != -1) {
                log.Add("プレイヤーの攻撃、敵は" + battle.EnemyDamage + "のダメージ!");
                if (log.Count >= 6) {
                    log.RemoveAt(0);
                }
            }
            
            int n = 0;
            log.ForEach(delegate(String str)
            {
                DrawString(300, 500 + n * 20, str, GetColor(255, 255, 255));
                n += 1;
            });
        }

        public void Update() {
                battle.Action();
            if(battle.enemy.Life <= 0) {
                battle.changeEnemy(Enemy.getNewEnemy());
            }
        }
    }
}
