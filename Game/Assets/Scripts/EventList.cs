using UnityEngine;
using System.Collections;

public class EventListScript : MonoBehaviour {

	public class EventList
	{
		private string[] leEvent = new string[3];

		private string[][] tabWar = new string[20][]{ 

			new string[3] {"Pokepea-ball ","‘Peacock Peacock ?’ – A wild peacock appears",""}
			, new string[3] {"The Walking Pea","‘Brhahwhwhwh FEATHERSSS’ – Dead peacock",""}
			, new string[3] {"Peacockarang","‘I’m the night. I’m Peacockman’ – A strangely dressed peacock",""} 
			, new string[3] {"Boomerangock ","‘YAHHH HA HYAH YAAAAH’ – Random pealien",""}
			, new string[3] {"Peadators ","‘Let’s hunt some aliens !’ – Peacock with strange mouth",""}
			, new string[3] {"Peaxcalibur","‘I took this out of a stone. What do we do now ?",""}
			, new string[3] {"Golden Peagun","‘Is this supposed to one shot or something ?",""}
			, new string[3] {"Hidden Feather Blade","‘Peacock’s Creed’ – Covered peacock",""}
			, new string[3] {"Lightfeather","‘Luke. I’m your pearent’ – Peark Vader",""}
			, new string[3] {"Pea-whip","‘Would work better on peavampires’",""}
			, new string[3] {"Pearamid Head","‘A bit foggy isn’t it ?’",""}
			, new string[3] {"Wolvepea","‘Made of steel by Peacorp and co’",""}
			, new string[3] {"Peakey Blade","‘… Hu. Is this even a weapon ?’ – Peackey Mouse",""}
			, new string[3] {"Peanana Bomb","‘ALL THOSE PEAWORMS WILL DIE’",""}
			, new string[3] {"Peazilla","‘All those radiations on such a sweet peacock’",""}
			, new string[3] {"PeaCop","‘Dead or alive, you’re com’",""}
			, new string[3] {"PeaKong","‘HUUHHUHUH OUUUUH’ – A huge peacock stand on a tower",""}
			, new string[3] {"Feathermourn","‘All hail the Pea King’ – Is written on it",""}
			, new string[3] {"Peatal Gear","‘That’s one shiny peabot’",""}
			, new string[3] {"Unknown blue shell","‘Noone would ever stand in front of my feathers !",""} 
		};
        private string[][] tabScience = new string[20][]{
			new string[3] {"Pearon-Man ","‘Yeay I know I’m awesome’ – Peaony Stark",""}
			, new string[3] {"R2-DDock","‘Blipihrbbititii’ – Droidock",""}
			, new string[3] {"Cybernetic","‘SARAH CONNOCK ?’ – Pearminator",""}
			, new string[3] {"Internet ","‘ Huuu, sexypeacock.com ..’ – Random internet user",""}
			, new string[3] {"Peaolorean ","‘88 miles PER HOUR !’ – Docock",""}
			, new string[3] {"Daleacock","‘EXTERMINATE",""}
			, new string[3] {"Nautileock","‘20.000 miles under the pea",""}
			, new string[3] {"Peaformers","‘Autohocks, UNITE !’ – Peaptimus Prime",""}
			, new string[3] {"Bioplants","‘I’m Peagroot’ – Peagroot",""}
			, new string[3] {"Multipass","‘Pealoo Dallas Multipass",""}
			, new string[3] {"Green Wise Peacock","‘Study you should, but playing you are.",""}
			, new string[3] {"Peagate","‘Watchout for Goa’uldock’ – Peack O’Neill",""}
			, new string[3] {"Books","‘What is that … Fifty shades of feathering ?!",""}
			, new string[3] {"Portal-Gun","‘The peacake is a lie",""}
			, new string[3] {"Peagle Glasse","‘Glasse, search sexy peacock on Peagle’ – private navigation",""}
			, new string[3] {"iPeacock","‘Sorry, I’m allergic to peash*t",""}
			, new string[3] {"Wall-Pea","‘Ehhhpea’ – Wall-Pea ",""}
			, new string[3] {"E-Pea","‘E-Pea home phone’ – E-Pea ",""}
			, new string[3] {"Franck tha Pea","‘If you don’t like it you can kiss my feathery little b*tt",""}
			, new string[3] {"Pearty MacFlock","‘We’re going back … TO THE FUTUR !’ – Docock ",""}
		};
        private string[][] tabSpirituality = new string[20][]{
			new string[3] {"Saurock ","‘This eye is quite watching us ain’t it ?’ – Pearodo",""}
			, new string[3] {"Peambuldore","‘Come there Harry, I’ve got to teach you something",""}
			, new string[3] {"Peadogue Cult","‘Wow So dogue much fabulous very handsome",""}
			, new string[3] {"Peaseidon","‘GRAHH SWIM MY LITTLE PEACOCK !",""}
			, new string[3] {"Peaception","‘Is that a dream ? Imma dreaming ?!!’ –dreamer",""}
			, new string[3] {"Pealkyries","‘Oh look mamma, blond peacock riding flying horses",""}
			, new string[3] {"Phorus","‘Great god of Peacock, show us the way.’ – believer",""}
			, new string[3] {"Peadalf the Grey","‘YOU SHALL NOT- Oh look that sexy peacock",""}
			, new string[3] {"Peades","‘Guarding doomgates is not an easy thing …",""}
			, new string[3] {"Dyonisock","‘Rhum, wine, and pearties !",""}
			, new string[3] {"Divine Stick","‘Shiny, amazing … But it does nothing else.",""}
			, new string[3] {"Morpheock","‘Red pea’ or blue pea’ ?!",""}
			, new string[3] {"Peaght Club","‘You met me at a very strange moment of my life",""}
			, new string[3] {"Nyarlathotock","‘That thing is a horror",""}
			, new string[3] {"Genius","‘Be the change that you want to see in the world",""}
			, new string[3] {"JCVD","‘I could crush a nut in my buttcrack",""}
			, new string[3] {"Martin Peather King","‘I have a dream, that one day, every peacock will live together",""}
			, new string[3] {"Shakespea","‘To be or not to be this is a peacock problem.",""}
			, new string[3] {"Peainstein","‘Imagination is more important than knowledge",""}
			, new string[3] {"Chtulhock","‘DIVINE PEACOCK OF TENTACLES",""}
		};

		public string[] getTabValues(int random, string tag){
			if (tag == "WarButton") {
				leEvent = tabWar[(random-1)];
			} 
			else if (tag == "ScienceButton") {
				leEvent = tabScience[(random-1)];
			} 
			else {
				leEvent = tabSpirituality[(random-1)];
			}
			return leEvent;
		}
	}
}
