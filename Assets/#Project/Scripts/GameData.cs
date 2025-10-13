using UnityEngine;

[CreateAssetMenu(fileName = "GameData", menuName = "Game Design/GameData")]
public class GameData : ScriptableObject
{
    [field: SerializeField] public PlayerData Player{ get; private set; }
    [field: SerializeField] public  float CameraDecal {get; private set;} = -3f;
    
}
