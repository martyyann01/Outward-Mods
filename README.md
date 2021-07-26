# Stackable Peacemaker

This mods intends to make the Peacemaker Elixir (passive skill) stack if you consume another Peacemaker Elixir (item) obtained when finishing the main quest. 

Would be compatible with : 
- the NewGamePlus mod by @random-facades (link here : https://github.com/random-facades/Outward-Mods/tree/main/NewGamePlus)
- being given another Peacemaker Elixir by someone in multiplayer

### ==================================

# RoadMap

- [ ] Create a new LevelStatusEffect, give it no actual effects, its just a hidden tracker. Make it invisible and permanent (forget the name of the properties but something like ShowInHUD and LengthType)

- [ ] Create a new LevelPassiveSkill which watches your new status, give it the same effects as Peacemaker passive (so that each level of the status adds to the effects)

- [ ] Edit Peacemaker Elixir and change it to give you the new LevelStatusEffect AND the LevelPassiveSkill. The Passive will only be learned once. Probably also make it NOT give the normal peacemaker passive - make sure you set the EffectBehaviour to "Destroy" to do this.

- [x] IDs reserved (from -16000 to -16999)


### ==================================

For more infomation, you can text me on Discord : NathanielGarro#9885
