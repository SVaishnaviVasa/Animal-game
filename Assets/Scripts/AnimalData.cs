using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Animal
{
    public string name;
    public bool isFlying;
    public bool isInsect;
    public bool isOmnivorous;
    public bool livesInGroup;
    public bool laysEggs;
    public string description; 
}

[CreateAssetMenu(fileName = "New Animal Data", menuName = "Animal Data", order = 51)]
public class AnimalData : ScriptableObject
{
    public List<Animal> animals;
}

