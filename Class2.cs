using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1
{
    public class Class2
    {
        public Int64 Id { get; set; }
        public String Nom { get; set; }
        public String Correu { get; set; }
        public String Telèfon { get; set; }

        public Class2() { }
        
        public Class2 (Int64 pId, String pNom, String pCorreuElectrònic, String pTelèfon)

        {
            this.Id = pId;
            this.Nom = pNom;
            this.Correu = pCorreuElectrònic;
            this.Telèfon = pTelèfon;
        }
    }
}
