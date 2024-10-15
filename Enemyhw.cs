using System;
using System.Reflection;
class Enemy_Encounters {
    static void Main (string[] args) {
        // Set Up Character:
        // Define and initialize variables for character stats (e.g., HP, attack, defense). 
        int characterHealth = 100;
        int characterAttack = 20;
        int characterDefense = 10;

        // Define Enemy Stats with Arrays:
        // Use arrays to store enemy HP, attack, and defense values.
        int[] enemyHealth = { 30, 40, 50 };
        int[] enemyAttack = { 10, 15, 20 };
        int[] enemyDefense = { 5, 7, 10 };

        // Loop through each enemy encounter
        for (int i = 0; i < enemyHealth.Length; i++)
        {
            Console.WriteLine($"Enemy Encounter {i + 1}: Enemy {i + 1} appears!");
            
            // Battle continues as long as both character and enemy are alive
            while (characterHealth > 0 && enemyHealth[i] > 0)
            {
                // Character attacks enemy
                int enemyDamage = characterAttack - enemyDefense[i];
                enemyHealth[i] -= enemyDamage;

                Console.WriteLine($"You attack the enemy for {enemyDamage} damage. Enemy Health is now {enemyHealth[i]}.");

                // Check if the enemy is defeated
                if (enemyHealth[i] <= 0)
                {
                    Console.WriteLine($"Enemy defeated!");
                    break;
                }

                // Enemy attacks character
                int characterDamage = enemyAttack[i] - characterDefense;
                characterHealth -= characterDamage;
                Console.WriteLine($"The enemy attacks you for {characterDamage} damage. Your Health is now {characterHealth}.");

                // Check if the character is defeated
                if (characterHealth <= 0)
                {
                    Console.WriteLine("Your character has been defeated!");
                    break;
                }
            }

            // If the character is defeated, exit the loop
            if (characterHealth <= 0)
            {
                Console.WriteLine("Game Over! You were defeated by the enemy!");
                break;
            }
        }

        // If the character survives all encounters
        if (characterHealth > 0)
        {
            Console.WriteLine("Congratulations! You have defeated the enemy!");
        }
    }
}