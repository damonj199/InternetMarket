using InternetMarket;

Smartphone samsung = new Smartphone() { };
samsung.Category = "smartphone";
samsung.Model = "Samsung S 23 Ultra";
samsung.Camera = 45.0;
samsung.Price = 112000;
samsung.Diagonal = 7.4;
samsung.Memory = 256;

samsung.DoInf();
samsung.DoAddPrice(samsung.Category);

Smartphone iphon = new Smartphone() { };
iphon.Category = "smartphone";
iphon.Model = "13 Pro";
iphon.Camera = 44.0;
iphon.Price = 97000;
iphon.Diagonal = 7.4;
iphon.Memory = 256;

iphon.DoInf();
iphon.DoAddPrice(iphon.Category);

Laptop lenovo = new Laptop() { };
lenovo.Category = "laptop";
lenovo.Model = "IdeaPad 5";
lenovo.Akkum = 7.5;
lenovo.Diagonal = 15.6;
lenovo.Price = 64454;
lenovo.Memory = 512;

lenovo.DoInf();
lenovo.DoAddPrice(lenovo.Category);