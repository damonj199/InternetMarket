using InternetMarket;

SmartphoneElectronics samsung = new SmartphoneElectronics() { };
samsung.Category = "smartphone";
samsung.Model = "Samsung S 23 Ultra";
samsung.Camera = 45.0;
samsung.Price = 112000;
samsung.Diagonal = 7.4;
samsung.Memory = 256;

samsung.DoInf();
samsung.DoAddPrice(samsung.Category);

SmartphoneElectronics iphon = new SmartphoneElectronics() { };
iphon.Category = "smartphone";
iphon.Model = "13 Pro";
iphon.Camera = 44.0;
iphon.Price = 97000;
iphon.Diagonal = 7.4;
iphon.Memory = 256;

iphon.DoInf();
iphon.DoAddPrice(iphon.Category);

LaptopElectronics lenovo = new LaptopElectronics() { };
lenovo.Category = "laptop";
lenovo.Model = "IdeaPad 5";
lenovo.Akkum = 7.5;
lenovo.Diagonal = 15.6;
lenovo.Price = 65454;
lenovo.Memory = 512;

lenovo.DoInf();
lenovo.DoAddPrice(lenovo.Category);