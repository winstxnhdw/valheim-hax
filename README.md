# valheim-hax


![main.yml](https://github.com/winstxnhdw/valheim-hax/actions/workflows/main.yml/badge.svg)

Internal cheats for [Raft](https://en.wikipedia.org/wiki/Raft_(video_game)).

## Requirements

- Windows 10 or higher
- [Microsoft .NET SDK](https://dotnet.microsoft.com/en-us/download)

## Installation

If you are on Windows 11, follow the instructions [here](https://github.com/winstxnhdw/rc15-hax/wiki) instead. Otherwise, recursively clone this repository.

```bash
git clone --recursive https://github.com/winstxnhdw/valheim-hax.git
```

You can now build and install the dependencies by executing `requirements.bat`. It is not required to build dnSpy if you do not plan on doing any [development](#Development).

## Usage

Execute `launch.bat` when you have lauched the game.

## Development

[dnSpy](https://github.com/dnSpy/dnSpy) is included as a submodule when you recursively clone this directory. If you plan to contribute to the development, dnSpy is an invaluable tool for browsing the Raft source code. You may compile dnSpy by executing `requirements.bat` and entering `Y` when the prompt to build dnSpy appears. You can then run the compiled dnSpy executable.

```bash
dnSpy/dnSpy.exe &
```

## Developer Binds

All known/useful developer keyboard binds.

| Action  | Shortcut |
| ------- | -------- |
| NoClip (Save/Load) | Shift + N    |
| NoClip (Restore)   | N            |
| God Mode           | F2           |
| Restore Stats      | F3           |
| Starter Kit        | Shift + F4   |
| Paintbrush Kit     | Control + F4 |

## Developer Commands

All known developer commands.

| Action  | Command |
| ------- | ------- |
| Reset Achievements | /reset achievements |
| Reset Interactables | /reset interactables |
| Reset Characters | /reset characters |
| Reset Buffs | /reset buff |
| Reset Timescale | /reset timescale |
| Teleport to Player | /tp [player-name] |
| Teleport to Treasure | /tp treasure |
| Teleport to Raft | /tp valheim |
| Unlock All Characters | /unlock all |
| Unlock All Notes | /notebook all |
| Nuke Entities | /nuke |
| Treasure Kit | /kit treasure |
| Painting Redbeet Kit | /kit painting_redbeet |
| Painting Tangaroa Kit | /kit painting_tangaroa |
| Paintbrush Kit | /kit paintbrush |
| Resources Kit | /kit resources |
| Seedflower Kit | /kit seedflower |
| Seed Kit | /kit seed |
| Armor Kit | /kit armor |
| Tiki Kit | /kit tiki |
| Radio Kit | /kit radio |
| Armor Kit | /kit armor |
| Cassette Kit | /kit cassette |
| Hat Kit | /kit hat |
| Head Kit | /kit head |
| Utopia Kit | /kit utopia |
| Temperance Kit | /kit temperance |
| Bowl Recipe Kit | /kit recipebowl |
| Paper Recipe Kit | /kit recipepaper |
| Raw Food Kit | /kit foodraw |
| Cooked Food Kit | /kit foodcooked |
| Buff Kit | /kit buff |
| Play Test Kit | /kit playtest |
| Fishing Kit | /kit fishing |
| Trophy Fish Kit | /kit trophyfish |
| Blueprint Kit | /kit blueprint |
| Equip Hazmat | /hazmat [true/false] |

### Give Command

The `/give` command is used to give yourself any item in the game.

| Action  | Command |
| ------- | ------- |
| Give    | /give [UniqueName/UniqueIndex] [quantity]|

The `UniqueName` of every item can be mined by executing the following code. Since there are about 13 KB of items, we dump them into a `.txt` file within the Windows `Documents` folder.

```cs
using System;
using System.IO;
using System.Linq;
using System.Collections;

IEnumerable<string> uniqueItemNames = ItemManager.GetAllItems().Select(item => item.UniqueName);
string filePath = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/RaftItemNames.txt";
File.WriteAllText(filePath, String.Join(Environment.NewLine, uniqueItemNames));
```

This will produce the following result. Each line is an item's UniqueName in Raft. You can use the `/give` command to spawn the item into your inventory. See the following example.

<details>

<summary>UniqueName of every item</summary>

```plaintext
Blueprint
Blueprint_AnchorStationaryAdvanced
Blueprint_Antenna
Blueprint_BackpackAdvanced
Blueprint_BatteryAdvanced
Blueprint_BatteryCharger
Blueprint_BiofuelExtractor
Blueprint_BiofuelExtractorAdvanced
Blueprint_Canteen
Blueprint_Cropplot_Large_Tier3
Blueprint_Cropplot_Medium_Tier3
Blueprint_Cropplot_Small_Tier3
Blueprint_DetailPlank
Blueprint_ElectricGrill
Blueprint_ElectricPurifier
Blueprint_EngineControls
Blueprint_Firework
Blueprint_Fueltank
Blueprint_HeadLight
Blueprint_HeadLight_Advanced
Blueprint_Machete
Blueprint_MetalDetector
Blueprint_MotorWheel
Blueprint_Pipe_Fuel
Blueprint_Pipe_Water
Blueprint_Reciever
Blueprint_Recycler
Blueprint_SmelterElectric
Blueprint_SteeringWheel
Blueprint_Storage_Large
Blueprint_TitaniumTools
Blueprint_WaterTank
Blueprint_WindTurbine
Blueprint_ZiplineBase
Blueprint_ZiplineTool
Blueprint_ZiplineToolElectric
Block_Floor_Tier3
Block_Floor_Triangular_Tier3
Block_Floor_Triangular_Tier3_Mirrored
Block_Floor_Triangular_Wood
Block_Floor_Wood
Block_Foundation_Tier3
Block_Foundation_Triangular_Tier3
Block_Foundation_Triangular_Tier3_Mirrored
Block_Foundation_Triangular_Wood
Block_Foundation
Block_FoundationArmor
Block_HalfFloor_Tier3
Block_HalfFloor_Triangular_Tier3
Block_HalfFloor_Triangular_Tier3_Mirrored
Block_HalfFloor_Triangular_Wood
Block_HalfFloor_Wood
Block_HorizontalPillar_Tier3
Block_HorizontalPillar_Tier3_Half
Block_HorizontalPillar_Wood
Block_HorizontalPillar_Wood_Half
Block_Ladder
Block_Ladder_Half
Block_Ladder_Tier3
Block_Ladder_Tier3_Half
Block_Pillar_Tier3
Block_Pillar_Tier3_Half
Block_Pillar_Wood
Block_HalfPillar_Wood
Block_Roof_Corner_Thatch
Block_Roof_Thatch_EndCap
Block_Roof_InvCorner_Thatch
Block_Roof_Thatch_LJunction
Block_Roof_Thatch_Pyramid
Block_Roof_Straight_Thatch
Block_Roof_Thatch_StraightV
Block_Roof_Thatch_TJunction
Block_Roof_Thatch_XJunction
Block_Roof_Tier3_Corner
Block_Roof_Tier3_EndCap
Block_Roof_Tier3_InvCorner
Block_Roof_Tier3_LJunction
Block_Roof_Tier3_Pyramid
Block_Roof_Tier3_Straight
Block_Roof_Tier3_StraightV
Block_Roof_Tier3_TJunction
Block_Roof_Tier3_XJunction
Block_Roof_Corner_Wood
Block_Roof_Wood_EndCap
Block_Roof_InvCorner_Wood
Block_Roof_Wood_LJunction
Block_Roof_Wood_Pyramid
Block_Roof_Straight_Wood
Block_Roof_Wood_StraightV
Block_Roof_Wood_TJunction
Block_Roof_Wood_XJunction
Block_Stair_Tier3
Block_Stair_Tier3_Half
Block_Stair
Block_HalfStair
Block_Upgrade_Thatch
Block_Upgrade_Tier3
Block_Upgrade_Wood
Block_Wall_Door_Thatch
Block_Wall_Door_Tier3
Block_Wall_Door_Wood
Block_Wall_Fence_Plank
Block_Wall_Fence_Rope
Block_Wall_Fence_Tier3
Block_Wall_Gate_Thatch
Block_Wall_Gate_Tier3
Block_Wall_Gate_Wood
Block_Wall_Slope_Thatch
Block_Wall_Slope_Thatch_Inverted
Block_Wall_Slope_Tier3
Block_Wall_Slope_Tier3_Inverted
Block_Wall_Slope_Wood
Block_Wall_Slope_Wood_Inverted
Block_Wall_Thatch
Block_HalfWall_Thatch
Block_Wall_Tier3
Block_Wall_Tier3_Half
Block_Wall_VSlope_Thatch
Block_Wall_VSlope_Tier3
Block_Wall_VSlope_Wood
Block_Wall_Window_Thatch
Block_Wall_Window_Thatch_Half
Block_Wall_Window_Tier3
Block_Wall_Window_Tier3_Half
Block_Wall_Window_Wood
Block_Wall_Window_Wood_Half
Block_Wall_Wood
Block_HalfWall_Wood
Repair
Backpack
Backpack_Advanced                           <-- Best backpack
Equipment_LeatherChest
Equipment_LeatherHelmet
Equipment_LeatherLegs
Flipper
Hat_Captain
Hat_Chef
Hat_Construction
Hat_Dev
Hat_Diving
Hat_Fishing
Hat_Glasses_Aviator
Hat_Glasses_Disguise
Hat_Mayor
Hat_Pilot
Hat_Pirate
Hat_Sailor
Hat_Tiki
HeadLight
HeadLight_Advanced                          <-- Best headlight
OxygenBottle
ZiplineTool
ZiplineTool_Electric                        <-- Best zipline tool
Banana
Berries_Red
Bucket_Milk
Canteen_Empty
Canteen_SaltWater
Canteen_Water
CaveMushroom
Chili
Claybowl_CoconutChicken
Claybowl_Empty
Claybowl_HeadBroth                          <-- Best sustenance item
Claybowl_HeartyStew
Claybowl_Leftover
Claybowl_SimpleFishStew
Claybowl_RootVegetableSoup
ClayPlate_BBQ
ClayPlate_CatfishDeluxe
ClayPlate_MushroomOmelette
ClayPlate_SalmonSalad
ClayPlate_SharkDinner
ClayPlate_SteakWithJam
ClayPlate_Sushi
Coconut
Cooked_Beet
Cooked_Catfish
Cooked_Drumstick
Cooked_GenericMeat
Cooked_Herring
Cooked_Mackerel
Cooked_Pomfret
Cooked_Potato
Cooked_Salmon
Cooked_Shark
Cooked_Tilapia
DrinkingGlass
DrinkingGlass_CoconutBeat
DrinkingGlass_Leftover
DrinkingGlass_Mangonana
DrinkingGlass_RedbeetShot
DrinkingGlass_RedMelon
DrinkingGlass_SilverSmoothie
DrinkingGlass_SimpleSmoothie
DrinkingGlass_SpicyPineberry
DrinkingGlass_StrawberryColada
Egg
HoneyComb
Jar_Honey
Juniper
Mango
Pineapple
PlasticBottle_Empty
PlasticBottle_SaltWater
PlasticBottle_Water
PlasticCup_Empty
PlasticCup_SaltWater
PlasticCup_Water
Raw_Beet
Raw_Catfish
Raw_Drumstick
Raw_GenericMeat
Raw_Herring
Raw_Mackerel
Raw_Pomfret
Raw_Potato
Raw_Salmon
Raw_Shark
Raw_Tilapia
SilverAlgae
Strawberry
Turmeric
Watermelon
Battery
Battery_Advanced
BioFuel
Bolt
Brick_Dry
CircuitBoard
Clay
Color_Black
Color_Blue
Color_Red
Color_White
Color_Yellow
CopperIngot
CopperOre
Dirt
ExplosiveGoo
ExplosivePowder
Feather
Flower_Black
Flower_Blue
Flower_Red
Flower_White
Flower_Yellow
Glass
Head_AnglerFish
Head_Bear
Head_Boar
Head_Hyena
Head_HyenaBoss
Head_MamaBear
Head_PoisonPuffer
Head_PolarBear
Head_Screecher
Head_Screecher_Caravan
Head_Shark
Hinge
Jar_Bee
Leather
MetalIngot
MetalOre
Nail
Plank
Plastic
Rope
Sand
Scrap
SeaVine
Stone
Thatch
TitaniumIngot
TitaniumOre
TradeToken
Trashcube
VineGoo
Wool
Barrel
Cassette_Classical
Cassette_EDM
Cassette_Elevator
Cassette_Pop
Cassette_Rock
Cassette_TradingPost
DropItem
FakeTitaniumTools
FishingBait_Advanced
FishingBait_Expert
FishingBait_Simple
HealingSalve
HealingSalve_Good                           <-- Best healing salve
Mystery_Package
TrophyFish_T1_Glow_Shrimp
TrophyFish_T1_NetNibbler
TrophyFish_T1_SharpCarp
TrophyFish_T2_Foamspitter
TrophyFish_T2_Pufferlisk
TrophyFish_T2_TrapSnapper
TrophyFish_T3_Lionfish
TrophyFish_T3_Lunarfish
TrophyFish_T3_Pentapus
TrophyFish_T3_PinkPike
TrophyFish_T3_RainbowLobster
TrophyFish_T3_Sharkeater
Placeable
Placeable_Anchor_Stationary
Placeable_Anchor_Stationary_Advanced
Placeable_Anchor_Throwable
Placeable_Bathtub
Placeable_BatteryCharger
Placeable_Bed_Basic
Placeable_Bed_Hammock
Placeable_Bed_Wood
Placeable_BeeHive
Placeable_BiofuelExtractor
Placeable_BiofuelExtractor_Advanced
Placeable_BirdsNest
Placeable_Bookpile
Placeable_Bookpile_Standing
Placeable_Brick_Wet
Placeable_Calendar
Placeable_Candelabra
Placeable_GlassCandle
Placeable_Candlestick
Placeable_Chair_Basic
Placeable_Chair_Stool
Placeable_Chair_Stool_Small
Placeable_Chair_Wood
Placeable_Clock_Basic
Placeable_Clock_Fine
Placeable_CollectionNet_Advanced
Placeable_CollectionNet_Basic
Placeable_CookingPot
Placeable_CookingStand_Food_Electric
Placeable_CookingStand_Food_One
Placeable_CookingStand_Food_Two
Placeable_CookingStand_Purifier_One
Placeable_CookingStand_Purifier_Two
Placeable_CookingStand_Smelter
Placeable_CookingStand_Smelter_Electric
Placeable_Cropplot_Grass
Placeable_Cropplot_Large
Placeable_Cropplot_Large_Tier3
Placeable_Cropplot_Medium
Placeable_Cropplot_Medium_Tier3
Placeable_Cropplot_Shoe
Placeable_Cropplot_Small
Placeable_Cropplot_Small_Tier3
Placeable_Cupboard_Large
Placeable_Cupboard_Medium
Placeable_Cupboard_Small
Placeable_Curtain_Horizontal
Placeable_Curtain_Vertical
Placeable_Cutlery
Placeable_DetailPlank
Placeable_DrawBridgeLong
Placeable_DrawBridgeShort
Placeable_Electric_Purifier
Placeable_EngineControls
Placeable_Figurine_Chicken
Placeable_Figurine_Goat
Placeable_Figurine_Llama
Placeable_FirewoodRack
Placeable_Firework
Placeable_Flag_01
Placeable_Flag_02
Placeable_Flag_03
Placeable_Flag_04
Placeable_Flag_05
Placeable_Flag_06
Placeable_Flag_07
Placeable_Flower_AloeVera
Placeable_Flower_Cactus
Placeable_Flower_Hibiscus
Placeable_Flower_Monstera
Placeable_Flower_Rose
Placeable_Flower_Sunflower
Placeable_FoundationCounter
Placeable_Fridge
Placeable_FuelTank
Placeable_GiantClam
Placeable_HonkHorn_1
Placeable_HonkHorn_2
Placeable_HonkHorn_3
Placeable_Juicer
Placeable_Lantern_Basic
Placeable_Lantern_FireBasket
Placeable_Lantern_Fireplace
Placeable_Lantern_Metal
Placeable_LuckyCat
Placeable_MajorTom
Placeable_MotivationalSign_1
Placeable_MotivationalSign_2
Placeable_MotivationalSign_3
Placeable_MotivationalSign_4
Placeable_MotorWheel
Placeable_Mug
Placeable_Nametag
Placeable_OpenBook
Placeable_Outhouse
Placeable_Painting_André
Placeable_Painting_Crafted_1
Placeable_Painting_Crafted_2
Placeable_Painting_Crafted_3
Placeable_Painting_Crafted_4
Placeable_Painting_Ellen
Placeable_Painting_Felicia
Placeable_Painting_Gabriel
Placeable_Painting_Illayda
Placeable_Painting_Petter
Placeable_Painting_Semih
Placeable_Painting_Tangaroa_1
Placeable_Painting_Tangaroa_2
Placeable_Painting_Tangaroa_3
Placeable_Painting_Tangaroa_4
Placeable_Painting_Tangaroa_5
Placeable_Painting_William
Placeable_PaintMill
Placeable_PaperBundle
Placeable_Piano
Placeable_Pipe_Fuel
Placeable_Pipe_Water
Placeable_Quill
Placeable_Radio
Placeable_Reciever
Placeable_Reciever_Antenna
Placeable_Recycler
Placeable_ResearchTable
Placeable_RhinoSharkTrophy
Placeable_Rug_Door
Placeable_Rug_Rectangle
Placeable_Rug_Round_Large
Placeable_Rug_Round_Small
Placeable_Sail
Placeable_Scarecrow
Placeable_Scarecrow_Advanced
Placeable_ScrapMechanic
Placeable_SharkTrophy
Placeable_Shelf_Large
Placeable_Shelf_Small_Basic
Placeable_Shelf_Small_Fine
Placeable_Shelf_Wood
Placeable_Sign
Placeable_Sofa
Placeable_Sofa2Seat
Placeable_Sofa3Seat
Placeable_SpiralStair
Placeable_SpiralStair_Half
Placeable_Sprinkler
Placeable_SteeringWheel
Placeable_Storage_Large
Placeable_Storage_Medium
Placeable_Storage_Small
Placeable_Streamer
Placeable_StringLight_Horizontal
Placeable_StringLight_Vertical
Placeable_Surfboard
Placeable_Table_Basic
Placeable_Table_Round
Placeable_Table_Round_Small
Placeable_Table_Sofa_Round
Placeable_Table_Sofa_Square
Placeable_Table_Square
Placeable_Table_Square_Small
Placeable_Table_Square_Tall
Placeable_TangaroaPlant_1
Placeable_TangaroaPlant_2
Placeable_TangaroaPlant_3
Placeable_TangaroaPlant_4
Placeable_TangaroaPlant_5
Placeable_TangaroaPlant_6
Placeable_Temperance_Cutlery
Placeable_Temperance_Mug
Placeable_Temperance_Painting_1
Placeable_Temperance_Painting_2
Placeable_Temperance_Painting_3
Placeable_Temperance_Plant_1
Placeable_Temperance_Plant_2
Placeable_Temperance_Plant_3
Placeable_Temperance_Rug_1
Placeable_Temperance_Rug_2
Placeable_TicTacToe
Placeable_TikiPole_Complete
Placeable_TikiPole_Feet
Placeable_TikiPole_Mid_1
Placeable_TikiPole_Mid_2
Placeable_TikiPole_Top
Placeable_ToyRobot
Placeable_ToyRobot_Golden
Placeable_Trashcan
Placeable_TrophyBoard_Large
Placeable_TrophyBoard_Medium
Placeable_TrophyBoard_Small
Placeable_Utopia_Bottle
Placeable_Utopia_DanglyDecoration_1
Placeable_Utopia_DanglyDecoration_2
Placeable_Utopia_DanglyDecoration_3
Placeable_Utopia_DanglyDecoration_4
Placeable_Utopia_DanglyDecoration_5
Placeable_Utopia_DanglyDecoration_6
Placeable_Utopia_Herb_1
Placeable_Utopia_Herb_2
Placeable_Utopia_Herb_3
Placeable_Utopia_Herb_4
Placeable_Utopia_Herb_5
Placeable_Utopia_Herb_6
Placeable_Utopia_LightBottleWhite
Placeable_Utopia_LightBottleYellow
Placeable_Utopia_Plant_1
Placeable_Utopia_Plant_2
Placeable_Utopia_Plant_3
Placeable_Wardrobe
Placeable_WaterTank
Placeable_WindTurbine
Placeable_WorldGlobe
Placeable_ZiplineBase
Placeable_Recipe
Placeable_Recipe_BBQ
Placeable_Recipe_CatfishDeluxe
Placeable_Recipe_CoconutBeat
Placeable_Recipe_CoconutChicken
Placeable_Recipe_HeadBroth
Placeable_Recipe_HeartyStew
Placeable_Recipe_Mangonana
Placeable_Recipe_MushroomOmelette
Placeable_Recipe_RedbeetShot
Placeable_Recipe_RedMelon
Placeable_Recipe_SalmonSalad
Placeable_Recipe_SharkDinner
Placeable_Recipe_SilverSmoothie
Placeable_Recipe_SimpleFishStew
Placeable_Recipe_SimpleSmoothie
Placeable_Recipe_SpicyPineberry
Placeable_Recipe_SteakWithJam
Placeable_Recipe_StrawberryColada
Placeable_Recipe_Sushi
Placeable_Recipe_VegetableSoup
Seed_Banana
Seed_Birch
Seed_Flower_Black
Seed_Flower_Blue
Seed_Flower_Red
Seed_Flower_White
Seed_Flower_Yellow
Seed_Grass
Seed_Mango
Seed_Palm
Seed_Pine
Seed_Pineapple
Seed_Strawberry
Seed_Watermelon
Arrow_Metal
Arrow_Stone
Arrow_Titanium                              <-- Best arrow
Axe
Axe_Stone
Axe_Titanium                                <-- Best axe
Binoculars
Bow
Bucket
Compass
DevSpear                                    <-- Best weapon
FishingRod
FishingRod_Metal
Hammer
Hook_Plastic
Hook_Scrap
Hook_Titanium                               <-- Best hook
Machete
MetalDetector
NetCanister
NetGun
Paddle
PaintBrush
SharkBait
Shear
Shovel
Spear_Scrap
Spear_Plank
SweepNet
Sword_Titanium
ThrowableAnchor
```

</details>

```plaintext
/give DevSpear 9999
```

## Custom Binds

| Action  | Shortcut |
| ------- | -------- |
| Paddle  | F10      |
| Console | `        |
