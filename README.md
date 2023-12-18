# The Lost Fireboy
<h1 align="center">PEMROGRAMAN GAME</h1>
<h3 align="center">The Lost Fireboy BASED ON DESKTOP APPLICATION</h3>

## Kelompok 1 :
- Muhammad Zaidan Fahmi 21050974033
- Muhammad Rafif Rais		21050974027
- Himmati Kairova 	21050974060

## Deskripsi :
The Lost Fireboy merupakan sebuah game adventure yang dibuat untuk memberikan layanan penyimpanan bagi siswa maupun guru dalam menunjang kegiatan akademik di sekolah sesuai dengan kebutuhan yang dibutuhkan dimana hanya pengguna mempunyai akun saja yang dapat mengakses, sehingga data-data akan lebih aman.

## Fitur :
- Pengguna dapat menambahkan file ke next cloud
- Pengguna dapat memindahkan file ke next cloud 
- Pengguna dapat menghapus file next cloud 
- Berbagi secara online di internet (melakukan file sharing kepada user lain dan juga dapat sharing melalui tautan)
- Pengguna dapat membuka dokumen secara langsung tanpa mengunduhnya.

## Tools
Game ini dibangu menggunakan : 
- Laptop Client 
- Mouse 
- Keyboard 
- Unity
- C#
- Visual Studio IDE

## Langkah-langkah : 
### Bahan :
   - Nextcloud : [nextcloud](https://download.nextcloud.com/)
   - Oracle VM Virtual Box : [virtual box](https://www.virtualbox.org/wiki/Downloads)
     
### Tahap Konfigurasi Penyimpanan Awan
Pada tahapan konfigurasi penyimpanan awan kami menggunakan nextcloud pada linux ubuntu yang dijalankan melalui virtual machine agar sistem penyimpanan bisa diakses melalui jaringan internet atau public.

  #### A. Konfigurasi Router Indihome 
   1. Masuk ke pengaturan router Indihome dengan mengakses alamat IP router melalui browser
      ![image](image/image1.png)
   2. Selanjutnya masuk ke menu Application kemudian pilih Port Forwarding
      ![image](image/image2.png)
   3. Selanjutnya centang kolom enable agar port aktif. Kemudian isi kolom Name sesuai dengan kebutuhan, Pada kolom Protocol pilih TCP. Pada WAN Port Start dan WAN Port End isi dengan angka 80. Pada LAN Host IP Address isi dengan alamat IP Server nextcloud, kemudian pada LAN Port Start dan LAN Port End isi dengan angka 80, kemudian klik Add.
      ![image](image/image3.png)
  #### B. Konfigurasi DNS menggunakan No-IP
   1. Buka situs www.noip.com melalui browser. Kemudian masuk dengan akun yang telah didaftarkan.
      ![image](image/image4.png)
   2. Pilih menu Dynamic DNS, kemudian pilih No-IP Hostnames. Kemudian klik Create Hostname untuk membuat hostname baru.
      ![image](image/image5.png)
   3. Isi Hostname dan pilih Domain yang tersedia, disini kami memilih domain sytes.net. Pada IPv4 Address secara otomatis membaca IP Public Jaringan yang kami gunakan, jika sudah klik Create Hostname.
      ![image](image/image6.png)
   4. Setelah melakukan konfigurasi, sistem penyimpanan awan yang sudah dibuat sekarang dapat diakses di luar jaringan lokal melalui jaringan internet dengan cara mengakses suncloud.sytes.net melalui browser.
      ![image](image/image7.png)



## Kesimpulan
Implementasi penyimpanan awan menggunakan Nextcloud pada mesin virtual di bidang pendidikan adalah langkah yang bermanfaat dan relevan. Hal ini memungkinkan akses data yang mudah, kolaborasi yang lebih baik, dan manajemen data yang lebih efisien.   Dengan demikian, teknologi ini memiliki potensi untuk memperkaya pengalaman pendidikan dan memungkinkan lembaga pendidikan untuk mengoptimalkan sumber daya mereka.


##### Sistem ini disusun oleh :
 > M Zaidan Fahmi 043 | 
 > M Rafif Rais 027 |
 > Himmati Kairova 060 
##### 🌐[S1 Pendidikan Teknologi Informasi UNESA](https://pendidikan-ti.ft.unesa.ac.id/)
