﻿using System;

namespace SysSonMarket.Models
{
    public class Saida
    {
        public int Id { get; set; }
        public Produto Produto { get; set; }
        public float ValorDaVenda { get; set; }
        public DateTime Data { get; set; }
    }
}