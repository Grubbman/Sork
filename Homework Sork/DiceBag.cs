using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Sork
{
    public enum Dice : uint
    {
        /// <summary>
        /// This can be considered a double-sided coin;
        /// used to delimit a 50/50 probability.
        /// </summary>
        D2 = 2,
        /// <summary>
        /// A Tetrahedron
        /// A 4 Sided Die
        /// </summary>
        D4 = 4,
        /// <summary>
        /// A Triangular Prism
        /// A 5 Sided Die
        /// </summary>
        D5 = 5,
        /// <summary>
        /// A Cube
        /// A 6 Sided Die
        /// </summary>
        D6 = 6,
        /// <summary>
        /// A Pentagonal prism
        /// A 7 Sided Die
        /// </summary>
        D7 = 7,
        /// <summary>
        /// A Octahedron
        /// A 8 Sided Die
        /// </summary>
        D8 = 8,
        /// <summary>
        /// A Pentagonal Trapezohedron
        /// A 10 Sided Die
        /// </summary>
        D10 = 10,
        /// <summary>
        /// A Dodecahedron
        /// A 12 Sided Die
        /// </summary>
        D12 = 12,
        /// <summary>
        /// A Heptagonal Trapezohedron
        /// A 14 Sided Die
        /// </summary>
        D14 = 14,
        /// <summary>
        /// A Octagonal Bipyramid
        /// A 16 Sided Die
        /// </summary>
        D16 = 16,
        /// <summary>
        /// A Rounded Rhombicuboctahedron
        /// A 18 Sided Die
        /// </summary>
        D18 = 18,
        /// <summary>
        /// A Icosahedron
        /// A 20 Sided Die
        /// </summary>
        D20 = 20,
        /// <summary>
        /// A Deltoidal Icositetrahedron
        /// A 24 Sided Die
        /// </summary>
        D24 = 24,
        /// <summary>
        /// A Rhombic Triacontahedron
        /// A 30 Sided Die
        /// </summary>
        D30 = 30,
        /// <summary>
        /// A Heptadecagonal Trapezohedron
        /// A 34 Sided Die
        /// </summary>
        D34 = 34,
        /// <summary>
        /// A Disdyakis Dodecahedron
        /// A 48 Sided Die
        /// </summary>
        D48 = 48,
        /// <summary>
        /// A Icosakaipentagonal Trapezohedron
        /// A 50 Sided Die
        /// </summary>
        D50 = 50,
        /// <summary>
        /// A Pentagonal Hexecontahedron
        /// A 60 Sided Die
        /// </summary>
        D60 = 60,
        /// <summary>
        /// A Zocchihedron
        /// A 100 Sided Die
        /// </summary>
        D100 = 100,
        /// <summary>
        /// A Disdyakis Triacontahedron
        /// A 120 Sided Die
        /// </summary>
        D120 = 120
    };

    class DiceBag
    {
        private Random RandomNumberGenerator;
        private Game game;

        public DiceBag(Game game)
        {
            RandomNumberGenerator = new Random();
            this.game = game;
        }
        
        private int InternalRoll(uint dice)
        {
            return 1 + RandomNumberGenerator.Next((Int32)dice);
        }

        private int Roll(Dice d)
        {
            return InternalRoll((uint)d);
        }

        private int RollWithModifier(Dice dice, uint modifier)
        {
            return InternalRoll((uint)dice) + (Int32)modifier;
        }

        /// <summary>
        /// Rolls a series of dice and returns a collection containing them.
        /// </summary>
        /// <param name="d">The d.</param>
        /// <param name="times">The times.</param>
        /// <returns>A Collection Holding the dice rolls.</returns>
        private List<int> RollQuantity(Dice d, uint times)
        {
            List<int> rolls = new List<int>();
            for (int i = 0; i < times; i++)
            {
                rolls.Add(InternalRoll((uint)d));
            }
            return rolls;
        }

        public int EnemyAttackChanceRoll()
          {
              return Roll(Dice.D20) + game.CurrentRoom.Enemy.Attack;
          }
        public int EnemyDodgeRoll()
        {
            return Roll(Dice.D16) + game.CurrentRoom.Enemy.Agility;
        }
          
          public int EnemyAttackDamage()
          {
            var damage = Roll(Dice.D10) + game.CurrentRoom.Enemy.Attack - game.Character.Defence;
            return damage > 0 ? damage : 0;
          }

        public int CharAttackChance()
        {
            return Roll(Dice.D20) + game.Character.Attack;
        }

        public int CharDodgeRoll()
        {
            return Roll(Dice.D16) + game.Character.Agility;
        }

        public int CharAttackDamage()
        {
            return Roll(Dice.D10) + game.Character.Attack - game.CurrentRoom.Enemy.Defence;
        }




    }
}
