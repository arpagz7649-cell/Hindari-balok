// --- Ini adalah kode JavaScript ---

// 1. Variabel
let skor = 0;
const kecepatan = 5;

// 2. Fungsi untuk menggerakkan objek
function gerakKanan() {
    console.log("Karakter bergerak ke kanan!");
    skor += 1; // Menambah skor setiap bergerak
}

// 3. Event Listener (Mendengar input user)
document.addEventListener("keydown", function(event) {
    if (event.key === "ArrowRight") {
        gerakKanan();
    }
});

// 4. Menampilkan pesan di konsol browser
console.log("Sistem JavaScript Aktif!");
