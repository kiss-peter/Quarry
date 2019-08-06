using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kofejto
{
    public class Item
    {
        public string nev;
        public int azonosito;
        public int[] recept = new int[4]; // 0 - fa, 1 - zuzottko, 2 - vas, 3 - gyemant                    
        public int sebzes;                                                                                 
                                                                                                           
        public Item(int _azonosito, int _sebzes, int[] _recept, string _nev)                                            
        {
            nev = _nev;                                                                      
            azonosito = _azonosito;                                                                        
            sebzes = _sebzes;                                                                              
            recept = _recept;                                                                              
        }                                                                                                  
        /// <summary>                                                                                      
        /// Kezdő item                                                                                     
        /// </summary>                                                                                     
        /// <param name="_azonosito"></param>                                                              
        /// <param name="_sebzes"></param>                                                                 
        public Item(int _azonosito, int _sebzes, string _nev)
        {
            nev = _nev;                                                                                                 
            azonosito = _azonosito;
            sebzes = _sebzes;
        }


    }
}
