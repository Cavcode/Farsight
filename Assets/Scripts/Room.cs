using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Farsight/Room")]
public class Room : ScriptableObject
{
    [TextArea]
    public string description;
    public string roomName;
    public string sound;
    public string soundTake;
    public Exit[] exits;
    public InteractableObject[] interactableObjectsInRoom;

}