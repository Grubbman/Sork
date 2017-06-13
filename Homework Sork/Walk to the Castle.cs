using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Sork
{
    public class Walk_to_the_Castle
    {
        /*
         if you search command where you wake you can find stone 
         
         so the 2 options after waking are to walk and swim 
         if you swim from the first river bank then you die by the strong current

         
         if you walk you go down the river bank you stop on the riverbank midway where it gives you the option to swim again 
         (in this area you can search and find a wood club) once you have the stone and the club you can with the craft option create a stone club
        
         if you swim from 2nd river bank you get eatten by a river monster

         to find a bridge where your options are -Cross- or -Back-
         if you choose -Cross- at the bridge you are stopped by a bridge troll
         then your options are -Fight- or -Flee- if you fight you can choose how if you have a weapon you can get a + to attack which helps in the dice roll
         bridge troll will be easy to 100% kill with a weapon and give 50exp and with out a weapon you have a 50% to kill it with fists as weapon option
         if you lose to the bridge troll you loose 5 health

        once you defete the bridge troll you have option prompted option to -Cross- hidden option to -Search- which have the prompted options -bridge troll body- -bridge area-
        if you search bridge troll you find a key
        if you search the bridge area you find a troll cave in the troll cave is a treasure chest that you can use the key to open and get a metal dagger and some basic armor
        
        once you cross the bridge you come to a crossroads where you are prompted to go left or right 
        left leads to the castle guardhouse which are empty if you search justs prompts with "it is and dusty room with leaves and debree around"

        from the guardhouse you can -climb- to the guardhouse tower if you search it gives you a discription of the view of the forest and a delapidated castle
        -climb- option to go back to the guardhouse 

        from guardhouse you option -enter castle- to the courtyard which you can search and if you do you find slim monsters which you can fight which give you 20 exp

        you also -search- area option gives you barracks and kitchen 
        
        from barricks are nothing you find the bootprints in the dust and -search- give option to go to the hallway or armory 
        in the armory search finds a rusty chainmail in it and a broken sword have to go back to the barracks 
        
        the kitchen search finds moldy food and the option to fight 3 large rats which gives you 15exp each 

        from the kitchen progression location options are -dinning hall- and -courtyard-

        from the dinning room you have scattered bones and broken tables and chairs, from there you go to the hallway in hallway search only see old tattered tapistrys

        the 2 hallways from the barracks and the dinning hall lead to a stairwell -up- goes to 2nd floor -down-
        down goes to dungeon where you find a cells and dug tunnels if you search the tunnels there are ratmen 50 exp each who you can attack 
        the cells only have bones and buckets in them you can pick up a bucket
        ratmen body search gives you a sword and a health potion, the ratmen tunnel lead to the dungan entrence and the cells so is a circle

        upstairs to the second floor is where the upper stairwell that has 3 dirrection options climb to the roof, hallway left and right 
        hallway left goes to paripits that if you search you find evidence of a struggle and leading over the wall, search area lets you look over the edge and see the river below
        from the paripits you can go back to the hallway that leads to stairway or to rear guard tower, 

        on entering the guard tower you find the remains of some of your companions and so you have another flashback of where you where attacked on the parapits and tried your best to hold off the attacking force when you told you compainion to run and warn the others 
        with that knowlage you can search the companions body and get a silver armband 

        you go back to the paripits and then back to the hallway then back to the second floor stairwell to go right hallway

        the right hallway leads to the living quarters which if you scout area has 6 room options you can go into and search, most are empty and don't have much in them 
        room 4 has an entry way with a look out that has fallen asleep you have options promps to go back sneek past or attack (attack has 2 options if you found the armband you can assinate the guard)
        if you attack aloud you will wake enimy inside and it said you died, if you sneak past you find a room of sleeping people the intruders that killed you companion and tossed you over the wall into the river
        if you start killing the sleeping people with out killing the guard first on the 2nd person death it makes a sound that wakes the other and they kill you 
        if you kill the people in the order of person 2413 you get a specal ending where you find your goblin clan and live as the new cheif due to all the great gear you got from killing the adventurers





        add in to world
        
            var guardHouseRoom = new Room();
            guardHouseRoom.Name = "";
            guardHouseRoom.Description = "";

            var guardTowerRoom = new Room();
            guardTowerRoom.Name = "";
            guardTowerRoom.Description = "";

            var courtYardRoom = new Room();
            courtYardRoom.Name = "";
            courtYardRoom.Description = "";

            var barracksRoom = new Room();
            barracksRoom.Name = "";
            barracksRoom.Description = "";

            var armoryRoom = new Room();
            armoryRoom.Name = "";
            armoryRoom.Description = "";

            var castleF1Hallway1Room = new Room();
            castleF1Hallway1Room.Name = "";
            castleF1Hallway1Room.Description = "";

            var kitchenRoom = new Room();
            kitchenRoom.Name = "";
            kitchenRoom.Description = "";

            var pantryRoom = new Room();
            pantryRoom.Name = "";
            pantryRoom.Description = "";

            var dinningHallRoom = new Room();
            dinningHallRoom.Name = "";
            dinningHallRoom.Description = "";

            var castleF1Hallway2Room = new Room();
            castleF1Hallway2Room.Name = "";
            castleF1Hallway2Room.Description = "";

            var castleF1StairCaseRoom = new Room();
            castleF1StairCaseRoom.Name = "";
            castleF1StairCaseRoom.Description = "";

            var dungeonGuardRoom = new Room();
            dungeonGuardRoom.Name = "";
            dungeonGuardRoom.Description = "";

            var dungeonHallwayRoom = new Room();
            dungeonHallwayRoom.Name = "";
            dungeonHallwayRoom.Description = "";

            var dungeonTunnelRoom = new Room();
            dungeonTunnelRoom.Name = "";
            dungeonTunnelRoom.Description = "";

            var dungeonNestRoom = new Room();
            dungeonNestRoom.Name = "";
            dungeonNestRoom.Description = "";

            var dungeonCellRoom1 = new Room();
            dungeonCellRoom1.Name = "";
            dungeonCellRoom1.Description = "";

            var dungeonCellRoom2 = new Room();
            dungeonCellRoom2.Name = "";
            dungeonCellRoom2.Description = "";

            var dungeonCellRoom3 = new Room();
            dungeonCellRoom3.Name = "";
            dungeonCellRoom3.Description = "";

            var dungeonCellRoom4 = new Room();
            dungeonCellRoom4.Name = "";
            dungeonCellRoom4.Description = "";

            var dungeonCellRoom5 = new Room();
            dungeonCellRoom5.Name = "";
            dungeonCellRoom5.Description = "";

            var castleF2StairWellRoom = new Room();
            castleF2StairWellRoom.Name = "";
            castleF2StairWellRoom.Description = "";

            var castleRoofRoom = new Room();
            castleRoofRoom.Name = "";
            castleRoofRoom.Description = "";

            var castleF2Hallway1Room = new Room();
            castleF2Hallway1Room.Name = "";
            castleF2Hallway1Room.Description = "";

            var ropeBridgeRoom = new Room();
            ropeBridgeRoom.Name = "";
            ropeBridgeRoom.Description = "";

            var parapits1Room = new Room();
            parapits1Room.Name = "";
            parapits1Room.Description = "";

            var parapits2Room = new Room();
            parapits2Room.Name = "";
            parapits2Room.Description = "";

            var watchTowerF2EntryDoor = new Room();
            watchTowerF2EntryDoor.Name = "";
            watchTowerF2EntryDoor.Description = "";

            var watchTowerF2Ladder = new Room();
            watchTowerF2Ladder.Name = "";
            watchTowerF2Ladder.Description = "";

            var watchF2TowerEntryRoom = new Room();
            watchF2TowerEntryRoom.Name = "";
            watchF2TowerEntryRoom.Description = "";

            var watchF2TowerRoom1 = new Room();
            watchF2TowerRoom1.Name = "";
            watchF2TowerRoom1.Description = "";

            var watchF2TowerRoom2 = new Room();
            watchF2TowerRoom2.Name = "";
            watchF2TowerRoom2.Description = "";

            var watchF1TowerEntryRoom = new Room();
            watchF1TowerEntryRoom.Name = "";
            watchF1TowerEntryRoom.Description = "";


            var castleF2Hallway2Room = new Room();
            castleF2Hallway2Room.Name = "";
            castleF2Hallway2Room.Description = "";

            var castleF2Room1 = new Room();
            castleF2Room1.Name = "";
            castleF2Room1.Description = "";

            var castleF2Room2 = new Room();
            castleF2Room2.Name = "";
            castleF2Room2.Description = "";

            var castleF2Room3 = new Room();
            castleF2Room3.Name = "";
            castleF2Room3.Description = "";

            var castleF2Room4 = new Room();
            castleF2Room4.Name = "";
            castleF2Room4.Description = "";

            var castleF2Room5 = new Room();
            castleF2Room5.Name = "";
            castleF2Room5.Description = "";

            var castleF2Room6 = new Room();
            castleF2Room6.Name = "";
            castleF2Room6.Description = "";




        


        

        


    */
    }
}
