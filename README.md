# SumoArenaGame

# Sumo Arena Game 🤼‍♂️

🎮 **OYNANIŞ LİNKİ (WEBGL):** https://elifyadairem.itch.io/sumo-arena

---

## 📝 Proje Açıklaması
Bu proje, **Bilgisayar Mühendisliği Oyun Programlama** dersi final ödevi kapsamında Unity Oyun Motoru ile geliştirilmiştir. Oyun, fizik tabanlı (Rigidbody) mekanikler üzerine kurulu, 3D bir Sumo arenası simülasyonudur. Amaç, rakibi platformdan aşağı itmektir.

## 🕹️ Nasıl Oynanır? (Kontroller)
Oyun klavye üzerinden oynanmaktadır.

###  Oyuncu 
* **Hareket:** `W`, `A`, `S`, `D` Tuşları
* **Dash (Hızlı Saldırı):** `Sol Shift`
* **Zıplama:** `Space`

###  Rakip 
* **Hareket:** `Yön Tuşları` (Oklar)
* **Dash (Hızlı Saldırı):** `Sağ Shift`
* **Zıplama:** `Enter` (Return)

---

## ⚙️ Teknik Özellikler ve Kurallar
Proje, ödev isterlerine uygun olarak şu mekanikleri içermektedir:

1.  **4 Farklı Aksiyon:** Her iki karakter de ileri-geri Hareket,Sağ-SolHareket, Dash Atma ve Zıplama  yeteneklerine sahiptir.
2.  **Fizik Tabanlı Etkileşim:** `Rigidbody`, `AddForce` ve `Physics Materials` kullanılarak gerçekçi çarpışma ve sekme efektleri oluşturulmuştur.
3.  **UI ve Menü Sistemi:**
    * **Ana Menü:** Oyunu Başlat, Çıkış, Ses Ayarları.
    * **Pause Menüsü:** Oyun içi durdurma ve devam etme.
4.  **Game Loop:** Karakterlerden biri düştüğünde `GameManager` bunu algılar ve oyunu yeniden başlatır (veya menüye döner).


## 📦 Kullanılan Varlıklar (Assets)
* **Oyun Motoru:** Unity 2022.x
* **Modeller:** Unity Primitives (Sphere, Cube) 


---

**Geliştirici:** Elif İrem Şahin
