﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace PlugAndPlay.AuditLogging.EF
{
    public partial class Command
    {
        public int Id { get; set; }
        public string CommandName { get; set; }
        public string CommandData { get; set; }
        public string Username { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string Error { get; set; }
        public bool? Success { get; set; }
    }
}