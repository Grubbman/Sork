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
        private DiceBag diceBag;
        

        public Game()
        {
            header = new Header();
            diceBag = new DiceBag();
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
                    //run combat part
                    var AttackRoll = diceBag.Roll(DiceBag.Dice.D20);
                    var DodgeRoll = diceBag.Roll(DiceBag.Dice.D12);
                    var DamageRoll = diceBag.Roll(DiceBag.Dice.D6);
                    if ( AttackRoll + g.CurrentRoom.Enemy.Agility > DodgeRoll + g.Character.Agility)
                    {
                        g.Character.CurrentHP -= DamageRoll;
                    }

                    if ( AttackRoll + g.Character.Agility > DodgeRoll + g.CurrentRoom.Enemy.Agility)
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
