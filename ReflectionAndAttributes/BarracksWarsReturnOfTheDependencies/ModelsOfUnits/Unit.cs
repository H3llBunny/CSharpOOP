using BarracksWarsANewFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarracksWarsANewFactory.ModelsOfUnits
{
    public class Unit : IUnit
    {
        private int health;
        private int attackDamage;

        protected Unit(int health, int attackDamage)
        {
            this.SetInitialHealth(health);
            this.AttackDamage = attackDamage;
        }

        public int AttackDamage 
        {
            get
            {
                return this.attackDamage;
            }
            
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Attack damage should be positive.");
                }

                this.attackDamage = value;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }

            set
            {
                if (value < 0)
                {
                    this.health = 0;
                }
                else
                {
                    this.health = value;
                }
            }
        }

        private void SetInitialHealth(int health)
        {
            if (health <= 0)
            {
                throw new ArgumentException("Initial health should be positive.");
            }
            this.Health = health;
        }
    }
}
