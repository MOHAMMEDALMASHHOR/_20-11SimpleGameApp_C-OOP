PlayerCharacter playerCharacter1 = new PlayerCharacter("Ali",100,80,70,100);
EnemyCharacter enemy1 = new EnemyCharacter("Fakid",70,90,120);
playerCharacter1.Attach(enemy1);
playerCharacter1.Fireball(enemy1);