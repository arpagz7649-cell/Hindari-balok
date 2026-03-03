# --- Ini adalah kode Python ---

# 1. Variabel (Menyimpan data)
nama_game = "Survival Master"
skor_saat_ini = 100

# 2. Fungsi (Kumpulan perintah)
def cek_status(skor):
    if skor >= 100:
        return "Master Menang!"
    else:
        return "Terus Berjuang!"

# 3. Menampilkan hasil ke layar
print(f"Selamat Datang di {nama_game}")
hasil = cek_status(skor_saat_ini)
print(hasil)

# 4. Perulangan (Looping) sederhana
for i in range(3):
    print(f"Batu jatuh dalam... {3 - i}")
  
