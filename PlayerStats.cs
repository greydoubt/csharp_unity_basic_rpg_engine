using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    // The player's attributes
    public int wisdom = 1;
    public int intelligence = 1;
    public int strength = 1;
    public int dexterity = 1;
    public int luck = 1;
    public int faith = 1;
    public int stamina = 10;

    // The player's experience points and level
    public int experiencePoints = 0;
    public int level = 1;

    // The amount of experience points required for the player to level up
    public int experiencePointsPerLevel = 100;

    // Increases the player's experience points and levels up if necessary
    public void GainExperience(int amount)
    {
        experiencePoints += amount;

        if (experiencePoints >= experiencePointsPerLevel)
        {
            experiencePoints -= experiencePointsPerLevel;
            level++;

            // Increase the player's attributes based on their new level
            wisdom += 1;
            intelligence += 1;
            strength += 2;
            dexterity += 2;
            luck += 1;
            faith += 1;
            stamina += 5;

            // Increase the experience points required for the next level
            experiencePointsPerLevel += level * 100;
        }
    }
}
