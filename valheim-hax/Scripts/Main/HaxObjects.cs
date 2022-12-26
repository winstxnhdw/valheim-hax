// namespace Hax;
// public class HaxObjects : HaxComponents {
//     static ObjectsCache<Network_Player> playerObjects = new ObjectsCache<Network_Player>(0.3f);
//     public static Network_Player LocalPlayerObject {
//         get {
//             foreach (Network_Player player in playerObjects.Objects) {
//                 if (player == null) continue;
//                 if (!player.IsLocalPlayer) continue;
//                 return player;
//             }

//             return null;
//         }
//     }

//     protected override void Start() {
//         base.Start();
//         HaxObjects.playerObjects.Init(this);
//     }
// }