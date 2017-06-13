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
                    g.Character.CurrentHP -= g.CurrentRoom.Enemy.Attack; // would like to make enemy attack devided my % that is character defience = total enemy dammage to char hp
                    g.CurrentRoom.Enemy.CurrentHP -= g.Character.Attack; // need to make it so character attack is profession + weapon bonus = character attack % 
                    if (g.CurrentRoom.Enemy.CurrentHP <= 0)
                    {

                        g.CurrentRoom.Enemy = null;
                        //Console.Clear(); breaks it so you can not go back

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
