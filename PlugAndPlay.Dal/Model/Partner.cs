﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace PlugAndPlay.Dal.Model
{
    public partial class Partner
    {
        public Partner()
        {
            Klijent = new HashSet<Klijent>();
            KontaktKlijent = new HashSet<Kontakt>();
            KontaktPartner = new HashSet<Kontakt>();
            Ponuda = new HashSet<Ponuda>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Oib { get; set; }
        public string Adresa { get; set; }
        public int MjestoId { get; set; }
        public bool Agencija { get; set; }
        public bool Aktivan { get; set; }
        public bool Izvoz { get; set; }
        public string Racun { get; set; }
        public bool Pdv { get; set; }
        public string Valuta { get; set; }
        public int PrimarniKontaktId { get; set; }
        public bool Eracun { get; set; }
        public string EracunEmail { get; set; }
        public string Telefon { get; set; }
        public string Uvjet { get; set; }
        public string Napomena { get; set; }
        public decimal Limit { get; set; }
        public decimal Realizirano { get; set; }
        public decimal Naplaceno { get; set; }
        public decimal Duguje { get; set; }
        public int Odgoda { get; set; }
        public string Bonitet { get; set; }
        public string NapomenaUvjet { get; set; }

        public virtual Mjesto Mjesto { get; set; }
        public virtual ICollection<Klijent> Klijent { get; set; }
        public virtual ICollection<Kontakt> KontaktKlijent { get; set; }
        public virtual ICollection<Kontakt> KontaktPartner { get; set; }
        public virtual ICollection<Ponuda> Ponuda { get; set; }
    }
}