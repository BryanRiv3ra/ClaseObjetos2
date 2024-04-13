using ClaseObjetos2.ClaseHija;
Nintendo nintendo = new Nintendo();
nintendo.aniolanzamiento = 2017;
nintendo.esPortable = true;
nintendo.marca = "switch";
Console.WriteLine(nintendo.MostrarDeatallesNintendo());

//Playstation
Playstation ps = new Playstation();
ps.marca = "play station 1";
ps.aniolanzamiento = 1994;
ps.modelocontrolador = "dualsense";
Console.WriteLine($"{ps.mostrardetalleplay()}");

//Xbox 

Xbox xb = new Xbox();
xb.marca = "xbox 360";
xb.aniolanzamiento = 2005;
xb.movivimiento = "kinecnkt";
Console.WriteLine($"{xb.mostrardetalleXbox()}");

//Dreamcast
SegaDreamcast sega = new SegaDreamcast();
sega.marca = "Dreamcast";
sega.aniolanzamiento = 1998;
sega.compatibilidad = "compatibilidad";
Console.WriteLine($"{sega.mostrardetallesdreamcast()}");

