using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Homework_Sork
{
    public class Game
    {
        private System.Timers.Timer timer;
        private object tickLock = new object();
        private Header header;

        Random D20 = new Random();
        Random D6 = new Random();

        public Game()
        {
            header = new Header();
            Character = new Character();
            CurrentRoom = new World().Create();

            new CharacterBuilder().CreateCharacter(this.Character);

            timer = new System.Timers.Timer(1000);
            timer.Elapsed += OnTimerTick;
            timer.Start();
        }

        public Character Character { get; set; }
        public Room CurrentRoom { get; set; }

        public void StartTimerTick()
        {
            timer.Start();
        }

        public void StopTimerTick()
        {
            timer.Stop();
        }
        private void OnTimerTick(object sender, ElapsedEventArgs e)
        {
            lock (tickLock)
            {
                var g = this;
                g.Character.TickCount += 1;

                if (g.CurrentRoom.Enemy != null)
                {
                    var AttackHitRoll = D20.Next(1, 20);
                    var DamageRoll = D6.Next(1, 6);
                    if (  AttackHitRoll > g.Character.Defence)
                    {
                        g.Character.CurrentHP -= DamageRoll;
                    }

                    if ( AttackHitRoll > g.CurrentRoom.Enemy.Defence)
                    {
                        g.CurrentRoom.Enemy.CurrentHP -= DamageRoll;
                    }

                    if (g.CurrentRoom.Enemy.CurrentHP <= 0)
                    {

                        g.CurrentRoom.Enemy = null;

                    }
                    if (g.Character.CurrentHP <= 0)
                    {
                        Environment.Exit(0);
                    }
                }
                header.Print(g.Character, g.CurrentRoom.Enemy);
            }
        }

    }
}
