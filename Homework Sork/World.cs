using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Sork
{
    public class World
    {
        public Room Create()
        {
            //     Enemy List
            //var = new Enemy();
            //.Name = " ";
            //.Description = " ";
            //.CurrentHP = 0;
            //.GainedExperience = 0;
            //.Attack = 0;
            //.Defence = 0;
            //.Agility = 0;

            var slime = new Enemy();
            slime.Name = "slime";
            slime.Description = "Glob of living ozze.";
            slime.AttackDescription = "lunging forward it shoots pieces of itself at you that besolves what it touches";
            slime.CurrentHP = 5;
            slime.GainedExperience = 15;
            slime.Attack = 6;
            slime.Defence = 5;
            slime.Agility = 5;

            var bridgeTroll = new Enemy();
            bridgeTroll.Name = "Bridge Troll";
            bridgeTroll.Description = "Looks like a potato with limbs but very very smelly.";
            bridgeTroll.CurrentHP = 15;
            bridgeTroll.GainedExperience = 45;
            bridgeTroll.Attack = 8;
            bridgeTroll.Defence = 10;
            bridgeTroll.Agility = 5;

            //      Item List
            //var = new Item();
            //.Name = " ";
            //.Description = " ";
            //.UseDescription = " ";
            //.Weight = 0;
            //.StackMax = 0;
            //.Duration = 0;
            //.AttackBuff = 0;
            //.DefenceBuff = 0;
            //.AgilityBuff = 0;
            //.SneakBuff = 0;
            //.HPBuff = 0;
            //.Healing = 0;
            //.CraftRequirements = new List<Craft>
            //{
            //    ,
            //};

            var rock = new Item();
            rock.Name = "Rock";
            

            var stick = new Item();
            stick.Name = "Stick";
            

            var redHerb = new Item();
            redHerb.Name = "Red Herb";
            

            var blueHerb = new Item();
            blueHerb.Name = "Blue Herb";
            

            var greenHerb = new Item();
            greenHerb.Name = "Green Herb";
            
            
            var blackMushroom = new Item();
            blackMushroom.Name = "Black Mushroom";


            //      Weapon List
            //var = new Weapon();
            //.Name = " ";
            //.Description = " ";
            //.AttackDescription = " ";
            //.LevelRequirment = 1;
            //.Durability = 100;
            //.AttackBonus = 0;
            //.DefenceBonus = 0;
            //.AgilityBonus = 0;
            //.SneakBonus = 0;

            var fist = new Weapon();
            fist.Name = "Fists";
            fist.Description = "Your hands";
            fist.AttackDescription = "A jab with the left followed by a uppercut with the right ";
            fist.LevelRequirment = 1;
            fist.Durability = 100;
            fist.AttackBonus = 0;
            fist.DefenceBonus = 0;
            fist.AgilityBonus = 0;
            fist.SneakBonus = 0;

            var woodenClub = new Weapon();
            woodenClub.Name = "Wooden Club";
            woodenClub.Description = "Piece of wood from a tree";
            woodenClub.AttackDescription = "Swinging the Club ";
            woodenClub.LevelRequirment = 1;
            woodenClub.Durability = 100;
            woodenClub.AttackBonus = 1;
            woodenClub.DefenceBonus = 1;
            woodenClub.AgilityBonus = 0;
            woodenClub.SneakBonus = 0;


            // Create All Your Rooms
            var startRoom = new Room();
            startRoom.Name = "Stony River Shore";
            startRoom.Description = "Awakened by an ominous RAWR, the adventurer sits up to discover themself on a riverbank below a cliff. Evaluating themself, finds that they have no items on them and only dressed in common cloths. Hearing another Rawr, the person looks up to see a wall atop the cliff. With that sight a pain sparks alight in there head, with a flash of memory. Remembering standing with companions fighting together, then the feeling of falling. Recovering from the pain and feeling the lump on there head, the adventurer stands up to continue forward. With a desire to find the companions and regain the memorys from before waking on the riverbank.";
            startRoom.Items = new List<Item>
            {
                rock, redHerb
            };

            var woodbankRoom = new Room();
            woodbankRoom.Name = "Wooded River Bank";
            woodbankRoom.Description = "Walking for a little while you stop along a tree line part of the riverbank. Looking at the river water you think to yourself the current does not seem as strong.";
            woodbankRoom.Items = new List<Item>
            {
                stick, greenHerb
            };

            var frontbridgeRoom = new Room();
            frontbridgeRoom.Name = "Front Bridge";
            frontbridgeRoom.Description = "Standing on a path looking ahead you see the old stone bridge before you. It looks solid enough as it streaches out across the river.";
            frontbridgeRoom.Item = greenHerb;

            var middlebridgeRoom = new Room();
            middlebridgeRoom.Name = "Middle Bridge";
            middlebridgeRoom.Description = "On the bridge over the river.";
            middlebridgeRoom.Item = blueHerb;
            middlebridgeRoom.Enemy = bridgeTroll;
            

            var backbridgeRoom = new Room();
            backbridgeRoom.Name = "End Bridge";
            backbridgeRoom.Description = "With the sound of the water behind your back, looking forward you see the path before you.";

            var underbridgeRoom = new Room();
            underbridgeRoom.Name = "Below the Bridge.";
            underbridgeRoom.Description = "In the dank and drerry shadow of the bridge, you cling to a support as your eyes adjust.";
            underbridgeRoom.Item = blackMushroom;

            var trollRoom = new Room();
            trollRoom.Name = "Where the troll lived under the bridge.";
            trollRoom.Description = "With refuse and bones scattered around the crude room where the troll lived.";
            //trollRoom.Search = "Under the pile of smelly rags you find a dented strongbox, looks to have been used as a pillow by the troll...";
            //trollRoom.Item = "Short sword, small wooden shield"

            var forkPathRoom = new Room();
            forkPathRoom.Name = "The Fork in the Path";
            forkPathRoom.Description = "Looking around you see to the left is a once great coblestone road that goes uphill. To the right is a dirt path that continues through the plains till it enters a forest grove.";

            var forestGroveRoom = new Room();
            forestGroveRoom.Name = "Forest Grove (Right Path)";
            forestGroveRoom.Description = "Following the right path you continue on, untill you notice that there is a flipped wagon just beond the entrence to the forest. You approch to find only the bodys of a merchant and guards that have been feld by arrows. You hear a rusle from the trees looking up you suddenly fall backwards to the ground. Looking up as the light fads you ask yourself when did you grow a wooden branch from your forhead.";

            var cobbleStonePathRoom = new Room();
            cobbleStonePathRoom.Name = "Cobble Stone (Left Path)";
            cobbleStonePathRoom.Description = "";

            var frontGateRoom = new Room();
            frontGateRoom.Name = "Gate House Enterence";
            frontGateRoom.Description = "Standing infront of the looming enterence you see that the once grand iron gate has been split in the middle like a zipper but from the inside with large pieces of burned kindling scattered around.";



            // Create All Your Exits
            // wrong turns - future expantions
            var swimExit = new Exit();
            swimExit.Destination = null;
            swimExit.Name = "swim";
            swimExit.OnTravel = "You attempt to start to swim acoss but the current overwelm you as you go under swallowed by the dark waters.";
            swimExit.Aliases = new List<string>
            {
                "sw","swi"
            };

            var forestGroveExit = new Exit();
            forestGroveExit.Destination = null;
            forestGroveExit.Name = "right";
            forestGroveExit.OnTravel = "";

            //walk to open areas (not contained spaces) like paths
            var walkToWoodBank = new Exit();
            walkToWoodBank.Destination = woodbankRoom;
            walkToWoodBank.Name = "walk";
            walkToWoodBank.OnTravel = "You walk along the shore to ...";
            walkToWoodBank.Aliases = new List<string>
            {
                "w","wa","wal"
            };

            var walkToFrontBridge = new Exit();
            walkToFrontBridge.Destination = frontbridgeRoom;
            walkToFrontBridge.Name = "walk";
            walkToFrontBridge.OnTravel = "Walking past the next bend in the river you see a bridge, pushing forward you emerge from the trees.";
            walkToFrontBridge.Aliases = new List<string>
            {
                "w","wa","wal"
            };

            var walkToForkPath = new Exit();
            walkToForkPath.Destination = forkPathRoom;
            walkToForkPath.Name = "walk";
            walkToForkPath.OnTravel = "You walking down the path after the bridge until you come to a split in the path.";
            walkToForkPath.Aliases = new List<string>
            {
                "w","wa","wal"
            };

            var walkToCobblePath = new Exit();
            walkToCobblePath.Destination = cobbleStonePathRoom;
            walkToCobblePath.Name = "walk";
            walkToCobblePath.OnTravel = "Following the overgrown path uphill, it takes some twists and turns when it gets to some cliff areas, you continue forward till you find yourself surrounded by lots of big piles of rubble.";
            walkToForkPath.Aliases = new List<string>
            {
                "w","wa","wal"
            };

            var walkToFrontGate = new Exit();
            walkToFrontGate.Destination = frontGateRoom;
            walkToFrontGate.Name = "walk";
            walkToFrontGate.OnTravel = "";
            walkToForkPath.Aliases = new List<string>
            {
                "w","wa","wal"
            };





            //crossing a elevated area 
            var crossToMiddleBridge = new Exit();
            crossToMiddleBridge.Destination = middlebridgeRoom;
            crossToMiddleBridge.Name = "cross";
            crossToMiddleBridge.OnTravel = "With the first few steps forward you come to the center of the bridge with the river below.";
            crossToMiddleBridge.EnemyIntro = "A large hand grabes the railing and a creature swings over the railing from below. Standing before you is a troll stopping you more with his stiench then his body.";
            crossToMiddleBridge.Aliases = new List<string>
            {
                "c","cr","cro","cros"
            };

            var crossToBackBridge = new Exit();
            crossToBackBridge.Destination = backbridgeRoom;
            crossToBackBridge.Name = "cross";
            crossToBackBridge.OnTravel = "Now with water no longer under you you see a old path streach before you disapearing into a sea of tall grass.";
            crossToBackBridge.Aliases = new List<string>
            {
                "c","cr","cro","cros"
            };

            //going up or down in a confined area using climb in open space 
            var climbToUnderBridge = new Exit();
            climbToUnderBridge.Destination = underbridgeRoom;
            climbToUnderBridge.Name = "climb";
            climbToUnderBridge.OnTravel = "Leaning over the edge of the bridge, you examin for a path. You lower yourself using both the protruding and missing rock spots to climb down below.";
            climbToUnderBridge.Aliases = new List<string>
            {
                "c","cl","cli","clim", "^", "up", "ascend"
            };

            var climbBackToMiddleBridge = new Exit();
            climbBackToMiddleBridge.Destination = middlebridgeRoom;
            climbBackToMiddleBridge.Name = "back";
            climbBackToMiddleBridge.OnTravel = "Climbing back up the bridge supports, you pull yourself over the railing to once again stand over the river.";
            climbBackToMiddleBridge.Aliases = new List<string>
            {
                "b","ba","bac"
            };

            //enter & exit (like doorway) rooms
            var enterTheTrollRoom = new Exit();
            enterTheTrollRoom.Destination = trollRoom;
            enterTheTrollRoom.Name = "enter";
            enterTheTrollRoom.OnTravel = "Entering the oddly hanging structure.";
            enterTheTrollRoom.Aliases = new List<string>
            {
                "e","en","ent","ente"
            };

            var exitTheTrollRoom = new Exit();
            exitTheTrollRoom.Destination = underbridgeRoom;
            exitTheTrollRoom.Name = "exit";
            exitTheTrollRoom.OnTravel = "Leaving the trolls room";
            exitTheTrollRoom.Aliases = new List<string>
            {
                "e","ex","exi"
            };

            //back to open areas
            var backToStart = new Exit();
            backToStart.Destination = startRoom;
            backToStart.Name = "back";
            backToStart.OnTravel = "You follow the path back from which you came ...";
            backToStart.Aliases = new List<string>
            {
                "b","ba","bac"
            };

            var backToWoodBank = new Exit();
            backToWoodBank.Destination = woodbankRoom;
            backToWoodBank.Name = "back";
            backToWoodBank.OnTravel = "You follow the path back from which you came ...";
            backToWoodBank.Aliases = new List<string>
            {
                "b","ba","bac"
            };

            var backToFrontBridge = new Exit();
            backToFrontBridge.Destination = frontbridgeRoom;
            backToFrontBridge.Name = "back";
            backToFrontBridge.OnTravel = "Walking back to the start of the bridge ...";
            backToFrontBridge.Aliases = new List<string>
            {
                "b","ba","bac"
            };

            var backToMiddleBridge = new Exit();
            backToMiddleBridge.Destination = backbridgeRoom;
            backToMiddleBridge.Name = "back";
            backToMiddleBridge.OnTravel = "";
            backToMiddleBridge.Aliases = new List<string>
            {
                "b","ba","bac"
            };

            var backToUnderBridge = new Exit();
            backToUnderBridge.Destination = underbridgeRoom;
            backToUnderBridge.Name = "back";
            backToUnderBridge.OnTravel = "exiting the trolls room you return to the open space under the bridge";
            backToUnderBridge.Aliases = new List<string>
            {
                "b","ba","bac"
            };

            var backToBackBridge = new Exit();
            backToBackBridge.Destination = backbridgeRoom;
            backToBackBridge.Name = "back";
            backToBackBridge.OnTravel = "Back to the bridge";
            backToBackBridge.Aliases = new List<string>
            {
                "b","ba","bac"
            };

            var backToForkPath = new Exit();
            backToForkPath.Destination = forkPathRoom;
            backToForkPath.Name = "back";
            backToForkPath.OnTravel = "back down the cobble stone path to the fork";
            backToBackBridge.Aliases = new List<string>
            {
                "b","ba","bac"
            };

            /*
            var fakeExitToDemo = new Exit();
            fakeExitToDemo.Destination = middlebridgeRoom;
            fakeExitToDemo.Name = "float";
            fakeExitToDemo.OnTravel = "This should never be seen";
            */

            // Add Exits To Room
            startRoom.Exits = new List<Exit>
            {
                walkToWoodBank, swimExit, //fakeExitToDemo
            };

            woodbankRoom.Exits = new List<Exit>
            {
                backToStart, walkToFrontBridge, swimExit, //fakeExitToDemo
            };

            frontbridgeRoom.Exits = new List<Exit>
            {
                backToWoodBank, crossToMiddleBridge, //sneak to end bridge by thief
            };

            middlebridgeRoom.Exits = new List<Exit>
            {
                backToFrontBridge, climbToUnderBridge, crossToBackBridge
            };

            underbridgeRoom.Exits = new List<Exit>
            {
                enterTheTrollRoom, climbBackToMiddleBridge
            };

            trollRoom.Exits = new List<Exit>
            {
                exitTheTrollRoom
            };

            backbridgeRoom.Exits = new List<Exit>
            {
                walkToForkPath, backToMiddleBridge
            };

            forkPathRoom.Exits = new List<Exit>
            {
                backToBackBridge, forestGroveExit, walkToCobblePath
            };
            cobbleStonePathRoom.Exits = new List<Exit>
            {
                backToForkPath, walkToFrontGate
            };
            

            return startRoom;
        }
    }
}
