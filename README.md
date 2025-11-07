# 🎨 Colour Switch Prototipi

> Unity ve C# kullanılarak geliştirilen, popüler mobil oyun "Colour Switch"in temel mekaniklerini içeren bir prototip.

![Oynanış GIF'i](https://github.com/user-attachments/assets/6f5dc69d-0eb1-4133-8f8a-1b0469abc51b)

---

## 🎮 Oynanış

Oyunun temel amacı, bir topu sürekli zıplatarak, dönen veya hareket eden engellerin arasından geçirmektir. Kural basittir: **Top, sadece kendi rengindeki objelere temas edebilir.**

* **Zıplama:** Topu havada tutmak ve zıplatmak için ekrana/fareye tıklayın.
* **Engeller:** Her engel, topun geçebileceği (topla aynı renkte) ve geçemeyeceği (farklı renkte) segmentlere ayrılmıştır.
* **Renk Değiştirme:** Top, belirli noktalardaki "renk değiştirici" objelere çarptığında yeni bir renk alır ve bir sonraki engele bu yeni renkle meydan okur.
* **Puan:** Yol üzerindeki yıldızları toplayarak puan kazanılır.

## ✨ Temel Özellikler

* **Fizik Tabanlı Top Kontrolü:** Basit ve "dokun-zıplat" (tap-to-jump) mekaniği.
* **Dinamik Engeller:** Kendi etrafında dönen (`CemberDonus.cs`) çeşitli engel türleri.
* **Renk Mekaniği:** Topun ve engellerin renklerini karşılaştıran çarpışma sistemi (`TopKOntrol.cs`).
* **Prosedürel Seviye (Desteği):** Yeni engelleri ve objeleri oyun ilerledikçe oluşturan temel bir yapı (`BolumOlusturucu.cs`).

## 🛠️ Kullanılan Teknolojiler

* **Oyun Motoru:** **Unity 2D**
* **Programlama Dili:** **C#**

## 🚀 Projeyi Çalıştırma

Bu depoyu Unity'de açmak için:

1.  Depoyu klonlayın: `git clone https://github.com/Nightbold/Colour-Switch.git`
2.  Unity Hub'ı açın.
3.  "Add project from disk" (Disk'ten proje ekle) seçeneğini kullanın ve klonladığınız `Colourswitch` klasörünü seçin.
4.  Unity, proje ayarlarını ve `Library` klasörünü otomatik olarak yeniden oluşturacaktır.

## 👤 Geliştirici

* **Mehmet [Soyadını buraya yaz]** - ([@Nightbold](https://github.com/Nightbold))
