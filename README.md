# CustomerOrders MVC Projesi

Bu proje, müşteri ve sipariş bilgilerini görüntülemek için bir ASP.NET MVC uygulaması geliştirme örneğidir. MVC (Model-View-Controller) tasarım deseni takip edilmiştir.

---

## **Proje Yapısı**

Proje/ ├── Controllers/ │ └── CustomerOrdersController.cs ├── Models/ │ ├── Customer.cs │ ├── Order.cs │ └── CustomerOrderViewModel.cs ├── Views/ │ ├── CustomerOrders/ │ │ └── Index.cshtml ├── wwwroot/ │ └── (Statik dosyalar: CSS, JS, görseller) └── Program.cs


---

## **Özellikler**
- **Modeller:**
  1. `Customer`:  
     - Müşteri bilgilerini tutar (ID, Ad, Soyad, E-posta).
  2. `Order`:  
     - Sipariş bilgilerini içerir (ID, Ürün Adı, Fiyat, Miktar).
  3. `CustomerOrderViewModel`:  
     - `Customer` ve `Order` nesnelerini birleştirerek view'da kullanıma hazır hale getirir.

- **Controller:**  
  - `CustomerOrdersController`:  
    - İş mantığını yönetir.  
    - Örnek müşteri ve sipariş bilgileri oluşturur ve bunları view'a iletir.

- **View:**  
  - `Index.cshtml`:  
    - Müşteri bilgilerini ve sipariş listesini görüntüler.

--
