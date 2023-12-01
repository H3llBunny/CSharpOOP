using PlayersAndMonsters.Models.BattleFields.Contracts;
using PlayersAndMonsters.Models.Players.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayersAndMonsters.Models.BattleFields
{
    public class BattleField : IBattleField
    {
        public void Fight(IPlayer attacker, IPlayer enemy)
        {
            if (attacker.IsDead || enemy.IsDead)
            {
                throw new ArgumentException("Player is dead!");
            }

            if (attacker.GetType().Name == "Beginner")
            {
                attacker.Health += 40;

                foreach (var card in attacker.CardRepository.Cards)
                {
                    card.DamagePoints += 30;
                }
            }

            if (enemy.GetType().Name == "Beginner")
            {

                enemy.Health += 40;

                foreach (var card in enemy.CardRepository.Cards)
                {
                    card.DamagePoints += 30;
                }
            }

            foreach (var card in attacker.CardRepository.Cards)
            {
                attacker.Health += card.HealthPoints;
            }

            foreach (var card in enemy.CardRepository.Cards)
            {
                enemy.Health += card.HealthPoints;
            }
            int attackerDamage = attacker.CardRepository.Cards.Sum(card => card.DamagePoints);
            int enemyDamage = enemy.CardRepository.Cards.Sum(card => card.DamagePoints);

            while (!attacker.IsDead && !enemy.IsDead)
            {
                enemy.TakeDamage(attackerDamage);

                if (!enemy.IsDead)
                {
                    attacker.TakeDamage(enemyDamage);
                }
            }
        }
    }
}
