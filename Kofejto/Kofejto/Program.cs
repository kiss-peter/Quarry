using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Console = Colorful.Console;


namespace Kofejto
{
    class Program
    {



        static WMPLib.WindowsMediaPlayer Player;

        static private void PlayFile(String url)
        {
            Player = new WMPLib.WindowsMediaPlayer();
            Player.PlayStateChange +=
                new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(Player_PlayStateChange);
            Player.MediaError +=
                new WMPLib._WMPOCXEvents_MediaErrorEventHandler(Player_MediaError);
            Player.URL = url;
            Player.controls.play();
        }

        static private void Form1_Load(object sender, System.EventArgs e)
        {
            // TODO  Insert a valid path in the line below.
            PlayFile(@"C:\Users\KZ\Downloads\sweden.mp3");
        }

        static private void Player_PlayStateChange(int NewState)
        {
            if ((WMPLib.WMPPlayState)NewState == WMPLib.WMPPlayState.wmppsStopped)
            {

            }
        }

        static private void Player_MediaError(object pMediaObject)
        {

        }



















        static void UtesAnimacioKo()
        {

            Console.Clear();
            string path = System.IO.Path.GetDirectoryName(
            System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            path = path.Substring(6);
            var path2 = path + "\\stone1.mp3";
            var path3 = path + "\\stone2.mp3";
            var path4 = path + "\\stone3.mp3";
            var path5 = path + "\\stone4.mp3";
            PlayFile(path2);
            Szines(" ■■■■■■■■■", Color.Gray); Szines2("             ■■■■■■■■■", Color.Khaki);
            Szines2("     |                 ■■■■■■■■■ ", Color.Khaki);
            Szines2("     |                 ■■■■■■■■■ ", Color.Khaki);
            Szines2("     |                 ■■■■■■■■■ ", Color.Khaki);
            Szines2("     |             ", Color.Khaki);
            Sleep(500);
            PlayFile(path3);
            Console.Clear();
            Szines("      ■■■■■■■■■", Color.Gray); Szines2("        ■■■■■■■■■ ", Color.Khaki);
            Szines2("          |            ■■■■■■■■■ ", Color.Khaki);
            Szines2("          |            ■■■■■■■■■ ", Color.Khaki);
            Szines2("          |            ■■■■■■■■■ ", Color.Khaki);
            Szines2("          |             ", Color.Khaki);
            Sleep(500);
            PlayFile(path4);
            Console.Clear();
            Szines("           ■■■■■■■■■", Color.Gray); Szines2("   ■■■■■■■■■ ", Color.Khaki);
            Szines2("               |       ■■■■■■■■■ ", Color.Khaki);
            Szines2("               |       ■■■■■■■■■ ", Color.Khaki);
            Szines2("               |       ■■■■■■■■■ ", Color.Khaki);
            Szines2("               |             ", Color.Khaki);
            Sleep(500);
            PlayFile(path5);
            Console.Clear();
            Szines("                ■■■■■■■■■", Color.Gray); Szines2("   ■■■■ ", Color.Khaki);
            Szines2("                    |      ■■■■■ ", Color.Khaki);
            Szines2("                    |     ■■■■■■ ", Color.Khaki);
            Szines2("                    |    ■■■■■■■ ", Color.Khaki);
            Szines2("                    |             ", Color.Khaki);
            Sleep(500);
            PlayFile(path5);
            Console.Clear();
            Szines2("                        ■■■■■■■■■", Color.Gray);
            Szines2("                            |    ", Color.Khaki);
            Szines2("                            |    ", Color.Khaki);
            Szines2("                            |    ", Color.Khaki);
            Szines2("                            |    \n\n", Color.Khaki);
            Sleep(500);
        }

        static void UtesAnimacioVas()
        {
            Console.Clear();
            Szines(" ■■■■■■■■■", Color.LightGray); Szines2("             ■■■■■■■■■", Color.Khaki);
            Szines2("     |                 ■■■■■■■■■ ", Color.Khaki);
            Szines2("     |                 ■■■■■■■■■ ", Color.Khaki);
            Szines2("     |                 ■■■■■■■■■ ", Color.Khaki);
            Szines2("     |             ", Color.Khaki);
            Sleep(400);
            Console.Clear();
            Szines("      ■■■■■■■■■", Color.LightGray); Szines2("        ■■■■■■■■■ ", Color.Khaki);
            Szines2("          |            ■■■■■■■■■ ", Color.Khaki);
            Szines2("          |            ■■■■■■■■■ ", Color.Khaki);
            Szines2("          |            ■■■■■■■■■ ", Color.Khaki);
            Szines2("          |             ", Color.Khaki);
            Sleep(400);
            Console.Clear();
            Szines("           ■■■■■■■■■", Color.LightGray); Szines2("   ■■■■■■■■■ ", Color.Khaki);
            Szines2("               |       ■■■■■■■■■ ", Color.Khaki);
            Szines2("               |       ■■■■■■■■■ ", Color.Khaki);
            Szines2("               |       ■■■■■■■■■ ", Color.Khaki);
            Szines2("               |             ", Color.Khaki);
            Sleep(400);
            Console.Clear();
            Szines("                ■■■■■■■■■", Color.LightGray); Szines2("   ■■■■ ", Color.Khaki);
            Szines2("                    |      ■■■■■ ", Color.Khaki);
            Szines2("                    |     ■■■■■■ ", Color.Khaki);
            Szines2("                    |    ■■■■■■■ ", Color.Khaki);
            Szines2("                    |             ", Color.Khaki);
            Sleep(400);
            Console.Clear();
            Szines2("                        ■■■■■■■■■", Color.LightGray);
            Szines2("                            |    ", Color.Khaki);
            Szines2("                            |    ", Color.Khaki);
            Szines2("                            |    ", Color.Khaki);
            Szines2("                            |    \n\n", Color.Khaki);
            Sleep(400);
        }

        static void UtesAnimacioGyemant()
        {
            Console.Clear();
            Szines(" ■■■■■■■■■", Color.DeepSkyBlue); Szines2("             ■■■■■■■■■", Color.Khaki);
            Szines2("     |                 ■■■■■■■■■ ", Color.Khaki);
            Szines2("     |                 ■■■■■■■■■ ", Color.Khaki);
            Szines2("     |                 ■■■■■■■■■ ", Color.Khaki);
            Szines2("     |             ", Color.Khaki);
            Sleep(300);
            Console.Clear();
            Szines("      ■■■■■■■■■", Color.DeepSkyBlue); Szines2("        ■■■■■■■■■ ", Color.Khaki);
            Szines2("          |            ■■■■■■■■■ ", Color.Khaki);
            Szines2("          |            ■■■■■■■■■ ", Color.Khaki);
            Szines2("          |            ■■■■■■■■■ ", Color.Khaki);
            Szines2("          |             ", Color.Khaki);
            Sleep(300);
            Console.Clear();
            Szines("           ■■■■■■■■■", Color.DeepSkyBlue); Szines2("   ■■■■■■■■■ ", Color.Khaki);
            Szines2("               |       ■■■■■■■■■ ", Color.Khaki);
            Szines2("               |       ■■■■■■■■■ ", Color.Khaki);
            Szines2("               |       ■■■■■■■■■ ", Color.Khaki);
            Szines2("               |             ", Color.Khaki);
            Sleep(300);
            Console.Clear();
            Szines("                ■■■■■■■■■", Color.DeepSkyBlue); Szines2("   ■■■■ ", Color.Khaki);
            Szines2("                    |      ■■■■■ ", Color.Khaki);
            Szines2("                    |     ■■■■■■ ", Color.Khaki);
            Szines2("                    |    ■■■■■■■ ", Color.Khaki);
            Szines2("                    |             ", Color.Khaki);
            Sleep(300);
            Console.Clear();
            Szines2("                        ■■■■■■■■■", Color.DeepSkyBlue);
            Szines2("                            |    ", Color.Khaki);
            Szines2("                            |    ", Color.Khaki);
            Szines2("                            |    ", Color.Khaki);
            Szines2("                            |    \n\n", Color.Khaki);
            Sleep(300);
        }




        static void Szines2(string szoveg, Color szin)
        {
            Console.ForegroundColor = szin;
            Console.WriteLine(szoveg);
            Console.ForegroundColor = Color.White;
        }

        static void Szines(string szoveg, Color szin)
        {
            Console.ForegroundColor = szin;
            Console.Write(szoveg);
            Console.ForegroundColor = Color.White;
        }

        static void Szines(int szoveg, Color szin)
        {
            Console.ForegroundColor = szin;
            Console.Write(szoveg);
            Console.ForegroundColor = Color.White;
        }

        static void Szines(double szoveg, Color szin)
        {
            Console.ForegroundColor = szin;
            Console.Write(szoveg);
            Console.ForegroundColor = Color.White;
        }

        static int Drop()
        {
            Random rnd = new Random();
            int drop = rnd.Next(0, 25);
            int[] esely = { 0, 0, 0, 0, 1, 1, 1, 2, 2, 3, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 };
            switch (esely[drop])
            {
                case 0:
                    Console.Write("Kaptál egy fát ");
                    Szines2("(16% esély)", Color.Aqua);
                    break;
                case 1:
                    Console.Write("Kaptál egy követ ");
                    Szines2("(12% esély)", Color.Aqua);
                    break;
                case 2:
                    Console.Write("Kaptál egy vasat ");
                    Szines2("(8% esély)", Color.Aqua);
                    break;
                case 3:
                    Console.Write("Kaptál egy gyémántot ");
                    Szines2("(4% esély)", Color.Aqua);
                    break;
                case 4:
                    Console.Write("Kaptál egy kis bitcoint ");
                    Szines2("(60% esély)", Color.Aqua);
                    break;
            }
            return esely[drop];

        }

        static long Jelen()
        {
            long jelenlegiIdo = DateTime.Now.Hour * 3600000 + DateTime.Now.Minute * 60000 + DateTime.Now.Second * 1000 + DateTime.Now.Millisecond;
            return jelenlegiIdo;
        }
        static int GeneralIdo()
        {
            Random rnd = new Random();
            int utesIdo = rnd.Next(1, 4);
            return utesIdo * 1000;
        }

        static int Sebzes(int alsoHatar, int felsoHatar)
        {
            Random rnd = new Random();
            int sebzes = rnd.Next(alsoHatar, felsoHatar + 1);
            return sebzes;

        }
        static void Sleep(int x)
        {
            System.Threading.Thread.Sleep(x);
        }


        static void Main(string[] args)
        {

            string path = System.IO.Path.GetDirectoryName(
            System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            path = path.Substring(6);
            var path2 = path + "\\sweden.mp3";

            PlayFile(path2);
            Console.WriteLine("Üdvözöllek a Kőfejtő nevezetű játékban.\nA játékban a SPACE billentyű segítségével, adott időközönként (1-3 mp, ne próbáld meg hamarabb) kiüthetsz egy blokkot,  ami dobhat: fát, követ, vasat, gyémántot, illetve bitcoint.\nEzekből a nyersanyagokból tudsz különböző dolgokat craftolni, illetve fejleszteni.\nAz inventory az I-vel nyitható meg, a craft menü a C-vel ,ez a bevezető, pedig a H-val.\nZenét készítette: C418\n");
            Sleep(1000);
            int vegSebzes;
            int regielet = 100;
            int koElet = 100;
            int utesSzamlalo = 0;
            int lvl = 1;
            Console.ForegroundColor = Color.White;

            Console.SetWindowSize(50, 25);

            int[] csakany1Recept = new int[4]; csakany1Recept[0] = 2; csakany1Recept[1] = 3; csakany1Recept[2] = 0; csakany1Recept[3] = 0; // 2 fa, 3 kő
            int[] csakany2Recept = new int[4]; csakany2Recept[0] = 2; csakany2Recept[1] = 3; csakany2Recept[2] = 3; csakany2Recept[3] = 0; // 2 fa, 3 kő, 3 vas
            int[] csakany3Recept = new int[4]; csakany3Recept[0] = 2; csakany3Recept[1] = 3; csakany3Recept[2] = 3; csakany3Recept[3] = 3; // 2 fa, 3 kő, 3 vas, 3 gyémánt

            int[] inv = { 0, 0, 0, 0, 0 };


            Item csakany0 = new Item(0, 30, "Kezdő kőcsákány");
            Item csakany1 = new Item(1, 80, csakany1Recept, "Erős kőcsákány");
            Item csakany2 = new Item(2, 200, csakany2Recept, "Vascsákány");
            Item csakany3 = new Item(3, 800, csakany3Recept, "Gyémántcsákány");


            Item jelenlegiItem = csakany0;

            while (true)
            {

                ConsoleKeyInfo key;
                long kezdesiIdo = Jelen();
                double utesido = GeneralIdo();
                Console.Write(inv[0]);
                Szines(" fa ", Color.RosyBrown);
                Console.Write(inv[1]);
                Szines(" kő ", Color.Gray);
                Console.Write(inv[2]);
                Szines(" vas ", Color.LightGray);
                Console.Write(inv[3]);
                Szines(" gyémánt ", Color.DeepSkyBlue);
                Console.Write(" --- " + inv[4]);
                Szines(" bitcoin", Color.Orange);
                System.Console.WriteLine("\n");
                Console.Write("Következő ütésig még ");
                Szines(utesido / 1000, Color.Yellow);
                Console.Write(" mp kell          ");
                Szines("Ütésszámláló: ", Color.White);
                Szines(utesSzamlalo, Color.RoyalBlue);

                Szines("          Szint: ", Color.White);
                Szines(lvl, Color.RoyalBlue);

                Szines("          Help: ", Color.White);
                Szines("'H' ", Color.RoyalBlue);

               // Szines("          Zene: ", Color.White);
               // Szines("'Z' ", Color.RoyalBlue);



                bool[] crafte = { false, false, false, false, false, false, false, false, false, false, false, false };

                // ~  + Math.Round(utesido, 2) / 1000 + " mp");
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.Spacebar || key.Key == ConsoleKey.Tab)
                {
                    utesSzamlalo++;
                    long leutosIdo = Jelen();
                    long kulonbseg = leutosIdo - kezdesiIdo;

                    if (kulonbseg > GeneralIdo())
                    {
                        if (jelenlegiItem == csakany0 || jelenlegiItem == csakany1)
                            UtesAnimacioKo();
                        if (jelenlegiItem == csakany2)
                            UtesAnimacioVas();
                        if (jelenlegiItem == csakany3)
                            UtesAnimacioGyemant();



                        vegSebzes = Sebzes(Convert.ToInt32(jelenlegiItem.sebzes * 0.8), Convert.ToInt32(jelenlegiItem.sebzes * 1.2));

                        Console.Write("\nKomolyat rásóztál. ");
                        Szines(vegSebzes, Color.Red);
                        Console.Write("-t sebeztél\n");
                        int ind = Drop();
                        Random rndBit = new Random();
                        int bitcoinDrop = rndBit.Next(1, 3);
                        inv[ind] = inv[ind] + bitcoinDrop;

                        koElet = koElet - vegSebzes;
                        if (koElet > 0)
                        {
                            Console.Write("Viszont a kő még stabil. Üsd tovább, még van ");
                            Szines(koElet, Color.Green);
                            Console.Write(" élete\n\n");
                        }
                        else
                        {
                            Random rnd = new Random();

                            int ujelet = rnd.Next(regielet + 100, regielet + 120);
                            lvl++;
                            rndBit = new Random();
                            Console.Write("Hűha! Széjjel csaptál egy követ. Jöjjön a következő, egy kicsit több élettel." + " Az új kő élete: ");
                            Szines(ujelet, Color.Green);
                            System.Console.WriteLine();
                            ind = Drop();
                            bitcoinDrop = rnd.Next(1, 3);
                            inv[ind] = inv[ind] + bitcoinDrop;
                            System.Console.WriteLine();
                            koElet = ujelet;
                            regielet = koElet;
                        }


                    }
                    else
                    {
                        Console.Clear();
                        Szines2("Túl hamar ütöttél. Büntetésül várj még 10 másodpercet. Aztán kilép a játék. Elveszett az állásod :( Legközelebb szabály szerint játszál.", Color.Red);
                        var path3 = path + "\\death.mp3";
                        PlayFile(path3);
                        Sleep(10000);
                        Environment.Exit(0);
                    }

                }
                else if (key.Key == ConsoleKey.I)
                {
                    Console.Clear();
                    Console.Write(inv[0]);
                    Szines(" fa ", Color.RosyBrown);
                    Console.Write(inv[1]);
                    Szines(" kő ", Color.Gray);
                    Console.Write(inv[2]);
                    Szines(" vas ", Color.LightGray);
                    Console.Write(inv[3]);
                    Szines(" gyémánt ", Color.DeepSkyBlue);
                    Console.Write(" --- " + inv[4]);
                    Szines(" bitcoin", Color.Orange);
                    Szines("   Craft: 'C' billentyű\n", Color.Yellow);
                }
                else if (key.Key == ConsoleKey.H)
                {
                    Console.Clear();
                    Console.WriteLine("Üdvözöllek a Kőfejtő nevezetű játékban.\nA játékban a SPACE billentyű segítségével, adott időközönként (1-3 mp, ne próbáld meg hamarabb) kiüthetsz egy blokkot,  ami dobhat: fát, követ, vasat, gyémántot, illetve bitcoint.\nEzekből a nyersanyagokból tudsz különböző dolgokat craftolni, illetve fejleszteni.\nAz inventory az I-vel nyitható meg, a craft menü a C-vel ,ez a bevezető, pedig a H-val.\n");

                }
                else if (key.Key == ConsoleKey.Z)
                {

                    PlayFile(@"C:\Users\KZ\Downloads\death.mp3");

                    Console.Clear();

                }
                else if (key.Key == ConsoleKey.C)
                {
                    while (true)
                    {

                        CraftSystem:

                        Console.Clear();
                        Console.Write(inv[0]);
                        Szines(" fa ", Color.RosyBrown);
                        Console.Write(inv[1]);
                        Szines(" kő ", Color.Gray);
                        Console.Write(inv[2]);
                        Szines(" vas ", Color.LightGray);
                        Console.Write(inv[3]);
                        Szines(" gyémánt ", Color.DeepSkyBlue);
                        Console.Write(" --- " + inv[4]);
                        Szines(" bitcoin", Color.Orange);
                        Szines("   Craft: 'C' billentyű\n", Color.Yellow);
                        System.Console.Write("\nA csákányt az azonosítójának a lenyomásával craftolhatod le, a többi billentyűvel pedig visszamehetsz");
                        System.Console.Write("\nJelenlegi csákányod: ");
                        Szines(jelenlegiItem.nev, Color.Yellow);
                        System.Console.Write("    Sebzése: ");
                        Szines(jelenlegiItem.sebzes, Color.Violet);
                        System.Console.Write("  (+-20%)");
                        System.Console.WriteLine('\n');
                        System.Console.Write("\nCraftolható csákányok és nyersanyagok: \n");

                        if (inv[0] >= csakany1.recept[0] && inv[1] >= csakany1.recept[1] && inv[2] >= csakany1.recept[2] && inv[3] >= csakany1.recept[3])
                        {
                            Szines2("1. Erős kőcsákány (2 fa, 3 kő - 80 sebzés)", Color.Green);
                            crafte[0] = true;
                        }
                        else
                        {
                            Szines2("1. Erős kőcsákány (2 fa, 3 kő - 80 sebzés)", Color.Red);
                            crafte[0] = false;
                        }


                        if (inv[0] >= csakany2.recept[0] && inv[1] >= csakany2.recept[1] && inv[2] >= csakany2.recept[2] && inv[3] >= csakany2.recept[3])
                        {
                            Szines2("2. Vascsákány (2 fa, 3 kő, 3 vas - 200 sebzés)", Color.Green);
                            crafte[1] = true;
                        }
                        else
                        {
                            Szines2("2. Vascsákány (2 fa, 3 kő, 3 vas - 200 sebzés)", Color.Red);
                            crafte[1] = false;
                        }

                        if (inv[0] >= csakany3.recept[0] && inv[1] >= csakany3.recept[1] && inv[2] >= csakany3.recept[2] && inv[3] >= csakany3.recept[3])
                        {
                            Szines2("3. Gyémántcsákány (2 fa, 3 kő, 3 vas, 3 gyémánt - 800 sebzés)\n", Color.Green);
                            crafte[2] = true;
                        }
                        else
                        {
                            Szines2("3. Gyémántcsákány (2 fa, 3 kő, 3 vas, 3 gyémánt - 800 sebzés)\n", Color.Red);
                            crafte[2] = false;
                        }

                        if (inv[4] >= 3)
                        {
                            Szines2("4. 3 bitcoin -> 1 fa", Color.Green);
                            crafte[3] = true;
                        }
                        else
                        {
                            Szines2("4. 3 bitcoin -> 1 fa", Color.Red);
                            crafte[3] = false;
                        }

                        if (inv[4] >= 6)
                        {
                            Szines2("5. 6 bitcoin -> 1 kő", Color.Green);
                            crafte[4] = true;
                        }
                        else
                        {
                            Szines2("5. 6 bitcoin -> 1 kő", Color.Red);
                            crafte[4] = false;
                        }

                        if (inv[4] >= 9)
                        {
                            Szines2("6. 9 bitcoin -> 1 vas", Color.Green);
                            crafte[5] = true;
                        }
                        else
                        {
                            Szines2("6. 9 bitcoin -> 1 vas", Color.Red);
                            crafte[5] = false;
                        }

                        if (inv[4] >= 12)
                        {
                            Szines2("7. 12 bitcoin -> 1 gyémánt", Color.Green);
                            crafte[6] = true;
                        }
                        else
                        {
                            Szines2("7. 12 bitcoin -> 1 gyémánt", Color.Red);
                            crafte[6] = false;
                        }


                        if (inv[0] >= 1)
                        {
                            Szines2("\nA. 1 fa -> 1 bitcoin", Color.Green);
                            crafte[7] = true;
                        }
                        else
                        {
                            Szines2("\nA. 1 fa -> 1 bitcoin", Color.Red);
                            crafte[7] = false;
                        }

                        if (inv[1] >= 1)
                        {
                            Szines2("B. 1 kő -> 3 bitcoin", Color.Green);
                            crafte[8] = true;
                        }
                        else
                        {
                            Szines2("B. 1 kő -> 3 bitcoin", Color.Red);
                            crafte[8] = false;
                        }

                        if (inv[2] >= 1)
                        {
                            Szines2("C. 1 vas -> 5 bitcoin", Color.Green);
                            crafte[9] = true;
                        }
                        else
                        {
                            Szines2("C. 1 vas -> 5 bitcoin", Color.Red);
                            crafte[9] = false;
                        }

                        if (inv[3] >= 1)
                        {
                            Szines2("D. 1 gyémánt -> 7 bitcoin", Color.Green);
                            crafte[10] = true;
                        }
                        else
                        {
                            Szines2("D. 1 gyémánt -> 7 bitcoin", Color.Red);
                            crafte[10] = false;
                        }

                        if (inv[4] >= 7)
                        {
                            Szines2("\nE. Enchantolás (x1.1 sebzés) (7 bitcoin)", Color.Green);
                            crafte[11] = true;
                        }
                        else
                        {
                            Szines2("\nE. Enchantolás (x1.1 sebzés) (7 bitcoin)", Color.Red);
                            crafte[11] = false;
                        }







                        ConsoleKeyInfo buy;
                        buy = Console.ReadKey();

                        if (buy.Key == ConsoleKey.D0 || buy.Key == ConsoleKey.NumPad0 || buy.Key == ConsoleKey.I || buy.Key == ConsoleKey.H)
                        { Console.Clear(); }


                        if (buy.Key == ConsoleKey.D1 || buy.Key == ConsoleKey.NumPad1)
                            if (crafte[0] == true)
                            {
                                Console.Clear();
                                jelenlegiItem = csakany1;
                                Szines("Sikeresen lecraftoltad az Erős csákányt\n", Color.Green);
                                Sleep(600);
                                inv[0] = inv[0] - csakany1Recept[0];
                                inv[1] = inv[1] - csakany1Recept[1];
                                inv[2] = inv[2] - csakany1Recept[2];
                                inv[3] = inv[3] - csakany1Recept[3];
                                goto CraftSystem;
                            }
                            else
                            {
                                Console.Clear();
                                crafte[0] = false;
                                Szines2("Nincsen elég nyersanyagod, hogy ezt lecraftolhasd\n", Color.OrangeRed);
                                Sleep(600);
                                goto CraftSystem;
                            }

                        if (buy.Key == ConsoleKey.D2 || buy.Key == ConsoleKey.NumPad2)
                            if (crafte[1] == true)
                            {
                                Console.Clear();
                                jelenlegiItem = csakany2;
                                Szines("Sikeresen lecraftoltad a Vascsákányt\n", Color.Green);
                                Sleep(600);
                                inv[0] = inv[0] - csakany2Recept[0];
                                inv[1] = inv[1] - csakany2Recept[1];
                                inv[2] = inv[2] - csakany2Recept[2];
                                inv[3] = inv[3] - csakany2Recept[3];
                                goto CraftSystem;

                            }
                            else
                            {
                                Console.Clear();
                                crafte[1] = false;
                                Szines2("Nincsen elég nyersanyagod, hogy ezt lecraftolhasd\n", Color.OrangeRed);
                                Sleep(600);
                                goto CraftSystem;
                            }

                        if (buy.Key == ConsoleKey.D3 || buy.Key == ConsoleKey.NumPad3)
                            if (crafte[2] == true)
                            {
                                Console.Clear();
                                jelenlegiItem = csakany3;
                                Szines("Sikeresen lecraftoltad a Gyémántcsákányt\n", Color.Green);
                                Sleep(600);
                                inv[0] = inv[0] - csakany3Recept[0];
                                inv[1] = inv[1] - csakany3Recept[1];
                                inv[2] = inv[2] - csakany3Recept[2];
                                inv[3] = inv[3] - csakany3Recept[3];
                                goto CraftSystem;

                            }
                            else
                            {
                                Console.Clear();
                                crafte[2] = false;
                                Szines2("Nincsen elég nyersanyagod, hogy ezt lecraftolhasd\n", Color.OrangeRed);
                                Sleep(600);
                                goto CraftSystem;
                            }


                        if (buy.Key == ConsoleKey.D4 || buy.Key == ConsoleKey.NumPad4)
                            if (crafte[3] == true)
                            {
                                Console.Clear();
                                Szines("Sikeresen lecraftoltál egy fát\n", Color.Green);
                                Sleep(600);
                                inv[0]++;
                                inv[4] = inv[4] - 3;
                                goto CraftSystem;

                            }
                            else
                            {
                                Console.Clear();
                                crafte[3] = false;
                                Szines2("Nincsen elég nyersanyagod, hogy ezt lecraftolhasd\n", Color.OrangeRed);
                                Sleep(600);
                                goto CraftSystem;
                            }
                        if (buy.Key == ConsoleKey.D5 || buy.Key == ConsoleKey.NumPad5)
                            if (crafte[4] == true)
                            {
                                Console.Clear();
                                Szines("Sikeresen lecraftoltál egy követ\n", Color.Green);
                                Sleep(600);
                                inv[1]++;
                                inv[4] = inv[4] - 6;
                                goto CraftSystem;

                            }
                            else
                            {
                                Console.Clear();
                                crafte[4] = false;
                                Szines2("Nincsen elég nyersanyagod, hogy ezt lecraftolhasd\n", Color.OrangeRed);
                                Sleep(600);
                                goto CraftSystem;
                            }

                        if (buy.Key == ConsoleKey.D6 || buy.Key == ConsoleKey.NumPad6)
                            if (crafte[5] == true)
                            {
                                Console.Clear();
                                Szines("Sikeresen lecraftoltál egy vasat\n", Color.Green);
                                Sleep(600);
                                inv[2]++;
                                inv[4] = inv[4] - 9;
                                goto CraftSystem;

                            }
                            else
                            {
                                Console.Clear();
                                crafte[5] = false;
                                Szines2("Nincsen elég nyersanyagod, hogy ezt lecraftolhasd\n", Color.OrangeRed);
                                Sleep(600);
                                goto CraftSystem;
                            }

                        if (buy.Key == ConsoleKey.D7 || buy.Key == ConsoleKey.NumPad7)
                            if (crafte[6] == true)
                            {
                                Console.Clear();
                                Szines("Sikeresen lecraftoltál egy gyémántot\n", Color.Green);
                                Sleep(600);
                                inv[3]++;
                                inv[4] = inv[4] - 12;
                                goto CraftSystem;

                            }
                            else
                            {
                                Console.Clear();
                                crafte[6] = false;
                                Szines2("Nincsen elég nyersanyagod, hogy ezt lecraftolhasd\n", Color.OrangeRed);
                                Sleep(600);
                                goto CraftSystem;
                            }


                        if (buy.Key == ConsoleKey.A)
                            if (crafte[7] == true)
                            {
                                Console.Clear();
                                Szines("Sikeresen eladtál egy fát\n", Color.Green);
                                Sleep(600);
                                inv[4] = inv[4] + 1;
                                inv[0] = inv[0] - 1;
                                goto CraftSystem;

                            }
                            else
                            {
                                Console.Clear();
                                crafte[7] = false;
                                Szines2("Nincsen elég nyersanyagod, hogy ezt eladhasd", Color.OrangeRed);
                                Sleep(600);
                                goto CraftSystem;
                            }

                        if (buy.Key == ConsoleKey.B)
                            if (crafte[8] == true)
                            {
                                Console.Clear();
                                Szines("Sikeresen eladtál egy követ\n", Color.Green);
                                Sleep(600);
                                inv[4] = inv[4] + 3;
                                inv[1] = inv[1] - 1;
                                goto CraftSystem;

                            }
                            else
                            {
                                Console.Clear();
                                crafte[8] = false;
                                Szines2("Nincsen elég nyersanyagod, hogy ezt eladhasd", Color.OrangeRed);
                                Sleep(600);
                                goto CraftSystem;
                            }

                        if (buy.Key == ConsoleKey.C)
                            if (crafte[9] == true)
                            {
                                Console.Clear();
                                Szines("Sikeresen eladtál egy vasat\n", Color.Green);
                                Sleep(600);
                                inv[4] = inv[4] + 5;
                                inv[2] = inv[2] - 1;
                                goto CraftSystem;

                            }
                            else
                            {
                                Console.Clear();
                                crafte[9] = false;
                                Szines2("Nincsen elég nyersanyagod, hogy ezt eladhasd", Color.OrangeRed);
                                Sleep(600);
                                goto CraftSystem;
                            }
                        if (buy.Key == ConsoleKey.D)
                            if (crafte[10] == true)
                            {
                                Console.Clear();
                                Szines("Sikeresen eladtál egy gyémántot\n", Color.Green);
                                Sleep(600);
                                inv[4] = inv[4] + 9;
                                inv[3] = inv[3] - 1;
                                goto CraftSystem;

                            }
                            else
                            {
                                Console.Clear();
                                crafte[10] = false;
                                Szines2("Nincsen elég nyersanyagod, hogy ezt eladhasd", Color.OrangeRed);
                                Sleep(600);

                            }

                        if (buy.Key == ConsoleKey.E)
                            if (crafte[11] == true)
                            {
                                Console.Clear();
                                Szines("Sikeresen enchantoltad a csákányodat.\n", Color.Green);
                                Szines("wow Élesség IV, Sújtás V \n", Color.RoyalBlue);
                                Sleep(600);
                                inv[4] = inv[4] - 7;
                                jelenlegiItem.sebzes = Convert.ToInt32(jelenlegiItem.sebzes * 1.1);


                            }
                            else
                            {
                                Console.Clear();
                                crafte[11] = false;
                                Szines2("Nincsen elég nyersanyagod, hogy enchantolhasd", Color.OrangeRed);
                                Sleep(600);
                            }
                        else
                        {
                            Console.Clear();
                            break;
                        }

                    }



















                }
                else
                {

                    StringBuilder rosszgomb = new StringBuilder(
                    String.Format("Rossz gomb, a SPACE-t nyomogassad ne a(z): {0}-t. Büntetésül várj még 10 másodpercet. Aztán kilép a játék. Elveszett az állásod. Legközelebb szabály szerint játszál. :(", key.KeyChar));
                    Console.Clear();
                    Console.ForegroundColor = Color.Red;
                    System.Console.WriteLine(rosszgomb);
                    var path3 = path + "\\death.mp3";
                    PlayFile(path3);
                    Sleep(10000);
                    Environment.Exit(0);


                }

            }

        }
    }
}
//ez a játék unbalanced
//Peti nem ismeri a balance fogalmát
//Peti nem szeret engem
//Bálint 2k19
//amúgy a kedvenc játékom