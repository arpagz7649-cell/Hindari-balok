<?php
/* SYSTEM: MASTER BACKEND CORE 
   Bahasa: PHP (Hypertext Preprocessor)
*/

// 1. Data Pemain
$user_name = "Master";
$level = 10;
$inventory = ["Pedang", "Perisai", "Ramuan"];

// 2. Fungsi Logika
function check_power_level($lvl) {
    if ($lvl > 5) {
        return "Master sangat kuat!";
    } else {
        return "Butuh latihan lagi.";
    }
}

// 3. Menampilkan Output ke HTML
echo "<h1>Profil Pemain</h1>";
echo "Nama: " . $user_name . "<br>";
echo "Status: " . check_power_level($level) . "<br>";

// 4. Perulangan untuk Item
echo "<h3>Inventory:</h3><ul>";
foreach ($inventory as $item) {
    echo "<li>" . $item . "</li>";
}
echo "</ul>";
?>
