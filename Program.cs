using DesafioPOO.Models;

//Instanciar as classes Nokia e Iphone
Nokia smartphoneNokia = new Nokia("7199999-9999","Nokia N12","abcdefg123",32);
Iphone smartphoneIphone = new Iphone("1199999-9999","Iphone 11","hlmnop987",64);
//Usar os métodos da classe Nokia
smartphoneNokia.Ligar();
smartphoneNokia.ReceberLigacao();
smartphoneNokia.InstalarAplicativo("Telegram");
//Usar os métodos da classe Iphone
smartphoneIphone.Ligar();
smartphoneIphone.ReceberLigacao();
smartphoneIphone.InstalarAplicativo("WhatsApp");