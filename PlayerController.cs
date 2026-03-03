// --- Ini adalah kode C# ---
using System;

public class KarakterGame {
    // 1. Variabel (Properti)
    public string nama = "Master";
    public int health = 100;

    // 2. Fungsi (Method)
    public void Serang() {
        Console.WriteLine(nama + " melancarkan serangan!");
    }
}

class Program {
    static void Main() {
        KarakterGame pemain = new KarakterGame();
        pemain.Serang();
        Console.WriteLine("HP Saat Ini: " + pemain.health);
    }
}
