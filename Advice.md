# RoadMap

- [ ] Create a new LevelStatusEffect, give it no actual effects, its just a hidden tracker. Make it invisible and permanent (forget the name of the properties but something like ShowInHUD and LengthType)

- [ ] Create a new LevelPassiveSkill which watches your new status, give it the same effects as Peacemaker passive (so that each level of the status adds to the effects)

- [ ] Edit Peacemaker Elixir and change it to give you the new LevelStatusEffect AND the LevelPassiveSkill. The Passive will only be learned once. Probably also make it NOT give the normal peacemaker passive - make sure you set the EffectBehaviour to "Destroy" to do this.


## ==================================

# Sinai's additional advice :

1. Hey, welcome. The only tricky part there would be keeping track of what "level" the peacemaker skill is at, if you want it to be unlimited then you'll need to save that data somehow. Sideloader offers the ability to easily add custom save data, you could use that or implement your own system if you want. As for actually making the change, I guess you would patch Item.Use and do your check there. Or actually maybe just patch LearnSkillEffect.ActivateLocally, normally it would check if you already have the skill, in that case you would increment your "peacemaker level". As for adding extra stats for each stack, it shouldnt be too hard to do, I think passives only register their stat level once when the passive is learned or loaded from a save.

2. Heres some links to help you get started
 	- https://outward.fandom.com/wiki/Advanced_Modding_Guide
	- https://sinai-dev.github.io/OSLDocs/#/
	- https://github.com/sinai-dev/Outward-Mods


3. There's 3 main ways to mod:
	- using Unity's API to create GameObjects, Components, Behaviour scripts, etc etc.
	- changing assets, either with SideLoader or just manually (ie changing stats)
	- harmony patches to change how the game code behaves


4. You could use LevelPassiveSkill, but how that works is by watching a certain LevelStatusEffect and bases the level off of that. This would mean making a permanent invisible status effect (which is possible) and increasing its level with each use of a Peacemaker Elixir item. That might all be possible with SideLoader itself to be honest. If you go with the patching, yeah, hooks with Harmony. They're not as scary as they sound ^^ And yeah you would make a new skill item for your passive, and a new status effect for the invisible status, then edit Peacemaker Elixir item to make them work.


5. > "Is it gonna work properly if the mod is added onto an already existing save with the player already having the original effect ?" :
	- Hmm, probably not with that exact approach. What you can do instead is change the Peacemaker Elixir passive to instead be a LevelPassiveSkill - sideloader does support this although its not extensively tested. Basically just edit the passive and change the class to be SL_LevelPassiveSkill, you can do that with the menu or directly in the XML file. Can't guarantee it will work but hopefully it does.


6. > "How am I gonna handle uninstalling the mod ?":
	- Simply removing the mod should cause everything to go back to normal on the next launch. If the Item ID doesn't exist anymore the game will just remove the item.

