using System;

namespace SurvivalGame {
    public class PlayerManager {
        // Properti Pemain
        private string playerName = "Master";
        private int health = 100;
        private int currentScore = 0;
        private int level = 1;

        public void StartGame() {
            Console.WriteLine("Memulai Sistem Game untuk: " + playerName);
            UpdateStatus();
        }

        public void TakeDamage(int damage) {
            health -= damage;
            if (health <= 0) {
                GameOver();
            } else {
                Console.WriteLine("Master terkena serangan! Sisa HP: " + health);
            }
        }

        public void AddScore(int points) {
            currentScore += points;
            Console.WriteLine("Skor bertambah: " + currentScore);
            
            // Logika Level Up setiap 100 poin
            if (currentScore >= level * 100) {
                LevelUp();
            }
        }

        private void LevelUp() {
            level++;
            health = 100; // Reset HP saat naik level
            Console.WriteLine("SELAMAT! Naik ke Level: " + level);
        }

        private void GameOver() {
            Console.WriteLine("GAME OVER! Skor Akhir Master: " + currentScore);
        }

        private void UpdateStatus() {
            Console.WriteLine("--- Status Saat Ini ---");
            Console.WriteLine("HP: " + health + " | Level: " + level);
        }
    }
}
