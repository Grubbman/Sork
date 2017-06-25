using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Sork
{
    class DiceBag
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

        private Random RandomNumberGenerator;
        public Character Character { get; set; }
        public Room CurrentRoom { get; set; }

        public DiceBag()
        {
            RandomNumberGenerator = new Random();
        }

        private int InternalRoll(uint dice)
        {
            return 1 + RandomNumberGenerator.Next((Int32)dice);
        }

        //
        // do not really know how to do this right hmm thinking about putting all the different types of rolls in dicebag like
        // having a assigned D# to the weapons so that it will auto roll the dice and if there is more then one * the number of times it rolls
        /* ref example
          public int EnemyAttackChance(Dice dice, uint modifier)
          {
              return InternalRoll((uint)dice) + CurrentRoom.Enemy.Agility;
          }
          
          public int EnemyAttackDammage(Dice dice, uint modifier)
          {
              return InternalRoll((uint)dice) + CurrentRoom.Enemy.Attack;
          }
        */
        public int CharAttackChance(Dice dice)
        {
            return InternalRoll((uint)dice);
        }

        public int CharAttackDamage(Dice dice)
        {
            return InternalRoll((uint)dice);
        }

        public int EnemyAttackChance(Dice dice)
        {
            return InternalRoll((uint)dice);
        }

        public int EnemyAttackDamage(Dice dice)
        {
            return InternalRoll((uint)dice);
        }




        public int Roll(Dice d)
        {
            return InternalRoll((uint)d);
        }

        public int RollWithModifier(Dice dice, uint modifier)
        {
            return InternalRoll((uint)dice) + (Int32)modifier;
        }

        /// <summary>
        /// Rolls a series of dice and returns a collection containing them.
        /// </summary>
        /// <param name="d">The d.</param>
        /// <param name="times">The times.</param>
        /// <returns>A Collection Holding the dice rolls.</returns>
        public List<int> RollQuantity(Dice d, uint times)
        {
            List<int> rolls = new List<int>();
            for (int i = 0; i < times; i++)
            {
                rolls.Add(InternalRoll((uint)d));
            }
            return rolls;
        }
    }
}
