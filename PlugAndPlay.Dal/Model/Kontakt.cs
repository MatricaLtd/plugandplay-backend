﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace PlugAndPlay.Dal.Model
{
    public partial class Kontakt
    {
        public int Id { get; set; }
        public bool Aktivan { get; set; }
        public string Prefiks { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Funkcija { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Jezik { get; set; }
        public string Napomena { get; set; }
        public int? KlijentId { get; set; }
        public int? PartnerId { get; set; }

        public virtual Klijent Klijent { get; set; }
        public virtual Partner Partner { get; set; }
    }
}