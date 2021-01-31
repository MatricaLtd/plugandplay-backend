﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace PlugAndPlay.Dal.Model
{
    public partial class Ugovor
    {
        public Ugovor()
        {
            Ponuda = new HashSet<Ponuda>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }
        public int Godina { get; set; }
        public bool Aktivan { get; set; }
        public decimal Realizirano { get; set; }
        public decimal Naplaceno { get; set; }
        public string Valuta { get; set; }
        public int ValutaPlacanja { get; set; }
        public bool Avb { get; set; }
        public decimal Commit { get; set; }
        public decimal AgePopust { get; set; }
        public decimal UgovorFlatPopust { get; set; }
        public decimal UgovorKoličinaPopust { get; set; }
        public decimal AvansKolicina { get; set; }
        public string Napomena { get; set; }
        public byte[] Filename { get; set; }
        public int KlijentId { get; set; }
        public int PartnerId { get; set; }

        public virtual ICollection<Ponuda> Ponuda { get; set; }
    }
}